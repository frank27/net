using System;

namespace menu {
    public class Option1 : Option
    {
        public Option1(string title) : base(title)
        {
        }

        public override void execute()
        {
           Console.WriteLine("Execute option 1");
        }
    }
}