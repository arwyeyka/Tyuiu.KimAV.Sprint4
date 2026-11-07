using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KimAV.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] array)
        {
            int result = 0;

            int rows = array.GetUpperBound(0) + 1; 
            int columns = array.Length / rows; 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (result < array[i, j])
                    {
                        result = array[i, j];
                    }
                }
            }
            return result;
        }
    }
}
