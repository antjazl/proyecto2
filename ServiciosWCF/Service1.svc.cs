using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AccesoDatos;
using Logica;

namespace ServiciosWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        LogicaTaxa logic = new LogicaTaxa();

        
        #region metodos de accion

        public Int64 InsertarTaxa(taxa nuevaTaxa)
        {
            return logic.InsertarTaxa(nuevaTaxa);
        }

        public bool actualizarTaxa(taxa taxaActualizada)
        {
            return logic.actualizarTaxa(taxaActualizada);
        }

        public bool eliminarTaxa(taxa taxaEliminada)
        {
            return logic.eliminarTaxa(taxaEliminada.IdTaxa);
        }

        public taxa SeleccionarTaxaPorIDTaxa(long Idtaxa)
        {
            return logic.SeleccionarTaxaPorIDTaxa(Idtaxa);
        }

        #endregion
    }
}
