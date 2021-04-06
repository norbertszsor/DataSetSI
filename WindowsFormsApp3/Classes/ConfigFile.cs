namespace WindowsFormsApp3
{
    public class ConfigFile
    {
        public char separator;
        public int liczbaKolumn;
        public string nazwaPlikuConfig;
        public string nazwaPlikuDanych;
        public int kolumnaDecyzyjna;
        public bool[] kolumnyDoNormalizacji;

        public ConfigFile(char _separator, int _containerLenght, string _json, string _fileName, int _significantRow, bool[] _charRows)
        {
            this.separator = _separator;
            this.liczbaKolumn = _containerLenght;
            this.nazwaPlikuConfig = _json;
            this.nazwaPlikuDanych = _fileName;
            this.kolumnaDecyzyjna = _significantRow;
            this.kolumnyDoNormalizacji = _charRows;
        }

      
    }
}
