using System;
using System.IO;
using System.Windows.Forms;


namespace AdovePremiere
{
    public partial class Form1 : Form
    {
        private ModeloFfmpeg modelo;
        private BaseDeDatos bbdd;


        public Form1(ModeloFfmpeg modelo, BaseDeDatos bbdd)
        {
            this.modelo = modelo;
            this.bbdd = bbdd;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Getters y Setters -----------------------------

        private String getRuta()
        {
            return textBoxRuta.Text;
        }

        private String getNombre()
        {
            return textBoxNombre.Text;
        }

        private String getTiempoInicio()
        {
            return textBoxInicio.Text;
        }

        private String getTiempoFin()
        {
            return textBoxFin.Text;
        }

        private String getFormato()
        {
            return comboBoxFormatos.SelectedItem.ToString();
        }

        private String getResolucion()
        {
            return comboBoxResolucion.SelectedItem.ToString();
        }

        private String getFormatoOriginal()
        {
            String formato = textBoxRuta.Text;
            int cant = formato.Length;
            return cant > 0 ? formato.Substring((cant - 3), 3) : "";
        }

        private String getUser()
        {
            return textBoxUsuario.Text;
        }

        private String getPass()
        {
            return textBoxPass.Text;
        }


        // -------------------------------------------------

        private void buttonFormato_Click(object sender, EventArgs e)
        {
            this.panelFormato.Visible = true;
            this.panelExtraer.Visible = false;
            this.panelRemover.Visible = false;
            this.panelResolucion.Visible = false;
            this.panelImagenes.Visible = false;
            this.panelVacio.Visible = false;

        }

        private void buttonExtraer_Click(object sender, EventArgs e)
        {
            this.panelExtraer.Visible = true;
            this.panelFormato.Visible = false;
            this.panelRemover.Visible = false;
            this.panelResolucion.Visible = false;
            this.panelImagenes.Visible = false;
            this.panelVacio.Visible = false;
        }


        private void buttonRemover_Click(object sender, EventArgs e)
        {
            this.panelRemover.Visible = true;
            this.panelFormato.Visible = false;
            this.panelExtraer.Visible = false;
            this.panelResolucion.Visible = false;
            this.panelImagenes.Visible = false;
            this.panelVacio.Visible = false;
        }

        private void buttonResolucion_Click(object sender, EventArgs e)
        {
            this.panelResolucion.Visible = true;
            this.panelFormato.Visible = false;
            this.panelExtraer.Visible = false;
            this.panelRemover.Visible = false;
            this.panelImagenes.Visible = false;
            this.panelVacio.Visible = false;
        }


        private void buttonImagenes_Click(object sender, EventArgs e)
        {
            this.panelImagenes.Visible = true;
            this.panelFormato.Visible = false;
            this.panelExtraer.Visible = false;
            this.panelRemover.Visible = false;
            this.panelResolucion.Visible = false;
            this.panelVacio.Visible = false;
        }

        private void buttonExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Video Files|*.mp4;*.avi;*.mpeg;*.flv;";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                string ruta = Path.GetFullPath(sFileName);
                textBoxRuta.Text = ruta;
            }
        }


    private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            
        }



        // Seccion cambiar resolucion -----------------------------------

        private void buttonCambiarReso_Click(object sender, EventArgs e)
        {
            modelo.cambiarResolucion(getRuta(), getNombre(), getResolucion(), getFormatoOriginal());
        }

  

        // Seccion extraer imagenes --------------------------------------

        private void buttonExtraerImg_Click(object sender, EventArgs e)
        {
            modelo.extraerImagenes(getRuta(), getNombre(), getTiempoInicio(), getTiempoFin());
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @textBoxRuta.Text;
        }

        // Seccion remover audio ------------------------------------------

        private void buttonRemoverAudio_Click(object sender, EventArgs e)
        {
            progressBarRemover.Maximum = 100;
            progressBarRemover.Value = 100;
            modelo.removerAudio(getRuta(), getNombre(), getFormatoOriginal());
            progressBarRemover.Value = 0;
        }

        // Seccion extraer audio mp3 ----------------------------------------

        private void buttonExtraerAudio_Click(object sender, EventArgs e)
        {
            progressBarExtrarAud.Maximum = 100;
            progressBarExtrarAud.Value = 100;
            modelo.extraerAudio(getRuta(), getNombre(), getFormatoOriginal());
            progressBarExtrarAud.Value = 0;
        }

        // Seccion cambiar formato -------------------------------------------


        private void buttonFormat_Click(object sender, EventArgs e)
        {
            labelFormatoOriginal.Text = getFormatoOriginal();
            modelo.convertirFormato(getRuta(), getNombre(), getFormato());
        }

        // Seccion Login --------------------------------------------------------

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //if (this.bbdd.buscarUsuario(textBoxUsuario.Text, textBoxPass.Text) != null)
                if (bbdd.api(getUser(),getPass()))
            {
                MessageBox.Show("Iniciaste sesion correctamente!", "Login");
                panelLogin.Visible = false;
            }
            else
            {
                MessageBox.Show("La contraseña o usuario son incorrectos.", "Login");
            }
        }
    }
}
