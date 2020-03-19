using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
	public class Knjiga
	{
		public string Naziv { get; set; }
		public int RaspolozivaKolicina { get; set; } = 1;

		public Knjiga(string n, int rK)
		{
			Naziv = n;
			RaspolozivaKolicina = rK;
		}

		public Knjiga() { }
	}
}
