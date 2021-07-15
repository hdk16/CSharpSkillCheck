using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetCoffeeShop : GourmetShop, ITaxCompute
    {
        private int v1;
        private string v2;
        private Dictionary<int, double> coffeePriceDict;

        public GourmetCoffeeShop(int v1, string v2, Dictionary<int, double> coffeePriceDict)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.coffeePriceDict = coffeePriceDict;
        }
        public string getV2()
        {
            return v2;
        }
        public override double PayPerPiece(int quantity)
        {
            double d = quantity * coffeePriceDict[1];
            return d;
            throw new NotImplementedException();
        }

        public override double PayPerWeight(int weight)
        {
            double d = weight * coffeePriceDict[2];
            return d;
            throw new NotImplementedException();
        }

        public double TaxOnTotalBill()
        {
            throw new NotImplementedException();
        }
    }
}
