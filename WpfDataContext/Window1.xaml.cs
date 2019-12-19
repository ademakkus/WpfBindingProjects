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

namespace WpfDataContext
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
			#region Stackpanel datacontext
			/*
				 * Person p = new Person("Adem", 35, "Mavi");
				//sp.DataContext = p; //
														//binding to lblFName
				

				 * */
			#endregion
			
			Person[] people ={
				new Person("Adem AKKUŞ",35,"Mavi"),
				new Person("Gülten AKKUŞ",28,"Yeşil"),
				new Person("Furkan AKKUŞ",10,"Kahve"),
				new Person("Ayşenur AKKUŞ",6,"Mor")

			};
			Binding nameBinding = new Binding("FirstName");
			lblFName.SetBinding(ContentProperty, nameBinding);
			//binding to lblAge
			Binding ageBinding = new Binding("Age");
			lblAge.SetBinding(ContentProperty, ageBinding);
			//binding to lblColor 
			Binding colorBinding = new Binding("FavoriteColor");
			lblColor.SetBinding(ContentProperty, colorBinding);
			cmbPeopleFName.ItemsSource = people;
		
		}
	}
}
