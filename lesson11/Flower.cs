using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11
{
    
    internal class Flower:Plant
    {

        public Color Colorr { get; set; }
        public Flower(int id):base(id) { }  


        public Flower(int id, Color Color):base(id) {
            this.Colorr = Color; } 
        public string Printbase()
        {
            return base.Printbase() + " " + Colorr;
        }

        public void Chek(Flower f)
        {
            if (f.Season == this.Season &&f.amountRequired==this.amountRequired)
            {
                Console.WriteLine("אפשרי");

            }
            else { Console.WriteLine("לא אפשרי"); }
        }
        public static void Chek2(Flower f, Flower f2)
        {
            if (f.Season == f2.Season && f.amountRequired == f2.amountRequired)
            {
                Console.WriteLine("אפשרי");

            }
            else { Console.WriteLine("לא אפשרי"); }
        }



    }
}
