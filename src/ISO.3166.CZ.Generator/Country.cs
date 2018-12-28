using CsvHelper.Configuration;

namespace ISO3166CZ
{
	internal class GeneratorCountry
	{
		/// <summary>
		/// ISO 3166-1 numeric je trojciferný systém, který je shodný se systémem definovaným Statistickým oddělením OSN.
		/// </summary>
		public int Numeric { get; set; }
		/// <summary>
		/// ISO 3166-1 alpha-3 je třípísmenný systém obsahující několik vyhrazených kódů
		/// </summary>
		public string Alpha3 { get; set; }
		/// <summary>
		/// ISO 3166-1 alpha-2 je dvoupísmenný systém obsahující několik vyhrazených kódů
		/// </summary>
		public string Alpha2 { get; set; }
		/// <summary>
		/// nazev zeme (CZ)
		/// </summary>
		public string Name { get; set; }
	}

	/// <remarks>
	/// mapovani CSV
	/// </remarks>
	internal class GeneratorCountryMapper : ClassMap<GeneratorCountry>
	{
		public GeneratorCountryMapper()
		{
			var i = 0;
			Map(m => m.Numeric).Index(i++);
			Map(m => m.Alpha3).Index(i++);
			Map(m => m.Alpha2).Index(i++);
			Map(m => m.Name).Index(i++);
		}
	}
}
