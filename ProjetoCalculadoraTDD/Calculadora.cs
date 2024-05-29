using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadoraTDD
{
    public class Calculadora
    {
        private List<string> _historico;
        private DateTime _date;

        public Calculadora(DateTime date)
        {
            _historico = new List<string>();
            _date = date;
        }

        public int Somar(int x, int y)
        {
            _historico.Insert(0, $"Resultado: {x + y}. Data: {_date}");
            return x + y;
        }

        public int Subtrair(int x, int y)
        {

            _historico.Insert(0, $"Resultado: {x - y}. Data: {_date}");
            return x - y;
        }

        public int Multiplicar(int x, int y)
        {
            _historico.Insert(0, $"Resultado: {x * y}. Data: {_date}");
            return x * y;
        }

        public int Dividir(int x, int y)
        {
            _historico.Insert(0, $"Resultado: {x / y}. Data: {_date}");
            return x / y;
        }

        public List<string> Historico()
        {
            _historico.RemoveRange(3, _historico.Count - 3);
            return _historico;
        }
    }
}
