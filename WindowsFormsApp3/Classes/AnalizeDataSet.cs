using System.IO;
namespace WindowsFormsApp3
{
    public static class AnalizeDataSet
    {
     
        private static string open(string _path)
        {
            string line;
            if (File.Exists(_path))
            {
                System.IO.StreamReader read = new System.IO.StreamReader(_path);
                line = read.ReadLine();
                read.Close();
                return line;
            }
            else
                return "file do not exist";
            
            
        }     
        private static char analizeSeparator(string _path)
        {
            
            string line = open(_path);
            int max, min = 0;
            char separatorChar = (char)0, tmpChar;

            for (int i = 0; i < 255; i++)
            {
                tmpChar = (char)i;
                max = line.Split(tmpChar).Length - 1;

                if (max > min)
                {
                    separatorChar = tmpChar; 
                    min = max;
                }

            }

            return separatorChar;
        }

        public static ConfigFile generateConfigFIle(string _path,string _name)
        {
            
            string line = open(_path);
            char separator = analizeSeparator(_path);
            string[] container = line.Split(separator);
            bool[] charRows = new bool[container.Length];
            for (int i = 0; i < container.Length; i++)
            {
                container[i] = container[i].Replace('.', ',');
                try
                {
                    float.Parse(container[i]);
                    charRows[i] = true;
                }
                catch
                {

                }
            }
            charRows[0] = false;
            ConfigFile tmpConfigFile = new ConfigFile(separator, container.Length, "Automatyczny: " + _name, _name, 0, charRows);


            return tmpConfigFile;

        }
        
    }
}
