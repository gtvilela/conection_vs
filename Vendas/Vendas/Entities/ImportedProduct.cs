using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Vendas.Entities
{
    class ImportedProduct : Product
    {
        public double Customs { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(double customs, string name, double price) : base(name, price)
        {
            Customs = customs;
        }

        public override string priceTag()
        {
            return Name
                + " $ "
                + totalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + "Customs fee: $ "
                + Customs.ToString("F2", CultureInfo.InvariantCulture)
                +")";
        }

        public double totalPrice()
        {
            return Price + Customs;
        }
    }
}
