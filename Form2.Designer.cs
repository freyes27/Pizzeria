namespace Pizzeria
{
    partial class Menupizza
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BotonFamiliar = new System.Windows.Forms.RadioButton();
            this.BotonMediana = new System.Windows.Forms.RadioButton();
            this.BotonIndividual = new System.Windows.Forms.RadioButton();
            this.BotonBebida1 = new System.Windows.Forms.RadioButton();
            this.BotonBebida2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Cajapizza = new System.Windows.Forms.TextBox();
            this.Cajabebida = new System.Windows.Forms.TextBox();
            this.BotonPedido = new System.Windows.Forms.Button();
            this.BotonCerrarCja = new System.Windows.Forms.Button();
            this.Pedidos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BotonIndividual);
            this.groupBox1.Controls.Add(this.BotonMediana);
            this.groupBox1.Controls.Add(this.BotonFamiliar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(73, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizzas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BotonBebida2);
            this.groupBox2.Controls.Add(this.BotonBebida1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(485, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bebidas";
            // 
            // BotonFamiliar
            // 
            this.BotonFamiliar.AutoSize = true;
            this.BotonFamiliar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonFamiliar.Location = new System.Drawing.Point(67, 25);
            this.BotonFamiliar.Name = "BotonFamiliar";
            this.BotonFamiliar.Size = new System.Drawing.Size(160, 24);
            this.BotonFamiliar.TabIndex = 0;
            this.BotonFamiliar.TabStop = true;
            this.BotonFamiliar.Text = "Familiar $20.000";
            this.BotonFamiliar.UseVisualStyleBackColor = false;
            this.BotonFamiliar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // BotonMediana
            // 
            this.BotonMediana.AutoSize = true;
            this.BotonMediana.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BotonMediana.Location = new System.Drawing.Point(67, 84);
            this.BotonMediana.Name = "BotonMediana";
            this.BotonMediana.Size = new System.Drawing.Size(165, 24);
            this.BotonMediana.TabIndex = 1;
            this.BotonMediana.TabStop = true;
            this.BotonMediana.Text = "Mediana $12.000";
            this.BotonMediana.UseVisualStyleBackColor = false;
            // 
            // BotonIndividual
            // 
            this.BotonIndividual.AutoSize = true;
            this.BotonIndividual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonIndividual.Location = new System.Drawing.Point(67, 139);
            this.BotonIndividual.Name = "BotonIndividual";
            this.BotonIndividual.Size = new System.Drawing.Size(163, 24);
            this.BotonIndividual.TabIndex = 2;
            this.BotonIndividual.TabStop = true;
            this.BotonIndividual.Text = "Individual $8.000";
            this.BotonIndividual.UseVisualStyleBackColor = false;
            // 
            // BotonBebida1
            // 
            this.BotonBebida1.AutoSize = true;
            this.BotonBebida1.Location = new System.Drawing.Point(55, 35);
            this.BotonBebida1.Name = "BotonBebida1";
            this.BotonBebida1.Size = new System.Drawing.Size(163, 24);
            this.BotonBebida1.TabIndex = 0;
            this.BotonBebida1.TabStop = true;
            this.BotonBebida1.Text = "Individual $1.500";
            this.BotonBebida1.UseVisualStyleBackColor = true;
            this.BotonBebida1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // BotonBebida2
            // 
            this.BotonBebida2.AutoSize = true;
            this.BotonBebida2.Location = new System.Drawing.Point(56, 119);
            this.BotonBebida2.Name = "BotonBebida2";
            this.BotonBebida2.Size = new System.Drawing.Size(150, 24);
            this.BotonBebida2.TabIndex = 1;
            this.BotonBebida2.TabStop = true;
            this.BotonBebida2.Text = "Familiar $5.000";
            this.BotonBebida2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pizza Hat Spa";
            // 
            // Cajapizza
            // 
            this.Cajapizza.Location = new System.Drawing.Point(345, 116);
            this.Cajapizza.Name = "Cajapizza";
            this.Cajapizza.Size = new System.Drawing.Size(37, 20);
            this.Cajapizza.TabIndex = 5;
            // 
            // Cajabebida
            // 
            this.Cajabebida.Location = new System.Drawing.Point(423, 116);
            this.Cajabebida.Name = "Cajabebida";
            this.Cajabebida.Size = new System.Drawing.Size(35, 20);
            this.Cajabebida.TabIndex = 3;
            // 
            // BotonPedido
            // 
            this.BotonPedido.Location = new System.Drawing.Point(114, 222);
            this.BotonPedido.Name = "BotonPedido";
            this.BotonPedido.Size = new System.Drawing.Size(191, 38);
            this.BotonPedido.TabIndex = 3;
            this.BotonPedido.Text = "AgregarPedido";
            this.BotonPedido.UseVisualStyleBackColor = true;
            this.BotonPedido.Click += new System.EventHandler(this.BotonPedido_Click);
            // 
            // BotonCerrarCja
            // 
            this.BotonCerrarCja.Location = new System.Drawing.Point(512, 222);
            this.BotonCerrarCja.Name = "BotonCerrarCja";
            this.BotonCerrarCja.Size = new System.Drawing.Size(191, 39);
            this.BotonCerrarCja.TabIndex = 4;
            this.BotonCerrarCja.Text = "CerrarCaja";
            this.BotonCerrarCja.UseVisualStyleBackColor = true;
            this.BotonCerrarCja.Click += new System.EventHandler(this.BotonCerrarCja_Click);
            // 
            // Pedidos
            // 
            this.Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.Pedidos.Location = new System.Drawing.Point(140, 267);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(545, 171);
            this.Pedidos.TabIndex = 5;
            this.Pedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pedidos_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cantidad";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Pizza";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CantidadBebida";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Bebidas";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad";
            // 
            // Menupizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cajabebida);
            this.Controls.Add(this.Cajapizza);
            this.Controls.Add(this.Pedidos);
            this.Controls.Add(this.BotonCerrarCja);
            this.Controls.Add(this.BotonPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menupizza";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BotonFamiliar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton BotonIndividual;
        private System.Windows.Forms.RadioButton BotonMediana;
        private System.Windows.Forms.RadioButton BotonBebida2;
        private System.Windows.Forms.RadioButton BotonBebida1;
        private System.Windows.Forms.TextBox Cajapizza;
        private System.Windows.Forms.TextBox Cajabebida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonPedido;
        private System.Windows.Forms.Button BotonCerrarCja;
        private System.Windows.Forms.DataGridView Pedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}