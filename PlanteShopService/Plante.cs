using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanteShopService
{
    public class Plante
    {
		private int _planteID;

		public int PlanteID
		{
			get { return _planteID; }
			set { _planteID = value; }
		}


		private string _planteType;

		public string PlanteType
		{
			get { return _planteType; }
			set { _planteType = value; }
		}


		private string _planteNavn;

		public string PlanteNavn
		{
			get { return _planteNavn; }
			set { _planteNavn = value; }
		}


		private int _maksHoejde;

		public int MaksHoejde
		{
			get { return _maksHoejde; }
			set { _maksHoejde = value; }
		}

		private double _price;

		public double Price
		{
			get { return _price; }
			set { _price = value; }
		}


        public Plante(int planteId, string planteType, string planteNavn, int maksHoejde, double price)
        {
            _planteID = planteId;
            _planteType = planteType;
            _planteNavn = planteNavn;
            _maksHoejde = maksHoejde;
            _price = price;
        }

        public Plante(string planteType, string planteNavn, int maksHoejde, double price)
        {
            _planteType = planteType;
            _planteNavn = planteNavn;
            _maksHoejde = maksHoejde;
            _price = price;
        }

        public Plante()
        {
            
        }

        public override string ToString()
        {
            return $"{PlanteID}, {PlanteType}, {PlanteNavn}, {MaksHoejde}, {Price}";


        }

	}
}
