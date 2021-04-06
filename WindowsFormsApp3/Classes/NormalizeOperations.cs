using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp3
{
    static public class NormalizeOperations
    {
        static private string[] normalize(float[] _tmpFloatArray,float _newMin, float _newMax)
        {
            string[] tmpCharArray = new string[_tmpFloatArray.Length];
            float _min = _tmpFloatArray.Min();
            float _max = _tmpFloatArray.Max();
            float tmpFloat;

            if(_newMin != 0 && _newMax != 0)
            {
                for (int i = 0; i < _tmpFloatArray.GetLength(0); i++)
                {
                    tmpFloat = (_tmpFloatArray[i] - _min) / (_max - _min);
                    tmpFloat = (tmpFloat * (_newMin - _newMax)) + _newMax;
                    tmpCharArray[i] = tmpFloat.ToString("n2");

                }
            }
            else
            {
                for (int i = 0; i < _tmpFloatArray.GetLength(0); i++)
                {
                    tmpFloat = (_tmpFloatArray[i] - _min) / (_max - _min);
                    tmpCharArray[i] = tmpFloat.ToString("n2");

                }
            }
            

            return tmpCharArray;
        }
        static private UnnormalizedDataSet nromalizeCheck(UnnormalizedDataSet _tmpDataSet, ConfigFile _configFile)
        {
         
            foreach (var i in _tmpDataSet.dataList)
            {
                for (int j = 0; j < _configFile.liczbaKolumn; j++)
                {
                    i.container[j] = i.container[j].Replace('.', ',');
                }
            }

            return _tmpDataSet;
        }
        static public List<string[]> prepareDataSet(UnnormalizedDataSet _tmpDataSet, ConfigFile _configFile, float _newMin,float _newMax)
        {
            _tmpDataSet = nromalizeCheck(_tmpDataSet, _configFile);

            List<string[]> tmpPreparedDataSet = new List<string[]>();
            
            for (int j = 0; j < _configFile.liczbaKolumn; j++)
            {
                float[] tmpFloatArray = new float[_tmpDataSet.dataList.Count];
                string[] tmpCharArray = new string[_tmpDataSet.dataList.Count];

                for (int i = 0; i <_tmpDataSet.dataList.Count; i++) 
                {
                    if(_configFile.kolumnyDoNormalizacji[j] == true)
                    {
                        float patheticValue;
                        if (float.TryParse(_tmpDataSet.dataList[i].container[j], out patheticValue) == true)
                        {
                            tmpFloatArray[i] = float.Parse(_tmpDataSet.dataList[i].container[j]);
                        }
                        else
                        {
                            foreach (char c in _tmpDataSet.dataList[i].container[j])
                            {
                                tmpFloatArray[i] = (float)Convert.ToInt32(c);
                            }
                        }  
                        
                    }
                    else
                    {
                        tmpCharArray[i] = _tmpDataSet.dataList[i].container[j];
                    }

                }

                if(_configFile.kolumnyDoNormalizacji[j] == true)
                {
                    tmpCharArray = normalize(tmpFloatArray,_newMin,_newMax);
                    tmpPreparedDataSet.Add(tmpCharArray);
                }
                else
                {
                    tmpPreparedDataSet.Add(tmpCharArray);
                }
                
            }
         

            return tmpPreparedDataSet;
        }


    }
}
