using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace WindowsFormsApp3
{
    static class NormalizedDataSetSave
    {
        static public void saveToOwnFormat(string _path,List<string[]> _dataset)
        {
            List<string[]> transposedDataSet = new List<string[]>();
            TextWriter txtFile = new StreamWriter(_path);
            string row;

            for (int i = 0; i < _dataset[0].Length; i++)
            {
                string[] tmpArray = new string[_dataset.Count];
                for (int j = 0; j < _dataset.Count; j++)
                {
                    tmpArray[j] = "ova"+_dataset[j][i]+"ncode";
                }
                transposedDataSet.Add(tmpArray);
            }
            
            foreach(var i in transposedDataSet)
            {
                row = string.Join(" ", i);
                txtFile.WriteLine(row);
            }
            txtFile.Close();

        }
        static public List<string> openFromOwnFromat(string _path)
        {
            List<string> transposedDataSet = new List<string>();
            List<string[]> tmpDataSet = new List<string[]>();
            string row;
            string[] tmpArray;

            transposedDataSet = File.ReadAllLines(_path).ToList();
            
            foreach(var i in transposedDataSet)
            {
                tmpArray = i.Split(" ");
                tmpDataSet.Add(tmpArray);   
            }
            transposedDataSet.Clear();

            for (int i = 0; i < tmpDataSet[0].Length; i++)
            {
                tmpArray = new string[tmpDataSet.Count];

                for (int j = 0; j < tmpDataSet.Count; j++)
                {
                    tmpArray[j] = tmpDataSet[j][i];
                }
                row = string.Join(" ", tmpArray);
                row = row.Replace("ova", "");
                row = row.Replace("ncode", "");
                transposedDataSet.Add(row);
            }
            return transposedDataSet;
        }
        static public void saveToJSON(string _path, List<string> _dataset)
        {
            string jsonToSave = JsonConvert.SerializeObject(_dataset, Formatting.Indented);
            File.WriteAllText(_path, jsonToSave);
        }
        static public List<string> opentFromJSON(string _path)
        {
            _path = File.ReadAllText(_path);
            List<string> dataset = JsonConvert.DeserializeObject<List<string>>(_path);
            return dataset;
        }
        static public void saveToTXT(string _path, List<string> _dataset)
        {
            TextWriter txtFile = new StreamWriter(_path);

            foreach(var i in _dataset)
            {
                txtFile.WriteLine(i);
            }

            txtFile.Close();
        }
        static public List<string> openFromTXT(string _path)
        {
            List<string> dataset = new List<string>();
            dataset = File.ReadAllLines(_path).ToList();

            return dataset;
        }
    }
}
