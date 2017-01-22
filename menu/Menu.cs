using System;
using System.Collections.Generic;

namespace menu {
    public class Menu {
        private List<Option> options;
        private Salir salir;
        public Menu() {
            options = new List<Option>();
            salir = new Salir();
        }

        public void close() {
            this.addOption(salir);
        }

        public void show() {
            for (int i=0; i<options.Count;i++) {
                options[i].show(i+1);
            }    
        }

        public Option getOption() {
            Console.WriteLine("Ingrese opcion");
            int option = int.Parse(Console.ReadLine());
            return options[option-1];  
        }

        public void addOption(Option option) {
            options.Add(option);
        }
        public bool finished() {
            return salir.isExecuted();
        }

    }
}
