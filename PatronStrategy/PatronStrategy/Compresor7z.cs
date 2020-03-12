namespace PatronStrategy
{
    public class Compresor7z : ICompresorStrategy
    {
        public string Comprimir(string archivo)
        {
            return string.Format("{0}.7z",archivo);
        }
    }
}