using System;

namespace menu
{
    public class Program
    {
        private Menu menu;
        public Program() {
            menu = new Menu(); 
            menu.addOption(new Option1("OPtion 1"));
            menu.addOption(new Option2("OPtion 2"));
            menu.close();
        }
        
        public void execute() {
            do {
                menu.show();
                menu.getOption().execute();
            } while (!menu.finished());
        }
        public static void Main(string[] args)
        {
            new Program().execute();
        }
    }
}
