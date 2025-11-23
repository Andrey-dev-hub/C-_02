using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buy.Entities
{
     class Usado: Product
    {
        public DateTime Tempo_Uso { get; set; }

        public Usado()
        {
        }

        public Usado(string name, double price,DateTime tempo_Uso) : base(name, price)
        {
            Tempo_Uso = tempo_Uso;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + $" Produto usado: {Tempo_Uso}";
        }
    }
}
