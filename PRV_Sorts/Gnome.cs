using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRV_Sorts
{
    class Gnome
    {
        private static Gnome instance;
        private Gnome() { }

        public static Gnome getInstance()
        {
            if (instance == null) instance = new Gnome();
            return instance;
        }

    }
}
