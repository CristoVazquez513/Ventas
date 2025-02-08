namespace Ventas
{
    partial class FrmPrincipal
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
            BtnClientes = new Button();
            BtnVentas = new Button();
            BtnProductos = new Button();
            SuspendLayout();
            // 
            // BtnClientes
            // 
            BtnClientes.Location = new Point(104, 41);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(97, 86);
            BtnClientes.TabIndex = 0;
            BtnClientes.Text = "Clientes";
            BtnClientes.UseVisualStyleBackColor = true;
            BtnClientes.Click += BtnClientes_Click;
            // 
            // BtnVentas
            // 
            BtnVentas.Location = new Point(415, 41);
            BtnVentas.Name = "BtnVentas";
            BtnVentas.Size = new Size(97, 86);
            BtnVentas.TabIndex = 0;
            BtnVentas.Text = "Ventas";
            BtnVentas.UseVisualStyleBackColor = true;
            BtnVentas.Click += BtnVentas_Click;
            // 
            // BtnProductos
            // 
            BtnProductos.Location = new Point(259, 41);
            BtnProductos.Name = "BtnProductos";
            BtnProductos.Size = new Size(97, 86);
            BtnProductos.TabIndex = 0;
            BtnProductos.Text = "Productos";
            BtnProductos.UseVisualStyleBackColor = true;
            BtnProductos.Click += BtnProductos_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnProductos);
            Controls.Add(BtnVentas);
            Controls.Add(BtnClientes);
            Name = "FrmPrincipal";
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnClientes;
        private Button BtnVentas;
        private Button BtnProductos;
    }
}