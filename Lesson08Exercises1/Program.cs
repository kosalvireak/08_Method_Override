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
        public string ShopName
        {
            get { return strShopName; }
        }
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
        public string Brand
        {
               get { return strBrand; }
        }
        public Computer(string strBrand, string strShopName):base(strShopName)
        {
            this.strBrand = strBrand;
        }
        public override string GetDiscount()
        {
            return "10% discount";
        }
    }
    class Phone : ElectronicsShop
    {
        private string strModel;
        public string Model
        {
            get { return strModel; }
        }
        public Phone(string strModel, string strShopName) : base(strShopName)
        {
            this.strModel = strModel;
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Computer objCom;
            Console.Write("Enter the name of the objCom: ");
            string objCom1 = Console.ReadLine();
            Console.Write("Enter the name of the Shop: ");
            string Shop = Console.ReadLine();
            objCom = new Computer(objCom1, Shop);
            Console.WriteLine(objCom.GetDiscount());
            Console.WriteLine("Shop name: {0},  objCom: {1}",objCom.Brand, objCom.ShopName);
            Console.ReadKey();

            Phone objPhone;
            Console.Write("Enter the name of the objPhone1: ");
            string objPhone1 = Console.ReadLine();
            Console.Write("Enter the name of the Shop: ");
            string shop = Console.ReadLine();
            objPhone = new Phone(objPhone1, shop);

            Console.WriteLine(objPhone.GetDiscount());
            Console.WriteLine("Shop name: {0},  objCom: {1}", objPhone.Model, objPhone.ShopName);

        }
    }
}
