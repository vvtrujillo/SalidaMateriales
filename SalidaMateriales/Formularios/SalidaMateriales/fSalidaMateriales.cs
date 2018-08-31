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

namespace SalidaMateriales.Formularios
{
    public partial class fSalidaMateriales : Form
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

        private string strIdArticulo;
        private string strTipoArticuloSel;
        private string strCodigoArticuloSel;
        private string strNombreArticuloSel;
        private string strCodCentroCosto;
        private string strCodPlantaSolicitante;
        private int intIdPlantaBodega;
        private int intIDEncabezado;
        private string strTipoMaterial;


        public fSalidaMateriales()
        {
            InitializeComponent();
        }

        private void EstadoInicial()
        {
            cmbTipoArticulo.SelectedIndex = -1;
            txtArticuloNombre.Text = String.Empty;
            txtCentroCostoDescrip.Text = String.Empty;


            strIdArticulo = "";
            strTipoArticuloSel = "";
            strCodigoArticuloSel = "";
            strNombreArticuloSel = "";
            strCodCentroCosto = "";
            strCodPlantaSolicitante = "";
            intIdPlantaBodega = 0;
            intIDEncabezado = 0;

            txtCantidad.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;

            gbDetalleSolicitud.Enabled = false;

            dgSalidaMat.Rows.Clear();
            txtPlanta.Text = String.Empty;
            cmbPlanta.SelectedIndex = -1;
            txtPlantaSol.Text = String.Empty;

            strTipoMaterial = "";
        }

        private void SalidaMateriales_Load(object sender, EventArgs e)
        {
            EstadoInicial();
            CargaComboBoxBodega();
        }

        private void tsbCerrarSM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsSalidaMateriales_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void btnBuscarCodArticulo_Click(object sender, EventArgs e)
        {

            if (cmbTipoArticulo.Text == "")
                return;

            if (strTipoArticuloSel == "MP")
            {
                strIdArticulo = rutinas.Buscar(cConexionSQLMaestro, "Artuculos", "m_Articulo", "idArticulo", "IDArticulo", "Codigo", "CodigoArticuloPaso", "", btnBuscarCodArticulo, true);
            }
            else if (strTipoArticuloSel == "E")
            {
                strIdArticulo = rutinas.Buscar(cConexionSQLMaestro, "Artuculos", "m_ArticuloEnvase", "idArticulo", "IDArticuloEnvase", "Codigo", "CodigoArticuloEnvase", "", btnBuscarCodArticulo, true);
            }

            SqlConnection Con = new SqlConnection(cConexionSQLMaestro);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spObtieneNombreArticulo", Con);
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

            cmd.Parameters["@intIDArticulo"].Value = Convert.ToInt32(strIdArticulo);
            cmd.Parameters["@vchTipoArt"].Value = strTipoArticuloSel;

            cmd.ExecuteNonQuery();


            txtArticuloNombre.Text = cmd.Parameters["@vchNombreArticuloMostrar"].Value.ToString();
            strCodigoArticuloSel = cmd.Parameters["@vchCodArticulo"].Value.ToString();
            strNombreArticuloSel = cmd.Parameters["@vchNombreArticuloSel"].Value.ToString();

            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();

            txtCantidad.Enabled = true;
            btnAgregar.Enabled = true;
        }

        private void cmbTipoArticulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbTipoArticulo.Text == "Materias Primas")
            {
                strTipoArticuloSel = "MP";
            }
            else if (cmbTipoArticulo.Text == "Envases")
            {
                strTipoArticuloSel = "E";
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Atención", "Debe ingresar cantidad a solicitar.", false, false);
                return;
            }
            dgSalidaMat.Rows.Add(strCodigoArticuloSel, strNombreArticuloSel, txtCantidad.Text.Trim(), strTipoArticuloSel);
            btnEliminar.Enabled = true;
            LimpiaControlesIngreso();
            SumaCantidades();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgSalidaMat.Rows.Remove(dgSalidaMat.CurrentRow);
            SumaCantidades();
        }

        private void LimpiaControlesIngreso()
        {
            cmbTipoArticulo.SelectedIndex = -1;
            txtArticuloNombre.Text = String.Empty;
            txtCantidad.Text = String.Empty;

            strCodigoArticuloSel = "";
            strNombreArticuloSel = "";
            txtCantidad.Enabled = false;
            btnAgregar.Enabled = false;
        }

        private void CargaComboBoxBodega()
        {
            rutinas.CargarDatosComboBox(cConexionSQLMaestro, "spObtieneBodegaComboBox", cmbPlanta, "IDBodega", "Descripcion");
            cmbPlanta.SelectedIndex = -1;
        }

        private void cmbPlanta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtPlanta.Text = Convert.ToString(cmbPlanta.SelectedValue);
            intIdPlantaBodega = Convert.ToInt32(cmbPlanta.Text);
        }

        private void btnCentroCostoBusq_Click(object sender, EventArgs e)
        {
            strCodCentroCosto = rutinas.Buscar(cConexionCentral, "Centro de Costo", "CentroCosto", "Codigo", "CreCodigo", "Nombre", "CreNombre", "", btnCentroCostoBusq, true);

            SqlConnection Con = new SqlConnection(cConexionCentral);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spObtieneNombreCentroCosto", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@intCodCCosto", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@vchNombreCentroCosto", SqlDbType.VarChar, 50);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@intCodCCosto"].Value = Convert.ToInt32(strCodCentroCosto);

            cmd.ExecuteNonQuery();

            txtCentroCostoDescrip.Text = cmd.Parameters["@vchNombreCentroCosto"].Value.ToString().Trim();

            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();
        }

        private void btnPlantaSol_Click(object sender, EventArgs e)
        {
            strCodPlantaSolicitante = rutinas.Buscar(cConexionSQLMaestro, "Plantas", "m_Planta", "Cod Planta", "IDPlanta", "Nombre", "Descripcion", "", btnPlantaSol, true);

            SqlConnection Con = new SqlConnection(cConexionSQLMaestro);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spObtieneNombrePlanta", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@intIdPlanta", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@vchNombrePlanta", SqlDbType.VarChar, 50);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@intIdPlanta"].Value = Convert.ToInt32(strCodPlantaSolicitante);

            cmd.ExecuteNonQuery();

            txtPlantaSol.Text = cmd.Parameters["@vchNombrePlanta"].Value.ToString().Trim();

            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();

            gbDetalleSolicitud.Enabled = true;
        }

        private void InsertaEncabezado()
        {
            string auxRespuesta = "";
            bool respuestaEnc = true;

            SqlConnection Con = new SqlConnection(cConexionCentral);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spInsertNewSolicMatEnc", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@intIdPlantaSol", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@intIdCentroCosto", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@intIdBodega", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@vchTipoSolicitud", SqlDbType.VarChar, 100);
            auxParametro = cmd.Parameters.Add("@vchUsuario", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@vchTerminal", SqlDbType.VarChar, 50);
            auxParametro = cmd.Parameters.Add("@intIdEncabezado", SqlDbType.Int);
            auxParametro.Direction = ParameterDirection.Output;
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@intIdPlantaSol"].Value = Convert.ToInt32(strCodPlantaSolicitante);
            cmd.Parameters["@intIdCentroCosto"].Value = Convert.ToInt32(strCodCentroCosto);
            cmd.Parameters["@intIdBodega"].Value = intIdPlantaBodega;
            cmd.Parameters["@vchTipoSolicitud"].Value = "Solicitud Materiales";
            cmd.Parameters["@vchUsuario"].Value = Properties.Settings.Default.Login;
            cmd.Parameters["@vchTerminal"].Value = Environment.MachineName;

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

            intIDEncabezado = Convert.ToInt32(cmd.Parameters["@intIdEncabezado"].Value.ToString());

            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();

            if (auxRespuesta == "")
            {
                foreach (DataGridViewRow row in dgSalidaMat.Rows)
                {
                    string strCodMaterial = "";
                    string strNombreMaterial = "";
                    decimal decCantidad = 0;

                    strCodMaterial = row.Cells["codigo_articulo"].Value.ToString();
                    strNombreMaterial = row.Cells["nombre_articulo"].Value.ToString();
                    decCantidad = Convert.ToDecimal(row.Cells["cant_articulo"].Value.ToString());
                    strTipoMaterial = row.Cells["tipo_material"].Value.ToString();

                    if (InsertaDetalle(intIDEncabezado, strCodMaterial, strNombreMaterial, decCantidad, strTipoMaterial))
                    {
                        respuestaEnc = true;
                    }
                    else
                    {
                        respuestaEnc = false;
                    }                    
                }

                if (respuestaEnc)
                {
                    rutinas.PresentaMensajeAceptar(cFormularioPadre, "bueno", "Éxito", "Se realizo la inserción correctamente.", false, false);
                }
                else
                {
                    EliminaEncabezado(intIDEncabezado);
                }

                EstadoInicial();
            }
            else
            {
                rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Error en la Operación.", auxRespuesta, false, false);
            }

        }

        private bool InsertaDetalle(int Encabezado,
                                    string CodigoMaterial,
                                    string NombreMaterial,
                                    decimal Cantidad,
                                    string tipoMaterial)
        {
            string auxRespuesta = "";
            bool RespuestaError = true;

            SqlConnection Con = new SqlConnection(cConexionCentral);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spInsertNewSolicMatDetalle", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@intIdSolMatEnc", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@vchCodigoMaterial", SqlDbType.VarChar, 10);
            auxParametro = cmd.Parameters.Add("@vchNombreMaterial", SqlDbType.VarChar, 100);
            auxParametro = cmd.Parameters.Add("@decCantidadMat", SqlDbType.Decimal);
            auxParametro = cmd.Parameters.Add("@chTipoMaterial", SqlDbType.Char, 2);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@intIdSolMatEnc"].Value = Encabezado;
            cmd.Parameters["@vchCodigoMaterial"].Value = CodigoMaterial.Trim();
            cmd.Parameters["@vchNombreMaterial"].Value = NombreMaterial.Trim();
            cmd.Parameters["@decCantidadMat"].Value = Cantidad;
            cmd.Parameters["@chTipoMaterial"].Value = tipoMaterial;

            try
            {
                cmd.ExecuteNonQuery();
                if (cmd.Parameters["@msgError"].Value.ToString() != "")
                {
                    auxRespuesta = "No se pudo insertar, " + cmd.Parameters["@msgError"].Value.ToString();
                    RespuestaError = false;
                }
            }
            catch (Exception ex)
            {
                auxRespuesta = "No se pudo insertar" + ex.ToString();
                RespuestaError = false;
            }

            cmd.Connection.Close(); cmd.Connection.Dispose();
            Con.Close(); Con.Dispose();

            if (auxRespuesta != "")
            {
                rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Error", "Error en insertar Encabezado: " + auxRespuesta, false, false);
            }

            return RespuestaError;
        }

        private void tsbGrabarSM_Click(object sender, EventArgs e)
        {
            if (dgSalidaMat.Rows.Count==0)
            {
                rutinas.PresentaMensajeAceptar(cFormularioPadre, "atencioin", "Atención", "Debe Ingresar materiales a Solicitar", false, false);
            }
            else
            {
                InsertaEncabezado();
            }            
        }

        private void EliminaEncabezado(int idEncabezado)
        {
            string auxRespuesta = "";

            SqlConnection Con = new SqlConnection(cConexionCentral);
            Con.Open();
            SqlCommand cmd = new SqlCommand("spEliminaEncabezadoSolMat", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter auxParametro = null;

            auxParametro = cmd.Parameters.Add("@intIdSolMatEnc", SqlDbType.Int);
            auxParametro = cmd.Parameters.Add("@msgError", SqlDbType.VarChar, 255);
            auxParametro.Direction = ParameterDirection.Output;

            cmd.Parameters["@intIdSolMatEnc"].Value = idEncabezado;

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
                rutinas.PresentaMensajeAceptar(cFormularioPadre, "alerta", "Alerta", "Se eliminó Encabezado.", false, false);
            }
            else
            {
                rutinas.PresentaMensajeAceptar(cFormularioPadre, "malo", "Error en la Operación.", auxRespuesta, false, false);
            }
        }

        private void SumaCantidades()
        {
            int Suma = 0;
            foreach (DataGridViewRow row in dgSalidaMat.Rows)
            {
                Suma += (int)(Convert.ToInt32(row.Cells["cant_articulo"].Value));
            }

            txtSumCant.Text = Convert.ToString(Suma);
        }
       
    }
}
