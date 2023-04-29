namespace MovieRentalApp
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelSlogan2 = new System.Windows.Forms.Label();
            this.buttonClose2 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(551, 99);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(165, 26);
            this.textBoxUsername.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(551, 153);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(165, 26);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(431, 99);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(87, 20);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "Username:";
            this.labelUserName.Click += new System.EventHandler(this.labelUserName_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(426, 153);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 20);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password:";
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(570, 269);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(146, 39);
            this.buttonCreateAccount.TabIndex = 6;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(551, 202);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 39);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelSlogan2
            // 
            this.labelSlogan2.AutoSize = true;
            this.labelSlogan2.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlogan2.Location = new System.Drawing.Point(119, 400);
            this.labelSlogan2.Name = "labelSlogan2";
            this.labelSlogan2.Size = new System.Drawing.Size(417, 43);
            this.labelSlogan2.TabIndex = 20;
            this.labelSlogan2.Text = "Ssh ... The Movie is About to Start!";
            this.labelSlogan2.Click += new System.EventHandler(this.labelSlogan2_Click);
            // 
            // buttonClose2
            // 
            this.buttonClose2.Location = new System.Drawing.Point(653, 472);
            this.buttonClose2.Name = "buttonClose2";
            this.buttonClose2.Size = new System.Drawing.Size(63, 37);
            this.buttonClose2.TabIndex = 21;
            this.buttonClose2.Text = "Close";
            this.buttonClose2.UseVisualStyleBackColor = true;
            this.buttonClose2.Click += new System.EventHandler(this.buttonClose2_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(641, 202);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 39);
            this.buttonClear.TabIndex = 22;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MovieRentalApp.Properties.Resources.movie;
            this.pictureBox2.Location = new System.Drawing.Point(38, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 225);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 580);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClose2);
            this.Controls.Add(this.labelSlogan2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "Login";
            this.Text = "Login to Movies-R-US DataBase (c) 2023.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelSlogan2;
        private System.Windows.Forms.Button buttonClose2;
        private System.Windows.Forms.Button buttonClear;
    }
}