using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAO
{
    internal class LopDAO
    {
        private static LopDAO instance;
        public static LopDAO Instance
        {
            get { if (instance == null) instance = new LopDAO(); return instance; }
            private set { instance = value; }
        }
    }
}
