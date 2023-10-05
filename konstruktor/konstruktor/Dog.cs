using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktor
{
    public class Dog
    {
		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private double kg;

		public double Kg
		{
			get { return kg; }
			set { kg = value; }
		}
		public Dog()
		{
			this.age = 3;
			this.name = "Maya";
			this.kg = 10;
		}
		//:this nasledqva ot gorniq ctor
		public Dog(int age):this()
		{
			this.age=age;
		}
		public Dog(int age, string name) : this(age)
		{
			this.name = name;
		}
		public Dog(int age,string name,double kg):this(age,name)
		{
			this.kg=kg;
		}
		public void Print()
		{
            Console.WriteLine($"{age} {name} {kg}");
        }

	}
}
