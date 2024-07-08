namespace LoginScreen
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
            Username = new TextBox();
            LoginBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            Password = new MaskedTextBox();
            SuspendLayout();
            // 
            // Username
            // 
            Username.Location = new Point(221, 85);
            Username.Name = "Username";
            Username.Size = new Size(323, 23);
            Username.TabIndex = 0;
            Username.TextChanged += Username_TextChanged;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.Highlight;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 14F);
            LoginBtn.ForeColor = SystemColors.ButtonFace;
            LoginBtn.Location = new Point(221, 221);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(107, 40);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 58);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 141);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // Password
            // 
            Password.AllowPromptAsInput = false;
            Password.Location = new Point(221, 177);
            Password.Name = "Password";
            Password.Size = new Size(323, 23);
            Password.TabIndex = 5;
            Password.UseSystemPasswordChar = true;
            Password.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginBtn);
            Controls.Add(Username);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username;
        private Button LoginBtn;
        private Label label1;
        private Label label2;
        private MaskedTextBox Password;
    }
}
