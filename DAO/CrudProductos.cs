using MerlinDuarte23_03_23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerlinDuarte23_03_23.DAO
{
    public class CrudProductos
    { 
        public void AgregarProductos(Producto ParametroProducto)
        {
            using(AlmacenContext db = new AlmacenContext()) 
            {
                Producto Prod = new Producto();
                
                Prod.Nombre = ParametroProducto.Nombre;
                Prod.Descripción = ParametroProducto.Descripción;
                Prod.Precio = ParametroProducto.Precio;
                Prod.Stock = ParametroProducto.Stock;
                db.Add(Prod);
                db.SaveChanges();
            }
        }
    }
}
