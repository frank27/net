using System;
namespace DobleDesplacho {
    public abstract class Persona {
        public void Saludar() {
            Console.WriteLine("Soy una persona que saluda al entrar");
        }
        public abstract void aceptar(VisitadorPersona visitadorPersona);

        public void perdir() {
            Console.WriteLine("Soy una persona que pide un menú");
        }

        public void despedirse() {
            Console.WriteLine("Soy una persona que se despide al salir");
        }
    }
}