using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
	public class Clan
	{
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public List<Knjiga> Knjige { get; set; } = new List<Knjiga>();

		public string ImeIPrezime
		{
			get
			{
				return $"{Ime} {Prezime}";
			}
		}
	}
}
