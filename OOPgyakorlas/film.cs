using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyakorlas
{
	internal class film
	{
		private string cim;
		private string rendezo;
		private int HosszPerc;
		private string mufaj;
		private bool megjelenes;

		public string Cim { get => cim; set => cim = value; }
		public string Rendezo { get => rendezo; set => rendezo = value; }
		public int HosszPerc1 { get => HosszPerc; set => HosszPerc = value; }
		public string Mufaj { get => mufaj; set => mufaj = value; }
		public bool Megjelenes { get => megjelenes; set => megjelenes = value; }

		public film(string cim, string rendezo, int hosszPerc, string mufaj, bool megjelenes)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			HosszPerc = hosszPerc;
			this.mufaj = mufaj;
			this.megjelenes = megjelenes;
		}

		public film(string cim, string rendezo)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			HosszPerc = 120;
			mufaj = "Ismeretlen";
			megjelenes = false;
		}


		public void Jatszas()
		{
            Console.WriteLine($"A(z) \"{cim}\" című film elkezdődött!");
        }

		 public void MufajModositas(string ujMufaj)
		{
			mufaj = ujMufaj;
		}

		public void HosszNoveles(int percek)
		{
			HosszPerc += percek;
		}

		public override string ToString()
		{
			return $"{cim} - {rendezo} / {HosszPerc} / {mufaj} / {megjelenes}";
		}
	}
}
