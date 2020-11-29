using System;

namespace EncapsulationITVDN
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("Title");
            doc.Body = "Doc Body";
            doc.Footer = "Doc Footer";
            doc.Show();
            Console.ReadLine();
        }
    }
}
