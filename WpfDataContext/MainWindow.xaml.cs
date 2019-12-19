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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDataContext
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			Person p = new Person("Adem", 35,"Mavi");
			sp.DataContext = p; //
			//binding to lblFName
			Binding nameBinding = new Binding("FirstName");
			lblFName.SetBinding(ContentProperty, nameBinding);
			//binding to lblAge
			Binding ageBinding = new Binding("Age");
			lblAge.SetBinding(ContentProperty, ageBinding);
			//binding to lblColor 
			Binding colorBinding = new Binding("FavoriteColor");
			lblColor.SetBinding(ContentProperty, colorBinding);

			Person[] people ={
				new Person("Adem AKKUŞ",35,"Mavi"),
				new Person("Gülten AKKUŞ",28,"Yeşil"),
				new Person("Furkan AKKUŞ",10,"Kahve"),
				new Person("Ayşenur AKKUŞ",6,"Mor")
				
			};
			cmbPeopleFName.ItemsSource = people;
			cmbPeopleAge.ItemsSource = people;
			cmbPeopleColor.ItemsSource = people;
			lbPeople.ItemsSource = people;
		}
	}
}
