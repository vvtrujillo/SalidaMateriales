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


namespace SalidaMateriales.Formularios.SalidaMateriales
{
    public partial class fGrillaSolMateriales : Form
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
        private System.Drawing.Font cFuente;
        public System.Drawing.Font Fuente { set { cFuente = value; } }
        //
        private int idArticuloBodega = 0;
        private int CodigoArticulo = 1;
        private int NombreCompleto = 2;
        private int CantidadArtBod = 3;
        private int TipoArticulo = 4;

        //
       
        
        public fGrillaSolMateriales()
        {
            InitializeComponent();
        }

        private void fGrillaSolMateriales_Load(object sender, EventArgs e)
        {
            ObtieneListaMaterialesBodega();
        }

        private void PrepararDataGridMateriales(DataGridView pDataGrid)
        {
            foreach (DataGridViewColumn c in pDataGrid.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                c.ReadOnly = true;
                c.DefaultCellStyle.Font =  cFuente;

            }
            pDataGrid.RowHeadersVisible = false;
            if (pDataGrid.Name == "dgSalidaMatSolicitud")
            {
                dgSalidaMatSolicitud.Columns[idArticuloBodega].Visible = false; pDataGrid.Columns[idArticuloBodega].HeaderText = "idArticuloBodega";
                dgSalidaMatSolicitud.Columns[CodigoArticulo].Width = 100; pDataGrid.Columns[CodigoArticulo].HeaderText = "Código";
                dgSalidaMatSolicitud.Columns[NombreCompleto].Width = 200; pDataGrid.Columns[NombreCompleto].HeaderText = "Nombre";
                dgSalidaMatSolicitud.Columns[CantidadArtBod].Width = 50; pDataGrid.Columns[CantidadArtBod].HeaderText = "Cantidad";
                dgSalidaMatSolicitud.Columns[TipoArticulo].Visible = false; pDataGrid.Columns[TipoArticulo].HeaderText = "Tipo";
                dgSalidaMatSolicitud.Columns[CantidadArtBod].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;                             
            }
        }

        private void ObtieneListaMaterialesBodega()
        {
            string aux = "EXEC spObtieneArticulosBodega";
            SqlConnection SqlCon = new SqlConnection(cConexionCentral);
            SqlDataAdapter SqlDa = new SqlDataAdapter(aux, SqlCon);
            DataSet ds = new DataSet("Consulta");
            SqlDa.Fill(ds, "Consulta");
            dgSalidaMatSolicitud.DataSource = ds.Tables["Consulta"];
            PrepararDataGridMateriales(dgSalidaMatSolicitud);
            dgSalidaMatSolicitud.Refresh();
            if (dgSalidaMatSolicitud.RowCount > 0) { dgSalidaMatSolicitud.Rows[0].Selected = false; }
            dgSalidaMatSolicitud.ClearSelection();
        }        

        private void tsListadoMaterialesBodega_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void dgSalidaMatSolicitud_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.strIdArticuloBodegaSel = dgSalidaMatSolicitud.SelectedCells[idArticuloBodega].Value.ToString();
            Program.strTipoArticuloSelecc= dgSalidaMatSolicitud.SelectedCells[TipoArticulo].Value.ToString();

            this.Close();
        }

        private void Filtra_CodigosArticulos()
        {

        }

        private void txtFiltroCodArt_TextChanged(object sender, EventArgs e)
        {
            (dgSalidaMatSolicitud.DataSource as DataTable).DefaultView.RowFilter = string.Format("CodigoArticulo LIKE '{0}%' OR CodigoArticulo LIKE '% {0}%'", txtFiltroCodArt.Text);
        }

        private void txtFiltroNombreArtBod_TextChanged(object sender, EventArgs e)
        {
            (dgSalidaMatSolicitud.DataSource as DataTable).DefaultView.RowFilter = string.Format("NombreCompleto LIKE '{0}%' OR NombreCompleto LIKE '% {0}%'", txtFiltroNombreArtBod.Text);
        }
      
    }
}
