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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        taxa SeleccionarTaxaPorIDTaxa(long Idtaxa);

        [OperationContract]
        Int64 InsertarTaxa(taxa nuevaTaxa);

        [OperationContract]
        bool actualizarTaxa(taxa taxaActualizada);

        [OperationContract]
        bool eliminarTaxa(taxa taxaEliminada);
    }
}
