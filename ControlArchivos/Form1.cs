namespace ControlArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            poblarUnidadesSistema();
        }



        private void poblarUnidadesSistema()
        {
            try
            {
                var discos = Directory.GetLogicalDrives();
                foreach (var disco in discos)
                {
                    cboSystemDrives.Items.Add(disco);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }

        private void cboSystemDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var disk = cboSystemDrives.SelectedItem.ToString();
                DriveInfo diskinfo = new DriveInfo(disk);

                var drivedetalle = $@"
                    Drive:  {disk} drive:


                    Tamaño Total {diskinfo.TotalSize}
                    Tamaño Total Disponible: {diskinfo.TotalFreeSpace}
                    Format: {diskinfo.DriveFormat}
                ";

                txtSystemDestails.Text = drivedetalle;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCrearDirectorio.Text))
                    throw new Exception("Por favor ingrese una ruta para el directorio");

                if (!Directory.Exists(txtCrearDirectorio.Text))
                {
                    Directory.CreateDirectory(txtCrearDirectorio.Text);
                    MessageBox.Show("El directorio fue creado exitosamente");

                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una ruta para el nuevo directorio");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubDirectorio_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtCrearDirectorio.Text))
                    throw new Exception("Asegúrese de haber incluido una ruta de directorio en el nuevo directorio ");
                if (string.IsNullOrEmpty(txtSubDirectorio.Text))
                    throw new Exception("Asegúrese de haber incluido una ruta para el nuevo Subdirectorio ");


                var rutaDirectorio = txtCrearDirectorio.Text;
                var subDirInfo = new DirectoryInfo(rutaDirectorio);
                subDirInfo.CreateSubdirectory(txtSubDirectorio.Text);
                MessageBox.Show("El subdirectorio fue creado exitosamente!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrarDetalleDirectorio_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCrearDirectorio.Text))
                    throw new Exception("Asegúrese de haber incluido una ruta de directorio en el nuevo directorio ");

                var directorio = txtCrearDirectorio.Text;
                var directorioInfo = new DirectoryInfo(directorio);

                if (directorioInfo.Exists)
                    throw new Exception("El directorio no existe");

                var subDirectorios = directorioInfo.GetDirectories();

                foreach (var subdir in subDirectorios)
                {

                    if(!cboDetalleDirectorio.Items.Contains(subdir.Name))
                        cboDetalleDirectorio.Items.Add(subdir.Name);
                }

                var archivos = directorioInfo.GetFiles("*");

                foreach (var archivo in archivos)
                {

                    if (!cboDetalleDirectorio.Items.Contains(archivo.Name))
                        cboDetalleDirectorio.Items.Add(archivo.Name);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCopiarDirectorio_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtDirectorioOrigen.Text) || string.IsNullOrEmpty(txtDirectorioDestino.Text))
                    throw new Exception("Los campos Directorio Origen y directorio Destino deben tener valores");

                var directorioOrigen = new DirectoryInfo(txtDirectorioOrigen.Text);
                var directorioDestino = new DirectoryInfo(txtDirectorioDestino.Text);

                CopiarDirectorio(directorioOrigen,directorioDestino);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           


        }


        private void CopiarDirectorio(DirectoryInfo directorioOrigen , DirectoryInfo directorioDestino)
        {
            try
            {
                if (!directorioOrigen.Exists)
                    throw new Exception("El directorio Origen no existe");


                if(!directorioDestino.Exists)
                    directorioDestino.Create();

                var archivos = directorioOrigen.GetFiles();

                foreach (var archivo in archivos)
                {
                    archivo.CopyTo(Path.Combine(directorioDestino.FullName, archivo.Name));
                }


                var directorios = directorioOrigen.GetDirectories();

                foreach (var directorio in directorios)
                {
                    string destino = Path.Combine(directorioDestino.FullName,directorio.Name);
                    CopiarDirectorio(directorio, new DirectoryInfo(destino));

                }

                MessageBox.Show("Directorio copiado exitosamente");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnCrearArchivo_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(txtNuevoArchivo.Text))
                    throw new Exception("Asegurese de incuir una ruta para el nuevo archivo");

                if(!File.Exists(txtNuevoArchivo.Text))
                {
                    File.Create(txtNuevoArchivo.Text);
                    MessageBox.Show("Archivo creado exitosamente");
                }
                else
                {

                    MessageBox.Show("Por favor ingrese la ruta del nuevo archivo");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }







        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtSeleccionarArchivo.Text = openFileDialog1.FileName;
                    txtRenombrarArchivo.Text = openFileDialog1.FileName;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bntRenombrarArchivo_Click(object sender, EventArgs e)
        {
            try
            {

                var origen = txtSeleccionarArchivo.Text;
                var destino = txtRenombrarArchivo.Text;

                var origenArchivoInfo = new FileInfo(origen);
                if(origenArchivoInfo.Exists)
                {
                    origenArchivoInfo.MoveTo(destino);
                    MessageBox.Show("El archivo fue renombrado exitosamente.");
                }

                else
                {

                    MessageBox.Show("Error al tratar de renombrar el archivo");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {


            try
            {

                validarSeleccionarArchivo();


                FileStream fs = new FileStream(txtSeleccionarArchivo.Text, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(txtEscribir.Text);
                sw.Flush(); // Limpiar los buffer
                fs.Close(); //cerrar FileStream

                MessageBox.Show("Se agregó el nuevo contenido exitosamente.");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                validarSeleccionarArchivo();
                FileStream fs = new FileStream(txtSeleccionarArchivo.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                txtLeer.Text = sr.ReadToEnd();
                fs.Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        void validarSeleccionarArchivo()
        {

            if (string.IsNullOrEmpty(txtSeleccionarArchivo.Text))
                throw new Exception("Asegúrese de seleccionar un archivo...");


            if (!File.Exists(txtSeleccionarArchivo.Text))
                throw new Exception("El archivo seleccionado no existe");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                validarSeleccionarArchivo();

                FileStream fs = new FileStream(txtSeleccionarArchivo.Text,FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                var contenido = sr.ReadToEnd();

                int indice = contenido.IndexOf(txtBuscar.Text.Trim(),0);

                if (indice > -1)
                    MessageBox.Show("La cadena se encuentra en el archivo");
                    
                else
                    MessageBox.Show("La cadena no se encuentra en el archivo");

                fs.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                validarSeleccionarArchivo();

                var ruta = txtSeleccionarArchivo.Text;

                var sw = File.AppendText(ruta);

                sw.WriteLine(txtActualizar.Text);
                sw.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }



   
}