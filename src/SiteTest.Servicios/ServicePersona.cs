using System.Collections.Generic;
using System.Linq;

namespace SiteTest.Servicios
{
    public class ServicePersona
    {
        public ServicePersona()
        {
        }

        public List<Persona> ObtenerPersonas()
        {
            var lista = new List<Persona>();
            lista.Add(new Persona() { Nombre = "Emilio", Apellido = "Montes", Rut = "16385993-9"});
            lista.Add(new Persona() { Nombre = "Fernando", Apellido = "Montes", Rut = "17365465-2" });
            lista.Add(new Persona() { Nombre = "Italo", Apellido = "Montes", Rut = "19386633-6" });

            return lista;
        }

        public Persona ObtenerPersonaPor(string rut)
        {
            var lista = ObtenerPersonas();
            return lista.FirstOrDefault(x => x.Rut.Contains(rut));
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Rut { get; set; }
    }
}
