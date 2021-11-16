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

    class Triangel : Figur
    {
        public Triangel(float bredd, float höjd) : base(bredd, höjd)
        {
        }

        public float BeräknaArea()
        {
            return bredd * höjd / 2;
        }
    }

    class Cirkel : Figur
    {
        public Cirkel(float bredd, float höjd) : base(bredd, höjd)
        {
        }

        public float BeräknaArea()
        {
            return bredd * (float)Math.PI;
        }
    }

    class Linje : Figur
    {
        public Linje(float bredd, float höjd) : base(bredd, höjd)
        {
        }
    }
}
