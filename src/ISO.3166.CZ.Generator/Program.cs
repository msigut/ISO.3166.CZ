using CsvHelper;
using System;
using System.IO;
using System.Text;

namespace ISO3166CZ.Generator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			var enumAlfa2 = new StringBuilder();
			var enumAlfa3 = new StringBuilder();
			var nameAlfa2 = new StringBuilder();
			var nameAlfa3 = new StringBuilder();

			using (var reader = File.OpenText(@"..\..\..\..\..\data\wiki.countries.csv"))
			{
				var csv = new CsvReader(reader);
				csv.Configuration.RegisterClassMap<CsvCountryMapper>();

				var countries = csv.GetRecords<CsvCountry>();
				foreach (var c in countries)
				{
					var tab = "\t\t";
					// Alfa2 - enum
					enumAlfa2.AppendLine($"{tab}/// <summary>");
					enumAlfa2.AppendLine($"{tab}/// {c.Name} ({c.Numeric})");
					enumAlfa2.AppendLine($"{tab}/// </summary>");
					enumAlfa2.AppendLine($"{tab}{c.Alpha2} = {c.Numeric},");
					// Alfa3 - enum
					enumAlfa3.AppendLine($"{tab}/// <summary>");
					enumAlfa3.AppendLine($"{tab}/// {c.Name} ({c.Numeric})");
					enumAlfa3.AppendLine($"{tab}/// </summary>");
					enumAlfa3.AppendLine($"{tab}{c.Alpha3} = {c.Numeric},");

					tab = "\t\t\t\t";
					// Alfa2 - name
					nameAlfa2.AppendLine($"{tab}/// <summary>");
					nameAlfa2.AppendLine($"{tab}/// {c.Name} ({c.Numeric})");
					nameAlfa2.AppendLine($"{tab}/// </summary>");
					nameAlfa2.AppendLine($"{tab}case Alpha2Country.{c.Alpha2}:");
					nameAlfa2.AppendLine($"{tab}\treturn \"{c.Name}\";");
					nameAlfa2.AppendLine();
					// Alfa3 - name
					nameAlfa3.AppendLine($"{tab}/// <summary>");
					nameAlfa3.AppendLine($"{tab}/// {c.Name} ({c.Numeric})");
					nameAlfa3.AppendLine($"{tab}/// </summary>");
					nameAlfa3.AppendLine($"{tab}case Alpha3Country.{c.Alpha3}:");
					nameAlfa3.AppendLine($"{tab}\treturn \"{c.Name}\";");
					nameAlfa3.AppendLine();
				}
			}

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
	}
}");

			#endregion
		}
	}
}
