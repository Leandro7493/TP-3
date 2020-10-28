
namespace Ejercicio_4
{
    // SEALED hace que la clase no pueda ser heredada
    sealed class EncriptadorNulo : Encriptador
    {
        public EncriptadorNulo() : base("Nulo") { }

        public override string Encriptar(string pCadena)
        {
            return pCadena;
        }

        public override string Desencriptar(string pCadena)
        {
            return pCadena;
        }
    }
}
