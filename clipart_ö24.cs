using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clipart_Ovn_2_4
{
    class Figur
    {
        public float bredd;
        public float höjd;

        public Figur(float bredd, float höjd)
        {
            this.bredd = bredd;
            this.höjd = höjd;
        }
    }

    class Cirkel : Figur
    {
        public Cirkel(float bredd, float höjd) : base(bredd, höjd)
        {

        }

        public float BeräknaArena()
        {
            return bredd * (float)Math.PI;
        }
    }

    class Linjel : Figur
    {
        public Linjel(float bredd, float höjd) : base(bredd, höjd)
        {

        }
    }
}
