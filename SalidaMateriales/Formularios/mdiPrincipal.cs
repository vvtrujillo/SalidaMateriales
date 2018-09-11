using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SalidaMateriales.Formularios;
using SalidaMateriales.Formularios.Parametros;
using SalidaMateriales.Formularios.Materiales;



namespace SalidaMateriales.Formularios
{
    public partial class mdiPrincipal : Form
    {
        //Declaraciones para mover el formulario desde el panel del titulo
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //Fin declaraciones para mover el formulario

        clMSC.clMSC Rutinas = new clMSC.clMSC();

        public Color cColorFondoConFoco = Color.White;
        public Color cColorFondoSinFoco = Color.FromArgb(208, 216, 217);
        public string cConexionSQLMaestro = string.Empty;
        public string cConexionSQLCentral = string.Empty;
                
        public mdiPrincipal()
        {
            InitializeComponent();
        }

        private void IniciarSistema()
        {
            sstPrincipal.Items["Proceso"].Text = "Sistema ...";
            sstPrincipal.Items["Version"].Text = "Versión: " + Properties.Settings.Default.VersionSistema;
            sstPrincipal.Items["Usuario"].Text = Properties.Settings.Default.Nombre + " / " + Properties.Settings.Default.Login;
            sstPrincipal.Items["Perfil"].Text = "Perfil: " + Properties.Settings.Default.Perfil;
            sstPrincipal.Items["EstacionDeTrabajo"].Text = "Estación de trabajo: " + System.Environment.MachineName;
            sstPrincipal.Items["Servidor"].Text = "Servidor: " + Properties.Settings.Default.ServidorSQLCentral;
            sstPrincipal.Items["BaseDeDatos"].Text = "Base de datos: " + Properties.Settings.Default.BaseSQLCentral;

            //cConexionSQLMaestro = "server=" + Properties.Settings.Default.ServidorSQLMaestroEntidades + ";Integrated security=false;database=" + Properties.Settings.Default.BaseSQLMaestroEntidades + ";User=sa;Password=molinera";
            cConexionSQLCentral = "server=" + Properties.Settings.Default.ServidorSQLCentral + ";Integrated security=false;database=" + Properties.Settings.Default.BaseSQLCentral + ";User=sa;Password=molinera";
            cConexionSQLMaestro = "server=" + Properties.Settings.Default.ServidorSQLMaestroEntidades + ";Integrated security=false;database=" + Properties.Settings.Default.BaseSQLMaestroEntidades + ";User=sa;Password=molinera";

            Properties.Settings.Default.Save();

            Rutinas.AplicarAccesoAMenuPrincipal(ref msPrincipal, Properties.Settings.Default.PrivilegioAccesoMenu);
        }

        private void mdiPrincipal_Load(object sender, EventArgs e)
        {
            IniciarSistema();
        }

        private void mdiPrincipal_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void tsmSalirSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tsmCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            foreach (Form a in this.MdiChildren)
            {
                a.Close();
            }
            System.Diagnostics.Process.Start(@Properties.Settings.Default.RutaProgramaAcceso);
            this.Close();
        }

        private void tsmConfiguracion_Click(object sender, EventArgs e)
        {
            if (!Rutinas.ChequearFormularioActivo(this, "fConfiguracion", sstPrincipal))
            {
                fConfiguracion fAux = new fConfiguracion();
                sstPrincipal.Items["Proceso"].Text = "Configuración";
                Rutinas.AplicarAccesoAFuncionalidad(fAux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
                fAux.FormularioPadre = this;
                fAux.ConexionCentral = cConexionSQLCentral;
                fAux.StartPosition = FormStartPosition.CenterScreen;
                fAux.AutoScaleMode = AutoScaleMode.None;
                fAux.MdiParent = this;
                fAux.Show();
                fAux.Focus();
            }
        }

        private void tsmSolicitudMaterialesForm_Click(object sender, EventArgs e)
        {
            fSalidaMateriales fAux = new fSalidaMateriales();           
            sstPrincipal.Items["Proceso"].Text = "Configuración";
            Rutinas.AplicarAccesoAFuncionalidad(fAux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
            fAux.FormularioPadre = this;
            fAux.ConexionCentral = cConexionSQLCentral;
            fAux.ConexionSQLMaestro = cConexionSQLMaestro;
            fAux.StartPosition = FormStartPosition.CenterScreen;
            fAux.AutoScaleMode = AutoScaleMode.None;
            fAux.MdiParent = this;
            fAux.Show();
            fAux.Focus();
        }

        private void ingresoMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fIngresoMaterial fAux = new fIngresoMaterial();
            sstPrincipal.Items["Proceso"].Text = "Configuración";
            Rutinas.AplicarAccesoAFuncionalidad(fAux, Properties.Settings.Default.PrivilegioAccesoFuncionalidad);
            fAux.FormularioPadre = this;
            fAux.ConexionCentral = cConexionSQLCentral;
            fAux.ConexionSQLMaestro = cConexionSQLMaestro;
            fAux.StartPosition = FormStartPosition.CenterScreen;
            fAux.AutoScaleMode = AutoScaleMode.None;
            fAux.MdiParent = this;
            fAux.Show();
            fAux.Focus();
        }
    }
}
