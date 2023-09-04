using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_videosharp.info_
{
    internal class Body
    {
        public int x;
        public int y;
        public Cell cell;

        public Body(int x, int y, Cell cell)
        {
            this.x = x;
            this.y = y;
            this.cell = cell;
        }
    }
}
