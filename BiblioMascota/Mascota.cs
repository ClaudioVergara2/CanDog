using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioMascota
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }
        public bool Vacunado { get; set; }
        public DateTime FechaNacim { get; set; }
        public string tamano { get; set; }
        public string NomPro { get; set; }
        public int EdadPro { get; set; }

        public bool Validar()
        {
            bool errores = false;
            if (Id < 0) errores = true;
            if (Nombre.Length < 2) errores = true;
            if (Raza.Length < 2) errores = true;
            if (Sexo.Length < 2) errores = true;
            if (tamano.Length < 2) errores = true;
            if (NomPro.Length < 2) errores = true;

            //Fecha no puede ser menor a 1900,1,1
            //- Lo agrege en las pripiedades de dtFecha

            //Sexo & Tamaño
            //- Agrege los items en Form1_Load
            return !errores;
        }

        //public int ValorLavadoCortePelo()
        //{
        //    int pre;
        //    if (tamano == "Pequeño")
        //    {
        //        Console.WriteLine("El precio es $8000");
        //    }
        //    if (tamano == "Mediano")
        //    {
        //        Console.WriteLine("El precio es $11000");
        //    }
        //    if (tamano == "Grande")
        //    {
        //        Console.WriteLine("El precio es $18000");
        //    }
        //    return pre;
        //}
    }
}
