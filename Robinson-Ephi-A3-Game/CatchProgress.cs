using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
   public class CatchProgress
    {
        public void Render(float x, float y, float g)
        {
            Draw.FillColor = Color.Red;
            Draw.Rectangle(x, y, 100, 20);
            Draw.FillColor = Color.Green;
            Draw.Rectangle(x, y, g * 20, 20);

        }
    }
}
