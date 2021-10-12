using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_prc.Models;


namespace MVC_prc.datos
{
    public class ProductoAdmin
    {
        public IEnumerable<PRODUCTO> Consultar()
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                return contexto.PRODUCTO.AsNoTracking().ToList();
            }
        }
        public PRODUCTO Consultar(int id)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                return contexto.PRODUCTO.AsNoTracking().FirstOrDefault(c => c.codigo == id);
            }
        }
        public void Guardar(PRODUCTO modelo)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                contexto.PRODUCTO.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public void Modificar(PRODUCTO modelo)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                contexto.Entry(modelo).State =
                System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(PRODUCTO modelo)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                contexto.Entry(modelo).State =
                System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}