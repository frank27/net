using System;

namespace menu {
    class Option2 : Option
    {
        public Option2(string title) : base(title)
        {
        }

        public override void execute()
        {
            Console.Write("OPtion 2 ...........");
        }
    }
}