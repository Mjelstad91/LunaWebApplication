namespace PresentationLayer.Migrations
{
	using DAL;
	using Model.AdminModel;
	using Model.Models;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<LunaContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			ContextKey = "Oblig1.Models.LunaContext";
		}

		protected override void Seed(LunaContext context)
		{
			var allMovies = new List<Movie>
			{
				//DRAMA
				new Movie
				{
					Title = "Gj�keredet",
					Genre = "Drama",
					Stars = 8.7,
					Storyline = "McMurphy plasseres p� et sinnssykehus hvor alle pasientene er sl�vet ned av" +
								 "medikamenter og underkastet sykehusledelsen og overs�ster Ratched." +
								 "McMurphy gj�r oppr�r fra f�rste stund og etterhvert f�r han de andre pasientene med seg. " +
								  "Hans oppr�r tas imidlertid ille opp av stedets ledelse og de ser seg derfor n�dt til � knekke ham.",
					ContentRating = "15",
					ReleaseYear = "1975",
					Price = 80.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BZjA0OWVhOTAtYWQxNi00YzNhLWI4ZjYtNjFjZTEyYjJlNDVlL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SY1000_CR0,0,672,1000_AL_.jpg",
					Director = "Milos Forman",
					Duration = "132 min",
					IsAvailable = 1
				},
				new Movie
				{
					Title = "Jakten",
					Genre = "Drama",
					Stars = 8.3,
					Storyline = "Jakten er en foruroligende skildring av hvordan l�gn blir til sannhet - en moderne fortelling om heksejakt, " +
								"urettferdighet, skyld og tilgivelse. En beretning om hvor skr�pelig fellesskapet er, n�r sladder, tvil og " +
								"ondskap f�r lov til � spre om seg.",
					ContentRating = "15",
					ReleaseYear = "2012",
					Price = 80.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BNDM2MzMwMzcxNF5BMl5BanBnXkFtZTcwNTczMDk3OA@@._V1_SY1000_CR0,0,681,1000_AL_.jpg",
					Director = "Thomas Vinterberg",
					Duration = "115 min",
					IsAvailable = 1

				},
				new Movie
				{

					Title = "Frihetens regn",
					Genre = "Drama",
					Stars = 9.3,
					Storyline = "Andy Dufrenes� kone bedrar ham, n�r hun s� blir drept og Andy kan plasseres p� �stedet b�rer det rett i kasjotten. " +
								"Shawshank-fengselet er s� visst ingen anstalt for mors beste barn, der vaktene har sadisme og tortur som hobby.",
					ContentRating = "15",
					Director = "Frank Darabont",
					Duration = "142 min",
					ReleaseYear = "1994",
					Price = 80.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg",
					IsAvailable = 1
				},
				new Movie
				{
					Title = "Forrest Gump",
					Genre = "Drama",
					Stars = 8.8,
					Storyline = "Forrest Gump er en enkel mann som sitter p� en benk og forteller fremmede mennesker om sin fantastiske livshistorie. " +
								"Gjennom hans uskyldige, naive og godtroende synsvinkel er vi vitne til en rekke viktige hendelser som bidro til � forme det 20. �rhundre.",
					ContentRating = "11",
					Director = "Robert Zemeckis",
					Duration = "142 min",
					ReleaseYear = "1994",
					Price = 80.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BNWIwODRlZTUtY2U3ZS00Yzg1LWJhNzYtMmZiYmEyNmU1NjMzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg",
					IsAvailable = 1
				},
					new Movie
				{
					Title = "12 Angry Men",
					Genre = "Drama",
					Stars = 8.9,
					Storyline = "Et jurymedlem (Henry Fonda) som m� pr�ve � overbevise de 11 andre medlemmene om � la en drapsmistenkte frikjennes, " +
								"fordi tvilen b�r falle han til gode.",
					ContentRating = "15",
					Director = "Sidney Lumet",
					Duration = "96 min",
					ReleaseYear = "1957",
					Price = 100.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BMWU4N2FjNzYtNTVkNC00NzQ0LTg0MjAtYTJlMjFhNGUxZDFmXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_SY1000_CR0,0,649,1000_AL_.jpg",
					IsAvailable = 1

				},
					new Movie
					{
						Title = "City of God",
						Genre = "Drama",
						Stars = 8.6,
						Storyline = "Filmen handler om livet i favelaen Cidade de Deus, en av slummene i Rio de Janeiro. De fleste skuespillerne hadde aldri spilt f�r, og kommer fra forskjellige favelaer. " +
									"Filmen ble dog ikke spilt inn i Cidade de Deus, av sikkerhetsmessige grunner.",
						ContentRating = "15",
						Director = " Fernando Meirelles",
						Duration = "130 min",
						ReleaseYear = "2002",
						Price = 80.00,
						Poster = "https://m.media-amazon.com/images/M/MV5BMGU5OWEwZDItNmNkMC00NzZmLTk1YTctNzVhZTJjM2NlZTVmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_SY1000_CR0,0,677,1000_AL_.jpg",
						IsAvailable = 1
					},
				//ACTION

				new Movie
				{
					   Title = "The Matrix",
					Genre = "Action",
					Stars = 8.7,
					Storyline = "Tenk deg at virkeligheten er en dr�m. Denne tanken forf�lger Thomas Anderson (Keanu Reeves). Thomas lever et dobbeltliv, " +
								"om dagen er han ansatt i et stort datafirma, om natten er han hackeren Neo, en langer av virtuelle fantasier.",
					ContentRating = "15",
					Director = "The Wachowski Brothers",
					Duration = "136 min",
					ReleaseYear = "1999",
					Price = 80.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SY1000_CR0,0,665,1000_AL_.jpg",
					IsAvailable = 1
				},
				new Movie
				{
				   Title = "Die Hard",
					Genre = "Action",
					Stars = 8.2,
					Storyline = "John McClane, officer of the NYPD, tries to save his wife Holly Gennaro and several others that were taken hostage by German terrorist Hans Gruber during a Christmas party at the Nakatomi Plaza in Los Angeles.",
					ContentRating = "18",
					Director = "John McTiernan",
					Duration = "132 min",
					ReleaseYear = "1988",
					Price = 80.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BMzNmY2IwYzAtNDQ1NC00MmI4LThkOTgtZmVhYmExOTVhMWRkXkEyXkFqcGdeQXVyMTk5NDA3Nw@@._V1_.jpg",
					IsAvailable = 1
				},
				new Movie
				{

					Title = "Mad Max: Fury Road",
					Genre = "Action",
					Stars = 8.1,
					Storyline = "Max (Tom Hardy) blir motvillig tatt med i jakten p� Furiosa (Charlize Theron), som har stj�let noe verdifullt fra krigsherren Ud�delige Joe (Hugh Keays-Byrne), nemlig avlsm�drene som skal f�de hans avkom.",
					ContentRating = "15",
					Director = "George Miller",
					Duration = "120 min",
					ReleaseYear = "2015",
					Price = 100.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BN2EwM2I5OWMtMGQyMi00Zjg1LWJkNTctZTdjYTA4OGUwZjMyXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg",
					IsAvailable = 1
				},
				new Movie
				{
					Title = "The Dark Knight",
					Genre = "Action",
					Stars = 9.0,
					Storyline = "Det har g�tt ett �r siden Batman reddet Gotham fra Ra's Al Ghul. En bank blir ranet av en gjeng maskerte tyver. Men n�r alt kommer til alt er det kun �n mann " +
					"som st�r igjen som vinneren � den gale The Joker (Heath Ledger), som gjerne vil se hele verden g� under for sine f�tter.",
					ContentRating = "15",
					Director = "Christopher Nolan",
					Duration = "152 min",
					ReleaseYear = "2008",
					Price = 100.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_SY1000_CR0,0,675,1000_AL_.jpg",
					IsAvailable = 1
				},
				new Movie
				{
					Title = "Kill Bill: Vol 1",
					Genre = "Action",
					Stars = 8.1,
					Storyline = "Leiemorderen The Bride obber i elitegruppen DiVAS. Da hun velger � forlate karrieren for � bli smidd i hymnens lenker, blir det ikke tatt n�dig opp av sjefen hennes, Bill. " +
								"Han s�rger for � sende hennes tidligere kolleger til bryllupet for � lage et blodbad. P� mirakul�st vis overlever The Bride � bli skutt i hodet, " +
								"men havner i koma. Fire �r senere v�kner hun opp fast bestemt p� hevn.",
					ContentRating = "15",
					Director = "Quentin Tarantino",
					Duration = "111 min",
					ReleaseYear = "2003",
					Price = 100.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BNzM3NDFhYTAtYmU5Mi00NGRmLTljYjgtMDkyODQ4MjNkMGY2XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg",
					IsAvailable = 1
				},
				new Movie
				{
					Title = "Inception",
					Genre = "Action",
					Stars = 8.8,
					Storyline = "Handlingen er satt til en verden hvor dr�mmer i stor grad styrer verdens rundgang. Dom Cobb (Leonardo DiCaprio) er verdens beste p� en illegal ting kalt \"extraction\" � " +
								"han kan bryte seg inn i folks dr�mmer og stjele ideer � noe han b�de har profittert p� og tapt p�, siden han ogs� mistet " +
								"familien p� grunn av evnene sine, og samtidig er en av Amerikas mest etters�kte menn.",
					ContentRating = "15",
					Director = "Christopher Nolan",
					Duration = "148 min",
					ReleaseYear = "2010",
					Price = 100.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_SY1000_CR0,0,675,1000_AL_.jpg",
					IsAvailable = 1
				},
				//KOMEDIER
				new Movie
				{
					Title = "The Big Lebowski",
					Genre = "Komedie",
					Stars = 8.1,
					Storyline = "Jeff Bridges spiller Jeffrey Lebowski, en arbeidsledig etterlevning fra hippietiden som g�r under kallenavnet �The Dude�. The Dude, hvis " +
								"hovedinteresser er bowling, pot og White Russian, blir overfalt i sin leilighet av pornoprodusenten Jackie Treehorns muskelmenn, " +
		"						som krever � f� tilbakebetalt gjelda til The Dudes p�st�tte kone Bunny.",
					Director = "Joel & Ethan Coen",
					ContentRating = "15",
					Duration = "117 min",
					ReleaseYear = "1998",
					Price = 80.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BZTFjMjBiYzItNzU5YS00MjdiLWJkOTktNDQ3MTE3ZjY2YTY5XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SY1000_CR0,0,665,1000_AL_.jpg",
					IsAvailable = 1
				},
				new Movie
				{
					Title = "Tilbake til Fremtiden",
					Genre = "Komedie",
					Stars = 8.5,
					Storyline = "Marty McFly, en 17 �r gammel gutt som g�r p� videreg�ende skole, og som liker � skate og spille p� el-gitar, blir invitert av vennen hans " +
								"Dr. Emmet Brown, en eksentrisk lokal vitenskapsmann, for � se p� en demonstrasjon av Doktorens nyeste oppfinnelse: en modifisert DeLorean " +
								"DMC-12 som kan reise i tid. For � dra gjennom tiden, m� man n� 140 km/t.",
					ContentRating = "12",
					Director = "Robert Zemeckis",
					Duration = "116 min",
					ReleaseYear = "1985",
					Price = 80.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BZmU0M2Y1OGUtZjIxNi00ZjBkLTg1MjgtOWIyNThiZWIwYjRiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SY1000_CR0,0,643,1000_AL_.jpg",
					IsAvailable = 1
				},
				new Movie
				{
					Title = "The Great Dictator",
					Genre = "Komedie",
					Stars = 8.5,
					Storyline = "Diktatoren handler om en j�disk barberer (Charlie Chaplin) som p�drar seg hukommelsestap etter en krigsskade under f�rste verdenskrig. " +
								"Som pasient i diverse sykehus er han derfor beskyttet for forandringene i hjemlandet Tomania (omskrivining av Tyskland).",
					ContentRating = "12",
					Director = "Charles Chaplin",
					Duration = "125 min",
					ReleaseYear = "1940",
					Price = 100.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BMmExYWJjNTktNGUyZS00ODhmLTkxYzAtNWIzOGEyMGNiMmUwXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SY1000_CR0,0,676,1000_AL_.jpg",
					IsAvailable = 1
				},
				new Movie
				{
					Title = "Hot Fuzz",
					Genre = "Komedie",
					Stars = 7.9,
					Storyline = "Nicholas Angel (Simon Pegg) er den beste politimannen i London, med en arrestasjonsrekord 400% h�yere enn noen andre i styrken. " +
								"Han er s� god at han gj�r slik at alle andre ser skikkelig talentl�se ut. Som et resultat av dette sender Angels overordnede ham til et " +
								"sted der hans talent ikke vil gj�re dem alle til skamme - den s�vnige og tilsynelatende lovlydige landsbyen Sandford.",
					ContentRating = "12",
					Director = "Edgar Wright",
					Duration = "121 min",
					ReleaseYear = "2007",
					Price = 80.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BMzg4MDJhMDMtYmJiMS00ZDZmLThmZWUtYTMwZDM1YTc5MWE2XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SY999_CR0,0,672,999_AL_.jpg",
					IsAvailable = 1
				},
				new Movie
				{
					Title = "The Wolf of Wallstreet",
					Genre = "Komedie",
					Stars = 8.2,
					Storyline = "Filmen sentrerer seg rundt Jordan Belfort (Leonardo DiCaprio), en aksjemegler p� Wall Street som m�tte sitte 20 m�neder i fengsel etter � ha " +
								"innr�mmet � ha drevet en \"Pump & Dump\" svindel og hvitvasking av penger. Han fikk redusert fengselsstraff fordi han samarbeidet med politiet " +
								"og tystet p� tidligere kollega og samarbeidspartnere.",
					ContentRating = "15",
					Director = "Martin Scorsese",
					Duration = "180 min",
					ReleaseYear = "2013",
					Price = 100.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BMjIxMjgxNTk0MF5BMl5BanBnXkFtZTgwNjIyOTg2MDE@._V1_SY1000_CR0,0,674,1000_AL_.jpg",
					IsAvailable = 1
				},
				new Movie
				{
					Title = "Hjemme Alene",
					Genre = "Komedie",
					Stars = 7.5,
					Storyline = "Dagen etter en familiekrangel blir �tte�ringen Kevin McCallister ved en feil etterlatt hjemme da familien reiser p� juleferie. " +
								"Dette er f�rste gang han ikke har noen voksne � forholde seg til, og han utnytter muligheten til � sove i foreldrenes store seng, " +
								"samt en rekke andre ting han ellers ikke f�r lov til. Men han oppdager at det ogs� finnes ulemper med � v�re hjemme alene." ,
					ContentRating = "11",
					Director = "Chris Colombus",
					Duration = "103 min",
					ReleaseYear = "1990",
					Price = 80.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BMzFkM2YwOTQtYzk2Mi00N2VlLWE3NTItN2YwNDg1YmY0ZDNmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_SY1000_CR0,0,672,1000_AL_.jpg",
					IsAvailable = 1

				},
				//BARNEFILMER
				new Movie
				{
					Title = "Ratatouille ",
					Genre = "Barn",
					Stars = 8.0,
					Storyline = "I den animerte filmen, \"Rottatouille\", dr�mmer rotta Remy om � bli en fransk mesterkokk, mot familiens �nsker og det faktum at han er en " +
								"rotte i en desidert gnagerfiendtlig yrkesgruppe.",
					ContentRating = "5",
					Director = "Brad Bird",
					Duration = "111 min",
					ReleaseYear = "2007",
					Price = 80.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BMTMzODU0NTkxMF5BMl5BanBnXkFtZTcwMjQ4MzMzMw@@._V1_SY1000_CR0,0,674,1000_AL_.jpg",
					IsAvailable = 1

				},
					new Movie
				{
					Title = "Oppdrag Nemo",
					Genre = "Barn",
					Stars = 8.1,
					Storyline = "Filmen har en enkel historie, hvor den lille klovnefisken �Nemo� har verdens mest overbeskyttende alenepappa, �Marlin�. " +
								"�Nemo� blir fanget av en tannlege og hobbydykker i Sydney og �Marlin� m� trosse alle sine nevroser for � redde s�nnen sin. " +
								"Med seg p� turen har han med seg palettkirurgifisken �Dory�, som har ekstremt d�rlig korttidshukommelse men som ogs� er utrolig hjertelig.",
					ContentRating = "5",
					Director = "Andrew Stanton",
					Duration = "100 min",
					ReleaseYear = "2003",
					Price = 80.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BZjMxYzBiNjUtZDliNC00MDAyLTg3N2QtOWNjNmNhZGQzNDg5XkEyXkFqcGdeQXVyNjE2MjQwNjc@._V1_.jpg",
					IsAvailable = 1

				},
						new Movie
				{
					Title = "Alvin og Gjengen",
					Genre = "Barn",
					Stars = 5.2,
					Storyline = "Vi m�ter de tre ekornene mens de ser deres hjem blir hugget ned for � brukes som juletre, mens de fortsatt er inne i det. " +
								"De ender opp i lobbyen til Jet Records hvor de hopper opp i muffinskurven til Dave som er p� vei hjem etter � ha blitt kastet ut fra " +
								"plateselskapet, som mener han ikke kan skrive sanger." ,
					ContentRating = "5",
					Director = "Tim Hill",
					Duration = "92 min",
					ReleaseYear = "2007",
					Price = 65.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BMjdmNWY4MjItMjBiMi00MWNiLWI0ZjctYzBjZmEzOGRmNTc5XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SY1000_CR0,0,678,1000_AL_.jpg",
					IsAvailable = 1
				},
				new Movie
				{
					Title = "Sm�spioner",
					Genre = "Barn",
					Stars = 5.5,
					Storyline = "Carmen (Alexa Vega) og Juni (Daryl Sabara) er to helt normale barn som har helt alminnelig kjedelige foreldre. Det er iallfall det de tror, " +
								"helt til de finner ut at foreldrene Gregorio (Antonio Banderas) og Ingrid (Carla Gugino) er tidligere topptrente hemmelige agenter som blir " +
								"tvunget tilbake i bransjen n�r de h�rer at flere av kollegene deres har forsvunnet p� mystisk vis. ",
					ContentRating = "5",
					Director = "Robert Rodriguez",
					Duration = "88 min",
					ReleaseYear = "2001",
					Price = 65.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BY2JhODU1NmQtNjllYS00ZmQwLWEwZjYtMTE5NjA1M2YyMzdjXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SY1000_CR0,0,673,1000_AL_.jpg",
					IsAvailable = 1

				},
				new Movie
				{
					Title = "Paddington 2",
					Genre = "Barn",
					Stars = 7.9,
					Storyline = "Da Paddington leter etter den perfekte presangen til sin tante Lucys hundre�rsdag finner han en bok i Herr Grubers butikk. " +
								"For � f� r�d til � kj�pe boken m� Paddington begynne � jobbe. Men plutselig blir boken stj�let! N� er det opp til Paddington " +
								"og familien Brown � avsl�re tyven" ,
					ContentRating = "5",
					Director = "Paul King",
					Duration = "103 min",
					ReleaseYear = "2017",
					Price = 80.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BMmYwNWZlNzEtNjE4Zi00NzQ4LWI2YmUtOWZhNzZhZDYyNmVmXkEyXkFqcGdeQXVyNzYzODM3Mzg@._V1_.jpg",
					IsAvailable = 1

				},
				new Movie
				{
					Title = "Grusomme Meg",
					Genre = "Barn",
					Stars = 7.7,
					Storyline = "Gru er en bitter og middelm�dig sm�kriminell som tenker altfor h�yt om seg selv. Han bestemmer seg for � sette seg selv p� kartet ved � " +
								"gj�re det st�rste kuppet noensinne - nemlig � stjele m�nen. Han adopterer derfor tre jenter, som inng�r i planen for � spionere p� fienden Vector. " +
								"Men n�r Gru faktisk gradvis begynner � bry seg om barna, st�r hele planen i fare, siden disse to tingene ikke lar seg kombinere. " ,
					ContentRating = "5",
					Director = "Pierre Coffin",
					Duration = "95 min",
					ReleaseYear = "2010",
					Price = 100.00,
					Poster = "https://m.media-amazon.com/images/M/MV5BMTY3NjY0MTQ0Nl5BMl5BanBnXkFtZTcwMzQ2MTc0Mw@@._V1_SY1000_CR0,0,675,1000_AL_.jpg",
					IsAvailable = 1
				},
			};

			byte[] adminSalt = DAL.Utilities.Security.PasswordEncryption.addSalt();

			AdminUser admin = new AdminUser
			{
				Username = "admin",
				Salt = adminSalt,
				Password = DAL.Utilities.Security.PasswordEncryption.toHash("admin", adminSalt)
			};

			context.AdminUsers.Add(admin);

			foreach (Movie m in allMovies)
			{
				context.Movies.Add(m);
			}

		}


	}
}

