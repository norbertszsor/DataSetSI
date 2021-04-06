using System.IO;
using Newtonsoft.Json;
namespace WindowsFormsApp3
{
    static public class JsonOperations
    {
        public static void Save(ConfigFile _tmpConfigFile)
        {
           
            string jsonToSave = JsonConvert.SerializeObject(_tmpConfigFile,Formatting.Indented);
            File.WriteAllText(_tmpConfigFile.nazwaPlikuConfig+".ini", jsonToSave);
         
        }
        public static ConfigFile Open(string _path)
        {
            _path = File.ReadAllText(_path);
            ConfigFile tmpCofigFile = JsonConvert.DeserializeObject<ConfigFile>(_path);

            return tmpCofigFile;
        }
    }
}
