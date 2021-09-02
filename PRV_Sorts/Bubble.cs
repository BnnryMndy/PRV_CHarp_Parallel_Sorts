using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRV_Sorts
{
    class Bubble
    {
        private static Bubble instance;
        private Bubble() { }

        public Bubble GetInstance()
        {
            if(instance == null)
            {
                instance = new Bubble();
            }

            return instance;
        }
    }
}
