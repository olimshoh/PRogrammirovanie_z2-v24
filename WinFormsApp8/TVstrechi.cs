using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp8
{
    public class TVstrechi
    {
        public string nazvanie;
        public double vremya;
        public override string ToString()
        {
            {
                return nazvanie + ':' + vremya;
            }
        }
    }
}
