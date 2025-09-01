namespace pryBarbero_Sinterpart
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblContraseña = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label3 = new Label();
            cmbModulo = new ComboBox();
            lblModulo = new Label();
            label5 = new Label();
            label6 = new Label();
            lblSinterpart = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(52, 98);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(42, 161);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.White;
            btnAceptar.Location = new Point(315, 120);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(121, 32);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Location = new Point(317, 193);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 32);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = Color.Blue;
            txtUsuario.Location = new Point(115, 95);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(121, 23);
            txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.ForeColor = Color.Blue;
            txtContraseña.Location = new Point(115, 158);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(121, 23);
            txtContraseña.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // cmbModulo
            // 
            cmbModulo.FormattingEnabled = true;
            cmbModulo.Items.AddRange(new object[] { "ADM ", "SIST ", "COM ", "VTA" });
            cmbModulo.Location = new Point(115, 219);
            cmbModulo.Name = "cmbModulo";
            cmbModulo.Size = new Size(121, 23);
            cmbModulo.TabIndex = 8;
            cmbModulo.SelectedIndexChanged += cmbModulo_SelectedIndexChanged;
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(44, 222);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(49, 15);
            lblModulo.TabIndex = 9;
            lblModulo.Text = "Modulo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 32);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 40);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 11;
            // 
            // lblSinterpart
            // 
            lblSinterpart.AutoSize = true;
            lblSinterpart.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSinterpart.Location = new Point(12, 21);
            lblSinterpart.Name = "lblSinterpart";
            lblSinterpart.Size = new Size(150, 28);
            lblSinterpart.TabIndex = 12;
            lblSinterpart.Text = "SinterPart S.R.L";
            lblSinterpart.Click += lblSinterpart_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(522, 318);
            Controls.Add(lblSinterpart);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblModulo);
            Controls.Add(cmbModulo);
            Controls.Add(label3);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Name = "frmLogin";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label3;
        private ComboBox cmbModulo;
        private Label lblModulo;
        private Label label5;
        private Label label6;
        private Label lblSinterpart;
    }
}
