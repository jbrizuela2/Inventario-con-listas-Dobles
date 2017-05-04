namespace Inventario
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
            if (disposing && (components != null)) {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.txtBorrar = new System.Windows.Forms.TextBox();
            this.btnAgregarPrimero = new System.Windows.Forms.Button();
            this.btnReporteInverso = new System.Windows.Forms.Button();
            this.btnEliminarUltimo = new System.Windows.Forms.Button();
            this.btnEliminarPrimero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(67, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(67, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(67, 64);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(67, 87);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(188, 18);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.Size = new System.Drawing.Size(167, 273);
            this.txtReporte.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 123);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(15, 152);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(15, 210);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(15, 181);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 11;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(15, 268);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 13;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(96, 212);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(71, 20);
            this.txtBuscar.TabIndex = 14;
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(96, 184);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(71, 20);
            this.txtPosicion.TabIndex = 15;
            // 
            // txtBorrar
            // 
            this.txtBorrar.Location = new System.Drawing.Point(96, 154);
            this.txtBorrar.Name = "txtBorrar";
            this.txtBorrar.Size = new System.Drawing.Size(71, 20);
            this.txtBorrar.TabIndex = 16;
            // 
            // btnAgregarPrimero
            // 
            this.btnAgregarPrimero.Location = new System.Drawing.Point(96, 123);
            this.btnAgregarPrimero.Name = "btnAgregarPrimero";
            this.btnAgregarPrimero.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPrimero.TabIndex = 17;
            this.btnAgregarPrimero.Text = "A.Primero";
            this.btnAgregarPrimero.UseVisualStyleBackColor = true;
            this.btnAgregarPrimero.Click += new System.EventHandler(this.btnAgregarPrimero_Click);
            // 
            // btnReporteInverso
            // 
            this.btnReporteInverso.Location = new System.Drawing.Point(96, 268);
            this.btnReporteInverso.Name = "btnReporteInverso";
            this.btnReporteInverso.Size = new System.Drawing.Size(75, 23);
            this.btnReporteInverso.TabIndex = 18;
            this.btnReporteInverso.Text = "Reporte";
            this.btnReporteInverso.UseVisualStyleBackColor = true;
            this.btnReporteInverso.Click += new System.EventHandler(this.btnReporteInverso_Click);
            // 
            // btnEliminarUltimo
            // 
            this.btnEliminarUltimo.Location = new System.Drawing.Point(96, 239);
            this.btnEliminarUltimo.Name = "btnEliminarUltimo";
            this.btnEliminarUltimo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUltimo.TabIndex = 20;
            this.btnEliminarUltimo.Text = "E.Ultimo";
            this.btnEliminarUltimo.UseVisualStyleBackColor = true;
            this.btnEliminarUltimo.Click += new System.EventHandler(this.btnEliminarUltimo_Click);
            // 
            // btnEliminarPrimero
            // 
            this.btnEliminarPrimero.Location = new System.Drawing.Point(15, 239);
            this.btnEliminarPrimero.Name = "btnEliminarPrimero";
            this.btnEliminarPrimero.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPrimero.TabIndex = 19;
            this.btnEliminarPrimero.Text = "E.Primero";
            this.btnEliminarPrimero.UseVisualStyleBackColor = true;
            this.btnEliminarPrimero.Click += new System.EventHandler(this.btnEliminarPrimero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 307);
            this.Controls.Add(this.btnEliminarUltimo);
            this.Controls.Add(this.btnEliminarPrimero);
            this.Controls.Add(this.btnReporteInverso);
            this.Controls.Add(this.btnAgregarPrimero);
            this.Controls.Add(this.txtBorrar);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.TextBox txtBorrar;
        private System.Windows.Forms.Button btnAgregarPrimero;
        private System.Windows.Forms.Button btnReporteInverso;
        private System.Windows.Forms.Button btnEliminarUltimo;
        private System.Windows.Forms.Button btnEliminarPrimero;
    }
}

