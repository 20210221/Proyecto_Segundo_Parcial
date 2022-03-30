namespace Capa_Presentacion
{
    partial class Form_Presentacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Presentacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelTopFormulario = new System.Windows.Forms.Panel();
            this.ExitPresentacion = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MoverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TextBuscar = new System.Windows.Forms.TextBox();
            this.BuscarContacto = new System.Windows.Forms.PictureBox();
            this.TablaContactos = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAddContacto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditarContacto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarContacto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardarContacto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TextCode = new System.Windows.Forms.TextBox();
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.TextApellido = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TextDir = new System.Windows.Forms.TextBox();
            this.TextDate = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TextPhone = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanelTopFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTopFormulario
            // 
            this.PanelTopFormulario.BackColor = System.Drawing.Color.Teal;
            this.PanelTopFormulario.Controls.Add(this.ExitPresentacion);
            this.PanelTopFormulario.Controls.Add(this.bunifuCustomLabel1);
            this.PanelTopFormulario.Controls.Add(this.pictureBox1);
            this.PanelTopFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopFormulario.Location = new System.Drawing.Point(0, 0);
            this.PanelTopFormulario.Name = "PanelTopFormulario";
            this.PanelTopFormulario.Size = new System.Drawing.Size(803, 86);
            this.PanelTopFormulario.TabIndex = 0;
            // 
            // ExitPresentacion
            // 
            this.ExitPresentacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("ExitPresentacion.Image")));
            this.ExitPresentacion.Location = new System.Drawing.Point(712, 12);
            this.ExitPresentacion.Name = "ExitPresentacion";
            this.ExitPresentacion.Size = new System.Drawing.Size(64, 64);
            this.ExitPresentacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ExitPresentacion.TabIndex = 3;
            this.ExitPresentacion.TabStop = false;
            this.ExitPresentacion.Click += new System.EventHandler(this.ExitPresentacion_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(95, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(293, 33);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Agenda Electrónica";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MoverFormulario
            // 
            this.MoverFormulario.Fixed = true;
            this.MoverFormulario.Horizontal = true;
            this.MoverFormulario.TargetControl = this.PanelTopFormulario;
            this.MoverFormulario.Vertical = true;
            // 
            // TextBuscar
            // 
            this.TextBuscar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBuscar.Location = new System.Drawing.Point(77, 117);
            this.TextBuscar.Multiline = true;
            this.TextBuscar.Name = "TextBuscar";
            this.TextBuscar.Size = new System.Drawing.Size(429, 48);
            this.TextBuscar.TabIndex = 1;
            this.TextBuscar.TextChanged += new System.EventHandler(this.TextBuscar_TextChanged);
            // 
            // BuscarContacto
            // 
            this.BuscarContacto.BackColor = System.Drawing.Color.Teal;
            this.BuscarContacto.Image = ((System.Drawing.Image)(resources.GetObject("BuscarContacto.Image")));
            this.BuscarContacto.Location = new System.Drawing.Point(30, 117);
            this.BuscarContacto.Name = "BuscarContacto";
            this.BuscarContacto.Size = new System.Drawing.Size(48, 48);
            this.BuscarContacto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BuscarContacto.TabIndex = 4;
            this.BuscarContacto.TabStop = false;
            // 
            // TablaContactos
            // 
            this.TablaContactos.AllowUserToAddRows = false;
            this.TablaContactos.AllowUserToDeleteRows = false;
            this.TablaContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaContactos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaContactos.BackgroundColor = System.Drawing.Color.White;
            this.TablaContactos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaContactos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaContactos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaContactos.ColumnHeadersVisible = false;
            this.TablaContactos.Location = new System.Drawing.Point(30, 221);
            this.TablaContactos.Name = "TablaContactos";
            this.TablaContactos.ReadOnly = true;
            this.TablaContactos.RowHeadersVisible = false;
            this.TablaContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaContactos.Size = new System.Drawing.Size(476, 260);
            this.TablaContactos.TabIndex = 5;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(33, 189);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(45, 18);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "COD";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(95, 189);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(71, 18);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "Nombre";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(182, 189);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(72, 18);
            this.bunifuCustomLabel4.TabIndex = 7;
            this.bunifuCustomLabel4.Text = "Apellido";
            // 
            // btnAddContacto
            // 
            this.btnAddContacto.Activecolor = System.Drawing.Color.Teal;
            this.btnAddContacto.BackColor = System.Drawing.Color.Teal;
            this.btnAddContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddContacto.BorderRadius = 7;
            this.btnAddContacto.ButtonText = "Agregar Contacto";
            this.btnAddContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddContacto.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddContacto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddContacto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddContacto.Iconimage")));
            this.btnAddContacto.Iconimage_right = null;
            this.btnAddContacto.Iconimage_right_Selected = null;
            this.btnAddContacto.Iconimage_Selected = null;
            this.btnAddContacto.IconMarginLeft = 0;
            this.btnAddContacto.IconMarginRight = 0;
            this.btnAddContacto.IconRightVisible = true;
            this.btnAddContacto.IconRightZoom = 0D;
            this.btnAddContacto.IconVisible = true;
            this.btnAddContacto.IconZoom = 90D;
            this.btnAddContacto.IsTab = false;
            this.btnAddContacto.Location = new System.Drawing.Point(30, 498);
            this.btnAddContacto.Name = "btnAddContacto";
            this.btnAddContacto.Normalcolor = System.Drawing.Color.Teal;
            this.btnAddContacto.OnHovercolor = System.Drawing.Color.Teal;
            this.btnAddContacto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddContacto.selected = false;
            this.btnAddContacto.Size = new System.Drawing.Size(171, 48);
            this.btnAddContacto.TabIndex = 8;
            this.btnAddContacto.Text = "Agregar Contacto";
            this.btnAddContacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddContacto.Textcolor = System.Drawing.Color.White;
            this.btnAddContacto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContacto.Click += new System.EventHandler(this.btnAddContacto_Click);
            // 
            // btnEditarContacto
            // 
            this.btnEditarContacto.Activecolor = System.Drawing.Color.Teal;
            this.btnEditarContacto.BackColor = System.Drawing.Color.Teal;
            this.btnEditarContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarContacto.BorderRadius = 7;
            this.btnEditarContacto.ButtonText = "Editar Contacto";
            this.btnEditarContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarContacto.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditarContacto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditarContacto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditarContacto.Iconimage")));
            this.btnEditarContacto.Iconimage_right = null;
            this.btnEditarContacto.Iconimage_right_Selected = null;
            this.btnEditarContacto.Iconimage_Selected = null;
            this.btnEditarContacto.IconMarginLeft = 0;
            this.btnEditarContacto.IconMarginRight = 0;
            this.btnEditarContacto.IconRightVisible = true;
            this.btnEditarContacto.IconRightZoom = 0D;
            this.btnEditarContacto.IconVisible = true;
            this.btnEditarContacto.IconZoom = 90D;
            this.btnEditarContacto.IsTab = false;
            this.btnEditarContacto.Location = new System.Drawing.Point(223, 498);
            this.btnEditarContacto.Name = "btnEditarContacto";
            this.btnEditarContacto.Normalcolor = System.Drawing.Color.Teal;
            this.btnEditarContacto.OnHovercolor = System.Drawing.Color.Teal;
            this.btnEditarContacto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditarContacto.selected = false;
            this.btnEditarContacto.Size = new System.Drawing.Size(162, 48);
            this.btnEditarContacto.TabIndex = 9;
            this.btnEditarContacto.Text = "Editar Contacto";
            this.btnEditarContacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarContacto.Textcolor = System.Drawing.Color.White;
            this.btnEditarContacto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarContacto.Click += new System.EventHandler(this.btnEditarContacto_Click);
            // 
            // btnEliminarContacto
            // 
            this.btnEliminarContacto.Activecolor = System.Drawing.Color.Teal;
            this.btnEliminarContacto.BackColor = System.Drawing.Color.Teal;
            this.btnEliminarContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarContacto.BorderRadius = 7;
            this.btnEliminarContacto.ButtonText = "Eliminar Contacto";
            this.btnEliminarContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarContacto.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarContacto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarContacto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarContacto.Iconimage")));
            this.btnEliminarContacto.Iconimage_right = null;
            this.btnEliminarContacto.Iconimage_right_Selected = null;
            this.btnEliminarContacto.Iconimage_Selected = null;
            this.btnEliminarContacto.IconMarginLeft = 0;
            this.btnEliminarContacto.IconMarginRight = 0;
            this.btnEliminarContacto.IconRightVisible = true;
            this.btnEliminarContacto.IconRightZoom = 0D;
            this.btnEliminarContacto.IconVisible = true;
            this.btnEliminarContacto.IconZoom = 90D;
            this.btnEliminarContacto.IsTab = false;
            this.btnEliminarContacto.Location = new System.Drawing.Point(403, 498);
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.Normalcolor = System.Drawing.Color.Teal;
            this.btnEliminarContacto.OnHovercolor = System.Drawing.Color.Teal;
            this.btnEliminarContacto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarContacto.selected = false;
            this.btnEliminarContacto.Size = new System.Drawing.Size(171, 48);
            this.btnEliminarContacto.TabIndex = 10;
            this.btnEliminarContacto.Text = "Eliminar Contacto";
            this.btnEliminarContacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarContacto.Textcolor = System.Drawing.Color.White;
            this.btnEliminarContacto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarContacto.Click += new System.EventHandler(this.btnEliminarContacto_Click);
            // 
            // btnGuardarContacto
            // 
            this.btnGuardarContacto.Activecolor = System.Drawing.Color.Teal;
            this.btnGuardarContacto.BackColor = System.Drawing.Color.Teal;
            this.btnGuardarContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarContacto.BorderRadius = 7;
            this.btnGuardarContacto.ButtonText = "Guardar Contacto";
            this.btnGuardarContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarContacto.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarContacto.Enabled = false;
            this.btnGuardarContacto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarContacto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardarContacto.Iconimage")));
            this.btnGuardarContacto.Iconimage_right = null;
            this.btnGuardarContacto.Iconimage_right_Selected = null;
            this.btnGuardarContacto.Iconimage_Selected = null;
            this.btnGuardarContacto.IconMarginLeft = 0;
            this.btnGuardarContacto.IconMarginRight = 0;
            this.btnGuardarContacto.IconRightVisible = true;
            this.btnGuardarContacto.IconRightZoom = 0D;
            this.btnGuardarContacto.IconVisible = true;
            this.btnGuardarContacto.IconZoom = 90D;
            this.btnGuardarContacto.IsTab = false;
            this.btnGuardarContacto.Location = new System.Drawing.Point(605, 498);
            this.btnGuardarContacto.Name = "btnGuardarContacto";
            this.btnGuardarContacto.Normalcolor = System.Drawing.Color.Teal;
            this.btnGuardarContacto.OnHovercolor = System.Drawing.Color.Teal;
            this.btnGuardarContacto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardarContacto.selected = false;
            this.btnGuardarContacto.Size = new System.Drawing.Size(171, 48);
            this.btnGuardarContacto.TabIndex = 11;
            this.btnGuardarContacto.Text = "Guardar Contacto";
            this.btnGuardarContacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarContacto.Textcolor = System.Drawing.Color.White;
            this.btnGuardarContacto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarContacto.Click += new System.EventHandler(this.btnGuardarContacto_Click);
            // 
            // TextCode
            // 
            this.TextCode.Enabled = false;
            this.TextCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCode.Location = new System.Drawing.Point(537, 139);
            this.TextCode.Multiline = true;
            this.TextCode.Name = "TextCode";
            this.TextCode.Size = new System.Drawing.Size(239, 26);
            this.TextCode.TabIndex = 14;
            // 
            // TextNombre
            // 
            this.TextNombre.Enabled = false;
            this.TextNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNombre.Location = new System.Drawing.Point(537, 200);
            this.TextNombre.Multiline = true;
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(239, 24);
            this.TextNombre.TabIndex = 15;
            // 
            // TextApellido
            // 
            this.TextApellido.Enabled = false;
            this.TextApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextApellido.Location = new System.Drawing.Point(537, 260);
            this.TextApellido.Multiline = true;
            this.TextApellido.Name = "TextApellido";
            this.TextApellido.Size = new System.Drawing.Size(239, 26);
            this.TextApellido.TabIndex = 16;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(533, 118);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(64, 18);
            this.bunifuCustomLabel5.TabIndex = 17;
            this.bunifuCustomLabel5.Text = "Código";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(533, 179);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(71, 18);
            this.bunifuCustomLabel6.TabIndex = 18;
            this.bunifuCustomLabel6.Text = "Nombre";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(533, 239);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(72, 18);
            this.bunifuCustomLabel7.TabIndex = 19;
            this.bunifuCustomLabel7.Text = "Apellido";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(534, 300);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(85, 18);
            this.bunifuCustomLabel8.TabIndex = 20;
            this.bunifuCustomLabel8.Text = "Dirección";
            // 
            // TextDir
            // 
            this.TextDir.Enabled = false;
            this.TextDir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDir.Location = new System.Drawing.Point(536, 321);
            this.TextDir.Multiline = true;
            this.TextDir.Name = "TextDir";
            this.TextDir.Size = new System.Drawing.Size(239, 26);
            this.TextDir.TabIndex = 21;
            // 
            // TextDate
            // 
            this.TextDate.Enabled = false;
            this.TextDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDate.Location = new System.Drawing.Point(536, 385);
            this.TextDate.Multiline = true;
            this.TextDate.Name = "TextDate";
            this.TextDate.Size = new System.Drawing.Size(239, 26);
            this.TextDate.TabIndex = 23;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(534, 364);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(176, 18);
            this.bunifuCustomLabel9.TabIndex = 22;
            this.bunifuCustomLabel9.Text = "Fecha de Nacimiento";
            // 
            // TextPhone
            // 
            this.TextPhone.Enabled = false;
            this.TextPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPhone.Location = new System.Drawing.Point(535, 448);
            this.TextPhone.Multiline = true;
            this.TextPhone.Name = "TextPhone";
            this.TextPhone.Size = new System.Drawing.Size(239, 26);
            this.TextPhone.TabIndex = 25;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(533, 427);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(77, 18);
            this.bunifuCustomLabel10.TabIndex = 24;
            this.bunifuCustomLabel10.Text = "Teléfono";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(351, 189);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(46, 18);
            this.bunifuCustomLabel11.TabIndex = 26;
            this.bunifuCustomLabel11.Text = "Date";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(260, 189);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(85, 18);
            this.bunifuCustomLabel12.TabIndex = 27;
            this.bunifuCustomLabel12.Text = "Dirección";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(419, 189);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(77, 18);
            this.bunifuCustomLabel13.TabIndex = 28;
            this.bunifuCustomLabel13.Text = "Teléfono";
            // 
            // Form_Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(803, 567);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.TextPhone);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.TextDate);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.TextDir);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.TextApellido);
            this.Controls.Add(this.TextNombre);
            this.Controls.Add(this.TextCode);
            this.Controls.Add(this.btnGuardarContacto);
            this.Controls.Add(this.btnEliminarContacto);
            this.Controls.Add(this.btnEditarContacto);
            this.Controls.Add(this.btnAddContacto);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.TablaContactos);
            this.Controls.Add(this.BuscarContacto);
            this.Controls.Add(this.TextBuscar);
            this.Controls.Add(this.PanelTopFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Presentacion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Presentacion_Load);
            this.PanelTopFormulario.ResumeLayout(false);
            this.PanelTopFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopFormulario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ExitPresentacion;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl MoverFormulario;
        private System.Windows.Forms.TextBox TextBuscar;
        private System.Windows.Forms.PictureBox BuscarContacto;
        private System.Windows.Forms.DataGridView TablaContactos;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddContacto;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditarContacto;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarContacto;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarContacto;
        private System.Windows.Forms.TextBox TextCode;
        private System.Windows.Forms.TextBox TextNombre;
        private System.Windows.Forms.TextBox TextApellido;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.TextBox TextDir;
        private System.Windows.Forms.TextBox TextDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.TextBox TextPhone;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
    }
}

