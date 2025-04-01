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
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            linkLabel1 = new LinkLabel();
            lblUsuario = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(185, 212);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(124, 49);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(lblSenha);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(lblUsuario);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(77, 67);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(459, 356);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(144, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 35);
            textBox2.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(144, 94);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(240, 35);
            txtUsuario.TabIndex = 4;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(57, 147);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(70, 29);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            lblSenha.Click += label2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(188, 265);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(121, 29);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cadastre-se";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(57, 97);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(81, 29);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 487);
            Controls.Add(groupBox1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Label lblSenha;
        private LinkLabel linkLabel1;
        private Label lblUsuario;
        private TextBox textBox2;
        private TextBox txtUsuario;
    }
}
