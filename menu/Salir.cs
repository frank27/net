using System;

namespace menu {
    public class Salir : Option
    {
        private bool isExecute;
        public Salir() : base("Salir")
        {
            isExecute = false;
        }

        public override void execute()
        {
            isExecute = true;   
        }

        public bool isExecuted() {
            return isExecute;
        }
    }
}
