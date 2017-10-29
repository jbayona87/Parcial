using Interfaces.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface IRegistraMuestra
    {
        List<MuestrasDto> ListarMuestras();
        MuestrasDto RegistrarMuestra(MuestrasDto nuevoRegistro);
        void ActualizarMuestra(MuestrasDto registroActualizado);
        void EliminarMuestra(MuestrasDto registroEliminado);
    }
}
