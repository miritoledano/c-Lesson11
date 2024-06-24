using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lesson11
{
    abstract class Plant
    {
        private readonly int id;
        public Seson Season {  get; set; }  
        private string Name;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        private int AmountRequired;

        public int amountRequired
        {
            get
            {
                if (AmountRequired != 0)
                    return AmountRequired;
                else
                    return AmountRequired;
            }
            set { AmountRequired = value; }
        }


        private DateTime Date;

        public DateTime date
        {
            get
            {
                if (Date.Year < DateTime.Now.Year) { return Date; }
                else { return DateTime.Now; }
            }
            set { Date = value; }
        }


        private bool Elk;



        public bool elk
        {
            get { return Elk; }
            set { Elk = value; }
        }

        public int AgeOfPlant()
        {
            int x = DateTime.Now.Year - Date.Year;
            return x;


        }
        public Plant(int id)
        {
            this.id = id;

        }
        public Plant(int id, DateTime Date, int Amount, bool elk, Seson season)
        {
            this.id = id;
            this.Date = date;
            this.AmountRequired = Amount;
            this.elk = elk;
            this.Season = season;

        }



        public string Printbase()
        {
            return $"Plant ID: {id}\nSeason: {Season}\nName: {name}\nAmount Required: {amountRequired}\nDate: {date}\nElk: {elk}";
        }

    }
}
//    internal class Plant
//    {
//        private readonly int id;
//        public Seson Seson { get; set; }
//        private string Name;
//        public string name
//        {
//            get { return Name; }
//            set { Name = value; }
//        }

//        private int AmountRequired;
//        public int amountRequired
//        {
//            get
//            {
//                if (AmountRequired != 0)
//                    return AmountRequired;
//                else
//                    return AmountRequired;
//            }
//            set { AmountRequired = value; }
//        }

//        private DateTime Date;
//        public DateTime date
//        {
//            get
//            {
//                if (Date.Year < DateTime.Now.Year)
//                {
//                    return Date;
//                }
//                else
//                {
//                    return DateTime.Now;
//                }
//            }
//            set { Date = value; }
//        }

//        private bool Elk;
//        public bool elk
//        {
//            get { return Elk; }
//            set { Elk = value; }
//        }

//        public int AgeOfPlant()
//        {
//            int x = DateTime.Now.Year - Date.Year;
//            return x;
//        }

//        public Plant(int id)
//        {
//            this.id = id;
//        }

//        public Plant(int id, DateTime date, int Amount, bool elk, Seson seson)
//        {
//            this.id = id;
//            this.Date = date;
//            this.AmountRequired = Amount;
//            this.elk = elk;
//            this.Seson = seson;
//        }

//        public string Printbase()
//        {
//            return $"Plant ID: {id}\nSeason: {Seson}\nName: {Name}\nAmount Required: {amountRequired}\nDate: {date}\nElk: {elk}";
//        }
//    }
//}