using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas;
 
    public RepositorioRutas()
        {
            rutas= new List<Rutas>()
            {
                new Rutas{id=1,origen=1,destino=2,tiempo_estimado=1},
                new Rutas{id=2,origen=1,destino=3,tiempo_estimado=2},
                new Rutas{id=3,origen=2,destino=3,tiempo_estimado=3}
            };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetRutaWithId(int id){
            return rutas.SingleOrDefault(b => b.id == id);
        }

        public Rutas Update(Rutas newRuta){
            var ruta= rutas.SingleOrDefault(b => b.id == newRuta.id);
            if(ruta != null){
                ruta.id = newRuta.id;
                ruta.origen= newRuta.origen;
                ruta.destino= newRuta.destino;
                ruta.tiempo_estimado = newRuta.tiempo_estimado;
            }
        return ruta;
        }
    }
}