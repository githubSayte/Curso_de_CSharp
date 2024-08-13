using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    // metodo que demonstra o operador E logico (&&)
    public static class OperadoresLogicos
    {
        public static bool ELogico(bool a, bool b)
        {
            return a && b;
        }
        // metodo que demonstra o operador OU logico (||)
        public static bool OULogico(bool a, bool b)
        {
            return a || b;
        }
        public static bool Negacao(bool a)
        {
            return !a;
        }
        public static bool OUExclusivo(bool a, bool b)
        {
            return a ^ b;
        }
    }
}
