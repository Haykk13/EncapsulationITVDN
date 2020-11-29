using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationITVDN
{
    public class Body
    {
        private string content;
        public string Content
        {
            private get
            {
                if (content != null)
                {
                    return content;
                }
                else
                {
                    return "There is no body!";
                }
            }
            set
            {
                content = value;
            }

        }
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ResetColor();
        }
    }
}
