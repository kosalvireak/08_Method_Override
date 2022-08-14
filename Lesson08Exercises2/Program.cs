using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08Exercises2
{
    class Picture
    {
        private string strtitle; //private
        public string title
        {
            get { return strtitle; }
        }
        private float fltPrice; //private

        public float Price
        {
            get { return fltPrice; }
        }
        public Picture(string strtitle, float fltPrice)
        {
            this.strtitle = strtitle;
            this.fltPrice = fltPrice;
        }
        public virtual float GetPrice()
        {
            return fltPrice;
        }
    }
    class Photograph : Picture
    {
        private string strPhotographer;//private
        public string Photographer
        {
            get { return strPhotographer; }
        }
        private string strCamera;//private
        public string Camera
        {
            get { return strCamera; }
        }
        public Photograph(string strPhotographer, string strCamera, string strtitle, float fltPrice) : base(strtitle, fltPrice)
        {
            this.strPhotographer = strPhotographer;
            this.strCamera = strCamera;
        }
        public override float GetPrice()
        {
            return Price + 30f;
            //return Price ;
        }
    }
    class Painting : Picture
    {
        private string strArtist;//private
        public string Artist
        {
            get { return strArtist; }
        }
        private string strType; //private
        public string Type
        {
            get { return strType; }

        }
        public Painting(string strArtist, string strType, string strtitle, float fltPrice) : base(strtitle, fltPrice)
        {
            this.strArtist = strArtist;
            this.strType = strType;
        }

        public override float GetPrice()
        {
            return Price + 50f;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Photograph objPhoto;
            Console.Write("Enter the strPhotographer: ");
            string strPhotographer = Console.ReadLine();
            Console.Write("Enter the strCamera: ");
            string strCamera = Console.ReadLine();
            Console.Write("Enter the strtitle: ");
            string strtitle = Console.ReadLine();
            Console.Write("Enter the fltPrice: ");
            float fltPrice = float.Parse(Console.ReadLine());
            objPhoto = new Photograph(strPhotographer, strCamera, strtitle, fltPrice);

            Console.WriteLine(objPhoto.GetPrice());
            // cannot add string to console since our function return float  
            Console.WriteLine("strPhotographer: {0},  strCamera: {1}, strtitle: {2},  fltPrice: {3}, "
                , objPhoto.Photographer, objPhoto.Camera, objPhoto.title, objPhoto.Price);
            
            Console.ReadKey();

            Painting objPainting;
            Console.Write("Enter the strArtist: ");
            string strArtist = Console.ReadLine();
            Console.Write("Enter the strType: ");
            string strType = Console.ReadLine();
            Console.Write("Enter the strtitle: ");
            strtitle = Console.ReadLine();
            Console.Write("Enter the fltPrice: ");
            fltPrice = float.Parse(Console.ReadLine());
            objPainting = new Painting(strArtist, strType, strtitle, fltPrice);

            Console.WriteLine(objPainting.GetPrice());
            Console.WriteLine("strArtist: {0},  strType: {1}, strtitle: {2},  fltPrice: {3}, "
                , objPainting.Artist, objPainting.Type, objPainting.title, objPainting.Price);

            Console.ReadKey();



        }
    }
}
