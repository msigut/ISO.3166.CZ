## ISO.3166.CZ

ISO 3166-1 country codes + names of countries in Czech (alpha-2 and alpha-3) for .NET Standard 2.0 (netstandard2.0). Enums [Alpha2Country](/src/ISO.3166.CZ/Alpha2Country.cs) and [Alpha3Country](/src/ISO.3166.CZ/Alpha3Country.cs) generated by [wiki.countries.csv](/data/wiki.countries.csv) data file grabbed from [Česká Wikipedie - ISO 3166-1](https://cs.wikipedia.org/wiki/ISO_3166-1).

```
// using alpha-2 and alpha-3 version
Alpha2Country.CZ;
Alpha3Country.CZE;

// get czech name ("Česko", "Francie")
Alpha2Country.CZ.GetName();
Alpha2Country.FR.GetName();
```

For complete ISO 3166-1 country data call:

```
// get all ISO 3166-1 country data
Country.GetCountries();
```

[Country.cs](/src/ISO.3166.CZ/Country.cs) contains:
- **Numeric** - ISO 3166-1 numeric (trojciferný systém, shodný se systémem definovaným Statistickým oddělením OSN)
- **Alpha3** - ISO 3166-1 alpha-3 (třípísmenný systém obsahující několik vyhrazených kódů)
- **Alpha2** - ISO 3166-1 alpha-2 (dvoupísmenný systém obsahující několik vyhrazených kódů)
- **Name** - coutry name
