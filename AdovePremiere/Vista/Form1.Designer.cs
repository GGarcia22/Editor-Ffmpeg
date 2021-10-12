
namespace AdovePremiere
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panelVacio = new System.Windows.Forms.Panel();
            this.buttonFormato = new System.Windows.Forms.Button();
            this.buttonExtraer = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonResolucion = new System.Windows.Forms.Button();
            this.buttonImagenes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelImagenes = new System.Windows.Forms.Panel();
            this.buttonExtraerImg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFin = new System.Windows.Forms.TextBox();
            this.textBoxInicio = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelFormato = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxFormatos = new System.Windows.Forms.ComboBox();
            this.labelFormatoOriginal = new System.Windows.Forms.Label();
            this.buttonFormat = new System.Windows.Forms.Button();
            this.panelRemover = new System.Windows.Forms.Panel();
            this.progressBarRemover = new System.Windows.Forms.ProgressBar();
            this.buttonRemoverAudio = new System.Windows.Forms.Button();
            this.panelResolucion = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCambiarReso = new System.Windows.Forms.Button();
            this.comboBoxResolucion = new System.Windows.Forms.ComboBox();
            this.labelResolucion = new System.Windows.Forms.Label();
            this.panelExtraer = new System.Windows.Forms.Panel();
            this.progressBarExtrarAud = new System.Windows.Forms.ProgressBar();
            this.buttonExtraerAudio = new System.Windows.Forms.Button();
            this.buttonExaminar = new System.Windows.Forms.Button();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelImagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panelFormato.SuspendLayout();
            this.panelRemover.SuspendLayout();
            this.panelResolucion.SuspendLayout();
            this.panelExtraer.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "►Te damos la bienvenida a la aplicacion desktop◄\r\n";
            // 
            // panelVacio
            // 
            this.panelVacio.Location = new System.Drawing.Point(12, 247);
            this.panelVacio.Name = "panelVacio";
            this.panelVacio.Size = new System.Drawing.Size(679, 284);
            this.panelVacio.TabIndex = 12;
            // 
            // buttonFormato
            // 
            this.buttonFormato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFormato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormato.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormato.Location = new System.Drawing.Point(12, 70);
            this.buttonFormato.Name = "buttonFormato";
            this.buttonFormato.Size = new System.Drawing.Size(131, 54);
            this.buttonFormato.TabIndex = 13;
            this.buttonFormato.Text = "Cambiar formato ";
            this.buttonFormato.UseVisualStyleBackColor = true;
            this.buttonFormato.Click += new System.EventHandler(this.buttonFormato_Click);
            // 
            // buttonExtraer
            // 
            this.buttonExtraer.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonExtraer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExtraer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExtraer.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExtraer.Location = new System.Drawing.Point(149, 70);
            this.buttonExtraer.Name = "buttonExtraer";
            this.buttonExtraer.Size = new System.Drawing.Size(131, 54);
            this.buttonExtraer.TabIndex = 14;
            this.buttonExtraer.Text = "Extraer audio";
            this.buttonExtraer.UseVisualStyleBackColor = false;
            this.buttonExtraer.Click += new System.EventHandler(this.buttonExtraer_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemover.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemover.Location = new System.Drawing.Point(286, 70);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(131, 54);
            this.buttonRemover.TabIndex = 15;
            this.buttonRemover.Text = "Remover audio";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonResolucion
            // 
            this.buttonResolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResolucion.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResolucion.Location = new System.Drawing.Point(423, 70);
            this.buttonResolucion.Name = "buttonResolucion";
            this.buttonResolucion.Size = new System.Drawing.Size(131, 54);
            this.buttonResolucion.TabIndex = 16;
            this.buttonResolucion.Text = "Cambiar resolucion";
            this.buttonResolucion.UseVisualStyleBackColor = true;
            this.buttonResolucion.Click += new System.EventHandler(this.buttonResolucion_Click);
            // 
            // buttonImagenes
            // 
            this.buttonImagenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImagenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImagenes.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImagenes.Location = new System.Drawing.Point(560, 70);
            this.buttonImagenes.Name = "buttonImagenes";
            this.buttonImagenes.Size = new System.Drawing.Size(131, 54);
            this.buttonImagenes.TabIndex = 17;
            this.buttonImagenes.Text = "Extraer imagenes";
            this.buttonImagenes.UseVisualStyleBackColor = true;
            this.buttonImagenes.Click += new System.EventHandler(this.buttonImagenes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Opciones de edicion de video:";
            // 
            // panelImagenes
            // 
            this.panelImagenes.Controls.Add(this.buttonExtraerImg);
            this.panelImagenes.Controls.Add(this.label5);
            this.panelImagenes.Controls.Add(this.textBoxFin);
            this.panelImagenes.Controls.Add(this.textBoxInicio);
            this.panelImagenes.Controls.Add(this.axWindowsMediaPlayer1);
            this.panelImagenes.Location = new System.Drawing.Point(12, 247);
            this.panelImagenes.Name = "panelImagenes";
            this.panelImagenes.Size = new System.Drawing.Size(679, 281);
            this.panelImagenes.TabIndex = 0;
            // 
            // buttonExtraerImg
            // 
            this.buttonExtraerImg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonExtraerImg.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExtraerImg.Location = new System.Drawing.Point(501, 228);
            this.buttonExtraerImg.Name = "buttonExtraerImg";
            this.buttonExtraerImg.Size = new System.Drawing.Size(156, 37);
            this.buttonExtraerImg.TabIndex = 6;
            this.buttonExtraerImg.Text = "Extraer";
            this.buttonExtraerImg.UseVisualStyleBackColor = false;
            this.buttonExtraerImg.Click += new System.EventHandler(this.buttonExtraerImg_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(501, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 115);
            this.label5.TabIndex = 5;
            this.label5.Text = "<Ingresar entre que tiempo desea extraer imagenes. Escribirlo de la siguiente man" +
    "era 00:00:00 (horas, minutos, segundos)>";
            // 
            // textBoxFin
            // 
            this.textBoxFin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxFin.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFin.Location = new System.Drawing.Point(501, 187);
            this.textBoxFin.Name = "textBoxFin";
            this.textBoxFin.Size = new System.Drawing.Size(156, 23);
            this.textBoxFin.TabIndex = 4;
            // 
            // textBoxInicio
            // 
            this.textBoxInicio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxInicio.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInicio.Location = new System.Drawing.Point(501, 149);
            this.textBoxInicio.Name = "textBoxInicio";
            this.textBoxInicio.Size = new System.Drawing.Size(156, 23);
            this.textBoxInicio.TabIndex = 3;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(26, 19);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(441, 246);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // panelFormato
            // 
            this.panelFormato.Controls.Add(this.label8);
            this.panelFormato.Controls.Add(this.label7);
            this.panelFormato.Controls.Add(this.comboBoxFormatos);
            this.panelFormato.Controls.Add(this.labelFormatoOriginal);
            this.panelFormato.Controls.Add(this.buttonFormat);
            this.panelFormato.Location = new System.Drawing.Point(13, 247);
            this.panelFormato.Name = "panelFormato";
            this.panelFormato.Size = new System.Drawing.Size(678, 284);
            this.panelFormato.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(396, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cambiar formato de";
            // 
            // comboBoxFormatos
            // 
            this.comboBoxFormatos.FormattingEnabled = true;
            this.comboBoxFormatos.Items.AddRange(new object[] {
            "avi",
            "mp3",
            "mp4",
            "mpeg",
            "flv"});
            this.comboBoxFormatos.Location = new System.Drawing.Point(417, 110);
            this.comboBoxFormatos.Name = "comboBoxFormatos";
            this.comboBoxFormatos.Size = new System.Drawing.Size(97, 21);
            this.comboBoxFormatos.TabIndex = 2;
            // 
            // labelFormatoOriginal
            // 
            this.labelFormatoOriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFormatoOriginal.Location = new System.Drawing.Point(293, 107);
            this.labelFormatoOriginal.Name = "labelFormatoOriginal";
            this.labelFormatoOriginal.Size = new System.Drawing.Size(97, 24);
            this.labelFormatoOriginal.TabIndex = 1;
            this.labelFormatoOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFormat
            // 
            this.buttonFormat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonFormat.Location = new System.Drawing.Point(254, 162);
            this.buttonFormat.Name = "buttonFormat";
            this.buttonFormat.Size = new System.Drawing.Size(158, 53);
            this.buttonFormat.TabIndex = 0;
            this.buttonFormat.Text = "Convertir";
            this.buttonFormat.UseVisualStyleBackColor = false;
            this.buttonFormat.Click += new System.EventHandler(this.buttonFormat_Click);
            // 
            // panelRemover
            // 
            this.panelRemover.Controls.Add(this.progressBarRemover);
            this.panelRemover.Controls.Add(this.buttonRemoverAudio);
            this.panelRemover.Location = new System.Drawing.Point(11, 247);
            this.panelRemover.Name = "panelRemover";
            this.panelRemover.Size = new System.Drawing.Size(680, 284);
            this.panelRemover.TabIndex = 0;
            // 
            // progressBarRemover
            // 
            this.progressBarRemover.Location = new System.Drawing.Point(172, 159);
            this.progressBarRemover.Name = "progressBarRemover";
            this.progressBarRemover.Size = new System.Drawing.Size(343, 23);
            this.progressBarRemover.TabIndex = 1;
            // 
            // buttonRemoverAudio
            // 
            this.buttonRemoverAudio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonRemoverAudio.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoverAudio.Location = new System.Drawing.Point(255, 83);
            this.buttonRemoverAudio.Name = "buttonRemoverAudio";
            this.buttonRemoverAudio.Size = new System.Drawing.Size(176, 50);
            this.buttonRemoverAudio.TabIndex = 0;
            this.buttonRemoverAudio.Text = "Remover audio";
            this.buttonRemoverAudio.UseVisualStyleBackColor = false;
            this.buttonRemoverAudio.Click += new System.EventHandler(this.buttonRemoverAudio_Click);
            // 
            // panelResolucion
            // 
            this.panelResolucion.Controls.Add(this.label9);
            this.panelResolucion.Controls.Add(this.label6);
            this.panelResolucion.Controls.Add(this.buttonCambiarReso);
            this.panelResolucion.Controls.Add(this.comboBoxResolucion);
            this.panelResolucion.Controls.Add(this.labelResolucion);
            this.panelResolucion.Location = new System.Drawing.Point(12, 247);
            this.panelResolucion.Name = "panelResolucion";
            this.panelResolucion.Size = new System.Drawing.Size(679, 284);
            this.panelResolucion.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(198, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Resolucion deseada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Resolucion actual:";
            // 
            // buttonCambiarReso
            // 
            this.buttonCambiarReso.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCambiarReso.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambiarReso.Location = new System.Drawing.Point(274, 175);
            this.buttonCambiarReso.Name = "buttonCambiarReso";
            this.buttonCambiarReso.Size = new System.Drawing.Size(130, 48);
            this.buttonCambiarReso.TabIndex = 2;
            this.buttonCambiarReso.Text = "Cambiar resolucion";
            this.buttonCambiarReso.UseVisualStyleBackColor = false;
            this.buttonCambiarReso.Click += new System.EventHandler(this.buttonCambiarReso_Click);
            // 
            // comboBoxResolucion
            // 
            this.comboBoxResolucion.FormattingEnabled = true;
            this.comboBoxResolucion.Items.AddRange(new object[] {
            "1920:1080",
            "1360×768",
            "1280×768",
            "800x600\t",
            "640×480",
            "320×240"});
            this.comboBoxResolucion.Location = new System.Drawing.Point(337, 131);
            this.comboBoxResolucion.Name = "comboBoxResolucion";
            this.comboBoxResolucion.Size = new System.Drawing.Size(130, 21);
            this.comboBoxResolucion.TabIndex = 1;
            // 
            // labelResolucion
            // 
            this.labelResolucion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResolucion.Location = new System.Drawing.Point(337, 85);
            this.labelResolucion.Name = "labelResolucion";
            this.labelResolucion.Size = new System.Drawing.Size(130, 21);
            this.labelResolucion.TabIndex = 0;
            this.labelResolucion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelExtraer
            // 
            this.panelExtraer.Controls.Add(this.progressBarExtrarAud);
            this.panelExtraer.Controls.Add(this.buttonExtraerAudio);
            this.panelExtraer.Location = new System.Drawing.Point(12, 247);
            this.panelExtraer.Name = "panelExtraer";
            this.panelExtraer.Size = new System.Drawing.Size(679, 284);
            this.panelExtraer.TabIndex = 0;
            this.panelExtraer.Visible = false;
            // 
            // progressBarExtrarAud
            // 
            this.progressBarExtrarAud.Location = new System.Drawing.Point(168, 162);
            this.progressBarExtrarAud.Name = "progressBarExtrarAud";
            this.progressBarExtrarAud.Size = new System.Drawing.Size(347, 21);
            this.progressBarExtrarAud.TabIndex = 1;
            // 
            // buttonExtraerAudio
            // 
            this.buttonExtraerAudio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonExtraerAudio.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExtraerAudio.Location = new System.Drawing.Point(255, 82);
            this.buttonExtraerAudio.Name = "buttonExtraerAudio";
            this.buttonExtraerAudio.Size = new System.Drawing.Size(176, 52);
            this.buttonExtraerAudio.TabIndex = 0;
            this.buttonExtraerAudio.Text = "Extraer Audio .mp3";
            this.buttonExtraerAudio.UseVisualStyleBackColor = false;
            this.buttonExtraerAudio.Click += new System.EventHandler(this.buttonExtraerAudio_Click);
            // 
            // buttonExaminar
            // 
            this.buttonExaminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonExaminar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExaminar.Location = new System.Drawing.Point(588, 146);
            this.buttonExaminar.Name = "buttonExaminar";
            this.buttonExaminar.Size = new System.Drawing.Size(102, 36);
            this.buttonExaminar.TabIndex = 19;
            this.buttonExaminar.Text = "Examinar";
            this.buttonExaminar.UseVisualStyleBackColor = false;
            this.buttonExaminar.Click += new System.EventHandler(this.buttonExaminar_Click);
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxRuta.Location = new System.Drawing.Point(17, 146);
            this.textBoxRuta.Multiline = true;
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.Size = new System.Drawing.Size(565, 35);
            this.textBoxRuta.TabIndex = 21;
            this.textBoxRuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxNombre.Location = new System.Drawing.Point(186, 196);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(504, 36);
            this.textBoxNombre.TabIndex = 22;
            this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 36);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombre del archivo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLogin
            // 
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.label12);
            this.panelLogin.Controls.Add(this.textBoxPass);
            this.panelLogin.Controls.Add(this.label11);
            this.panelLogin.Controls.Add(this.textBoxUsuario);
            this.panelLogin.Controls.Add(this.label10);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Location = new System.Drawing.Point(11, 9);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(680, 522);
            this.panelLogin.TabIndex = 24;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLogin.Location = new System.Drawing.Point(273, 411);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(101, 40);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Iniciar Sesion";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(249, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Ingresar Contraseña:";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(254, 346);
            this.textBoxPass.MaxLength = 15;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(139, 25);
            this.textBoxPass.TabIndex = 5;
            this.textBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(219, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Ingresar Nombre de Usuario:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(254, 256);
            this.textBoxUsuario.MaxLength = 15;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(139, 25);
            this.textBoxUsuario.TabIndex = 3;
            this.textBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(543, 60);
            this.label10.TabIndex = 1;
            this.label10.Text = "*Para poder utilizar la aplicacion debes tener una cuenta registrada. Por favor i" +
    "nicia la sesion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "<Login>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(702, 543);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxRuta);
            this.Controls.Add(this.buttonExaminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonImagenes);
            this.Controls.Add(this.buttonResolucion);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonExtraer);
            this.Controls.Add(this.buttonFormato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelVacio);
            this.Controls.Add(this.panelResolucion);
            this.Controls.Add(this.panelImagenes);
            this.Controls.Add(this.panelRemover);
            this.Controls.Add(this.panelExtraer);
            this.Controls.Add(this.panelFormato);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelImagenes.ResumeLayout(false);
            this.panelImagenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panelFormato.ResumeLayout(false);
            this.panelFormato.PerformLayout();
            this.panelRemover.ResumeLayout(false);
            this.panelResolucion.ResumeLayout(false);
            this.panelResolucion.PerformLayout();
            this.panelExtraer.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelVacio;
        private System.Windows.Forms.Button buttonFormato;
        private System.Windows.Forms.Button buttonExtraer;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonResolucion;
        private System.Windows.Forms.Button buttonImagenes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelImagenes;
        private System.Windows.Forms.Panel panelFormato;
        private System.Windows.Forms.Panel panelRemover;
        private System.Windows.Forms.Panel panelResolucion;
        private System.Windows.Forms.Panel panelExtraer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFin;
        private System.Windows.Forms.TextBox textBoxInicio;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxFormatos;
        private System.Windows.Forms.Label labelFormatoOriginal;
        private System.Windows.Forms.Button buttonFormat;
        private System.Windows.Forms.ProgressBar progressBarExtrarAud;
        private System.Windows.Forms.Button buttonExtraerAudio;
        private System.Windows.Forms.Button buttonExtraerImg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCambiarReso;
        private System.Windows.Forms.ComboBox comboBoxResolucion;
        private System.Windows.Forms.Label labelResolucion;
        private System.Windows.Forms.ProgressBar progressBarRemover;
        private System.Windows.Forms.Button buttonRemoverAudio;
        private System.Windows.Forms.Button buttonExaminar;
        private System.Windows.Forms.TextBox textBoxRuta;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxPass;
    }
}

