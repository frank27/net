using System;

namespace DobleDesplacho{
    public class Mujer : Persona {
        public void escucharHalago() {
            Console.WriteLine("-Soy una mujer ruborizada");
        }
        public void escucharPiropo() {
            Console.WriteLine("-Soy una mujer más ruborizada");
        }
        public override void aceptar(VisitadorPersona visitadorPersona)
        {
            visitadorPersona.visitar(this);
        }
    }
}