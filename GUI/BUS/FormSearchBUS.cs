using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.BUS
{
    internal class FormSearchBUS
    {
        private static FormSearchBUS instance;
        public static FormSearchBUS Instance
        {
            get { if (instance == null) instance = new FormSearchBUS(); return instance; }
            private set { instance = value; }
        }
    }
}
