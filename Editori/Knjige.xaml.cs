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

namespace Biblioteka.Editori
{
	/// <summary>
	/// Interaction logic for Knjige.xaml
	/// </summary>
	public partial class Knjige : Window
	{
		public Knjige()
		{
			InitializeComponent();
			this.BindingGroup = new BindingGroup();
			this.DataContext = new Knjiga();
		}

		private void Otkazi(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void Unos(object sender, RoutedEventArgs e)
		{
			
			if (this.BindingGroup.CommitEdit())
			{
				this.DialogResult = true;
				this.Close();
			}

		}
	}
}
