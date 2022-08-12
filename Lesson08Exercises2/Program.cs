using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08Exercises2
{
    class Picture
    {
        private string strtitle;
        public string Title
        {
            get { return strtitle; }
        }
        private float fltPrice;

        public float Price
        {
            get { return fltPrice; }
            set { fltPrice = value; }
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
        private string strPhotographer;
        private string strCamera;
        public Photograph(string strPhotographer, string strCamera, string strtitle, float fltPrice) : base(strtitle, fltPrice)
        {
            this.strPhotographer = strPhotographer;
            this.strCamera = strCamera;
        }
        public override float GetPrice()
        {
            return Price + 30f;
        }
    }
    class Painting : Picture
    {
        private string strArtist;
        public string Artist
        {
            get { return strArtist; }
        }
        private string strType; //g
        public string Type
        {
            get { return strType; }

        }
        public Painting(string strArtist, string strType, string strtitle, float fltPrice) : base(strtitle, fltPrice)
        {
            this.strArtist = strArtist;
            this.strType = strType;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
