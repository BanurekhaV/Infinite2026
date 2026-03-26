using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class AccessSpecifiers
    {
        public int publicdata;
        private int privatedata;
        internal int internaldata;
        protected int protecteddata;
        protected internal int internalprotecteddata;

        public void Show()
        {
            publicdata = 10;
            privatedata = 15;
            internaldata = 20;
            protecteddata = 30;
            internalprotecteddata = 31;
        }
    }
    internal class Program : AccessSpecifiers
    {
        static void Main(string[] args)
        {
            AccessSpecifiers accessSpecifiers = new AccessSpecifiers();
            accessSpecifiers.publicdata = 20;
           // accessSpecifiers.privatedata = 25; not accessible
            accessSpecifiers.internaldata = 30;
            accessSpecifiers.internalprotecteddata = 31;
            Program program = new Program();
            program.protecteddata = 50;
        }
    }
}
