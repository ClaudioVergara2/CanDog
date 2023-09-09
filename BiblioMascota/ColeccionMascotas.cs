using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioMascota
{
    public class ColeccionMascotas
    {
        private static List<Mascota> Lis = new List<Mascota>();
        public static void CargarDatosPrueba()
        {
            Lis.Add(new Mascota { Id = 1, Nombre = "Plutón", Raza = "Pug", Vacunado=true, FechaNacim=DateTime.Today, Sexo = "Macho", tamano = "Pequeño", NomPro = "Sana", EdadPro = 24});;
            Lis.Add(new Mascota { Id = 2, Nombre = "Nina", Raza = "Poodle", Vacunado = true, FechaNacim = DateTime.Today,Sexo = "Hembra", tamano = "Pequeño", NomPro = "Lily", EdadPro = 40});
            Lis.Add(new Mascota { Id = 3, Nombre = "Simba", Raza = "Gran danés", Vacunado = false, FechaNacim = DateTime.Today, Sexo = "Macho", tamano = "Grande", NomPro = "Felix", EdadPro = 55});
            Lis.Add(new Mascota { Id = 4, Nombre = "Luna", Raza = "Border Collie", Vacunado = true, FechaNacim = DateTime.Today, Sexo = "Hembra", tamano = "Mediano", NomPro = "Rosé", EdadPro = 18});
            Lis.Add(new Mascota { Id = 5, Nombre = "Linda", Raza = "Bulldog", Vacunado = false, FechaNacim = DateTime.Today, Sexo = "Hembra", tamano = "Grande", NomPro = "Kim", EdadPro = 45});
        }
        public static bool Create(Mascota nueva)
        {
            if (Read(nueva.Id) == null)
            {
                Lis.Add(nueva);
                return true;
            }
            return false;
        }
        public static Mascota Read(int idBuscado)
        {
            for (int i = 0; i < Lis.Count; i++)
            {
                if (Lis[i].Id == idBuscado)
                {
                    return Lis[i];
                }
            }
            return null;
        }
        public static bool Update(Mascota mascota)
        {
            Mascota buscada = Read(mascota.Id);
            if (buscada == null) { return false; }
            buscada.Nombre = mascota.Nombre;
            buscada.Sexo = mascota.Sexo;
            buscada.Raza = mascota.Raza;
            buscada.Vacunado = mascota.Vacunado;
            buscada.FechaNacim = mascota.FechaNacim;
            buscada.tamano = mascota.tamano;
            buscada.NomPro = mascota.NomPro;
            buscada.EdadPro = mascota.EdadPro;
            return true;
        }
        public static Mascota Delete(int idEliminar)
        {
            Mascota buscada = Read(idEliminar);
            if (buscada == null)
            {
                return null;
            }
            else
            {
                Lis.Remove(buscada);
                return buscada;
            }
        }
        public static List<Mascota> ReadAll()
        {
            List<Mascota> miLista = new List<Mascota>();
            for (int i = 0; i < Lis.Count; i++)
            {
                miLista.Add(Lis[i]);
            }
            return miLista;
        }
    }
}
