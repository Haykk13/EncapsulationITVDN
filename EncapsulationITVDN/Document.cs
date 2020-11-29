using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationITVDN
{
    public class Document
    {
        Title title = null;
        Body body = null;
        Footer footer = null;

        void Initialize()
        {
            title = new Title();
            body = new Body();
            footer = new Footer();
        }
        public Document(string title)
        {
            Initialize();
            this.title.Content = title;
        }
        public string Body
        {
            set
            {
                body.Content = value;
            }
        }
        public string Footer
        {
            set
            {
                footer.Content = value;
            }
        }
        public void Show()
        {
            title.Show();
            body.Show();
            footer.Show();
        }

    }
}
