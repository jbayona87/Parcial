using DataModel;
using Interfaces.Dto;
using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarMuestras
{
    public class RegistraMuestra : IRegistraMuestra
    {
        private MuestrasDto ConvertToDto(Muestras muestras)
        {
            MuestrasDto _muestras = new MuestrasDto();
            _muestras.Id = muestras.Id;
            _muestras.Persona_Muestrada = muestras.Persona_Muestrada;
            _muestras.Fecha_Toma = muestras.Fecha_Toma;
            _muestras.Persona_Toma_Muestra = muestras.Persona_Toma_Muestra;
            return _muestras;
        }

        public List<MuestrasDto> ListarMuestras()
        {
            using (LaboratorioEntities dbContext = new LaboratorioEntities())
            {
                return dbContext.Muestras.ToList().Select(x => ConvertToDto(x)).ToList();
            }
        }

        public MuestrasDto RegistrarMuestra(MuestrasDto nuevoRegistro)
        {
            using (LaboratorioEntities dbContext = new LaboratorioEntities())
            {
                Muestras muestras = new Muestras();
                muestras.Persona_Muestrada = nuevoRegistro.Persona_Muestrada;
                muestras.Fecha_Toma = nuevoRegistro.Fecha_Toma;
                muestras.Persona_Toma_Muestra = nuevoRegistro.Persona_Toma_Muestra;
                dbContext.Muestras.Add(muestras);
                dbContext.SaveChanges();
                return ConvertToDto(muestras);
            }
        }

        public void ActualizarMuestra(MuestrasDto registroActualizado)
        {
            using (LaboratorioEntities dbContext = new LaboratorioEntities())
            {
                Muestras muestra = dbContext.Muestras.Find(registroActualizado.Id);
                muestra.Persona_Muestrada = registroActualizado.Persona_Muestrada;
                muestra.Fecha_Toma = registroActualizado.Fecha_Toma;
                muestra.Persona_Toma_Muestra = registroActualizado.Persona_Toma_Muestra;
                dbContext.Entry(muestra);
                dbContext.SaveChanges();
            }
        }

        public void EliminarMuestra(MuestrasDto registroEliminado)
        {
            using (LaboratorioEntities dbContext = new LaboratorioEntities())
            {
                Muestras muestra = (from n in dbContext.Muestras
                                    where n.Id == registroEliminado.Id
                                    select n).FirstOrDefault();
                dbContext.Muestras.Remove(muestra);
                dbContext.SaveChanges();
            }
        }
    }
}
