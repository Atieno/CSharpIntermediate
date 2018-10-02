using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class PresentationObject
    {
//properties
        public int Width { get; set; }
        public int Height { get; set; }

        //Methods
        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard.");
            Console.ReadLine();

        }
        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated .");

        }
        

    }
    public class Text: PresentationObject
    {
        //properties
        public int FontSize { get; set; }
        public int FontName { get; set; }

        //methods

        public void AddHyperlink(string url)
        {
            Console.WriteLine("The Link added ti "+ url);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }
    }
}
