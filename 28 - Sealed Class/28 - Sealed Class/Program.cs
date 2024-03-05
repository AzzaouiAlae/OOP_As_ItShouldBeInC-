using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28___Sealed_Class
{
    sealed class clsA
    {
         public virtual void Print()
        {

        }
    }

    class clsB : clsA
    {
        sealed public override void Print()
        {

        }
    }

    class clsC : clsB
    {
        public override void Print()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsB B = new clsB();
        }
    }
}
