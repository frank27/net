using System;
namespace DobleDesplacho {
    public class Camarero : VisitadorPersona
    {
        public void servir(Persona persona) {
            persona.aceptar(this);
        }
        public void visitar(Hombre hombre)
        {
            Console.WriteLine("Soy un Camarero que entrega la comida");
            Console.WriteLine("Soy un Camarero que invita un coñac");
        }

        public void visitar(Mujer mujer)
        {
            Console.WriteLine("Soy un Camarero que invita un coktail");
            Console.WriteLine("Soy un Camarero que entrega la comida");
        }

        public void recoger () {
            Console.WriteLine("Soy un Camarero que recoge a mesa");
        }
    }
}