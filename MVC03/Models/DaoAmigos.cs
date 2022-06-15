using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC03.Models
{
    public class DaoAmigos
    {
        public List<amigos> amigosQry()
        {
            List<amigos> list;

            using (var db = new ModelAmigos())
            {
                var query = from t in db.amigos select t;
                list = query.ToList<amigos>();
            }

            return list;
        }

        public void amigosIns(amigos t)
        {
            using (var db = new ModelAmigos())
            {
                db.amigos.Add(t);
                db.SaveChanges();
            }
        }

        public void amigosDel(int idamigo)
        {
            using (var db = new ModelAmigos())
            {
                var amigo = db.amigos.Find(idamigo);

                db.amigos.Remove(amigo);
                db.SaveChanges();
            }
        }

        public void amigosUpd(amigos t)
        {
            using (var db = new ModelAmigos())
            {
                var amigo = db.amigos.Find(t.idamigo);

                amigo.nombre = t.nombre;
                amigo.correo = t.correo;
                amigo.telefono = t.telefono;
                amigo.direccion = t.direccion;

                db.SaveChanges();
            }
        }
    }
}