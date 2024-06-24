using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11
{
    internal class Greenhouseflower:Flower

    {
		private string Name;

		public string name
		{
			get { return Name; }
			set { Name = value; }
		}
		private int NumofLine;

		public int numofLine
        {
			get { return NumofLine; }
			set { NumofLine = value; }
		}
		private int NumofPot;

		public int numofPot
        {
			get { return NumofPot; }
			set { NumofPot = value; }
		}

		private Supervision Supervision;


        public Supervision supervision
        {
			get { return Supervision; }
			set { Supervision = value; }
		}
        public Greenhouseflower(int id):base(id)
{

				
        }
        public Greenhouseflower(Supervision supervision, int numofPot, int numofLine, string Name,int id,Color color
			) : base(id, color)
        {
				this.Supervision = supervision;
			this.numofLine = numofLine;
			this.Name = Name;
				this.numofPot = numofPot;
			this.Colorr= color;
        }
		public string Printbase()
		{
			return base.Printbase() + " " + supervision + " " + numofPot + " " + numofLine + " " + Name;

        }

       
    }
}
