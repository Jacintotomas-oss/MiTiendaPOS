namespace MiTiendaPOS.Forms
{
    partial class FrmVentas
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
            grpEncabezado = new GroupBox();
            lblVenta = new Label();
            cboUsuario = new ComboBox();
            cboCliente = new ComboBox();
            lblUsuario = new Label();
            lblCliente = new Label();
            grpHistorial = new GroupBox();
            dgvVentas = new DataGridView();
            groupBox1 = new GroupBox();
            lblTotal = new Label();
            dgvDetalle = new DataGridView();
            btnQuitar = new Button();
            btnAgregar = new Button();
            nudCantidad = new NumericUpDown();
            lblCantidad = new Label();
            cboProducto = new ComboBox();
            lblProducto = new Label();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNueva = new Button();
            grpEncabezado.SuspendLayout();
            grpHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // grpEncabezado
            // 
            grpEncabezado.Controls.Add(lblVenta);
            grpEncabezado.Controls.Add(cboUsuario);
            grpEncabezado.Controls.Add(cboCliente);
            grpEncabezado.Controls.Add(lblUsuario);
            grpEncabezado.Controls.Add(lblCliente);
            grpEncabezado.Location = new Point(12, 37);
            grpEncabezado.Name = "grpEncabezado";
            grpEncabezado.Size = new Size(504, 100);
            grpEncabezado.TabIndex = 0;
            grpEncabezado.TabStop = false;
            grpEncabezado.Text = "Encabezado de la venta";
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVenta.Location = new Point(24, 67);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(76, 15);
            lblVenta.TabIndex = 4;
            lblVenta.Text = "Venta nueva";
            // 
            // cboUsuario
            // 
            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Location = new Point(321, 27);
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(155, 23);
            cboUsuario.TabIndex = 3;
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(76, 27);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(184, 23);
            cboCliente.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(266, 30);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(49, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(24, 30);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(46, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // grpHistorial
            // 
            grpHistorial.Controls.Add(dgvVentas);
            grpHistorial.Location = new Point(522, 37);
            grpHistorial.Name = "grpHistorial";
            grpHistorial.Size = new Size(266, 401);
            grpHistorial.TabIndex = 1;
            grpHistorial.TabStop = false;
            grpHistorial.Text = "Historial de Ventas";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(6, 30);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(254, 353);
            dgvVentas.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(dgvDetalle);
            groupBox1.Controls.Add(btnQuitar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(nudCantidad);
            groupBox1.Controls.Add(lblCantidad);
            groupBox1.Controls.Add(cboProducto);
            groupBox1.Controls.Add(lblProducto);
            groupBox1.Location = new Point(12, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(504, 295);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de productos";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(403, 262);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(71, 15);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total: $0.00";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(24, 98);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(452, 161);
            dgvDetalle.TabIndex = 8;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(24, 258);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(75, 23);
            btnQuitar.TabIndex = 7;
            btnQuitar.Text = "quitar linea";
            btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(354, 69);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(354, 40);
            nudCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 5;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(293, 43);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad";
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(88, 40);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(184, 23);
            cboProducto.TabIndex = 3;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(24, 43);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(58, 15);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "producto";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(351, 434);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(123, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar Venta";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(199, 434);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 23);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar venta";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(36, 434);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(108, 23);
            btnNueva.TabIndex = 13;
            btnNueva.Text = "Nueva Venta";
            btnNueva.UseVisualStyleBackColor = true;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 469);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNueva);
            Controls.Add(groupBox1);
            Controls.Add(grpHistorial);
            Controls.Add(grpEncabezado);
            Name = "FrmVentas";
            Text = "FrmVentas";
            grpEncabezado.ResumeLayout(false);
            grpEncabezado.PerformLayout();
            grpHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEncabezado;
        private Label lblUsuario;
        private Label lblCliente;
        private GroupBox grpHistorial;
        private Label lblVenta;
        private ComboBox cboUsuario;
        private ComboBox cboCliente;
        private GroupBox groupBox1;
        private Label lblProducto;
        private ComboBox cboProducto;
        private Button btnAgregar;
        private NumericUpDown nudCantidad;
        private Label lblCantidad;
        private Button btnQuitar;
        private DataGridView dgvVentas;
        private DataGridView dgvDetalle;
        private Label lblTotal;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNueva;
    }
}