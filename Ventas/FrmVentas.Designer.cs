namespace Ventas
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
            DgvVentas = new DataGridView();
            TxtBusquedaVentas = new TextBox();
            btnBuscarVentas = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtFechaVentas = new TextBox();
            TxtFolioVentas = new TextBox();
            TxtTotalVentas = new TextBox();
            TxtClienteVentas = new TextBox();
            BtnNuevoVentas = new Button();
            BtnEditarVentas = new Button();
            BtnEliminarVentas = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvVentas).BeginInit();
            SuspendLayout();
            // 
            // DgvVentas
            // 
            DgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvVentas.Location = new Point(3, 61);
            DgvVentas.Name = "DgvVentas";
            DgvVentas.Size = new Size(796, 244);
            DgvVentas.TabIndex = 0;
            // 
            // TxtBusquedaVentas
            // 
            TxtBusquedaVentas.Location = new Point(36, 17);
            TxtBusquedaVentas.Name = "TxtBusquedaVentas";
            TxtBusquedaVentas.Size = new Size(442, 23);
            TxtBusquedaVentas.TabIndex = 1;
            // 
            // btnBuscarVentas
            // 
            btnBuscarVentas.Location = new Point(518, 17);
            btnBuscarVentas.Name = "btnBuscarVentas";
            btnBuscarVentas.Size = new Size(75, 23);
            btnBuscarVentas.TabIndex = 2;
            btnBuscarVentas.Text = "Buscar";
            btnBuscarVentas.UseVisualStyleBackColor = true;
            btnBuscarVentas.Click += btnBuscarVentas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 322);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "Fecha";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 351);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Folio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 381);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 3;
            label3.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 413);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Cliente";
            // 
            // TxtFechaVentas
            // 
            TxtFechaVentas.Location = new Point(47, 319);
            TxtFechaVentas.Name = "TxtFechaVentas";
            TxtFechaVentas.Size = new Size(442, 23);
            TxtFechaVentas.TabIndex = 1;
            // 
            // TxtFolioVentas
            // 
            TxtFolioVentas.Location = new Point(47, 348);
            TxtFolioVentas.Name = "TxtFolioVentas";
            TxtFolioVentas.Size = new Size(442, 23);
            TxtFolioVentas.TabIndex = 1;
            // 
            // TxtTotalVentas
            // 
            TxtTotalVentas.Location = new Point(47, 378);
            TxtTotalVentas.Name = "TxtTotalVentas";
            TxtTotalVentas.Size = new Size(442, 23);
            TxtTotalVentas.TabIndex = 1;
            // 
            // TxtClienteVentas
            // 
            TxtClienteVentas.Location = new Point(47, 410);
            TxtClienteVentas.Name = "TxtClienteVentas";
            TxtClienteVentas.Size = new Size(442, 23);
            TxtClienteVentas.TabIndex = 1;
            // 
            // BtnNuevoVentas
            // 
            BtnNuevoVentas.Location = new Point(572, 325);
            BtnNuevoVentas.Name = "BtnNuevoVentas";
            BtnNuevoVentas.Size = new Size(75, 23);
            BtnNuevoVentas.TabIndex = 4;
            BtnNuevoVentas.Text = "Agregar";
            BtnNuevoVentas.UseVisualStyleBackColor = true;
            BtnNuevoVentas.Click += BtnNuevoVentas_Click;
            // 
            // BtnEditarVentas
            // 
            BtnEditarVentas.Location = new Point(572, 354);
            BtnEditarVentas.Name = "BtnEditarVentas";
            BtnEditarVentas.Size = new Size(75, 23);
            BtnEditarVentas.TabIndex = 4;
            BtnEditarVentas.Text = "Editar";
            BtnEditarVentas.UseVisualStyleBackColor = true;
            BtnEditarVentas.Click += button2_Click;
            // 
            // BtnEliminarVentas
            // 
            BtnEliminarVentas.Location = new Point(572, 383);
            BtnEliminarVentas.Name = "BtnEliminarVentas";
            BtnEliminarVentas.Size = new Size(75, 23);
            BtnEliminarVentas.TabIndex = 5;
            BtnEliminarVentas.Text = "Eliminar";
            BtnEliminarVentas.UseVisualStyleBackColor = true;
            BtnEliminarVentas.Click += BtnEliminarVentas_Click;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(BtnEliminarVentas);
            Controls.Add(BtnEditarVentas);
            Controls.Add(BtnNuevoVentas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBuscarVentas);
            Controls.Add(TxtClienteVentas);
            Controls.Add(TxtTotalVentas);
            Controls.Add(TxtFolioVentas);
            Controls.Add(TxtFechaVentas);
            Controls.Add(TxtBusquedaVentas);
            Controls.Add(DgvVentas);
            Name = "FrmVentas";
            Text = "FrmVentas";
            Load += FrmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)DgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvVentas;
        private TextBox TxtBusquedaVentas;
        private Button btnBuscarVentas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtFechaVentas;
        private TextBox TxtFolioVentas;
        private TextBox TxtTotalVentas;
        private TextBox TxtClienteVentas;
        private Button BtnNuevoVentas;
        private Button BtnEditarVentas;
        private Button BtnEliminarVentas;
    }
}