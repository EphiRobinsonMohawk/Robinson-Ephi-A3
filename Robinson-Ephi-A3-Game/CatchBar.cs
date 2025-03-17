using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Security;

namespace MohawkGame2D
{
    public class CatchBar
    {



        public void Render(float y)
        {
            Draw.FillColor = Color.Green;
            Draw.Rectangle(120, y, 80, 40);

        }
    } 

    
}
