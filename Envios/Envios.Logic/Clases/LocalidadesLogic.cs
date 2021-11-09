using Envios.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Envios.Logic.Clases
{
    public class LocalidadesLogic : BaseDBClasesLogic
    {
        public List<Localidades> GetAll()
        {
            return context.Localidades.ToList();
        }

        public void Add(Localidades newLocalidad)
        {
            context.Localidades.Add(newLocalidad);
            context.SaveChanges();
        }

        public void Update(Localidades localidad)
        {
            try
            {
                var localidadUpdate = context.Localidades.Find(localidad.LocalidadID);
                localidadUpdate.LocalidadName = localidad.LocalidadName;

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
                var localidadToDelete = context.Localidades.Find(id);

                ///BORRADO LOGICO
                localidadToDelete.Available = 0;
                context.SaveChanges();
            }
            catch (Exception)
            {
                ///throw new CustomException("EXISTEN ORDENES ASOCIADAS A ESTE DISTRIBUIDOR. NO SE PUEDE ELIMINAR");
            }
        }

        public Localidades GetDataById(int id)
        {
            Localidades localidad = context.Localidades.Where(p => p.LocalidadID == id).FirstOrDefault();

            return localidad;
        }
    }
}
