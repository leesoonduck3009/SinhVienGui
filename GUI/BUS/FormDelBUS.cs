using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.BUS
{
    internal class FormDelBUS
    {
        private static FormDelBUS instance;
        public static FormDelBUS Instance
        {
            get { if (instance == null) instance = new FormDelBUS(); return instance; }
            private set { instance = value; }
        }
    }
}
