using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
	internal class adat
	{
		private string nev;
		private int ar;

		public adat(string nev, int ar)
		{
			this.nev = nev;
			this.ar = ar;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Ar { get => ar; set => ar = value; }
	}
}
