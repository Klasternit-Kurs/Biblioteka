using Biblioteka.Editori;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Biblioteka
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public ObservableCollection<Knjiga> listaKnjiga = new ObservableCollection<Knjiga>();
		public ObservableCollection<Clan> listaClanova = new ObservableCollection<Clan>();

		public MainWindow()
		{
			InitializeComponent();
			dgKnjige.ItemsSource = listaKnjiga;
			dgClanovi.ItemsSource = listaClanova;
		}

		private void DodajKnjigu(object sender, RoutedEventArgs e)
		{
			Knjige k = new Knjige();
			k.Owner = this;

			if (k.ShowDialog() == true)
			{
				listaKnjiga.Add(k.DataContext as Knjiga);
			}
		}

		private void IzmeniKnjigu(object sender, RoutedEventArgs e)
		{
			Knjige k = new Knjige();
			k.Owner = this;
			k.DataContext = dgKnjige.SelectedItem;
			k.ShowDialog();
		}

		private void BrisanjeKnjige(object sender, RoutedEventArgs e)
		{
			if (dgKnjige.SelectedItem != null)
			{
				listaKnjiga.Remove(dgKnjige.SelectedItem as Knjiga);
			}
		}

		private void BrisanjeClana(object sender, RoutedEventArgs e)
		{
			if (dgClanovi.SelectedItem != null)
			{
				listaClanova.Remove(dgClanovi.SelectedItem as Clan);
			}
		}

		private void Pregled(object sender, RoutedEventArgs e)
		{
			if (dgClanovi.SelectedItem != null)
			{
				PregledKnjiga pk = new PregledKnjiga(listaKnjiga.ToList());
				pk.Owner = this;
				pk.DataContext = dgClanovi.SelectedItem;
				pk.ShowDialog();
			}
		}
	}
}
