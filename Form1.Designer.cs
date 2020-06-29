namespace Pizzeria
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CuadroUsuario = new System.Windows.Forms.TextBox();
            this.CuadroContra = new System.Windows.Forms.TextBox();
            this.BotonIngreso = new System.Windows.Forms.Button();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Pizzeria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTRASEÑA";
            // 
            // CuadroUsuario
            // 
            this.CuadroUsuario.Location = new System.Drawing.Point(240, 147);
            this.CuadroUsuario.Name = "CuadroUsuario";
            this.CuadroUsuario.Size = new System.Drawing.Size(202, 20);
            this.CuadroUsuario.TabIndex = 3;
            // 
            // CuadroContra
            // 
            this.CuadroContra.Location = new System.Drawing.Point(240, 204);
            this.CuadroContra.Name = "CuadroContra";
            this.CuadroContra.PasswordChar = '#';
            this.CuadroContra.Size = new System.Drawing.Size(201, 20);
            this.CuadroContra.TabIndex = 4;
            this.CuadroContra.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BotonIngreso
            // 
            this.BotonIngreso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonIngreso.Location = new System.Drawing.Point(453, 281);
            this.BotonIngreso.Name = "BotonIngreso";
            this.BotonIngreso.Size = new System.Drawing.Size(75, 28);
            this.BotonIngreso.TabIndex = 5;
            this.BotonIngreso.Text = "Ingresar";
            this.BotonIngreso.UseVisualStyleBackColor = false;
            this.BotonIngreso.Click += new System.EventHandler(this.BotonIngreso_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BotonCerrar.Location = new System.Drawing.Point(565, 281);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(73, 28);
            this.BotonCerrar.TabIndex = 6;
            this.BotonCerrar.Text = "Cerrar";
            this.BotonCerrar.UseVisualStyleBackColor = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Que disfrute su pizza!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.BotonIngreso);
            this.Controls.Add(this.CuadroContra);
            this.Controls.Add(this.CuadroUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CuadroUsuario;
        private System.Windows.Forms.TextBox CuadroContra;
        private System.Windows.Forms.Button BotonIngreso;
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.Label label4;
    }
}

