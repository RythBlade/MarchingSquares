using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarchingSquares
{
    public class MSLine
    {
        public MSPoint Start { get; set; }
        public MSPoint End { get; set; }

        public MSLine()
        {
            Start = new MSPoint(0.0f);
            End = new MSPoint(0.0f);
        }

        public MSLine( MSPoint start, MSPoint end)
        {
            Start = start;
            End = end;
        }
    }
}
