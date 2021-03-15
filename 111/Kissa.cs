using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111
{
    public class Kissa : Elain
    {
        private Kissa emo;
        //private int age { get; set; }
        //private string name { get; set; }
        //private bool onlihansyoja { get; set; }
        public int Kinopeus { get; set; }
        public Kissa Emo { get => emo; set => emo = value; }

        //public List<Kissa> lapset { get; set; }

        //public string palautaeläimennimi()
        //{
        //    return name;
        //}
        //public int palautaeläimenikä()
        //{
        //    return age;
        //}

        //public bool palautaliha()
        //{
        //    return onlihansyoja;
        //}
        List<Kissa> pennut = new List<Kissa>();
        public Kissa(string nimi, int ika, Kissa emo)
        {
            this.Name = nimi;
            this.Age = ika;
            this.emo = emo;
        }
        public Kissa()
        {
        }

        public Kissa(string nimi, int ika)
        {
            this.Name = nimi;
            this.Age = ika;
        }

        public int Lisapentu(string nimi, int ika, Kissa emo)
        {


            Kissa pentu = new Kissa(nimi, ika, emo);
            pentu.Age = ika;
            pentu.Name = nimi;
            //pentu.Emo = emo;
            //pennut.Add(emo);
            pennut.Add(pentu);
            return pennut.Count;
        }
        public List<Kissa> pentu()
        {
            return pennut;
        }


    }
}
