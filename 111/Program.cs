using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random hev = new Random();
            var elain = new List<Elain>();
            int maara = 12;
            for (int i = 1; i <= maara; i++)
            {
                 if ((i % 4) == 0)
                 {

                    Hevonen hevonen = new Hevonen() { Age  = hev.Next(1, 30), Name = "hevonen", onlihansyoja = false, hevnopeus  = hev.Next(7, 88) };
                    elain.Add(hevonen);

                 }
                 else if((i % 3) == 1)
                 {
                    Kissa Kissa = new Kissa() { Age = hev.Next(1, 25), Name = "Kissa", Onlihansyoja = true, Kinopeus = hev.Next(1, 20) };
                    elain.Add(Kissa);

                }
                else if ((i % 3) == 2)
                {
                    Koira koira = new Koira() { Age = hev.Next(1, 15), Name = "Koira",  onlihansyoja = true, kovnopeus = hev.Next(1, 30) };
                    elain.Add(koira);
                    
                }
                else if ((i % 3) == 0)
                {
                    papukaija papukaija = new papukaija() { Age = hev.Next(1, 10), Name = "Papukaija", onlihansyoja = false, lentonopeus = hev.Next(1, 15) };
                    elain.Add(papukaija);
                      
                }
                
            }
            //Kissa emo = new Kissa() { age = hev.Next(1, 25), name = "emo1", onlihansyoja = true, kinopeus = hev.Next(1, 20) };
            //Kissa emo2 = new Kissa() { age = hev.Next(1, 25), name = "emo2", onlihansyoja = true, kinopeus = hev.Next(1, 20) };
            //Kissa emo3 = new Kissa() { age = hev.Next(1, 25), name = "emo3", onlihansyoja = true, kinopeus = hev.Next(1, 20) };

            //emo.lapset.Add(new Kissa() { age = hev.Next(1, 25), name = "emo1", onlihansyoja = true, kinopeus = hev.Next(1, 20) });
            //emo2.lapset.Add(new Kissa() { age = hev.Next(1, 25), name = "emo1", onlihansyoja = true, kinopeus = hev.Next(1, 20) });
            Kissa emo = new Kissa("emo", 10);
            Kissa emo1 = new Kissa("emo1", 8);
            Kissa emo2 = new Kissa("emo2", 5);
            emo.Lisapentu("pentu", 3, emo);
            emo.Lisapentu("pentu1", 3, emo1);
            emo.Lisapentu("pentu1", 3, emo2);
            List<Kissa> pennut = emo.pentu();
            
            
            
            elaimet(elain);
            Console.WriteLine("----------------------------------------");
            aso(pennut);
      
            Console.Read();
        }

        private static void aso(List<Kissa> pennut)
        {
            foreach (var pentu in pennut)
            {
                //Kissa emopentu = pentu.Emo;
                Kissa emo = pentu.Emo;
                string nimi = pentu.Name;
                nimi = emo.Name;

                Console.WriteLine("pennun nimi: " + pentu.Name + "  ikä: " + pentu.Age + "  pennun emo: "+ pentu.Emo.Name+ "  emon ikä: "+ pentu.Emo.Age);
                
            }
        }


            private static void elaimet(List<Elain> elains)
            {
            foreach(var elain in elains)
            {
                Console.WriteLine("Nimi: " + elain.palautaeläimennimi() + "  Ikä: " +elain.palautaeläimenikä()+ " vegani? "+ elain.palautaliha());
                Console.WriteLine();
            }
            foreach (var hevonen in elains.OfType<Hevonen>())
            {

                Console.WriteLine("hevosen nopeus: " + hevonen.hevnopeus+ " Km");
            }
            foreach (var kissa in elains.OfType<Kissa>())
            {

                    Console.WriteLine("kissan nopeus: " + kissa.Kinopeus + " Km");
            }
            foreach (var koira in elains.OfType<Koira>())
            {

                    Console.WriteLine("Koiran nopeus: " + koira.kovnopeus + " Km");  
            }
            foreach (var papukaija in elains.OfType<papukaija>())
            {

                    Console.WriteLine("papukajan lentonopeus: " + papukaija.lentonopeus + " Km");
            }
            }
    }
}
