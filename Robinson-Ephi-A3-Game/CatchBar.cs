using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class CatchBar
    {




        public void Render(float position)
        {
            Draw.FillColor = Color.Green;
            Draw.Rectangle(120, position, 80, 40);

        }
    } 

    
}
