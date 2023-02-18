namespace ControlArchivos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSystemDestails = new System.Windows.Forms.TextBox();
            this.cboSystemDrives = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCrearDirectorio = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnSubDirectorio = new System.Windows.Forms.Button();
            this.txtSubDirectorio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDetalleDirectorio = new System.Windows.Forms.ComboBox();
            this.btnMostrarDetalleDirectorio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCopiarDirectorio = new System.Windows.Forms.Button();
            this.txtDirectorioDestino = new System.Windows.Forms.TextBox();
            this.txtDirectorioOrigen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCrearArchivo = new System.Windows.Forms.Button();
            this.txtNuevoArchivo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.txtSeleccionarArchivo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bntRenombrarArchivo = new System.Windows.Forms.Button();
            this.txtRenombrarArchivo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEscribir = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLeer = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtActualizar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSystemDestails
            // 
            this.txtSystemDestails.Location = new System.Drawing.Point(35, 100);
            this.txtSystemDestails.Multiline = true;
            this.txtSystemDestails.Name = "txtSystemDestails";
            this.txtSystemDestails.Size = new System.Drawing.Size(295, 218);
            this.txtSystemDestails.TabIndex = 0;
            // 
            // cboSystemDrives
            // 
            this.cboSystemDrives.FormattingEnabled = true;
            this.cboSystemDrives.Location = new System.Drawing.Point(35, 33);
            this.cboSystemDrives.Name = "cboSystemDrives";
            this.cboSystemDrives.Size = new System.Drawing.Size(295, 23);
            this.cboSystemDrives.TabIndex = 1;
            this.cboSystemDrives.SelectedIndexChanged += new System.EventHandler(this.cboSystemDrives_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(370, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo Directorio (Incluir Path):";
            // 
            // txtCrearDirectorio
            // 
            this.txtCrearDirectorio.Location = new System.Drawing.Point(579, 31);
            this.txtCrearDirectorio.Name = "txtCrearDirectorio";
            this.txtCrearDirectorio.Size = new System.Drawing.Size(180, 23);
            this.txtCrearDirectorio.TabIndex = 3;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(775, 33);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(159, 23);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear Directorio";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnSubDirectorio
            // 
            this.btnSubDirectorio.Location = new System.Drawing.Point(775, 77);
            this.btnSubDirectorio.Name = "btnSubDirectorio";
            this.btnSubDirectorio.Size = new System.Drawing.Size(159, 23);
            this.btnSubDirectorio.TabIndex = 7;
            this.btnSubDirectorio.Text = "Crear SubDirectorio";
            this.btnSubDirectorio.UseVisualStyleBackColor = true;
            this.btnSubDirectorio.Click += new System.EventHandler(this.btnSubDirectorio_Click);
            // 
            // txtSubDirectorio
            // 
            this.txtSubDirectorio.Location = new System.Drawing.Point(579, 77);
            this.txtSubDirectorio.Name = "txtSubDirectorio";
            this.txtSubDirectorio.Size = new System.Drawing.Size(180, 23);
            this.txtSubDirectorio.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(370, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nuevo SubDirectorio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(370, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mostrar Detalles del Directorio";
            // 
            // cboDetalleDirectorio
            // 
            this.cboDetalleDirectorio.FormattingEnabled = true;
            this.cboDetalleDirectorio.Location = new System.Drawing.Point(578, 130);
            this.cboDetalleDirectorio.Name = "cboDetalleDirectorio";
            this.cboDetalleDirectorio.Size = new System.Drawing.Size(181, 23);
            this.cboDetalleDirectorio.TabIndex = 9;
            // 
            // btnMostrarDetalleDirectorio
            // 
            this.btnMostrarDetalleDirectorio.Location = new System.Drawing.Point(775, 130);
            this.btnMostrarDetalleDirectorio.Name = "btnMostrarDetalleDirectorio";
            this.btnMostrarDetalleDirectorio.Size = new System.Drawing.Size(159, 23);
            this.btnMostrarDetalleDirectorio.TabIndex = 10;
            this.btnMostrarDetalleDirectorio.Text = "Mostrar Detalle Directorio";
            this.btnMostrarDetalleDirectorio.UseVisualStyleBackColor = true;
            this.btnMostrarDetalleDirectorio.Click += new System.EventHandler(this.btnMostrarDetalleDirectorio_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCopiarDirectorio);
            this.panel1.Controls.Add(this.txtDirectorioDestino);
            this.panel1.Controls.Add(this.txtDirectorioOrigen);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(370, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 125);
            this.panel1.TabIndex = 11;
            // 
            // btnCopiarDirectorio
            // 
            this.btnCopiarDirectorio.Location = new System.Drawing.Point(424, 82);
            this.btnCopiarDirectorio.Name = "btnCopiarDirectorio";
            this.btnCopiarDirectorio.Size = new System.Drawing.Size(110, 27);
            this.btnCopiarDirectorio.TabIndex = 12;
            this.btnCopiarDirectorio.TabStop = false;
            this.btnCopiarDirectorio.Text = "Copiar";
            this.btnCopiarDirectorio.UseVisualStyleBackColor = true;
            this.btnCopiarDirectorio.Click += new System.EventHandler(this.btnCopiarDirectorio_Click);
            // 
            // txtDirectorioDestino
            // 
            this.txtDirectorioDestino.Location = new System.Drawing.Point(354, 53);
            this.txtDirectorioDestino.Name = "txtDirectorioDestino";
            this.txtDirectorioDestino.Size = new System.Drawing.Size(180, 23);
            this.txtDirectorioDestino.TabIndex = 14;
            // 
            // txtDirectorioOrigen
            // 
            this.txtDirectorioOrigen.Location = new System.Drawing.Point(75, 53);
            this.txtDirectorioOrigen.Name = "txtDirectorioOrigen";
            this.txtDirectorioOrigen.Size = new System.Drawing.Size(180, 23);
            this.txtDirectorioOrigen.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(280, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Copiar Directorio";
            // 
            // btnCrearArchivo
            // 
            this.btnCrearArchivo.Location = new System.Drawing.Point(775, 344);
            this.btnCrearArchivo.Name = "btnCrearArchivo";
            this.btnCrearArchivo.Size = new System.Drawing.Size(159, 23);
            this.btnCrearArchivo.TabIndex = 14;
            this.btnCrearArchivo.Text = "Crear Archivo";
            this.btnCrearArchivo.UseVisualStyleBackColor = true;
            this.btnCrearArchivo.Click += new System.EventHandler(this.btnCrearArchivo_Click);
            // 
            // txtNuevoArchivo
            // 
            this.txtNuevoArchivo.Location = new System.Drawing.Point(579, 342);
            this.txtNuevoArchivo.Name = "txtNuevoArchivo";
            this.txtNuevoArchivo.Size = new System.Drawing.Size(180, 23);
            this.txtNuevoArchivo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(370, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nuevo Archivo  (Incluir Path):";
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Location = new System.Drawing.Point(352, 398);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(159, 23);
            this.btnAbrirArchivo.TabIndex = 17;
            this.btnAbrirArchivo.Text = "Abrir ";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // txtSeleccionarArchivo
            // 
            this.txtSeleccionarArchivo.Location = new System.Drawing.Point(150, 398);
            this.txtSeleccionarArchivo.Name = "txtSeleccionarArchivo";
            this.txtSeleccionarArchivo.Size = new System.Drawing.Size(180, 23);
            this.txtSeleccionarArchivo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Seleccionar Archivo:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bntRenombrarArchivo
            // 
            this.bntRenombrarArchivo.Location = new System.Drawing.Point(352, 437);
            this.bntRenombrarArchivo.Name = "bntRenombrarArchivo";
            this.bntRenombrarArchivo.Size = new System.Drawing.Size(159, 23);
            this.bntRenombrarArchivo.TabIndex = 20;
            this.bntRenombrarArchivo.Text = "Renombrar";
            this.bntRenombrarArchivo.UseVisualStyleBackColor = true;
            this.bntRenombrarArchivo.Click += new System.EventHandler(this.bntRenombrarArchivo_Click);
            // 
            // txtRenombrarArchivo
            // 
            this.txtRenombrarArchivo.Location = new System.Drawing.Point(150, 437);
            this.txtRenombrarArchivo.Name = "txtRenombrarArchivo";
            this.txtRenombrarArchivo.Size = new System.Drawing.Size(180, 23);
            this.txtRenombrarArchivo.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Renombrar";
            // 
            // txtEscribir
            // 
            this.txtEscribir.Location = new System.Drawing.Point(23, 508);
            this.txtEscribir.Multiline = true;
            this.txtEscribir.Name = "txtEscribir";
            this.txtEscribir.Size = new System.Drawing.Size(185, 140);
            this.txtEscribir.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(91, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Escribir";
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(35, 654);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(159, 23);
            this.btnEscribir.TabIndex = 23;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(266, 654);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(159, 23);
            this.btnLeer.TabIndex = 26;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(335, 488);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Leer";
            // 
            // txtLeer
            // 
            this.txtLeer.Location = new System.Drawing.Point(254, 508);
            this.txtLeer.Multiline = true;
            this.txtLeer.Name = "txtLeer";
            this.txtLeer.Size = new System.Drawing.Size(185, 140);
            this.txtLeer.TabIndex = 24;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(487, 654);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 23);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(545, 488);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(475, 508);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(185, 140);
            this.txtBuscar.TabIndex = 27;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(709, 654);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(159, 23);
            this.btnActualizar.TabIndex = 32;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(756, 488);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 31;
            this.label13.Text = "Actualizar";
            // 
            // txtActualizar
            // 
            this.txtActualizar.Location = new System.Drawing.Point(697, 508);
            this.txtActualizar.Multiline = true;
            this.txtActualizar.Name = "txtActualizar";
            this.txtActualizar.Size = new System.Drawing.Size(185, 140);
            this.txtActualizar.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 707);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLeer);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEscribir);
            this.Controls.Add(this.bntRenombrarArchivo);
            this.Controls.Add(this.txtRenombrarArchivo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAbrirArchivo);
            this.Controls.Add(this.txtSeleccionarArchivo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCrearArchivo);
            this.Controls.Add(this.txtNuevoArchivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMostrarDetalleDirectorio);
            this.Controls.Add(this.cboDetalleDirectorio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubDirectorio);
            this.Controls.Add(this.txtSubDirectorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtCrearDirectorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSystemDrives);
            this.Controls.Add(this.txtSystemDestails);
            this.Name = "Form1";
            this.Text = "Gestionar Archivos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSystemDestails;
        private ComboBox cboSystemDrives;
        private Label label1;
        private TextBox txtCrearDirectorio;
        private Button btnCrear;
        private Button btnSubDirectorio;
        private TextBox txtSubDirectorio;
        private Label label2;
        private Label label3;
        private ComboBox cboDetalleDirectorio;
        private Button btnMostrarDetalleDirectorio;
        private Panel panel1;
        private Button btnCopiarDirectorio;
        private TextBox txtDirectorioDestino;
        private TextBox txtDirectorioOrigen;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnCrearArchivo;
        private TextBox txtNuevoArchivo;
        private Label label7;
        private Button btnAbrirArchivo;
        private TextBox txtSeleccionarArchivo;
        private Label label8;
        private OpenFileDialog openFileDialog1;
        private Button bntRenombrarArchivo;
        private TextBox txtRenombrarArchivo;
        private Label label9;
        private TextBox txtEscribir;
        private Label label10;
        private Button btnEscribir;
        private Button btnLeer;
        private Label label11;
        private TextBox txtLeer;
        private Button btnBuscar;
        private Label label12;
        private TextBox txtBuscar;
        private Button btnActualizar;
        private Label label13;
        private TextBox txtActualizar;
    }
}