using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08Exercises1
{
    class ElectronicsShop
    {
        private string strShopName;
        public ElectronicsShop(string strShopName)
        {
            this.strShopName = strShopName;
        }
        public virtual string GetDiscount()
        {
            return "0%";
        }
    }
    class Computer:ElectronicsShop
    {
        private string strBrand;
        public Computer(string strBrand, string strShopName):base(strShopName)
        {
            this.strBrand = strBrand;
        }
        public override string GetDiscount()
        {
            return base.GetDiscount();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
