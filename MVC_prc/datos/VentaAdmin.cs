using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_prc.Models;


namespace MVC_prc.datos
{
    public class VentaAdmin
    {
        public IEnumerable<VENTAS> Consultar()
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                return contexto.VENTAS.AsNoTracking().ToList();
            }
        }
        public VENTAS Consultar(int id)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                return contexto.VENTAS.AsNoTracking().FirstOrDefault(c => c.codigo == id);
            }
        }
        public void Guardar(VENTAS modelo)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                contexto.VENTAS.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public void Modificar(VENTAS modelo)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                contexto.Entry(modelo).State =
                System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(VENTAS modelo)
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