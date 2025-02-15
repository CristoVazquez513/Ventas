namespace Ventas
{
    partial class FrmClientes
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
            DgvClientes = new DataGridView();
            TxtBusquedaClientes = new TextBox();
            TxtNombreClientes = new TextBox();
            TxtTelefonoClientes = new TextBox();
            TxtDomicilioClientes = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnBusquedaClientes = new Button();
            BtnNuevoClientes = new Button();
            BtnEditarClientes = new Button();
            BtnEliminarClientes = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvClientes).BeginInit();
            SuspendLayout();
            // 
            // DgvClientes
            // 
            DgvClientes.AllowUserToAddRows = false;
            DgvClientes.AllowUserToDeleteRows = false;
            DgvClientes.AllowUserToResizeColumns = false;
            DgvClientes.AllowUserToResizeRows = false;
            DgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvClientes.Location = new Point(2, 52);
            DgvClientes.Name = "DgvClientes";
            DgvClientes.Size = new Size(797, 204);
            DgvClientes.TabIndex = 0;
            // 
            // TxtBusquedaClientes
            // 
            TxtBusquedaClientes.Location = new Point(95, 23);
            TxtBusquedaClientes.Name = "TxtBusquedaClientes";
            TxtBusquedaClientes.Size = new Size(357, 23);
            TxtBusquedaClientes.TabIndex = 1;
            // 
            // TxtNombreClientes
            // 
            TxtNombreClientes.Location = new Point(95, 289);
            TxtNombreClientes.Name = "TxtNombreClientes";
            TxtNombreClientes.Size = new Size(357, 23);
            TxtNombreClientes.TabIndex = 2;
            // 
            // TxtTelefonoClientes
            // 
            TxtTelefonoClientes.Location = new Point(95, 331);
            TxtTelefonoClientes.Name = "TxtTelefonoClientes";
            TxtTelefonoClientes.Size = new Size(357, 23);
            TxtTelefonoClientes.TabIndex = 3;
            // 
            // TxtDomicilioClientes
            // 
            TxtDomicilioClientes.Location = new Point(95, 374);
            TxtDomicilioClientes.Name = "TxtDomicilioClientes";
            TxtDomicilioClientes.Size = new Size(357, 23);
            TxtDomicilioClientes.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 292);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 334);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 6;
            label2.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 377);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Domicilio";
            // 
            // BtnBusquedaClientes
            // 
            BtnBusquedaClientes.Location = new Point(521, 22);
            BtnBusquedaClientes.Name = "BtnBusquedaClientes";
            BtnBusquedaClientes.Size = new Size(75, 23);
            BtnBusquedaClientes.TabIndex = 8;
            BtnBusquedaClientes.Text = "Busqueda";
            BtnBusquedaClientes.UseVisualStyleBackColor = true;
            BtnBusquedaClientes.Click += BtnBusquedaClientes_Click;
            // 
            // BtnNuevoClientes
            // 
            BtnNuevoClientes.Location = new Point(521, 289);
            BtnNuevoClientes.Name = "BtnNuevoClientes";
            BtnNuevoClientes.Size = new Size(75, 23);
            BtnNuevoClientes.TabIndex = 9;
            BtnNuevoClientes.Text = "Agregar";
            BtnNuevoClientes.UseVisualStyleBackColor = true;
            BtnNuevoClientes.Click += BtnNuevoClientes_Click;
            // 
            // BtnEditarClientes
            // 
            BtnEditarClientes.Location = new Point(521, 330);
            BtnEditarClientes.Name = "BtnEditarClientes";
            BtnEditarClientes.Size = new Size(75, 23);
            BtnEditarClientes.TabIndex = 10;
            BtnEditarClientes.Text = "Editar";
            BtnEditarClientes.UseVisualStyleBackColor = true;
            BtnEditarClientes.Click += BtnEditarClientes_Click;
            // 
            // BtnEliminarClientes
            // 
            BtnEliminarClientes.Location = new Point(521, 374);
            BtnEliminarClientes.Name = "BtnEliminarClientes";
            BtnEliminarClientes.Size = new Size(75, 23);
            BtnEliminarClientes.TabIndex = 11;
            BtnEliminarClientes.Text = "Eliminar";
            BtnEliminarClientes.UseVisualStyleBackColor = true;
            BtnEliminarClientes.Click += BtnEliminarClientes_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEliminarClientes);
            Controls.Add(BtnEditarClientes);
            Controls.Add(BtnNuevoClientes);
            Controls.Add(BtnBusquedaClientes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtDomicilioClientes);
            Controls.Add(TxtTelefonoClientes);
            Controls.Add(TxtNombreClientes);
            Controls.Add(TxtBusquedaClientes);
            Controls.Add(DgvClientes);
            Name = "FrmClientes";
            Text = "FrmClientes";
            ((System.ComponentModel.ISupportInitialize)DgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvClientes;
        private TextBox TxtBusquedaClientes;
        private TextBox TxtNombreClientes;
        private TextBox TxtTelefonoClientes;
        private TextBox TxtDomicilioClientes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnBusquedaClientes;
        private Button BtnNuevoClientes;
        private Button BtnEditarClientes;
        private Button BtnEliminarClientes;
    }
}