using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16._2
{
    class Block
    {
        private int a, b, c, d;

        public Block(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public int A => this.a;
        public int B => this.b;
        public int C => this.c;
        public int D => this.d;

        // override object.Equals
        public override bool Equals(object obj)
        {
            #region Variant1
            bool result;
            if (obj == null || GetType() != obj.GetType())
            {
                result = false;
            }
            Block block = (Block)obj;
            if (a == block.a && b == block.b && c == block.c && d == block.d)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
            #endregion
            #region Variant2
            //bool result;
            //if (obj == null || GetType() != obj.GetType())
            //{
            //    result = false;
            //}
            //Block block = (Block)obj;
            //if (ToString() == block.ToString())
            //{
            //    result = true;
            //}
            //else
            //{
            //    result = false;
            //}
            //return result;
            #endregion
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {            
            return this.a.GetHashCode() + this.b.GetHashCode() +
                this.c.GetHashCode() + this.d.GetHashCode();
        }

        public override string ToString()
        {
            return $"a: {a}, b: {b}, c: {c}, d: {d}";
        }
    }
}
