using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationITVDN
{
    public class Footer
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
                    return "There is no Footer!";
                }
            }
            set
            {
                content = value;
            }

        }
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ResetColor();
        }
    }
}
