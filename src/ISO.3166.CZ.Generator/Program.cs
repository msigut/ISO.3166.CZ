using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using CsvHelper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ISO3166CZ.Generator
{
	class Program
	{
		static void Main(string[] args)
		{
			var enumAlfa2 = new StringBuilder();
			var enumAlfa3 = new StringBuilder();
			var nameAlfa2 = new StringBuilder();
			var nameAlfa3 = new StringBuilder();
			var nameAltAlfa2 = new StringBuilder();
			var nameAltAlfa3 = new StringBuilder();

			#region JSON

			var jsonCountries = new List<GeneratorCountry>();

			// deserialize JSON directly from a file
			var jsonStr = File.ReadAllText(@"..\..\..\..\..\data\territories.json");
			var obj = (JObject)JsonConvert.DeserializeObject(jsonStr);

			// get all 2-char territories
			var all = (JObject)obj["main"]["cs"]["localeDisplayNames"]["territories"];
			foreach (var item in all.Properties())
			{
				if (!Regex.IsMatch(item.Name, "^[a-z]{2}$", RegexOptions.Compiled | RegexOptions.IgnoreCase))
					continue;

				jsonCountries.Add(new GeneratorCountry()
				{
					Alpha2 = item.Name,
					Name = item.Value.ToString()
				});
			}

			#endregion

			#region CSV

			using (var reader = File.OpenText(@"..\..\..\..\..\data\wiki.countries.csv"))
			{
				var csv = new CsvReader(reader);
				csv.Configuration.RegisterClassMap<GeneratorCountryMapper>();

				var countries = csv.GetRecords<GeneratorCountry>();
				foreach (var c in countries)
				{
					// find JSON territory, when different names, use for comments
					var jsonName = jsonCountries.Where(x => x.Alpha2 == c.Alpha2).Select(x => x.Name).FirstOrDefault();
					var jsonComment = c.Name.Trim() == jsonName.Trim() ? "" : $" ; {jsonName}";

					var tab = "\t\t";
					// Alfa2 - enum
					enumAlfa2.AppendLine($"{tab}/// <summary>");
					enumAlfa2.AppendLine($"{tab}/// {c.Name}{jsonComment} ({c.Numeric})");
					enumAlfa2.AppendLine($"{tab}/// </summary>");
					enumAlfa2.AppendLine($"{tab}{c.Alpha2} = {c.Numeric},");
					// Alfa3 - enum
					enumAlfa3.AppendLine($"{tab}/// <summary>");
					enumAlfa3.AppendLine($"{tab}/// {c.Name}{jsonComment} ({c.Numeric})");
					enumAlfa3.AppendLine($"{tab}/// </summary>");
					enumAlfa3.AppendLine($"{tab}{c.Alpha3} = {c.Numeric},");

					tab = "\t\t\t\t";
					// Alfa2 - name
					nameAlfa2.AppendLine($"{tab}/// <summary>");
					nameAlfa2.AppendLine($"{tab}/// {c.Name}{jsonComment} ({c.Numeric})");
					nameAlfa2.AppendLine($"{tab}/// </summary>");
					nameAlfa2.AppendLine($"{tab}case Alpha2Country.{c.Alpha2}:");
					nameAlfa2.AppendLine($"{tab}\treturn \"{c.Name}\";");
					nameAlfa2.AppendLine();
					// Alfa3 - name
					nameAlfa3.AppendLine($"{tab}/// <summary>");
					nameAlfa3.AppendLine($"{tab}/// {c.Name}{jsonComment} ({c.Numeric})");
					nameAlfa3.AppendLine($"{tab}/// </summary>");
					nameAlfa3.AppendLine($"{tab}case Alpha3Country.{c.Alpha3}:");
					nameAlfa3.AppendLine($"{tab}\treturn \"{c.Name}\";");
					nameAlfa3.AppendLine();

					tab = "\t\t\t\t";
					// Alfa2 - alternative name
					nameAltAlfa2.AppendLine($"{tab}/// <summary>");
					nameAltAlfa2.AppendLine($"{tab}/// {c.Name}{jsonComment} ({c.Numeric})");
					nameAltAlfa2.AppendLine($"{tab}/// </summary>");
					nameAltAlfa2.AppendLine($"{tab}case Alpha2Country.{c.Alpha2}:");
					nameAltAlfa2.AppendLine($"{tab}\treturn \"{jsonName}\";");
					nameAltAlfa2.AppendLine();
					// Alfa3 - alternative name
					nameAltAlfa3.AppendLine($"{tab}/// <summary>");
					nameAltAlfa3.AppendLine($"{tab}/// {c.Name}{jsonComment} ({c.Numeric})");
					nameAltAlfa3.AppendLine($"{tab}/// </summary>");
					nameAltAlfa3.AppendLine($"{tab}case Alpha3Country.{c.Alpha3}:");
					nameAltAlfa3.AppendLine($"{tab}\treturn \"{jsonName}\";");
					nameAltAlfa3.AppendLine();
				}
			}

			#endregion

			#region C# code gragments

			File.WriteAllText(@"..\..\..\..\ISO.3166.CZ\Alpha2Country.cs", @"using System;

namespace ISO3166CZ
{	
	public enum Alpha2Country : int
	{
"
+ enumAlfa2.ToString() +
@"	}
}");

			File.WriteAllText(@"..\..\..\..\ISO.3166.CZ\Alpha3Country.cs", @"using System;

namespace ISO3166CZ
{	
	public enum Alpha3Country : int
	{
"
+ enumAlfa3.ToString() +
@"	}
}");

			File.WriteAllText(@"..\..\..\..\ISO.3166.CZ\Alpha2CountryName.cs", @"using System;

namespace ISO3166CZ
{	
	public static class Alpha2CountryExtensions
	{
		public static string GetName(this Alpha2Country country)
		{
			switch (country)
			{
"
+ nameAlfa2.ToString() +
@"
				default:
					throw new ArgumentException($""Unknown country: '{country}'."");
			}
		}

		public static string GetNameAlt(this Alpha2Country country)
		{
			switch (country)
			{
"
+ nameAltAlfa2.ToString() +
@"
				default:
					throw new ArgumentException($""Unknown country: '{country}'."");
			}
		}
	}
}");

			File.WriteAllText(@"..\..\..\..\ISO.3166.CZ\Alpha3CountryName.cs", @"using System;

namespace ISO3166CZ
{	
	public static class Alpha3CountryExtensions
	{
		public static string GetName(this Alpha3Country country)
		{
			switch (country)
			{
"
+ nameAlfa3.ToString() +
@"
				default:
					throw new ArgumentException($""Unknown country: '{country}'."");
			}
		}

		public static string GetNameAlt(this Alpha3Country country)
		{
			switch (country)
			{
"
+ nameAltAlfa3.ToString() +
@"
				default:
					throw new ArgumentException($""Unknown country: '{country}'."");
			}
		}
}
}");

			#endregion
		}
	}
}
