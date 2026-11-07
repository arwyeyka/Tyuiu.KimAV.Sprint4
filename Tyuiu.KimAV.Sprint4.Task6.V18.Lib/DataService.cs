using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KimAV.Sprint4.Task6.V18.Lib
{
    public class DataService : ISprint4Task6V18
    {
        public string[] Calculate(string[] array)
        {
            return Array.FindAll(array, s => s.Length > 6);
        }
    }
}
