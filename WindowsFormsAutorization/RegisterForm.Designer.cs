
namespace WindowsFormsAutorization
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRegistrationSurname = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationName = new System.Windows.Forms.TextBox();
            this.bottonRegister = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClosedForm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonTurnForm = new System.Windows.Forms.Button();
            this.buttonExpansionForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.RegisterButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxRegistrationSurname);
            this.panel1.Controls.Add(this.textBoxRegistrationName);
            this.panel1.Controls.Add(this.bottonRegister);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBoxUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(398, 171);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4, 20, 0, 0);
            this.label3.Size = new System.Drawing.Size(70, 56);
            this.label3.TabIndex = 9;
            this.label3.Text = "SURNAME";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 171);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(12, 20, 0, 0);
            this.label2.Size = new System.Drawing.Size(65, 56);
            this.label2.TabIndex = 8;
            this.label2.Text = "NAME";
            // 
            // textBoxRegistrationSurname
            // 
            this.textBoxRegistrationSurname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxRegistrationSurname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxRegistrationSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRegistrationSurname.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxRegistrationSurname.Location = new System.Drawing.Point(474, 171);
            this.textBoxRegistrationSurname.Name = "textBoxRegistrationSurname";
            this.textBoxRegistrationSurname.Size = new System.Drawing.Size(299, 41);
            this.textBoxRegistrationSurname.TabIndex = 7;
            this.textBoxRegistrationSurname.Text = "Enter your surname";
            this.textBoxRegistrationSurname.Enter += new System.EventHandler(this.textBoxRegistrationSurname_Enter);
            this.textBoxRegistrationSurname.MouseEnter += new System.EventHandler(this.textBoxRegistrationSurname_MouseEnter);
            this.textBoxRegistrationSurname.MouseLeave += new System.EventHandler(this.textBoxRegistrationSurname_MouseLeave);
            // 
            // textBoxRegistrationName
            // 
            this.textBoxRegistrationName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxRegistrationName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxRegistrationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRegistrationName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxRegistrationName.Location = new System.Drawing.Point(78, 171);
            this.textBoxRegistrationName.Name = "textBoxRegistrationName";
            this.textBoxRegistrationName.Size = new System.Drawing.Size(288, 41);
            this.textBoxRegistrationName.TabIndex = 6;
            this.textBoxRegistrationName.Text = "Enter your name";
            this.textBoxRegistrationName.Enter += new System.EventHandler(this.textBoxRegistrationName_Enter);
            this.textBoxRegistrationName.MouseEnter += new System.EventHandler(this.textBoxRegistrationName_MouseEnter);
            this.textBoxRegistrationName.MouseLeave += new System.EventHandler(this.textBoxRegistrationName_MouseLeave);
            // 
            // bottonRegister
            // 
            this.bottonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bottonRegister.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bottonRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bottonRegister.Location = new System.Drawing.Point(231, 337);
            this.bottonRegister.Name = "bottonRegister";
            this.bottonRegister.Size = new System.Drawing.Size(344, 57);
            this.bottonRegister.TabIndex = 5;
            this.bottonRegister.Text = "REGISTER NOW";
            this.bottonRegister.UseVisualStyleBackColor = true;
            this.bottonRegister.Click += new System.EventHandler(this.bottonRegister_Click);
            this.bottonRegister.MouseEnter += new System.EventHandler(this.bottonRegister_MouseEnter);
            this.bottonRegister.MouseLeave += new System.EventHandler(this.bottonRegister_MouseLeave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(474, 256);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(299, 41);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.MouseEnter += new System.EventHandler(this.textBoxPassword_MouseEnter);
            this.textBoxPassword.MouseLeave += new System.EventHandler(this.textBoxPassword_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(400, 258);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUser.Location = new System.Drawing.Point(78, 258);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(288, 41);
            this.textBoxUser.TabIndex = 2;
            this.textBoxUser.MouseEnter += new System.EventHandler(this.textBoxUser_MouseEnter);
            this.textBoxUser.MouseLeave += new System.EventHandler(this.textBoxUser_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonClosedForm);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.buttonTurnForm);
            this.panel2.Controls.Add(this.buttonExpansionForm);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 64);
            this.panel2.TabIndex = 0;
            // 
            // buttonClosedForm
            // 
            this.buttonClosedForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonClosedForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClosedForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClosedForm.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonClosedForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonClosedForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonClosedForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClosedForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClosedForm.Location = new System.Drawing.Point(753, 3);
            this.buttonClosedForm.Name = "buttonClosedForm";
            this.buttonClosedForm.Size = new System.Drawing.Size(47, 46);
            this.buttonClosedForm.TabIndex = 9;
            this.buttonClosedForm.Text = "X";
            this.buttonClosedForm.UseVisualStyleBackColor = false;
            this.buttonClosedForm.Click += new System.EventHandler(this.buttonClosedForm_Click);
            this.buttonClosedForm.MouseEnter += new System.EventHandler(this.buttonClosedForm_MouseEnter);
            this.buttonClosedForm.MouseLeave += new System.EventHandler(this.buttonClosedForm_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(257, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 56);
            this.textBox1.TabIndex = 4;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // buttonTurnForm
            // 
            this.buttonTurnForm.BackgroundImage = global::WindowsFormsAutorization.Properties.Resources._300px_Тире_21;
            this.buttonTurnForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTurnForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTurnForm.Location = new System.Drawing.Point(655, 3);
            this.buttonTurnForm.Name = "buttonTurnForm";
            this.buttonTurnForm.Size = new System.Drawing.Size(42, 46);
            this.buttonTurnForm.TabIndex = 6;
            this.buttonTurnForm.UseVisualStyleBackColor = true;
            this.buttonTurnForm.Click += new System.EventHandler(this.buttonTurnForm_Click);
            // 
            // buttonExpansionForm
            // 
            this.buttonExpansionForm.BackgroundImage = global::WindowsFormsAutorization.Properties.Resources.iconfinder_1_icon_music_02_36947431;
            this.buttonExpansionForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExpansionForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExpansionForm.Location = new System.Drawing.Point(703, 3);
            this.buttonExpansionForm.Name = "buttonExpansionForm";
            this.buttonExpansionForm.Size = new System.Drawing.Size(47, 46);
            this.buttonExpansionForm.TabIndex = 5;
            this.buttonExpansionForm.UseVisualStyleBackColor = true;
            this.buttonExpansionForm.Click += new System.EventHandler(this.buttonExpansionForm_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegisterButton.Location = new System.Drawing.Point(270, 406);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(266, 32);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "Authorization";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonClosedForm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonTurnForm;
        private System.Windows.Forms.Button buttonExpansionForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRegistrationSurname;
        private System.Windows.Forms.TextBox textBoxRegistrationName;
        private System.Windows.Forms.Button bottonRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegisterButton;
    }
}