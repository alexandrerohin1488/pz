using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz10var
{
    public class SistemaOtr
    {
        private int Dot1;
        private int Dot2;
        private int Dot3;
        public void SetDots(int Dot1, int Dot2, int Dot3)
        {
            this.Dot1 = Dot1;
            this.Dot2 = Dot2;
            this.Dot3 = Dot3;
        }
        public void LengthOtrezok()
        {
            int C = Dot1 + Dot2;
            int D = Dot2 + Dot3;
            int F = D + C;
            Console.WriteLine("Сумма отрезков = Длина отрезка AB = " + C + " + Длина отрезка BC = "+ D + " = " + F);
        }
    }
}

