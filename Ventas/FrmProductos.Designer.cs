namespace Ventas
{
    partial class FrmProductos
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
            DgvProductos = new DataGridView();
            TxtBusquedaProductos = new TextBox();
            TxtSKUProductos = new TextBox();
            TxtDescripcionProductos = new TextBox();
            TxtValUProductos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnBusquedaProductos = new Button();
            BtnNuevoProductos = new Button();
            BtnEditarProductos = new Button();
            BtnEliminarProductos = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvProductos).BeginInit();
            SuspendLayout();
            // 
            // DgvProductos
            // 
            DgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProductos.Location = new Point(3, 48);
            DgvProductos.Name = "DgvProductos";
            DgvProductos.Size = new Size(793, 256);
            DgvProductos.TabIndex = 0;
            // 
            // TxtBusquedaProductos
            // 
            TxtBusquedaProductos.Location = new Point(22, 17);
            TxtBusquedaProductos.Name = "TxtBusquedaProductos";
            TxtBusquedaProductos.Size = new Size(463, 23);
            TxtBusquedaProductos.TabIndex = 1;
            // 
            // TxtSKUProductos
            // 
            TxtSKUProductos.Location = new Point(95, 326);
            TxtSKUProductos.Name = "TxtSKUProductos";
            TxtSKUProductos.Size = new Size(463, 23);
            TxtSKUProductos.TabIndex = 2;
            // 
            // TxtDescripcionProductos
            // 
            TxtDescripcionProductos.Location = new Point(95, 355);
            TxtDescripcionProductos.Name = "TxtDescripcionProductos";
            TxtDescripcionProductos.Size = new Size(463, 23);
            TxtDescripcionProductos.TabIndex = 3;
            // 
            // TxtValUProductos
            // 
            TxtValUProductos.Location = new Point(95, 384);
            TxtValUProductos.Name = "TxtValUProductos";
            TxtValUProductos.Size = new Size(463, 23);
            TxtValUProductos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 328);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 5;
            label1.Text = "SKU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 358);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 387);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 7;
            label3.Text = "Valor unitario";
            // 
            // BtnBusquedaProductos
            // 
            BtnBusquedaProductos.Location = new Point(535, 19);
            BtnBusquedaProductos.Name = "BtnBusquedaProductos";
            BtnBusquedaProductos.Size = new Size(75, 23);
            BtnBusquedaProductos.TabIndex = 8;
            BtnBusquedaProductos.Text = "Busqueda";
            BtnBusquedaProductos.UseVisualStyleBackColor = true;
            BtnBusquedaProductos.Click += BtnBusquedaProductos_Click;
            // 
            // BtnNuevoProductos
            // 
            BtnNuevoProductos.Location = new Point(611, 331);
            BtnNuevoProductos.Name = "BtnNuevoProductos";
            BtnNuevoProductos.Size = new Size(75, 23);
            BtnNuevoProductos.TabIndex = 9;
            BtnNuevoProductos.Text = "Agregar";
            BtnNuevoProductos.UseVisualStyleBackColor = true;
            BtnNuevoProductos.Click += BtnNuevoProductos_Click;
            // 
            // BtnEditarProductos
            // 
            BtnEditarProductos.Location = new Point(611, 360);
            BtnEditarProductos.Name = "BtnEditarProductos";
            BtnEditarProductos.Size = new Size(75, 23);
            BtnEditarProductos.TabIndex = 10;
            BtnEditarProductos.Text = "Editar";
            BtnEditarProductos.UseVisualStyleBackColor = true;
            BtnEditarProductos.Click += BtnEditarProductos_Click;
            // 
            // BtnEliminarProductos
            // 
            BtnEliminarProductos.Location = new Point(611, 389);
            BtnEliminarProductos.Name = "BtnEliminarProductos";
            BtnEliminarProductos.Size = new Size(75, 23);
            BtnEliminarProductos.TabIndex = 11;
            BtnEliminarProductos.Text = "Eliminar";
            BtnEliminarProductos.UseVisualStyleBackColor = true;
            BtnEliminarProductos.Click += BtnEliminarProductos_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEliminarProductos);
            Controls.Add(BtnEditarProductos);
            Controls.Add(BtnNuevoProductos);
            Controls.Add(BtnBusquedaProductos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtValUProductos);
            Controls.Add(TxtDescripcionProductos);
            Controls.Add(TxtSKUProductos);
            Controls.Add(TxtBusquedaProductos);
            Controls.Add(DgvProductos);
            Name = "FrmProductos";
            Text = "FrmProductos";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)DgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvProductos;
        private TextBox TxtBusquedaProductos;
        private TextBox TxtSKUProductos;
        private TextBox TxtDescripcionProductos;
        private TextBox TxtValUProductos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnBusquedaProductos;
        private Button BtnNuevoProductos;
        private Button BtnEditarProductos;
        private Button BtnEliminarProductos;
    }
}