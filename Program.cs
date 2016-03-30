using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Geometria.MiColor UnColor;
            //UnColor = Geometria.MiColor.Verde;

            //UnColor = (Geometria.MiColor)22;

            //Console.Write(UnColor);

            //switch (UnColor)
            //{
            //    case Geometria.MiColor.Rojo:
            //        break;
            //    case Geometria.MiColor.Verde:
            //        break;
            //    case Geometria.MiColor.Azul:
            //        break;
            //    case Geometria.MiColor.Blanco:
            //        break;
            //    default:
            //        break;
            //}

            Rectangulo mir = new Rectangulo(new Punto(1, 5), new Punto(6, 1), MiColor.Verde);
            Console.Write(mir.GetSuperficie());
            Rectangulo.Mostrar(mir);

            Console.ReadKey();
        }
    }
}
