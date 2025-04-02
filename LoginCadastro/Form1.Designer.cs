namespace LoginCadastro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnLogin = new Button();
            groupBox1 = new GroupBox();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            linkLabel1 = new LinkLabel();
            lblUsuario = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(lblSenha);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(lblUsuario);
            groupBox1.Controls.Add(btnLogin);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // txtSenha
            // 
            txtSenha.Cursor = Cursors.IBeam;
            resources.ApplyResources(txtSenha, "txtSenha");
            txtSenha.Name = "txtSenha";
            txtSenha.TextChanged += txtSenha_TextChanged_1;
            // 
            // txtUsuario
            // 
            txtUsuario.Cursor = Cursors.IBeam;
            resources.ApplyResources(txtUsuario, "txtUsuario");
            txtUsuario.Name = "txtUsuario";
            txtUsuario.TextChanged += txtUsuario_TextChanged_1;
            // 
            // lblSenha
            // 
            resources.ApplyResources(lblSenha, "lblSenha");
            lblSenha.Name = "lblSenha";
            lblSenha.Click += label2_Click;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(linkLabel1, "linkLabel1");
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.LinkColor = SystemColors.GrayText;
            linkLabel1.Name = "linkLabel1";
            linkLabel1.TabStop = true;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblUsuario
            // 
            resources.ApplyResources(lblUsuario, "lblUsuario");
            lblUsuario.Name = "lblUsuario";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private GroupBox groupBox1;
        private Label lblSenha;
        private LinkLabel linkLabel1;
        private Label lblUsuario;
        private TextBox txtSenha;
        private TextBox txtUsuario;
    }
}
