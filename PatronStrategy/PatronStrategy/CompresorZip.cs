namespace PatronStrategy
{
    public class CompresorZip : ICompresorStrategy
    {
        public string Comprimir(string archivo)
        {
            return string.Format("{0}.zip",archivo);
        }
    }
}