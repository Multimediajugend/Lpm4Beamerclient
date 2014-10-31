using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeamerClient
{
    public class NextElement
    {
        public Element[] data;
    }

    public class Element
    {
        public String type
        {
            get;
            set;
        }
        public Int32 duration
        {
            get;
            set;
        }
        public String url
        {
            get;
            set;
        }
    }
}
