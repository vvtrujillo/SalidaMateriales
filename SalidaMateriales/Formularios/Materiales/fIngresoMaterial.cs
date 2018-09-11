using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SalidaMateriales.Formularios.Materiales
{
    public partial class fIngresoMaterial : Form
    {
        //Declaraciones para mover el formulario con el mouse desde el toolstrip (menu de botones del formulario)
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //Fin declaraciones para mover el formulario


        private Form cFormularioPadre;
        public Form FormularioPadre { set { cFormularioPadre = value; } }

        private string cConexionCentral;
        public string ConexionCentral { set { cConexionCentral = value; } }

        private SplitContainer cScoPrincipal;
        public SplitContainer ScoPrincipal { set { cScoPrincipal = value; } }
        private mdiPrincipal cMdiPrincipal;
        public mdiPrincipal MdiPrincipal { set { cMdiPrincipal = value; } }

        clMSC.clMSC rutinas = new clMSC.clMSC();

        private string cConexionSQLMaestro;
        public string ConexionSQLMaestro { set { cConexionSQLMaestro = value; } }
        private string cConexionSQL;
        public string ConexionSQL { set { cConexionSQL = value; } }

        private string strTipoArticuloSel;
        private string strIdArticulo;
        private string strCodigoArticuloBodega;



        public fIngresoMaterial()
        {
            InitializeComponent();
        }

        private void fIngresoMaterial_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void EstadoInicial()
        {
            btnBusqArticuloBodega.Enabled = false;
                        
            strTipoArticuloSel = "";
            strIdArticulo = "";

            txtArtBodegaNombre.Text = String.Empty;
            txtCantidadIngM.Text = String.Empty;
            txtUnidadMedidaIngM.Text = String.Empty;
            cmbTipoArticuloBodega.SelectedIndex = -1;
            txtCantidadIngM.Enabled = false;
        }

        private void InsertaNuevoArticuloBodega()
        {
            string auxRespuesta = "";
            SqlConnection Con = new SqlConnection(cConexionCentral);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spInsertNewMaterialBodega", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@vchTipoArticuloBo", SqlDbType.VarChar, 3);
            auxParametro = cmd.Parameters.Add("@vchCodigoArticuloBo", SqlDbType.VarChar, 10);
            auxParametro = cmd.Parameters.Add("@vchUnidadMedidaArtBo", SqlDbType.VarChar, 5);
            auxParametro = cmd.Parameters.Add("@decCantidadArticuloBo", SqlDbType.Decimal);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@vchTipoArticuloBo"].Value = strTipoArticuloSel;
            cmd.Parameters["@vchCodigoArticuloBo"].Value = strCodigoArticuloBodega;
            cmd.Parameters["@vchUnidadMedidaArtBo"].Value = txtUnidadMedidaIngM.Text.Trim();
            cmd.Parameters["@decCantidadArticuloBo"].Value = Convert.ToDecimal(txtCantidadIngM.Text.Trim());

            try
            {
                cmd.ExecuteNonQuery();
                if (cmd.Parameters["@msgError"].Value.ToString() != "")
                {
                    auxRespuesta = "No se pudo insertar, " + cmd.Parameters["@msgError"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                auxRespuesta = "No se pudo insertar" + ex.ToString();
            }

            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();

            if (auxRespuesta == "")
            {
                rutinas.PresentaMensajeAceptar(cFormularioPadre, "bueno", "Operación Correcta.", "Se ingreso la cantidad de articulo en bodega.", false, false);
                EstadoInicial();

            }
            else
            {
                rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Error en la Operación.", auxRespuesta, false, false);
            }

        }

        private void cmbTipoArticuloBodega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbTipoArticuloBodega.Text == "Materias Primas")
            {
                strTipoArticuloSel = "MP";
            }
            else if (cmbTipoArticuloBodega.Text == "Envases")
            {
                strTipoArticuloSel = "E";
            }

            btnBusqArticuloBodega.Enabled = true;
        }

        private void btnBusqArticuloBodega_Click(object sender, EventArgs e)
        {
            if (cmbTipoArticuloBodega.Text == "")
                return;

            if (strTipoArticuloSel == "MP")
            {
                strIdArticulo = rutinas.Buscar(cConexionSQLMaestro, "Artuculos", "m_Articulo", "idArticulo", "IDArticulo", "Codigo", "CodigoArticuloPaso", "", btnBusqArticuloBodega, true);
            }
            else if (strTipoArticuloSel == "E")
            {
                strIdArticulo = rutinas.Buscar(cConexionSQLMaestro, "Artuculos", "m_ArticuloEnvase", "idArticulo", "IDArticuloEnvase", "Codigo", "CodigoArticuloEnvase", "", btnBusqArticuloBodega, true);
            }

            SqlConnection Con = new SqlConnection(cConexionSQLMaestro);
            Con.Open();
            SqlCommand cmd = new SqlCommand("pa_spObtieneNombreArticulo", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@intIDArticulo", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@vchTipoArt", SqlDbType.VarChar, 3);
            auxParametro = cmd.Parameters.Add("@vchNombreArticuloMostrar", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;
            auxParametro = cmd.Parameters.Add("@vchCodArticulo", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;
            auxParametro = cmd.Parameters.Add("@vchNombreArticuloSel", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;
            auxParametro = cmd.Parameters.Add("@vchUnidadMedida", SqlDbType.VarChar, 2);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@intIDArticulo"].Value = Convert.ToInt32(strIdArticulo);
            cmd.Parameters["@vchTipoArt"].Value = strTipoArticuloSel;

            cmd.ExecuteNonQuery();

            txtArtBodegaNombre.Text = cmd.Parameters["@vchNombreArticuloMostrar"].Value.ToString();
            txtUnidadMedidaIngM.Text = cmd.Parameters["@vchUnidadMedida"].Value.ToString();
            strCodigoArticuloBodega= cmd.Parameters["@vchCodArticulo"].Value.ToString();

            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();

            txtCantidadIngM.Enabled = true;
        }

        private void tsIngresoMatBodega_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void tsbCerrarIngM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCantidadIngM_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void tsbGrabarIngM_Click(object sender, EventArgs e)
        {
            InsertaNuevoArticuloBodega();
        }
    }
}
