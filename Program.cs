using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DU_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vezmi si rovnicu a = 2*b+6/c – 10*d. Každé neznáme číslo, teda b, c, d si napíš osobitne a ulož si ich. 
            //Napríklad int b = 10 a podobne. Potom do premennej s názvom a si ulož výsledok danej rovnice. Výsledok napíš na konzolu.


            double b = 10;
            double c = 2;
            double d = 3;

            double a = (2 * b + 6 / c - 10 * d);

            //ty betar tam si namiesto - dal ine znamienko alebo mi to zle skopcilo :)

            Console.WriteLine(a);
            Console.Read();
        }
    }
}
