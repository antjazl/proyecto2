using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using AccesoDatos;

namespace Logica
{
    public class LogicaTaxa
    {
        DatosTaxa datos = new DatosTaxa();

        public List<taxa> seleccionarTaxas()
        {
            return datos.seleccionarTaxa();
        }

        #region metodos de accion

        public Int64 InsertarTaxa(taxa nuevaTaxa)
        {
            return datos.insertarTaxa(nuevaTaxa);
        }


        public bool actualizarTaxa(taxa taxaActualizada)
        {
            return datos.actualizarTaxa(taxaActualizada);
        }

        public bool eliminarTaxa(long idTaxa)
        {
            return datos.eliminarTaxa(idTaxa);
        }
        public taxa SeleccionarTaxaPorIDTaxa(long IdTaxa)
        {
            return datos.SeleccionarTaxaPorIDTaxa(IdTaxa);
        }
        #endregion

    }
}
