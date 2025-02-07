using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyakorlas
{
	internal class konyv
	{
		private string cim;
		private string szerzo;
		private int kiadasEv;
		private int oldalSzam;
		private int ar;

		public string Cim { get => cim; set => cim = value; }
		public string Szerzo { get => szerzo; set => szerzo = value; }
		public int KiadasEv { get => kiadasEv; set => kiadasEv = value; }
		public int OldalSzam { get => oldalSzam; set => oldalSzam = value; }
		public int Ar { get => ar; set => ar = value; }

		public konyv(string cim, string szerzo, int kiadasEv, int oldalSzam, int ar)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			this.kiadasEv = kiadasEv;
			this.oldalSzam = oldalSzam;
			this.ar = ar;
		}

		public konyv(string cim, string szerzo)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			kiadasEv = DateTime.Now.Year;
			oldalSzam = 200;
			ar = 3000;
		}


		public void Arnoveles(int osszeg)
		{
			ar += osszeg;
		}

		public void Kedvezmeny(double szazalek)
		{
			int csokkentes = Convert.ToInt16(ar * (szazalek / 100));

			ar -= csokkentes;
		}

		public int HanyOldalMaradt(int elolvasott) 
		{
			return oldalSzam - elolvasott;
		}

		public override string? ToString()
		{
			return $"{cim}  - {szerzo} / {oldalSzam} / {kiadasEv} - {ar}";
		}
	}
}
