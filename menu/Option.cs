using System;
namespace menu {
    public abstract class Option {
        private String title;

        public Option(String title) {
            this.title = title;
        }

        public void show(int nro) {
            Console.WriteLine($"{nro}.{title}");
        }

        public abstract void execute();

    }
}