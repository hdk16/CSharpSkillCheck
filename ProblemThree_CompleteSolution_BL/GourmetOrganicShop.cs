using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop, ITaxCompute
    {
        private int v1;
        private string v2;
        private Dictionary<int, double> organicPriceDict;

        public GourmetOrganicShop(int v1, string v2, Dictionary<int, double> organicPriceDict)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.organicPriceDict = organicPriceDict;
        }
        public string  getV2() 
        {
            return v2;
                 
        }

        public override double PayPerPiece(int quantity)
        {
            double d = quantity * organicPriceDict[1];
            return d;
            throw new NotImplementedException();
        }

        public override double PayPerWeight(int weight)
        {
            double d = weight * organicPriceDict[2];
            throw new NotImplementedException();
        }

        public double TaxOnTotalBill()
        {
            throw new NotImplementedException();
        }


    }
}
