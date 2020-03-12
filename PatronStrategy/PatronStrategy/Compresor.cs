using System;

namespace PatronStrategy
{
    public class Compresor
    {
        private readonly ICompresorStrategy _compresor;

        public Compresor(ICompresorStrategy compresor)
        {
            _compresor = compresor;
        }

        public string Comprimir(string archivo)
        {
            return _compresor.Comprimir(archivo);
        }
    }
}