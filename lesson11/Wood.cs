using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace lesson11
{
    internal class Wood:Plant
    {
       
     
    
    public Kind Kindd { get; set; }
        public TypeLeaves TypeLeavess { get; set; }
        private static int MaxTrees = 50;
        private int cnt = 0;
        public Wood(int id):base(id) {
            cnt++;
            DisplayMessage();
        
        }    
        
        public Wood(int id,Kind kind, TypeLeaves typeLeaves) : base(id)
        {
            this.Kindd = kind;
            this.TypeLeavess = typeLeaves;
            cnt++;
            DisplayMessage();

        }
        public string Printbase( )

        {
            return base.Printbase() + " " + Kindd + " " + TypeLeavess;
        }
        public int AgeWood(int n)
        {
            int x = AgeWoodOne(); 
            x += n;
            return x;
        }
        public int AgeWoodOne()
        {
            int x = AgeOfPlant();
            x ++;
            return x;
        }public bool Orla()
        {
            if (this.AgeOfPlant() > 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    public void DisplayMessage()
        {
            if (this.cnt <= MaxTrees)
            {
                Console.WriteLine("יש עוד אפשרות לשתול עצים.");
            }
            else
            {
                Console.WriteLine("שתילת העצים הסתיימה.");
            }
        }

    }
}
