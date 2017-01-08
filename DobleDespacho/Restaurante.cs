using System;
namespace DobleDesplacho {
    public class Restaurante {
        private Recepcionista recepcionista;
        private Camarero camarero;
        private Restaurante() {
            recepcionista = new Recepcionista();
            camarero = new Camarero();
        }

        public static void Main(String[] args) {
                new Restaurante().simularEscenario();
        }

        private void simularEscenario() {
            Random random = new Random();
            for(int i=0;i<5;i++) {
                Persona persona;
                if(random.Next()==0) {
                    persona = new Hombre();
                } else {
                    persona = new Mujer();
                }
                this.simularEscenario(persona);
            }
        }

        private void simularEscenario(Persona persona) {
            persona.Saludar();
            recepcionista.recibir(persona);
            persona.perdir();
            camarero.servir(persona);
            persona.despedirse();
            camarero.recoger();
            recepcionista.agradecerVisita();
            Console.WriteLine("... ");
            Console.WriteLine("... pasa el tiempo");
            Console.WriteLine("... ");
        }

    }
}