namespace OOPgyakorlas
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//konyv konyv1 = new("A kis herceg", "Antione", 1943, 96, 2500);
			//konyv konyv2 = new("Ez még készül", "Én");

   //         Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());

			//konyv1.Kedvezmeny(20);
			//konyv1.Arnoveles(1000);


			//Console.WriteLine("\n" + konyv1.ToString() + "\n" + konyv1.HanyOldalMaradt(20));


			//film film1 = new("Trónók harca", "Valaki", 600, "Epikus", true);
			//film film2 = new("Lehet", "én");

			//Console.WriteLine(film1.ToString() + "\n" + film2.ToString());

			//film1.MufajModositas("Sorozat");
			//film2.HosszNoveles(20);

			//film1.Jatszas();
			//film2.Jatszas();

			//Console.WriteLine(film1.ToString() + "\n" + film2.ToString());


			Karakter karak1 = new();
			Karakter karak2 = new();

			Console.WriteLine(film1.ToString() + "\n" + film2.ToString());

			film1.MufajModositas("Sorozat");
			film2.HosszNoveles(20);

			film1.Jatszas();
			film2.Jatszas();

			Console.WriteLine(film1.ToString() + "\n" + film2.ToString());


		}
	}
}
