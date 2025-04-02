namespace LoginCadastro
{
    partial class cadastro
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
            gbcadastro = new GroupBox();
            txtUserCadastro = new TextBox();
            txtSenhaCadastro = new TextBox();
            label2 = new Label();
            lblUsuarioCadastro = new Label();
            btnCadastro = new Button();
            gbcadastro.SuspendLayout();
            SuspendLayout();
            // 
            // gbcadastro
            // 
            gbcadastro.Controls.Add(txtUserCadastro);
            gbcadastro.Controls.Add(txtSenhaCadastro);
            gbcadastro.Controls.Add(label2);
            gbcadastro.Controls.Add(lblUsuarioCadastro);
            gbcadastro.Controls.Add(btnCadastro);
            gbcadastro.Location = new Point(51, 40);
            gbcadastro.Name = "gbcadastro";
            gbcadastro.Size = new Size(496, 394);
            gbcadastro.TabIndex = 0;
            gbcadastro.TabStop = false;
            gbcadastro.Text = "Cadastro";
            // 
            // txtUserCadastro
            // 
            txtUserCadastro.Location = new Point(156, 90);
            txtUserCadastro.Name = "txtUserCadastro";
            txtUserCadastro.Size = new Size(259, 35);
            txtUserCadastro.TabIndex = 1;
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.Location = new Point(156, 173);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.PasswordChar = '•';
            txtSenhaCadastro.Size = new Size(259, 35);
            txtSenhaCadastro.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 175);
            label2.Name = "label2";
            label2.Size = new Size(70, 29);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // lblUsuarioCadastro
            // 
            lblUsuarioCadastro.AutoSize = true;
            lblUsuarioCadastro.Location = new Point(65, 93);
            lblUsuarioCadastro.Name = "lblUsuarioCadastro";
            lblUsuarioCadastro.Size = new Size(81, 29);
            lblUsuarioCadastro.TabIndex = 1;
            lblUsuarioCadastro.Text = "Usuario";
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(202, 252);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(129, 46);
            btnCadastro.TabIndex = 0;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // cadastro
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 471);
            Controls.Add(gbcadastro);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cadastro";
            gbcadastro.ResumeLayout(false);
            gbcadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbcadastro;
        private TextBox txtUserCadastro;
        private TextBox txtSenhaCadastro;
        private Label label2;
        private Label lblUsuarioCadastro;
        private Button btnCadastro;
    }
}