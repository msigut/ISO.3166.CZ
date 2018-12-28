using System;

namespace ISO3166CZ
{	
	public static class Alpha3CountryExtensions
	{
		public static string GetName(this Alpha3Country country)
		{
			switch (country)
			{
				/// <summary>
				/// Afghánistán (4)
				/// </summary>
				case Alpha3Country.AFG:
					return "Afghánistán";

				/// <summary>
				/// Ålandy (248)
				/// </summary>
				case Alpha3Country.ALA:
					return "Ålandy";

				/// <summary>
				/// Albánie (8)
				/// </summary>
				case Alpha3Country.ALB:
					return "Albánie";

				/// <summary>
				/// Alžírsko (12)
				/// </summary>
				case Alpha3Country.DZA:
					return "Alžírsko";

				/// <summary>
				/// Americká Samoa (16)
				/// </summary>
				case Alpha3Country.ASM:
					return "Americká Samoa";

				/// <summary>
				/// Americké Panenské ostrovy (850)
				/// </summary>
				case Alpha3Country.VIR:
					return "Americké Panenské ostrovy";

				/// <summary>
				/// Andorra (20)
				/// </summary>
				case Alpha3Country.AND:
					return "Andorra";

				/// <summary>
				/// Angola (24)
				/// </summary>
				case Alpha3Country.AGO:
					return "Angola";

				/// <summary>
				/// Anguilla (660)
				/// </summary>
				case Alpha3Country.AIA:
					return "Anguilla";

				/// <summary>
				/// Antarktida (10)
				/// </summary>
				case Alpha3Country.ATA:
					return "Antarktida";

				/// <summary>
				/// Antigua a Barbuda (28)
				/// </summary>
				case Alpha3Country.ATG:
					return "Antigua a Barbuda";

				/// <summary>
				/// Argentina (32)
				/// </summary>
				case Alpha3Country.ARG:
					return "Argentina";

				/// <summary>
				/// Arménie (51)
				/// </summary>
				case Alpha3Country.ARM:
					return "Arménie";

				/// <summary>
				/// Aruba (533)
				/// </summary>
				case Alpha3Country.ABW:
					return "Aruba";

				/// <summary>
				/// Austrálie (36)
				/// </summary>
				case Alpha3Country.AUS:
					return "Austrálie";

				/// <summary>
				/// Ázerbájdžán (31)
				/// </summary>
				case Alpha3Country.AZE:
					return "Ázerbájdžán";

				/// <summary>
				/// Bahamy (44)
				/// </summary>
				case Alpha3Country.BHS:
					return "Bahamy";

				/// <summary>
				/// Bahrajn (48)
				/// </summary>
				case Alpha3Country.BHR:
					return "Bahrajn";

				/// <summary>
				/// Bangladéš (50)
				/// </summary>
				case Alpha3Country.BGD:
					return "Bangladéš";

				/// <summary>
				/// Barbados (52)
				/// </summary>
				case Alpha3Country.BRB:
					return "Barbados";

				/// <summary>
				/// Belgie (56)
				/// </summary>
				case Alpha3Country.BEL:
					return "Belgie";

				/// <summary>
				/// Belize (84)
				/// </summary>
				case Alpha3Country.BLZ:
					return "Belize";

				/// <summary>
				/// Bělorusko (112)
				/// </summary>
				case Alpha3Country.BLR:
					return "Bělorusko";

				/// <summary>
				/// Benin (204)
				/// </summary>
				case Alpha3Country.BEN:
					return "Benin";

				/// <summary>
				/// Bermudy (60)
				/// </summary>
				case Alpha3Country.BMU:
					return "Bermudy";

				/// <summary>
				/// Bhútán (64)
				/// </summary>
				case Alpha3Country.BTN:
					return "Bhútán";

				/// <summary>
				/// Bolívie (68)
				/// </summary>
				case Alpha3Country.BOL:
					return "Bolívie";

				/// <summary>
				/// Bonaire, Svatý Eustach a Saba ; Karibské Nizozemsko (535)
				/// </summary>
				case Alpha3Country.BES:
					return "Bonaire, Svatý Eustach a Saba";

				/// <summary>
				/// Bosna a Hercegovina (70)
				/// </summary>
				case Alpha3Country.BIH:
					return "Bosna a Hercegovina";

				/// <summary>
				/// Botswana (72)
				/// </summary>
				case Alpha3Country.BWA:
					return "Botswana";

				/// <summary>
				/// Bouvetův ostrov (74)
				/// </summary>
				case Alpha3Country.BVT:
					return "Bouvetův ostrov";

				/// <summary>
				/// Brazílie (76)
				/// </summary>
				case Alpha3Country.BRA:
					return "Brazílie";

				/// <summary>
				/// Britské indickooceánské území (86)
				/// </summary>
				case Alpha3Country.IOT:
					return "Britské indickooceánské území";

				/// <summary>
				/// Britské Panenské ostrovy (92)
				/// </summary>
				case Alpha3Country.VGB:
					return "Britské Panenské ostrovy";

				/// <summary>
				/// Brunej (96)
				/// </summary>
				case Alpha3Country.BRN:
					return "Brunej";

				/// <summary>
				/// Bulharsko (100)
				/// </summary>
				case Alpha3Country.BGR:
					return "Bulharsko";

				/// <summary>
				/// Burkina Faso (854)
				/// </summary>
				case Alpha3Country.BFA:
					return "Burkina Faso";

				/// <summary>
				/// Burundi (108)
				/// </summary>
				case Alpha3Country.BDI:
					return "Burundi";

				/// <summary>
				/// Cookovy ostrovy (184)
				/// </summary>
				case Alpha3Country.COK:
					return "Cookovy ostrovy";

				/// <summary>
				/// Curaçao (531)
				/// </summary>
				case Alpha3Country.CUW:
					return "Curaçao";

				/// <summary>
				/// Čad (148)
				/// </summary>
				case Alpha3Country.TCD:
					return "Čad";

				/// <summary>
				/// Černá Hora (499)
				/// </summary>
				case Alpha3Country.MNE:
					return "Černá Hora";

				/// <summary>
				/// Česko (203)
				/// </summary>
				case Alpha3Country.CZE:
					return "Česko";

				/// <summary>
				/// Čína (156)
				/// </summary>
				case Alpha3Country.CHN:
					return "Čína";

				/// <summary>
				/// Dánsko (208)
				/// </summary>
				case Alpha3Country.DNK:
					return "Dánsko";

				/// <summary>
				/// Demokratická republika Kongo ; Kongo – Kinshasa (180)
				/// </summary>
				case Alpha3Country.COD:
					return "Demokratická republika Kongo";

				/// <summary>
				/// Dominika (212)
				/// </summary>
				case Alpha3Country.DMA:
					return "Dominika";

				/// <summary>
				/// Dominikánská republika (214)
				/// </summary>
				case Alpha3Country.DOM:
					return "Dominikánská republika";

				/// <summary>
				/// Džibutsko (262)
				/// </summary>
				case Alpha3Country.DJI:
					return "Džibutsko";

				/// <summary>
				/// Egypt (818)
				/// </summary>
				case Alpha3Country.EGY:
					return "Egypt";

				/// <summary>
				/// Ekvádor (218)
				/// </summary>
				case Alpha3Country.ECU:
					return "Ekvádor";

				/// <summary>
				/// Eritrea (232)
				/// </summary>
				case Alpha3Country.ERI:
					return "Eritrea";

				/// <summary>
				/// Estonsko (233)
				/// </summary>
				case Alpha3Country.EST:
					return "Estonsko";

				/// <summary>
				/// Etiopie (231)
				/// </summary>
				case Alpha3Country.ETH:
					return "Etiopie";

				/// <summary>
				/// Faerské ostrovy (234)
				/// </summary>
				case Alpha3Country.FRO:
					return "Faerské ostrovy";

				/// <summary>
				/// Falklandy (Malvíny) ; Falklandské ostrovy (238)
				/// </summary>
				case Alpha3Country.FLK:
					return "Falklandy (Malvíny)";

				/// <summary>
				/// Fidži (242)
				/// </summary>
				case Alpha3Country.FJI:
					return "Fidži";

				/// <summary>
				/// Filipíny (608)
				/// </summary>
				case Alpha3Country.PHL:
					return "Filipíny";

				/// <summary>
				/// Finsko (246)
				/// </summary>
				case Alpha3Country.FIN:
					return "Finsko";

				/// <summary>
				/// Francie (250)
				/// </summary>
				case Alpha3Country.FRA:
					return "Francie";

				/// <summary>
				/// Francouzská Guyana (254)
				/// </summary>
				case Alpha3Country.GUF:
					return "Francouzská Guyana";

				/// <summary>
				/// Francouzská jižní a antarktická území ; Francouzská jižní území (260)
				/// </summary>
				case Alpha3Country.ATF:
					return "Francouzská jižní a antarktická území";

				/// <summary>
				/// Francouzská Polynésie (258)
				/// </summary>
				case Alpha3Country.PYF:
					return "Francouzská Polynésie";

				/// <summary>
				/// Gabon (266)
				/// </summary>
				case Alpha3Country.GAB:
					return "Gabon";

				/// <summary>
				/// Gambie (270)
				/// </summary>
				case Alpha3Country.GMB:
					return "Gambie";

				/// <summary>
				/// Ghana (288)
				/// </summary>
				case Alpha3Country.GHA:
					return "Ghana";

				/// <summary>
				/// Gibraltar (292)
				/// </summary>
				case Alpha3Country.GIB:
					return "Gibraltar";

				/// <summary>
				/// Grenada (308)
				/// </summary>
				case Alpha3Country.GRD:
					return "Grenada";

				/// <summary>
				/// Grónsko (304)
				/// </summary>
				case Alpha3Country.GRL:
					return "Grónsko";

				/// <summary>
				/// Gruzie (268)
				/// </summary>
				case Alpha3Country.GEO:
					return "Gruzie";

				/// <summary>
				/// Guadeloupe (312)
				/// </summary>
				case Alpha3Country.GLP:
					return "Guadeloupe";

				/// <summary>
				/// Guam (316)
				/// </summary>
				case Alpha3Country.GUM:
					return "Guam";

				/// <summary>
				/// Guatemala (320)
				/// </summary>
				case Alpha3Country.GTM:
					return "Guatemala";

				/// <summary>
				/// Guinea (324)
				/// </summary>
				case Alpha3Country.GIN:
					return "Guinea";

				/// <summary>
				/// Guinea-Bissau (624)
				/// </summary>
				case Alpha3Country.GNB:
					return "Guinea-Bissau";

				/// <summary>
				/// Guernsey (831)
				/// </summary>
				case Alpha3Country.GGY:
					return "Guernsey";

				/// <summary>
				/// Guyana (328)
				/// </summary>
				case Alpha3Country.GUY:
					return "Guyana";

				/// <summary>
				/// Haiti (332)
				/// </summary>
				case Alpha3Country.HTI:
					return "Haiti";

				/// <summary>
				/// Heardův ostrov a McDonaldovy ostrovy (334)
				/// </summary>
				case Alpha3Country.HMD:
					return "Heardův ostrov a McDonaldovy ostrovy";

				/// <summary>
				/// Honduras (340)
				/// </summary>
				case Alpha3Country.HND:
					return "Honduras";

				/// <summary>
				/// Hongkong ; Hongkong – ZAO Číny (344)
				/// </summary>
				case Alpha3Country.HKG:
					return "Hongkong";

				/// <summary>
				/// Chile (152)
				/// </summary>
				case Alpha3Country.CHL:
					return "Chile";

				/// <summary>
				/// Chorvatsko (191)
				/// </summary>
				case Alpha3Country.HRV:
					return "Chorvatsko";

				/// <summary>
				/// Indie (356)
				/// </summary>
				case Alpha3Country.IND:
					return "Indie";

				/// <summary>
				/// Indonésie (360)
				/// </summary>
				case Alpha3Country.IDN:
					return "Indonésie";

				/// <summary>
				/// Irák (368)
				/// </summary>
				case Alpha3Country.IRQ:
					return "Irák";

				/// <summary>
				/// Írán (364)
				/// </summary>
				case Alpha3Country.IRN:
					return "Írán";

				/// <summary>
				/// Irsko (372)
				/// </summary>
				case Alpha3Country.IRL:
					return "Irsko";

				/// <summary>
				/// Island (352)
				/// </summary>
				case Alpha3Country.ISL:
					return "Island";

				/// <summary>
				/// Itálie (380)
				/// </summary>
				case Alpha3Country.ITA:
					return "Itálie";

				/// <summary>
				/// Izrael (376)
				/// </summary>
				case Alpha3Country.ISR:
					return "Izrael";

				/// <summary>
				/// Jamajka (388)
				/// </summary>
				case Alpha3Country.JAM:
					return "Jamajka";

				/// <summary>
				/// Japonsko (392)
				/// </summary>
				case Alpha3Country.JPN:
					return "Japonsko";

				/// <summary>
				/// Jemen (887)
				/// </summary>
				case Alpha3Country.YEM:
					return "Jemen";

				/// <summary>
				/// Jersey (832)
				/// </summary>
				case Alpha3Country.JEY:
					return "Jersey";

				/// <summary>
				/// Jihoafrická republika (710)
				/// </summary>
				case Alpha3Country.ZAF:
					return "Jihoafrická republika";

				/// <summary>
				/// Jižní Georgie a Jižní Sandwichovy ostrovy (239)
				/// </summary>
				case Alpha3Country.SGS:
					return "Jižní Georgie a Jižní Sandwichovy ostrovy";

				/// <summary>
				/// Jižní Korea (410)
				/// </summary>
				case Alpha3Country.KOR:
					return "Jižní Korea";

				/// <summary>
				/// Jižní Súdán (728)
				/// </summary>
				case Alpha3Country.SSD:
					return "Jižní Súdán";

				/// <summary>
				/// Jordánsko (400)
				/// </summary>
				case Alpha3Country.JOR:
					return "Jordánsko";

				/// <summary>
				/// Kajmanské ostrovy (136)
				/// </summary>
				case Alpha3Country.CYM:
					return "Kajmanské ostrovy";

				/// <summary>
				/// Kambodža (116)
				/// </summary>
				case Alpha3Country.KHM:
					return "Kambodža";

				/// <summary>
				/// Kamerun (120)
				/// </summary>
				case Alpha3Country.CMR:
					return "Kamerun";

				/// <summary>
				/// Kanada (124)
				/// </summary>
				case Alpha3Country.CAN:
					return "Kanada";

				/// <summary>
				/// Kapverdy (132)
				/// </summary>
				case Alpha3Country.CPV:
					return "Kapverdy";

				/// <summary>
				/// Katar (634)
				/// </summary>
				case Alpha3Country.QAT:
					return "Katar";

				/// <summary>
				/// Kazachstán (398)
				/// </summary>
				case Alpha3Country.KAZ:
					return "Kazachstán";

				/// <summary>
				/// Keňa (404)
				/// </summary>
				case Alpha3Country.KEN:
					return "Keňa";

				/// <summary>
				/// Kiribati (296)
				/// </summary>
				case Alpha3Country.KIR:
					return "Kiribati";

				/// <summary>
				/// Kokosové ostrovy (166)
				/// </summary>
				case Alpha3Country.CCK:
					return "Kokosové ostrovy";

				/// <summary>
				/// Kolumbie (170)
				/// </summary>
				case Alpha3Country.COL:
					return "Kolumbie";

				/// <summary>
				/// Komory (174)
				/// </summary>
				case Alpha3Country.COM:
					return "Komory";

				/// <summary>
				/// Kongo ; Kongo – Brazzaville (178)
				/// </summary>
				case Alpha3Country.COG:
					return "Kongo";

				/// <summary>
				/// Kostarika (188)
				/// </summary>
				case Alpha3Country.CRI:
					return "Kostarika";

				/// <summary>
				/// Kuba (192)
				/// </summary>
				case Alpha3Country.CUB:
					return "Kuba";

				/// <summary>
				/// Kuvajt (414)
				/// </summary>
				case Alpha3Country.KWT:
					return "Kuvajt";

				/// <summary>
				/// Kypr (196)
				/// </summary>
				case Alpha3Country.CYP:
					return "Kypr";

				/// <summary>
				/// Kyrgyzstán (417)
				/// </summary>
				case Alpha3Country.KGZ:
					return "Kyrgyzstán";

				/// <summary>
				/// Laos (418)
				/// </summary>
				case Alpha3Country.LAO:
					return "Laos";

				/// <summary>
				/// Lesotho (426)
				/// </summary>
				case Alpha3Country.LSO:
					return "Lesotho";

				/// <summary>
				/// Libanon (422)
				/// </summary>
				case Alpha3Country.LBN:
					return "Libanon";

				/// <summary>
				/// Libérie (430)
				/// </summary>
				case Alpha3Country.LBR:
					return "Libérie";

				/// <summary>
				/// Libye (434)
				/// </summary>
				case Alpha3Country.LBY:
					return "Libye";

				/// <summary>
				/// Lichtenštejnsko (438)
				/// </summary>
				case Alpha3Country.LIE:
					return "Lichtenštejnsko";

				/// <summary>
				/// Litva (440)
				/// </summary>
				case Alpha3Country.LTU:
					return "Litva";

				/// <summary>
				/// Lotyšsko (428)
				/// </summary>
				case Alpha3Country.LVA:
					return "Lotyšsko";

				/// <summary>
				/// Lucembursko (442)
				/// </summary>
				case Alpha3Country.LUX:
					return "Lucembursko";

				/// <summary>
				/// Macao ; Macao – ZAO Číny (446)
				/// </summary>
				case Alpha3Country.MAC:
					return "Macao";

				/// <summary>
				/// Madagaskar (450)
				/// </summary>
				case Alpha3Country.MDG:
					return "Madagaskar";

				/// <summary>
				/// Maďarsko (348)
				/// </summary>
				case Alpha3Country.HUN:
					return "Maďarsko";

				/// <summary>
				/// Makedonie (807)
				/// </summary>
				case Alpha3Country.MKD:
					return "Makedonie";

				/// <summary>
				/// Malajsie (458)
				/// </summary>
				case Alpha3Country.MYS:
					return "Malajsie";

				/// <summary>
				/// Malawi (454)
				/// </summary>
				case Alpha3Country.MWI:
					return "Malawi";

				/// <summary>
				/// Maledivy (462)
				/// </summary>
				case Alpha3Country.MDV:
					return "Maledivy";

				/// <summary>
				/// Mali (466)
				/// </summary>
				case Alpha3Country.MLI:
					return "Mali";

				/// <summary>
				/// Malta (470)
				/// </summary>
				case Alpha3Country.MLT:
					return "Malta";

				/// <summary>
				/// Ostrov Man (833)
				/// </summary>
				case Alpha3Country.IMN:
					return "Ostrov Man";

				/// <summary>
				/// Maroko (504)
				/// </summary>
				case Alpha3Country.MAR:
					return "Maroko";

				/// <summary>
				/// Marshallovy ostrovy (584)
				/// </summary>
				case Alpha3Country.MHL:
					return "Marshallovy ostrovy";

				/// <summary>
				/// Martinik (474)
				/// </summary>
				case Alpha3Country.MTQ:
					return "Martinik";

				/// <summary>
				/// Mauricius (480)
				/// </summary>
				case Alpha3Country.MUS:
					return "Mauricius";

				/// <summary>
				/// Mauritánie (478)
				/// </summary>
				case Alpha3Country.MRT:
					return "Mauritánie";

				/// <summary>
				/// Mayotte (175)
				/// </summary>
				case Alpha3Country.MYT:
					return "Mayotte";

				/// <summary>
				/// Menší odlehlé ostrovy USA (581)
				/// </summary>
				case Alpha3Country.UMI:
					return "Menší odlehlé ostrovy USA";

				/// <summary>
				/// Mexiko (484)
				/// </summary>
				case Alpha3Country.MEX:
					return "Mexiko";

				/// <summary>
				/// Mikronésie (583)
				/// </summary>
				case Alpha3Country.FSM:
					return "Mikronésie";

				/// <summary>
				/// Moldavsko (498)
				/// </summary>
				case Alpha3Country.MDA:
					return "Moldavsko";

				/// <summary>
				/// Monako (492)
				/// </summary>
				case Alpha3Country.MCO:
					return "Monako";

				/// <summary>
				/// Mongolsko (496)
				/// </summary>
				case Alpha3Country.MNG:
					return "Mongolsko";

				/// <summary>
				/// Montserrat (500)
				/// </summary>
				case Alpha3Country.MSR:
					return "Montserrat";

				/// <summary>
				/// Mosambik (508)
				/// </summary>
				case Alpha3Country.MOZ:
					return "Mosambik";

				/// <summary>
				/// Myanmar ; Myanmar (Barma) (104)
				/// </summary>
				case Alpha3Country.MMR:
					return "Myanmar";

				/// <summary>
				/// Namibie (516)
				/// </summary>
				case Alpha3Country.NAM:
					return "Namibie";

				/// <summary>
				/// Nauru (520)
				/// </summary>
				case Alpha3Country.NRU:
					return "Nauru";

				/// <summary>
				/// Německo (276)
				/// </summary>
				case Alpha3Country.DEU:
					return "Německo";

				/// <summary>
				/// Nepál (524)
				/// </summary>
				case Alpha3Country.NPL:
					return "Nepál";

				/// <summary>
				/// Niger (562)
				/// </summary>
				case Alpha3Country.NER:
					return "Niger";

				/// <summary>
				/// Nigérie (566)
				/// </summary>
				case Alpha3Country.NGA:
					return "Nigérie";

				/// <summary>
				/// Nikaragua (558)
				/// </summary>
				case Alpha3Country.NIC:
					return "Nikaragua";

				/// <summary>
				/// Niue (570)
				/// </summary>
				case Alpha3Country.NIU:
					return "Niue";

				/// <summary>
				/// Nizozemsko (528)
				/// </summary>
				case Alpha3Country.NLD:
					return "Nizozemsko";

				/// <summary>
				/// Norfolk (574)
				/// </summary>
				case Alpha3Country.NFK:
					return "Norfolk";

				/// <summary>
				/// Norsko (578)
				/// </summary>
				case Alpha3Country.NOR:
					return "Norsko";

				/// <summary>
				/// Nová Kaledonie (540)
				/// </summary>
				case Alpha3Country.NCL:
					return "Nová Kaledonie";

				/// <summary>
				/// Nový Zéland (554)
				/// </summary>
				case Alpha3Country.NZL:
					return "Nový Zéland";

				/// <summary>
				/// Omán (512)
				/// </summary>
				case Alpha3Country.OMN:
					return "Omán";

				/// <summary>
				/// Pákistán (586)
				/// </summary>
				case Alpha3Country.PAK:
					return "Pákistán";

				/// <summary>
				/// Palau (585)
				/// </summary>
				case Alpha3Country.PLW:
					return "Palau";

				/// <summary>
				/// Palestinská autonomie ; Palestinská území (275)
				/// </summary>
				case Alpha3Country.PSE:
					return "Palestinská autonomie";

				/// <summary>
				/// Panama (591)
				/// </summary>
				case Alpha3Country.PAN:
					return "Panama";

				/// <summary>
				/// Papua-Nová Guinea (598)
				/// </summary>
				case Alpha3Country.PNG:
					return "Papua-Nová Guinea";

				/// <summary>
				/// Paraguay (600)
				/// </summary>
				case Alpha3Country.PRY:
					return "Paraguay";

				/// <summary>
				/// Peru (604)
				/// </summary>
				case Alpha3Country.PER:
					return "Peru";

				/// <summary>
				/// Pitcairnovy ostrovy (612)
				/// </summary>
				case Alpha3Country.PCN:
					return "Pitcairnovy ostrovy";

				/// <summary>
				/// Pobřeží slonoviny (384)
				/// </summary>
				case Alpha3Country.CIV:
					return "Pobřeží slonoviny";

				/// <summary>
				/// Polsko (616)
				/// </summary>
				case Alpha3Country.POL:
					return "Polsko";

				/// <summary>
				/// Portoriko (630)
				/// </summary>
				case Alpha3Country.PRI:
					return "Portoriko";

				/// <summary>
				/// Portugalsko (620)
				/// </summary>
				case Alpha3Country.PRT:
					return "Portugalsko";

				/// <summary>
				/// Rakousko (40)
				/// </summary>
				case Alpha3Country.AUT:
					return "Rakousko";

				/// <summary>
				/// Réunion (638)
				/// </summary>
				case Alpha3Country.REU:
					return "Réunion";

				/// <summary>
				/// Rovníková Guinea (226)
				/// </summary>
				case Alpha3Country.GNQ:
					return "Rovníková Guinea";

				/// <summary>
				/// Rumunsko (642)
				/// </summary>
				case Alpha3Country.ROU:
					return "Rumunsko";

				/// <summary>
				/// Rusko (643)
				/// </summary>
				case Alpha3Country.RUS:
					return "Rusko";

				/// <summary>
				/// Rwanda (646)
				/// </summary>
				case Alpha3Country.RWA:
					return "Rwanda";

				/// <summary>
				/// Řecko (300)
				/// </summary>
				case Alpha3Country.GRC:
					return "Řecko";

				/// <summary>
				/// Saint-Pierre a Miquelon (666)
				/// </summary>
				case Alpha3Country.SPM:
					return "Saint-Pierre a Miquelon";

				/// <summary>
				/// Salvador (222)
				/// </summary>
				case Alpha3Country.SLV:
					return "Salvador";

				/// <summary>
				/// Samoa (882)
				/// </summary>
				case Alpha3Country.WSM:
					return "Samoa";

				/// <summary>
				/// San Marino (674)
				/// </summary>
				case Alpha3Country.SMR:
					return "San Marino";

				/// <summary>
				/// Saúdská Arábie (682)
				/// </summary>
				case Alpha3Country.SAU:
					return "Saúdská Arábie";

				/// <summary>
				/// Senegal (686)
				/// </summary>
				case Alpha3Country.SEN:
					return "Senegal";

				/// <summary>
				/// Severní Korea (408)
				/// </summary>
				case Alpha3Country.PRK:
					return "Severní Korea";

				/// <summary>
				/// Severní Mariany (580)
				/// </summary>
				case Alpha3Country.MNP:
					return "Severní Mariany";

				/// <summary>
				/// Seychely (690)
				/// </summary>
				case Alpha3Country.SYC:
					return "Seychely";

				/// <summary>
				/// Sierra Leone (694)
				/// </summary>
				case Alpha3Country.SLE:
					return "Sierra Leone";

				/// <summary>
				/// Singapur (702)
				/// </summary>
				case Alpha3Country.SGP:
					return "Singapur";

				/// <summary>
				/// Slovensko (703)
				/// </summary>
				case Alpha3Country.SVK:
					return "Slovensko";

				/// <summary>
				/// Slovinsko (705)
				/// </summary>
				case Alpha3Country.SVN:
					return "Slovinsko";

				/// <summary>
				/// Somálsko (706)
				/// </summary>
				case Alpha3Country.SOM:
					return "Somálsko";

				/// <summary>
				/// Spojené arabské emiráty (784)
				/// </summary>
				case Alpha3Country.ARE:
					return "Spojené arabské emiráty";

				/// <summary>
				/// Spojené království Velké Británie a Severního Irska ; Spojené království (826)
				/// </summary>
				case Alpha3Country.GBR:
					return "Spojené království Velké Británie a Severního Irska";

				/// <summary>
				/// Spojené státy americké ; Spojené státy (840)
				/// </summary>
				case Alpha3Country.USA:
					return "Spojené státy americké";

				/// <summary>
				/// Srbsko (688)
				/// </summary>
				case Alpha3Country.SRB:
					return "Srbsko";

				/// <summary>
				/// Srí Lanka (144)
				/// </summary>
				case Alpha3Country.LKA:
					return "Srí Lanka";

				/// <summary>
				/// Středoafrická republika (140)
				/// </summary>
				case Alpha3Country.CAF:
					return "Středoafrická republika";

				/// <summary>
				/// Súdán (729)
				/// </summary>
				case Alpha3Country.SDN:
					return "Súdán";

				/// <summary>
				/// Surinam (740)
				/// </summary>
				case Alpha3Country.SUR:
					return "Surinam";

				/// <summary>
				/// Svatá Helena, Ascension a Tristan da Cunha ; Svatá Helena (654)
				/// </summary>
				case Alpha3Country.SHN:
					return "Svatá Helena, Ascension a Tristan da Cunha";

				/// <summary>
				/// Svatá Lucie (662)
				/// </summary>
				case Alpha3Country.LCA:
					return "Svatá Lucie";

				/// <summary>
				/// Svatý Bartoloměj (652)
				/// </summary>
				case Alpha3Country.BLM:
					return "Svatý Bartoloměj";

				/// <summary>
				/// Svatý Kryštof a Nevis (659)
				/// </summary>
				case Alpha3Country.KNA:
					return "Svatý Kryštof a Nevis";

				/// <summary>
				/// Svatý Martin (francouzská část) ; Svatý Martin (Francie) (663)
				/// </summary>
				case Alpha3Country.MAF:
					return "Svatý Martin (francouzská část)";

				/// <summary>
				/// Svatý Martin (nizozemská část) ; Svatý Martin (Nizozemsko) (534)
				/// </summary>
				case Alpha3Country.SXM:
					return "Svatý Martin (nizozemská část)";

				/// <summary>
				/// Svatý Tomáš a Princův ostrov (678)
				/// </summary>
				case Alpha3Country.STP:
					return "Svatý Tomáš a Princův ostrov";

				/// <summary>
				/// Svatý Vincenc a Grenadiny (670)
				/// </summary>
				case Alpha3Country.VCT:
					return "Svatý Vincenc a Grenadiny";

				/// <summary>
				/// Svazijsko (748)
				/// </summary>
				case Alpha3Country.SWZ:
					return "Svazijsko";

				/// <summary>
				/// Sýrie (760)
				/// </summary>
				case Alpha3Country.SYR:
					return "Sýrie";

				/// <summary>
				/// Šalomounovy ostrovy ; Šalamounovy ostrovy (90)
				/// </summary>
				case Alpha3Country.SLB:
					return "Šalomounovy ostrovy";

				/// <summary>
				/// Španělsko (724)
				/// </summary>
				case Alpha3Country.ESP:
					return "Španělsko";

				/// <summary>
				/// Špicberky a Jan Mayen ; Špicberky a Jan Mayen (744)
				/// </summary>
				case Alpha3Country.SJM:
					return "Špicberky a Jan Mayen";

				/// <summary>
				/// Švédsko (752)
				/// </summary>
				case Alpha3Country.SWE:
					return "Švédsko";

				/// <summary>
				/// Švýcarsko (756)
				/// </summary>
				case Alpha3Country.CHE:
					return "Švýcarsko";

				/// <summary>
				/// Tádžikistán (762)
				/// </summary>
				case Alpha3Country.TJK:
					return "Tádžikistán";

				/// <summary>
				/// Tanzanie (834)
				/// </summary>
				case Alpha3Country.TZA:
					return "Tanzanie";

				/// <summary>
				/// Thajsko (764)
				/// </summary>
				case Alpha3Country.THA:
					return "Thajsko";

				/// <summary>
				/// Tchaj-wan (158)
				/// </summary>
				case Alpha3Country.TWN:
					return "Tchaj-wan";

				/// <summary>
				/// Togo (768)
				/// </summary>
				case Alpha3Country.TGO:
					return "Togo";

				/// <summary>
				/// Tokelau (772)
				/// </summary>
				case Alpha3Country.TKL:
					return "Tokelau";

				/// <summary>
				/// Tonga (776)
				/// </summary>
				case Alpha3Country.TON:
					return "Tonga";

				/// <summary>
				/// Trinidad a Tobago (780)
				/// </summary>
				case Alpha3Country.TTO:
					return "Trinidad a Tobago";

				/// <summary>
				/// Tunisko (788)
				/// </summary>
				case Alpha3Country.TUN:
					return "Tunisko";

				/// <summary>
				/// Turecko (792)
				/// </summary>
				case Alpha3Country.TUR:
					return "Turecko";

				/// <summary>
				/// Turkmenistán (795)
				/// </summary>
				case Alpha3Country.TKM:
					return "Turkmenistán";

				/// <summary>
				/// Turks a Caicos (796)
				/// </summary>
				case Alpha3Country.TCA:
					return "Turks a Caicos";

				/// <summary>
				/// Tuvalu (798)
				/// </summary>
				case Alpha3Country.TUV:
					return "Tuvalu";

				/// <summary>
				/// Uganda (800)
				/// </summary>
				case Alpha3Country.UGA:
					return "Uganda";

				/// <summary>
				/// Ukrajina (804)
				/// </summary>
				case Alpha3Country.UKR:
					return "Ukrajina";

				/// <summary>
				/// Uruguay (858)
				/// </summary>
				case Alpha3Country.URY:
					return "Uruguay";

				/// <summary>
				/// Uzbekistán (860)
				/// </summary>
				case Alpha3Country.UZB:
					return "Uzbekistán";

				/// <summary>
				/// Vánoční ostrov (162)
				/// </summary>
				case Alpha3Country.CXR:
					return "Vánoční ostrov";

				/// <summary>
				/// Vanuatu (548)
				/// </summary>
				case Alpha3Country.VUT:
					return "Vanuatu";

				/// <summary>
				/// Vatikán (336)
				/// </summary>
				case Alpha3Country.VAT:
					return "Vatikán";

				/// <summary>
				/// Venezuela (862)
				/// </summary>
				case Alpha3Country.VEN:
					return "Venezuela";

				/// <summary>
				/// Vietnam (704)
				/// </summary>
				case Alpha3Country.VNM:
					return "Vietnam";

				/// <summary>
				/// Východní Timor (626)
				/// </summary>
				case Alpha3Country.TLS:
					return "Východní Timor";

				/// <summary>
				/// Wallis a Futuna (876)
				/// </summary>
				case Alpha3Country.WLF:
					return "Wallis a Futuna";

				/// <summary>
				/// Zambie (894)
				/// </summary>
				case Alpha3Country.ZMB:
					return "Zambie";

				/// <summary>
				/// Západní Sahara (732)
				/// </summary>
				case Alpha3Country.ESH:
					return "Západní Sahara";

				/// <summary>
				/// Zimbabwe (716)
				/// </summary>
				case Alpha3Country.ZWE:
					return "Zimbabwe";


				default:
					throw new ArgumentException($"Unknown country: '{country}'.");
			}
		}
	}
}