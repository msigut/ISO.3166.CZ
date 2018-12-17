using System;
using System.Collections.Generic;
using System.Linq;

namespace ISO3166CZ
{
	public class Country
	{
		/// <summary>
		/// ISO 3166-1 numeric je trojciferný systém, který je shodný se systémem definovaným Statistickým oddělením OSN.
		/// </summary>
		public int Numeric { get; set; }
		/// <summary>
		/// ISO 3166-1 alpha-3 je třípísmenný systém obsahující několik vyhrazených kódů
		/// </summary>
		public Alpha3Country Alpha3 { get; set; }
		/// <summary>
		/// ISO 3166-1 alpha-2 je dvoupísmenný systém obsahující několik vyhrazených kódů
		/// </summary>
		public Alpha2Country Alpha2 { get; set; }
		/// <summary>
		/// nazev zeme (CZ)
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// get all ISO 3166-1 country data
		/// </summary>
		public static IEnumerable<Country> GetCountries()
		{
			var values = Enum.GetValues(typeof(Alpha2Country)).Cast<int>();

			var result = new List<Country>();
			foreach (var numeric in values)
			{
				result.Add(new Country()
				{
					Numeric = numeric,
					Alpha2 = (Alpha2Country)(int)numeric,
					Alpha3 = (Alpha3Country)(int)numeric,
					Name = ((Alpha2Country)(int)numeric).GetName(),
				});
			}
			return result;
		}
	}
}
