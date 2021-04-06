namespace WindowsFormsApp3
{
    public class LineContainer
    {
        public string[] container;

        public LineContainer(string _toChar,char _separator)
        {
            this.container = _toChar.Split(_separator);
        }
    }
}
