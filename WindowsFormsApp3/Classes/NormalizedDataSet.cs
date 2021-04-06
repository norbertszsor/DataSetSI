using System;
using System.Collections.Generic;
using System.Linq;
namespace WindowsFormsApp3
{
    public class NormalizedDataSet
    {
        public List<string[]> dataset = new List<string[]>();

        public NormalizedDataSet(List<string[]> _preparedDataSet, ConfigFile _configFile)
        {
           
            for(int j = 0; j<_preparedDataSet[0].GetLength(0); j++)
            {
                string[] tmpStringArray = new string[_configFile.liczbaKolumn];

                for (int i = 0; i < _configFile.liczbaKolumn; i++)
                {
                    tmpStringArray[i] = _preparedDataSet[i][j];
                }
                this.dataset.Add(tmpStringArray);
            }
        }

        public List<string> NormalizedDataSetView()
        {
            List<string> tmpNormalizedDataSet = new List<string>();

            foreach(var i in this.dataset)
            {
                string row = string.Join(" ", i);
                tmpNormalizedDataSet.Add(row);
            }

            return tmpNormalizedDataSet;
        }
    }
}
