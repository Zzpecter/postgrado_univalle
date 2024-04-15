namespace GUI
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.bAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.bInscribirNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.bInscribirExistente = new System.Windows.Forms.ToolStripMenuItem();
            this.bGestionAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.bNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.bGestionDelPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.bUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bDocentesGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.bDocentesEspecialidad = new System.Windows.Forms.ToolStripMenuItem();
            this.bEgresados = new System.Windows.Forms.ToolStripMenuItem();
            this.bGestionEgresados = new System.Windows.Forms.ToolStripMenuItem();
            this.bTramites = new System.Windows.Forms.ToolStripMenuItem();
            this.bOfertas = new System.Windows.Forms.ToolStripMenuItem();
            this.bGestionInteresados = new System.Windows.Forms.ToolStripMenuItem();
            this.bEnvioOfertas = new System.Windows.Forms.ToolStripMenuItem();
            this.bPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.bEditarPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.bCatalogos = new System.Windows.Forms.ToolStripMenuItem();
            this.bABMAulas = new System.Windows.Forms.ToolStripMenuItem();
            this.bABMAreasEspecialidad = new System.Windows.Forms.ToolStripMenuItem();
            this.bABMEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.bABMTelefonos = new System.Windows.Forms.ToolStripMenuItem();
            this.bABMTiposAula = new System.Windows.Forms.ToolStripMenuItem();
            this.bPostgrado = new System.Windows.Forms.ToolStripMenuItem();
            this.bGestionPostgrado = new System.Windows.Forms.ToolStripMenuItem();
            this.bAsignarDocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.bMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.bReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.bReporteInscripciones = new System.Windows.Forms.ToolStripMenuItem();
            this.bReporteMateriaNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.bReporteDocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.bReportePostgrados = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAutenticacion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.tHora = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbGif = new System.Windows.Forms.PictureBox();
            this.bCerrarSesion = new System.Windows.Forms.Button();
            this.bPerfil = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.bNotificaciones = new System.Windows.Forms.Button();
            this.bBitacora = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.bAgenda = new System.Windows.Forms.Button();
            this.pbReloj = new System.Windows.Forms.PictureBox();
            this.lblNotificaciones = new System.Windows.Forms.Label();
            this.msMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReloj)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bAlumnos,
            this.bGestionDelPersonal,
            this.bEgresados,
            this.bOfertas,
            this.bPermisos,
            this.bCatalogos,
            this.bPostgrado,
            this.bReportes});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(713, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // bAlumnos
            // 
            this.bAlumnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bInscribirNuevo,
            this.bInscribirExistente,
            this.bGestionAlumnos,
            this.bNotas});
            this.bAlumnos.Name = "bAlumnos";
            this.bAlumnos.Size = new System.Drawing.Size(67, 20);
            this.bAlumnos.Text = "Alumnos";
            // 
            // bInscribirNuevo
            // 
            this.bInscribirNuevo.Name = "bInscribirNuevo";
            this.bInscribirNuevo.Size = new System.Drawing.Size(165, 22);
            this.bInscribirNuevo.Text = "Inscribir Nuevo";
            this.bInscribirNuevo.Click += new System.EventHandler(this.inscribirNuevoToolStripMenuItem_Click);
            // 
            // bInscribirExistente
            // 
            this.bInscribirExistente.Name = "bInscribirExistente";
            this.bInscribirExistente.Size = new System.Drawing.Size(165, 22);
            this.bInscribirExistente.Text = "Inscribir Existente";
            this.bInscribirExistente.Click += new System.EventHandler(this.inscribirExistenteToolStripMenuItem_Click);
            // 
            // bGestionAlumnos
            // 
            this.bGestionAlumnos.Name = "bGestionAlumnos";
            this.bGestionAlumnos.Size = new System.Drawing.Size(165, 22);
            this.bGestionAlumnos.Text = "Gestión";
            this.bGestionAlumnos.Click += new System.EventHandler(this.gestiónToolStripMenuItem_Click);
            // 
            // bNotas
            // 
            this.bNotas.Name = "bNotas";
            this.bNotas.Size = new System.Drawing.Size(165, 22);
            this.bNotas.Text = "Ingresar Notas";
            this.bNotas.Click += new System.EventHandler(this.bNotas_Click);
            // 
            // bGestionDelPersonal
            // 
            this.bGestionDelPersonal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bUsuarios,
            this.docentesToolStripMenuItem});
            this.bGestionDelPersonal.Name = "bGestionDelPersonal";
            this.bGestionDelPersonal.Size = new System.Drawing.Size(126, 20);
            this.bGestionDelPersonal.Text = "Gestión del Personal";
            // 
            // bUsuarios
            // 
            this.bUsuarios.Name = "bUsuarios";
            this.bUsuarios.Size = new System.Drawing.Size(123, 22);
            this.bUsuarios.Text = "Usuarios";
            this.bUsuarios.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // docentesToolStripMenuItem
            // 
            this.docentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bDocentesGeneral,
            this.bDocentesEspecialidad});
            this.docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            this.docentesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.docentesToolStripMenuItem.Text = "Docentes";
            // 
            // bDocentesGeneral
            // 
            this.bDocentesGeneral.Name = "bDocentesGeneral";
            this.bDocentesGeneral.Size = new System.Drawing.Size(150, 22);
            this.bDocentesGeneral.Text = "General";
            this.bDocentesGeneral.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // bDocentesEspecialidad
            // 
            this.bDocentesEspecialidad.Name = "bDocentesEspecialidad";
            this.bDocentesEspecialidad.Size = new System.Drawing.Size(150, 22);
            this.bDocentesEspecialidad.Text = "Especialidades";
            this.bDocentesEspecialidad.Click += new System.EventHandler(this.especialidadesToolStripMenuItem_Click);
            // 
            // bEgresados
            // 
            this.bEgresados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bGestionEgresados,
            this.bTramites});
            this.bEgresados.Name = "bEgresados";
            this.bEgresados.Size = new System.Drawing.Size(72, 20);
            this.bEgresados.Text = "Egresados";
            // 
            // bGestionEgresados
            // 
            this.bGestionEgresados.Name = "bGestionEgresados";
            this.bGestionEgresados.Size = new System.Drawing.Size(152, 22);
            this.bGestionEgresados.Text = "Gestión";
            this.bGestionEgresados.Click += new System.EventHandler(this.bGestionEgresados_Click);
            // 
            // bTramites
            // 
            this.bTramites.Name = "bTramites";
            this.bTramites.Size = new System.Drawing.Size(152, 22);
            this.bTramites.Text = "Tramites";
            this.bTramites.Click += new System.EventHandler(this.bTramites_Click);
            // 
            // bOfertas
            // 
            this.bOfertas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bGestionInteresados,
            this.bEnvioOfertas});
            this.bOfertas.Name = "bOfertas";
            this.bOfertas.Size = new System.Drawing.Size(57, 20);
            this.bOfertas.Text = "Ofertas";
            // 
            // bGestionInteresados
            // 
            this.bGestionInteresados.Name = "bGestionInteresados";
            this.bGestionInteresados.Size = new System.Drawing.Size(193, 22);
            this.bGestionInteresados.Text = "Gestión de Interesados";
            this.bGestionInteresados.Click += new System.EventHandler(this.bGestionInteresados_Click);
            // 
            // bEnvioOfertas
            // 
            this.bEnvioOfertas.Name = "bEnvioOfertas";
            this.bEnvioOfertas.Size = new System.Drawing.Size(193, 22);
            this.bEnvioOfertas.Text = "Envio de Ofertas";
            this.bEnvioOfertas.Click += new System.EventHandler(this.bEnvioOfertas_Click);
            // 
            // bPermisos
            // 
            this.bPermisos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bEditarPermisos});
            this.bPermisos.Name = "bPermisos";
            this.bPermisos.Size = new System.Drawing.Size(67, 20);
            this.bPermisos.Text = "Permisos";
            // 
            // bEditarPermisos
            // 
            this.bEditarPermisos.Name = "bEditarPermisos";
            this.bEditarPermisos.Size = new System.Drawing.Size(155, 22);
            this.bEditarPermisos.Text = "Editar Permisos";
            this.bEditarPermisos.Click += new System.EventHandler(this.bEditarPermisos_Click);
            // 
            // bCatalogos
            // 
            this.bCatalogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bABMAulas,
            this.bABMAreasEspecialidad,
            this.bABMEspecialidades,
            this.bABMTelefonos,
            this.bABMTiposAula});
            this.bCatalogos.Name = "bCatalogos";
            this.bCatalogos.Size = new System.Drawing.Size(72, 20);
            this.bCatalogos.Text = "Catálogos";
            // 
            // bABMAulas
            // 
            this.bABMAulas.Name = "bABMAulas";
            this.bABMAulas.Size = new System.Drawing.Size(187, 22);
            this.bABMAulas.Text = "Aulas";
            this.bABMAulas.Click += new System.EventHandler(this.bABMAulas_Click);
            // 
            // bABMAreasEspecialidad
            // 
            this.bABMAreasEspecialidad.Name = "bABMAreasEspecialidad";
            this.bABMAreasEspecialidad.Size = new System.Drawing.Size(187, 22);
            this.bABMAreasEspecialidad.Text = "Areas de Especialidad";
            this.bABMAreasEspecialidad.Click += new System.EventHandler(this.bABMAreasEspecialidad_Click);
            // 
            // bABMEspecialidades
            // 
            this.bABMEspecialidades.Name = "bABMEspecialidades";
            this.bABMEspecialidades.Size = new System.Drawing.Size(187, 22);
            this.bABMEspecialidades.Text = "Especialidades";
            this.bABMEspecialidades.Click += new System.EventHandler(this.bABMEspecialidades_Click);
            // 
            // bABMTelefonos
            // 
            this.bABMTelefonos.Name = "bABMTelefonos";
            this.bABMTelefonos.Size = new System.Drawing.Size(187, 22);
            this.bABMTelefonos.Text = "Telefonos";
            this.bABMTelefonos.Click += new System.EventHandler(this.bABMTelefonos_Click);
            // 
            // bABMTiposAula
            // 
            this.bABMTiposAula.Name = "bABMTiposAula";
            this.bABMTiposAula.Size = new System.Drawing.Size(187, 22);
            this.bABMTiposAula.Text = "Tipos de Aula";
            this.bABMTiposAula.Click += new System.EventHandler(this.bABMTiposAula_Click);
            // 
            // bPostgrado
            // 
            this.bPostgrado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bGestionPostgrado,
            this.bAsignarDocentes,
            this.bMaterias});
            this.bPostgrado.Name = "bPostgrado";
            this.bPostgrado.Size = new System.Drawing.Size(78, 20);
            this.bPostgrado.Text = "Postgrados";
            // 
            // bGestionPostgrado
            // 
            this.bGestionPostgrado.Name = "bGestionPostgrado";
            this.bGestionPostgrado.Size = new System.Drawing.Size(166, 22);
            this.bGestionPostgrado.Text = "Gestion";
            this.bGestionPostgrado.Click += new System.EventHandler(this.bGestionPostgrado_Click);
            // 
            // bAsignarDocentes
            // 
            this.bAsignarDocentes.Name = "bAsignarDocentes";
            this.bAsignarDocentes.Size = new System.Drawing.Size(166, 22);
            this.bAsignarDocentes.Text = "Asignar Docentes";
            this.bAsignarDocentes.Click += new System.EventHandler(this.bAsignarDocentes_Click);
            // 
            // bMaterias
            // 
            this.bMaterias.Name = "bMaterias";
            this.bMaterias.Size = new System.Drawing.Size(166, 22);
            this.bMaterias.Text = "Materias";
            this.bMaterias.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);
            // 
            // bReportes
            // 
            this.bReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bReporteInscripciones,
            this.bReporteMateriaNotas,
            this.bReporteDocentes,
            this.bReportePostgrados});
            this.bReportes.Name = "bReportes";
            this.bReportes.Size = new System.Drawing.Size(65, 20);
            this.bReportes.Text = "Reportes";
            // 
            // bReporteInscripciones
            // 
            this.bReporteInscripciones.Name = "bReporteInscripciones";
            this.bReporteInscripciones.Size = new System.Drawing.Size(210, 22);
            this.bReporteInscripciones.Text = "Inscripciones";
            this.bReporteInscripciones.Click += new System.EventHandler(this.bReporteInscripciones_Click);
            // 
            // bReporteMateriaNotas
            // 
            this.bReporteMateriaNotas.Name = "bReporteMateriaNotas";
            this.bReporteMateriaNotas.Size = new System.Drawing.Size(210, 22);
            this.bReporteMateriaNotas.Text = "Notas por Materia";
            this.bReporteMateriaNotas.Click += new System.EventHandler(this.bReporteMateriaNotas_Click);
            // 
            // bReporteDocentes
            // 
            this.bReporteDocentes.Name = "bReporteDocentes";
            this.bReporteDocentes.Size = new System.Drawing.Size(210, 22);
            this.bReporteDocentes.Text = "Docentes - Especialidades";
            this.bReporteDocentes.Click += new System.EventHandler(this.bReporteDocentes_Click);
            // 
            // bReportePostgrados
            // 
            this.bReportePostgrados.Name = "bReportePostgrados";
            this.bReportePostgrados.Size = new System.Drawing.Size(210, 22);
            this.bReportePostgrados.Text = "Postgrados";
            this.bReportePostgrados.Click += new System.EventHandler(this.bReportePostgrados_Click);
            // 
            // lblAutenticacion
            // 
            this.lblAutenticacion.AutoSize = true;
            this.lblAutenticacion.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutenticacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAutenticacion.Location = new System.Drawing.Point(17, 19);
            this.lblAutenticacion.Name = "lblAutenticacion";
            this.lblAutenticacion.Size = new System.Drawing.Size(188, 27);
            this.lblAutenticacion.TabIndex = 4;
            this.lblAutenticacion.Text = "Bienvenido!";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFecha.Location = new System.Drawing.Point(12, 326);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(75, 21);
            this.lblFecha.TabIndex = 22;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.DarkRed;
            this.lblHora.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(24, 385);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(167, 32);
            this.lblHora.TabIndex = 24;
            this.lblHora.Text = "00:00:00";
            // 
            // tHora
            // 
            this.tHora.Interval = 1000;
            this.tHora.Tick += new System.EventHandler(this.tHora_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbGif);
            this.groupBox1.Controls.Add(this.bCerrarSesion);
            this.groupBox1.Controls.Add(this.bPerfil);
            this.groupBox1.Controls.Add(this.lblAutenticacion);
            this.groupBox1.Controls.Add(this.pbFoto);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 289);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // pbGif
            // 
            this.pbGif.Image = global::GUI.Properties.Resources.Logo;
            this.pbGif.Location = new System.Drawing.Point(22, 76);
            this.pbGif.Name = "pbGif";
            this.pbGif.Size = new System.Drawing.Size(241, 175);
            this.pbGif.TabIndex = 1;
            this.pbGif.TabStop = false;
            // 
            // bCerrarSesion
            // 
            this.bCerrarSesion.BackgroundImage = global::GUI.Properties.Resources.imgCerrarSesion;
            this.bCerrarSesion.Location = new System.Drawing.Point(519, 257);
            this.bCerrarSesion.Name = "bCerrarSesion";
            this.bCerrarSesion.Size = new System.Drawing.Size(150, 26);
            this.bCerrarSesion.TabIndex = 26;
            this.bCerrarSesion.UseVisualStyleBackColor = true;
            this.bCerrarSesion.Click += new System.EventHandler(this.bCerrarSesion_Click);
            // 
            // bPerfil
            // 
            this.bPerfil.BackgroundImage = global::GUI.Properties.Resources.imgConfigPerfil1;
            this.bPerfil.Location = new System.Drawing.Point(519, 216);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(150, 35);
            this.bPerfil.TabIndex = 27;
            this.bPerfil.UseVisualStyleBackColor = true;
            this.bPerfil.Click += new System.EventHandler(this.bPerfil_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImage = global::GUI.Properties.Resources.imgPerfil;
            this.pbFoto.Location = new System.Drawing.Point(519, 60);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(150, 150);
            this.pbFoto.TabIndex = 21;
            this.pbFoto.TabStop = false;
            // 
            // bNotificaciones
            // 
            this.bNotificaciones.BackgroundImage = global::GUI.Properties.Resources.imgNotificacion;
            this.bNotificaciones.Location = new System.Drawing.Point(541, 322);
            this.bNotificaciones.Name = "bNotificaciones";
            this.bNotificaciones.Size = new System.Drawing.Size(160, 76);
            this.bNotificaciones.TabIndex = 31;
            this.bNotificaciones.UseVisualStyleBackColor = true;
            this.bNotificaciones.Click += new System.EventHandler(this.bNotificaciones_Click);
            // 
            // bBitacora
            // 
            this.bBitacora.BackgroundImage = global::GUI.Properties.Resources.imgBitacora;
            this.bBitacora.Location = new System.Drawing.Point(278, 342);
            this.bBitacora.Name = "bBitacora";
            this.bBitacora.Size = new System.Drawing.Size(200, 51);
            this.bBitacora.TabIndex = 30;
            this.bBitacora.UseVisualStyleBackColor = true;
            this.bBitacora.Click += new System.EventHandler(this.bBitacora_Click);
            // 
            // bSalir
            // 
            this.bSalir.BackgroundImage = global::GUI.Properties.Resources.imgSalir2;
            this.bSalir.Location = new System.Drawing.Point(541, 405);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(160, 45);
            this.bSalir.TabIndex = 29;
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bAgenda
            // 
            this.bAgenda.BackgroundImage = global::GUI.Properties.Resources.imgAgenda2;
            this.bAgenda.Location = new System.Drawing.Point(278, 399);
            this.bAgenda.Name = "bAgenda";
            this.bAgenda.Size = new System.Drawing.Size(200, 51);
            this.bAgenda.TabIndex = 25;
            this.bAgenda.UseVisualStyleBackColor = true;
            this.bAgenda.Click += new System.EventHandler(this.bAgenda_Click);
            // 
            // pbReloj
            // 
            this.pbReloj.BackgroundImage = global::GUI.Properties.Resources.imgReloj;
            this.pbReloj.Location = new System.Drawing.Point(12, 350);
            this.pbReloj.Name = "pbReloj";
            this.pbReloj.Size = new System.Drawing.Size(200, 100);
            this.pbReloj.TabIndex = 23;
            this.pbReloj.TabStop = false;
            // 
            // lblNotificaciones
            // 
            this.lblNotificaciones.AutoSize = true;
            this.lblNotificaciones.BackColor = System.Drawing.Color.Red;
            this.lblNotificaciones.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificaciones.ForeColor = System.Drawing.Color.White;
            this.lblNotificaciones.Location = new System.Drawing.Point(650, 326);
            this.lblNotificaciones.Name = "lblNotificaciones";
            this.lblNotificaciones.Size = new System.Drawing.Size(31, 19);
            this.lblNotificaciones.TabIndex = 32;
            this.lblNotificaciones.Text = "10";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 461);
            this.Controls.Add(this.lblNotificaciones);
            this.Controls.Add(this.bNotificaciones);
            this.Controls.Add(this.bBitacora);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bAgenda);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.pbReloj);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Bienvenido al Sistema de Postgrado Univalle!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmMenuPrincipal_VisibleChanged);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReloj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.PictureBox pbGif;
        private System.Windows.Forms.Label lblAutenticacion;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pbReloj;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tHora;
        private System.Windows.Forms.Button bAgenda;
        private System.Windows.Forms.Button bCerrarSesion;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bBitacora;
        private System.Windows.Forms.ToolStripMenuItem bAlumnos;
        private System.Windows.Forms.ToolStripMenuItem bInscribirNuevo;
        private System.Windows.Forms.ToolStripMenuItem bInscribirExistente;
        private System.Windows.Forms.ToolStripMenuItem bGestionAlumnos;
        private System.Windows.Forms.ToolStripMenuItem bGestionDelPersonal;
        private System.Windows.Forms.ToolStripMenuItem bUsuarios;
        private System.Windows.Forms.ToolStripMenuItem docentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bDocentesGeneral;
        private System.Windows.Forms.ToolStripMenuItem bDocentesEspecialidad;
        private System.Windows.Forms.ToolStripMenuItem bEgresados;
        private System.Windows.Forms.ToolStripMenuItem bGestionEgresados;
        private System.Windows.Forms.ToolStripMenuItem bTramites;
        private System.Windows.Forms.Button bNotificaciones;
        private System.Windows.Forms.Label lblNotificaciones;
        private System.Windows.Forms.ToolStripMenuItem bPermisos;
        private System.Windows.Forms.ToolStripMenuItem bEditarPermisos;
        private System.Windows.Forms.ToolStripMenuItem bCatalogos;
        private System.Windows.Forms.ToolStripMenuItem bABMAreasEspecialidad;
        private System.Windows.Forms.ToolStripMenuItem bABMTelefonos;
        private System.Windows.Forms.ToolStripMenuItem bABMTiposAula;
        private System.Windows.Forms.ToolStripMenuItem bABMAulas;
        private System.Windows.Forms.ToolStripMenuItem bOfertas;
        private System.Windows.Forms.ToolStripMenuItem bGestionInteresados;
        private System.Windows.Forms.ToolStripMenuItem bEnvioOfertas;
        private System.Windows.Forms.ToolStripMenuItem bPostgrado;
        private System.Windows.Forms.ToolStripMenuItem bGestionPostgrado;
        private System.Windows.Forms.ToolStripMenuItem bAsignarDocentes;
        private System.Windows.Forms.ToolStripMenuItem bABMEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem bMaterias;
        private System.Windows.Forms.ToolStripMenuItem bReportes;
        private System.Windows.Forms.ToolStripMenuItem bReporteInscripciones;
        private System.Windows.Forms.ToolStripMenuItem bNotas;
        private System.Windows.Forms.ToolStripMenuItem bReporteMateriaNotas;
        private System.Windows.Forms.ToolStripMenuItem bReporteDocentes;
        private System.Windows.Forms.ToolStripMenuItem bReportePostgrados;
    }
}