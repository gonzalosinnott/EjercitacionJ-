using Envios.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envios.Logic.Clases
{
    public class ProvinciasLogic : BaseDBClasesLogic
    {
        public List<Provincias> GetAll()
        {
            return context.Provincias.ToList();
        }

        public void Add(Provincias newProvincia)
        {
            context.Provincias.Add(newProvincia);
            context.SaveChanges();
        }

        public void Update(Provincias provincia)
        {
            try
            {
                var provinciaUpdate = context.Provincias.Find(provincia.ProvinciaID);
                provinciaUpdate.ProvinciaName = provincia.ProvinciaName;

                context.SaveChanges();
            }
            catch (Exception)
            {
                //throw new CustomException("INGRESO DE DATOS ERRONEOS");
            }
        }

        public void Delete(int id)
        {
            try
            {
                var provinciaToDelete = context.Provincias.Find(id);

                ///BORRADO LOGICO
                provinciaToDelete.Available = 0;
                context.SaveChanges();
            }
            catch (Exception)
            {
                ///throw new CustomException("EXISTEN ORDENES ASOCIADAS A ESTE DISTRIBUIDOR. NO SE PUEDE ELIMINAR");
            }
        }
    }
}
