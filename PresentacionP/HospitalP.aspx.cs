using NegociosN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        HospitalN hospitalN;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargar("%");
                lblcod.Visible = false;
                txtcod.Visible = false;
            }
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            hospitalN = new HospitalN();
            bool? respuesta = hospitalN.InsertarHospital(txtNombre.Text,txtDireccion.Text,txtTelefono.Text,Convert.ToInt16(txtNum_cama.Text));
            if (respuesta == true)
            {
                lblCorrecto.Text = "Se registro correctamente";
                lblCorrecto.Visible = true;
                pnlingresar.Visible = false;
                limpiar();
                cargar("%");
                lblcod.Visible= false;
                txtcod.Visible= false;
            }
            else
            {
                lblError.Text = "Ocurrio un error no se registro.";
                lblError.Visible = true;
            }
        }

        protected void btnactualizar_Click(object sender, EventArgs e)
        {

            hospitalN = new HospitalN();
            bool? respuesta = hospitalN.ActualizarHospital(Convert.ToInt16(txtcod.Text), txtNombre.Text, txtDireccion.Text, txtTelefono.Text, Convert.ToInt16(txtNum_cama.Text));
            if (respuesta == true)
            {

                lblCorrecto.Text = "Se Actualizo correctamente";
                lblCorrecto.Visible = true;
                pnlingresar.Visible = false;
                limpiar();
                cargar("%");
            }
            else
            {
                lblError.Text = "Ocurrio un error no se actualizo.";
                lblError.Visible = true;
            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            hospitalN = new HospitalN();

            bool? respuesta = hospitalN.EliminarHospital(Convert.ToInt16(txtcod.Text));

            if (respuesta == true)
            {

                lblcod.Visible = false;
                txtcod.Visible = false;

                lblCorrecto.Text = "Se elimino correctamente";
                lblCorrecto.Visible = true;
                pnlingresar.Visible = false;
                limpiar();
                cargar("%");
            }
            else
            {
                lblError.Text = "Ocurrio un error no se elimino";
                lblError.Visible = true;
            }

        }

        protected void dtgListadoHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcod.Text = HttpUtility.HtmlDecode(dtgListadoHospital.SelectedRow.Cells[1].Text);
            txtNombre.Text = HttpUtility.HtmlDecode(dtgListadoHospital.SelectedRow.Cells[2].Text);
            txtDireccion.Text = HttpUtility.HtmlDecode(dtgListadoHospital.SelectedRow.Cells[3].Text);
            txtTelefono.Text = HttpUtility.HtmlDecode(dtgListadoHospital.SelectedRow.Cells[4].Text);
            txtNum_cama.Text = HttpUtility.HtmlDecode(dtgListadoHospital.SelectedRow.Cells[5].Text);
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            hospitalN = new HospitalN();
            cargar(txtFiltro.Text);
        }

        public void cargar(string Filtro)
        {
            hospitalN = new HospitalN();
            var items = hospitalN.ListadoHospital(Filtro);
            dtgListadoHospital.DataSource = items;
            dtgListadoHospital.DataBind();
        }

        public void limpiar()
        {
            txtcod.Text = string.Empty;
            txtNombre.Text= string.Empty;
            txtDireccion.Text= string.Empty;
            txtTelefono.Text= string.Empty;
            txtNum_cama.Text= string.Empty;
        }

    }
}