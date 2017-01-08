using System;
namespace DobleDesplacho {
    public class Hombre : Persona
    {
        public void recibirPalmada(Recepcionista recepcionista) {
            Console.WriteLine("+Soy un hombre lleno de vanidad");
            recepcionista.recibirPropina(3);
        }
        public override void aceptar(VisitadorPersona visitadorPersona)
        {
            visitadorPersona.visitar(this);
        }
    }
}
