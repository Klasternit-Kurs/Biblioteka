using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Biblioteka
{
	/// <summary>
	/// Interaction logic for PregledKnjiga.xaml
	/// </summary>
	public partial class PregledKnjiga : Window
	{
		List<Knjiga> SveKnjige { get; set; }

		public string Pretraga { get; set; }

		public PregledKnjiga(List<Knjiga> k)
		{
			InitializeComponent();
			SveKnjige = k;
			txtPretraga.DataContext = this;
		}

		private void Iznajmi(object sender, RoutedEventArgs e)
		{
			foreach (Knjiga k in SveKnjige)
			{
				if (k.Naziv == Pretraga)
				{
					MessageBox.Show("Nasao :) ");
					return;
				}
			}
			MessageBox.Show("Nista :(");
		}
	}
}
