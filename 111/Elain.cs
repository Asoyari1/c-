using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111
{
    public class Elain
    {

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public bool Onlihansyoja { get => onlihansyoja; set => onlihansyoja = value; }

        private int age;
        private string name;
        private bool onlihansyoja;
        

        public void Asetaeläimenikä(int age)
        {
            if (age < 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                this.Age = age;
            }

        }
        public int palautaeläimenikä()
        {
            return Age;
        }
        public void asetaeläimennimi(string name)
        {
            this.Name = name;
        }
        public string palautaeläimennimi()
        {
            return Name;
        }
        public void liha(bool onlihansyoja)
        {
            this.Onlihansyoja = onlihansyoja;

        }
        public bool palautaliha()
        {
            
                return Onlihansyoja;
            

        }
    }
}
