using System;

namespace KidsMath.Models
{
    public struct OperandsRange
    {
        public int Start;
        public int End;

        public OperandsRange(int start, int end)
        {
            this.Start = start;
            this.End = end;
        }
    }
}