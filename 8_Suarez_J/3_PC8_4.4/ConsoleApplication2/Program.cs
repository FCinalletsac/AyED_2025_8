using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
            string msg = "ctOS";
            string enc = Level4.CaesarPlusOne(msg);
            bool ok = enc == "duPT"; // c->d, t->u, O->P, S->T
            Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");
            Console.ReadKey();
        }
    }

    static class Level4
    {
        public static string CaesarPlusOne(string s)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in s)
            {
                if (char.IsLower(c)) // minúscula
                {
                    if (c == 'z')
                        result.Append('a');
                    else
                        result.Append((char)(c + 1));
                }
                else if (char.IsUpper(c)) // mayúscula
                {
                    if (c == 'Z')
                        result.Append('A');
                    else
                        result.Append((char)(c + 1));
                }
                else
                {
                    
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}

