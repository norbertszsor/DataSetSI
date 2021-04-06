using System.IO;
using System.Collections.Generic;
namespace WindowsFormsApp3
{
    public class UnnormalizedDataSet
    {
        string path;
        public int unvalidLines;
        public List<LineContainer> dataList = new List<LineContainer>();
        

        public UnnormalizedDataSet(string _path,ConfigFile _tmpConfigFile)
        {
            this.unvalidLines = 0;
            this.path = _path;
            string line;

            if (File.Exists(this.path))
            {
                System.IO.StreamReader read = new System.IO.StreamReader(this.path);

                while ((line = read.ReadLine()) != null)
                {
                    if (line.Contains("?"))
                    {
                        this.unvalidLines += 1;
                    }
                    else
                    {
                        LineContainer tmpContainer = new LineContainer(line, _tmpConfigFile.separator);
                        this.dataList.Add(tmpContainer);
                    }
                   
 
                }
                read.Close();
            }
            try
            {
                foreach (var i in this.dataList)
                {
                    if (i.container.Length != _tmpConfigFile.liczbaKolumn)
                    {
                        dataList.Remove(i);
                        this.unvalidLines += 1;
                    }
                }
            }
            catch (System.InvalidOperationException)
            {
                this.unvalidLines = this.dataList.Count;
                dataList.Clear();
            }
          
            foreach (var i in this.dataList)
            {
                for (int j = 0; j < _tmpConfigFile.liczbaKolumn; j++)
                {
                    i.container[j] = i.container[j].Replace(',', ' ');
                }
            }


           
        }

        public List<string> unnormalizedDataSetView()
        {
            List<string> tmpDataView = new List<string>();

            foreach(var i in this.dataList)
            {
                string row = string.Join(" ", i.container);
                tmpDataView.Add(row);
            }

       
            return tmpDataView;
        }

    }
}
