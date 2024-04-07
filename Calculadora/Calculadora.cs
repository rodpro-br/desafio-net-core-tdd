using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string _data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            _data = data;
        }

        public int somar(int val1, int val2)
        {
            int res = val1 + val2;
            listaHistorico.Insert(0, $"Resultado Soma {val1} + {val2}: {res} - data {_data}");
            return res;
        }

        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            listaHistorico.Insert(0, $"Resultado Subtração {val1} - {val2}: {res} - data {_data}");
            return res;
        }

        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            listaHistorico.Insert(0, $"Resultado Multiplicação {val1} * {val2}: {res} - data {_data}");
            return res;
        }

        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;
            listaHistorico.Insert(0, $"Resultado Divisão {val1} / {val2}: {res} - data {_data}");
            return res;
        }

        public List<string> historico() 
        { 
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico; 
        }
    }
}
