using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
namespace Datos
{
    public class DatosTaxa
    {
        BiologiaBdRelacionesEntities contexto;

        public DatosTaxa()
        {
            contexto = new BiologiaBdRelacionesEntities();
            contexto.Configuration.ProxyCreationEnabled = false;
        }

        public taxa SeleccionarTaxaPorIDTaxa(long IdTaxa)
        {
            var consulta = from lstTaxa in contexto.taxas
                           where lstTaxa.IdTaxa == IdTaxa
                           select lstTaxa;
            taxa txaTaxa = consulta.SingleOrDefault();
            return txaTaxa;
        }


        public List<taxa> seleccionarTaxa()
        {
            var consultaRes = from lsttaxa in contexto.taxas
                              select lsttaxa;
            List<taxa> lsttaxaRes = consultaRes.ToList();
            return lsttaxaRes;
        }

        #region Metodos de accion

        public Int64 insertarTaxa(taxa nuevaTaxa)
        {
            contexto.taxas.Add(nuevaTaxa);
            contexto.SaveChanges();
            return nuevaTaxa.IdTaxa;
        }

        public bool actualizarTaxa(taxa TaxaModificada)
        {
            taxa tataxa = contexto.taxas.Where(t => t.IdTaxa == TaxaModificada.IdTaxa).SingleOrDefault();
            if (tataxa != null)
            {
                tataxa.IdTaxa = TaxaModificada.IdTaxa;
                tataxa.Nombre = TaxaModificada.Nombre;
                tataxa.nombrecomuns = TaxaModificada.nombrecomuns;
                tataxa.NombreCorto = TaxaModificada.NombreCorto;
                //etc etc
                contexto.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool eliminarTaxa(long idtaxa)
        {
            taxa tataxa = contexto.taxas.Where(t => t.IdTaxa == idtaxa).SingleOrDefault();
            if (tataxa != null)
            {
                contexto.taxas.Remove(tataxa);
                contexto.SaveChanges();
                return true;
            }
            else
                return false;
        }
        #endregion
    }
}
