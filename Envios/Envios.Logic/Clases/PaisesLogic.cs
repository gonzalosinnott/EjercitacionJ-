using Envios.Data;
using Envios.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envios.Logic.Clases
{
    public class PaisesLogic : BaseDBClasesLogic
    {
        public List<Paises> GetAll()
        {
            return context.Paises.ToList();
        }

        public void Add(Paises newPais)
        {
            context.Paises.Add(newPais);
            context.SaveChanges();
        }

        public void Update(Paises pais)
        {
            try
            {
                var paisUpdate = context.Paises.Find(pais.PaisID);
                paisUpdate.PaisName = pais.PaisName;

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
                var paisToDelete = context.Paises.Find(id);

                ///BORRADO LOGICO
                paisToDelete.Available = 0;
                context.SaveChanges();
            }
            catch (Exception)
            {
                ///throw new CustomException("EXISTEN ORDENES ASOCIADAS A ESTE DISTRIBUIDOR. NO SE PUEDE ELIMINAR");
            }
        }

        public Paises getPaisById(int id)
        {
            Paises pais = context.Paises.Where(p => p.PaisID == id).FirstOrDefault();                      

            return pais;
        }

        public Paises GetDataById(int id)
        {
            Paises pais = context.Paises.Where(p => p.PaisID == id).FirstOrDefault();

            return pais;
        }
    }
}
