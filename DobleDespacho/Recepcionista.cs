using System;

namespace DobleDesplacho {
    public class Recepcionista : VisitadorPersona
    {
        public void recibir(Persona persona) {
            Console.WriteLine("Soy un recepcionista que se alegra de su visita");
            persona.aceptar(this);
        }
        public void visitar(Hombre hombre)
        {
            hombre.recibirPalmada(this);
        }

        public void visitar(Mujer mujer)
        {
            Console.WriteLine("Soy un recepcionista que se admira de su belleza");
            mujer.escucharHalago();
            Console.WriteLine("Soy un recepcionista que se admira de su existencia");
            mujer.escucharPiropo();
        }
        public void recibirPropina(int euros) {
            Console.WriteLine($"Soy un recepcionista que gané {euros} euros");
        }

        public void agradecerVisita() {
            Console.WriteLine("Soy un recepcionista que agradece la visita");
        }

    }
}
