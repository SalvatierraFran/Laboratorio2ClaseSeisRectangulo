using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private Punto VerticeUno;
        private Punto VerticeDos;
        private Punto VerticeTres;
        private Punto VerticeCuatro;
        
        public MiColor ColorRectangulo;

        private float Superficie;
        private float Perimetro;

        public Rectangulo(Punto Verti1, Punto Verti3, MiColor Color)
        {
            this.VerticeUno = Verti1;
            this.VerticeTres = Verti3;

            this.VerticeDos = new Punto(this.VerticeTres.DevolverX(), this.VerticeUno.DevolverY());
            this.VerticeCuatro = new Punto(this.VerticeUno.DevolverX(), this.VerticeTres.DevolverY());
            this.CalcularSupertificie();
        }

        private void CalcularSupertificie()
        {
            float bas;
            float altura;

            bas = Math.Abs(this.VerticeDos.DevolverX() - this.VerticeTres.DevolverX());
            altura = Math.Abs(this.VerticeCuatro.DevolverY() - this.VerticeUno.DevolverY());

            this.Superficie = bas * altura;

            //Console.Write(this.Superficie);
        }

        public float GetSuperficie()
        {
            return this.Superficie;
        }

        public void CalcularPerimetro()
        {
            float bas = Math.Abs(this.VerticeDos.DevolverX() - this.VerticeTres.DevolverX());
            float altura = Math.Abs(this.VerticeCuatro.DevolverY() - this.VerticeUno.DevolverY());

            this.Perimetro = 2 * bas + 2 * altura;
        }

        public float GetPerimetro()
        {
            return this.Perimetro;
        }

        public static void Mostrar(Rectangulo UnRectangulo)
        {
            Console.Write("\nSuperficie: " + UnRectangulo.Superficie);
            Console.Write("\nPerimetro: " + UnRectangulo.Perimetro);

            float bas = Math.Abs(UnRectangulo.VerticeDos.DevolverX() - UnRectangulo.VerticeTres.DevolverX());
            float altura = Math.Abs(UnRectangulo.VerticeCuatro.DevolverY() - UnRectangulo.VerticeUno.DevolverY());

            Console.Write("\nBase: " + bas);
            Console.Write("\nAltura: " + altura);
        }
    }

    //Los enumerados van fuera de la clase, pero adentro del NameSpace.
    public enum MiColor
    {
        Rojo, Verde, Azul, Blanco
    }
}
