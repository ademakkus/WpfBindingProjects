using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataContext
{
	/// <summary>
	/// Person class
	/// </summary>
	class Person
	{
		public string FirstName { get; set; }
		public int Age { get; set; }
		public string FavoriteColor { get; set; }
		/// <summary>
		/// Person class constructor. it takes three parameters
		/// </summary>
		/// <param name="fName">string firstname</param>
		/// <param name="age">int age value</param>
		/// <param name="color">string FavoriteColor</param>
		public Person(string fName,int age,string color)
		{
			FirstName = fName;
			Age = age;
			FavoriteColor = color;


		}
	}
}
