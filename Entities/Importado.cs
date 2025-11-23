using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buy.Entities
{
     class Importado: Product
    {
        public double Taxa { get; set; }

        public Importado()
        {
        }

        public Importado(string name, double price, double taxa)
            : base(name, price)
        {
            Taxa = taxa;
        }
         
     
        public double TotalPrice()
        {
           return Price+ Taxa; 
        }

        public override string PriceTag()
        {
            return Name + " " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
