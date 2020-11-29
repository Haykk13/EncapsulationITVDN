using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationITVDN
{
    public class Title
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
                    return "There is no title!";
                }
            }
            set
            {
                content = value;
            }

        }
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(Content);
            Console.ResetColor();
        }
    }
}
