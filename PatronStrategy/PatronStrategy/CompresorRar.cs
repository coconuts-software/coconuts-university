namespace PatronStrategy
{
    public class CompresorRar : ICompresorStrategy
    {
        public string Comprimir(string archivo)
        {
            return string.Format("{0}.rar",archivo);
        }
    }
}