using System;
namespace DobleDesplacho {
    public interface VisitadorPersona {
        void visitar(Mujer mujer);
        void visitar(Hombre hombre);
    }
}
