using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace paginaWCF
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int eEliminar;

        protected void Page_Load(object sender, EventArgs e)
        {
            FormView1.ChangeMode(FormViewMode.Insert);
        }

        protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

        }

     

        protected void ObjectDataSource1_Deleting(object sender, ObjectDataSourceMethodEventArgs e)
        {
            wcf.taxa Eliminar = e.InputParameters[0] as wcf.taxa;
            if (Eliminar != null)
            {

                Eliminar.IdTaxa = eEliminar;
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (ObjectDataSource1.DeleteParameters.Count > 0)
            {
                ObjectDataSource1.DeleteParameters[0].DefaultValue = e.Keys["IdTaxa"].ToString();
            }
            eEliminar = Convert.ToInt32(e.Keys["IdTaxa"]);
        }

    }
}