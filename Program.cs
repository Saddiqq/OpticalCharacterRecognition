using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronOcr;

namespace OCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new IronOcr.IronTesseract().Read(@"images\MSTestImg.png").Text);
            Console.ReadKey();
        }
    }
}
