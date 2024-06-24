using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lesson11
{
    internal class Garden

    {
       
        const string member = "gardenm";
        private Plant[] plants=new Plant[100]; 
        private int plantCount=0;
        public void Add( Plant plant)
        {
            if (plantCount<100) {
          
plants[plantCount] = plant;
                plantCount++;
            }
           
            else
            {
                Console.WriteLine("אין מקום במערך הצמחים");
            }

        }
      

        public void Remove(params Plant[] t)
        {
            for (int j = 0; j < t.Length; j++)
            {
                for (int i = 0; i < plantCount; i++)
                {
                    if (plants[i] == t[j])
                    {
                        for (int k = i; k < plantCount - 1; k++)
                        {
                            plants[k] = plants[k + 1];
                        }
                        plants[plantCount - 1] = null;
                        plantCount--;
                        i--;
                    }
                }
            }
        }
            public void Print()
        {
          
           for(int j = 0;j < plants.Length;j++)
            {
                if (plants[j] != null && plants[j].AgeOfPlant() < 3)
                {
                    Console.WriteLine("העץ הוא עץ עורלה זהירות");
                }
             else   if (plants[j] != null)
                    Console.WriteLine(plants[j].Printbase());
               
            }

        }
        public int Cnt(Type p)
        {
            int cnt = 0;
            for (int i = 0; i < plants.Length; i++)
            {
                if (plants[i] != null && plants[i].GetType() ==p)
                {
                    cnt++;
                }
            }
            return cnt;
        }

      
        public Garden()
        {
                
        }
    public    static bool ChekMicsa(out int sum, params  Wood[] w1)
        {
           

 sum = 0;
            for (int i = 0; i < w1.Length; i++)
            {

                if (w1[i].amountRequired > 500)
                {
                    return false;
                }
                else
                {
                    sum += w1[i].amountRequired;
                 
                }
            }
            
            return true;
        }

    }
}
