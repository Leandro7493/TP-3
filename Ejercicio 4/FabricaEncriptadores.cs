using System;
using System.Collections.Generic;

namespace Ejercicio_4
{
    class FabricaEncriptadores
    {
        private Dictionary<string, IEncriptador> iEncriptadores;
        private static readonly Lazy<FabricaEncriptadores> cInstancia;
        
        static FabricaEncriptadores()
        {
            cInstancia = new Lazy<FabricaEncriptadores>(() => { return new FabricaEncriptadores(); });
        }

        private FabricaEncriptadores() { }

        public IEncriptador GetEncriptador(string nombre)
        {
            IEncriptador cInstancia = iEncriptadores[nombre];
            if (cInstancia == null) { cInstancia = new EncriptadorNulo(); }
            return cInstancia;
        }        

        public static FabricaEncriptadores Instancia
        {
            get { return cInstancia.Value; }
        }
    }
}
