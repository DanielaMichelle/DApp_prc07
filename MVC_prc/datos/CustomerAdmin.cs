using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// se agrega...
using MVC_prc.Models;


namespace MVC_prc.datos
{
    public class CustomerAdmin
    {
        public IEnumerable<CLIENTES> Consultar()
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                return contexto.CLIENTES.AsNoTracking().ToList();
            }
        }
        public CLIENTES Consultar(int id)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                return contexto.CLIENTES.AsNoTracking().FirstOrDefault(c => c.codigo == id);
            }
        }
        public void Guardar(CLIENTES modelo)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                contexto.CLIENTES.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public void Modificar(CLIENTES modelo)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                contexto.Entry(modelo).State =
                System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(CLIENTES modelo)
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