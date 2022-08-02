using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08Example
{
    class PetShop
    {
        private string strPetShopName;
        public string PetShopName
        {
            get { return strPetShopName; }
            set { strPetShopName = value; }
        }
        private string strAddress;
        public string Address
        {
            get { return strAddress; }
            set { strAddress = value; }
        }
        public PetShop(string strPetShopName, string strAddress)
        {
            this.strPetShopName = strPetShopName;
            this.strAddress = strAddress;
        }
        public string PetShopInfo()
        {
            return ("Pet Shop Name: " + strPetShopName + "Address: " + strAddress);
        }
        public virtual string Sound()
        {
            return "The animal make a sound";
        }
    }
    class Dog : PetShop
    {
        private string strName;
        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }
        public Dog(string strName, string strPetShopName, string strAddress) : base(strPetShopName, strAddress)
        {
            this.strName = strName;
        }

        public override string Sound()
        {
            return "The animal make a sound The dog bark";
        }
    }

    class Cat : PetShop
    {
        private string strName;
        public string Name
        {
            get { return strName; }
            set { Name = value; }
        }
        public Cat(string strName, string strPetShopName, string strAddress) : base(strPetShopName, strAddress)
        {
            this.strName = strName;
        }

        public override string Sound()
        {
            return "The animal makes a sound The cat meow.";
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the name of the dog: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the name of the shop: ");
            string shop = Console.ReadLine();
            Console.WriteLine("Enter the address of the shop: ");
            string address = Console.ReadLine();
            Dog objDog = new Dog(name, shop, address);
            Console.WriteLine("His name is: {0} from: {1} in {2}", objDog.Name, objDog.PetShopName, objDog.Address);
            Console.WriteLine(objDog.Sound());

            Cat objCat;
            Console.WriteLine("Enter the name of the cat: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the name of the shop: ");
            shop = Console.ReadLine();
            Console.WriteLine("Enter the address of the shop: ");
            address = Console.ReadLine();
            objCat = new Cat(name, shop, address);
            Console.WriteLine("His name is: {0} from: {1} in {2}", objCat.Name, objCat.PetShopName, objCat.Address);
            Console.WriteLine(objCat.Sound());
            Console.ReadKey();
        }
    }
}
