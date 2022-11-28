using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.BUS
{
    internal class FormChangeBUS
    {

        private static FormChangeBUS instance;
        public static FormChangeBUS Instance
        {
            get { if (instance == null) instance = new FormChangeBUS(); return instance; }
            private set { instance = value; }
        }
    }
}
