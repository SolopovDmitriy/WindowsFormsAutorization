
namespace WindowsFormsAutorization
{
    partial class LoginForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCome = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.buttonCome);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBoxUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 440);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // buttonCome
            // 
            this.buttonCome.AutoSize = true;
            this.buttonCome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCome.Location = new System.Drawing.Point(319, 313);
            this.buttonCome.Name = "buttonCome";
            this.buttonCome.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonCome.Size = new System.Drawing.Size(172, 51);
            this.buttonCome.TabIndex = 5;
            this.buttonCome.Text = "TO COME IN";
            this.buttonCome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCome.UseVisualStyleBackColor = true;
            this.buttonCome.Click += new System.EventHandler(this.buttonCome_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(257, 188);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(333, 56);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.MouseEnter += new System.EventHandler(this.textBoxPassword_MouseEnter);
            this.textBoxPassword.MouseLeave += new System.EventHandler(this.textBoxPassword_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(169, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUser.Location = new System.Drawing.Point(257, 114);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(333, 56);
            this.textBoxUser.TabIndex = 2;
            this.textBoxUser.MouseEnter += new System.EventHandler(this.textBoxUser_MouseEnter);
            this.textBoxUser.MouseLeave += new System.EventHandler(this.textBoxUser_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 58);
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
            this.textBox1.MouseEnter += new System.EventHandler(this.textBoxPassword_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBoxPassword_MouseLeave);
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
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTHORIZATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegisterButton.Location = new System.Drawing.Point(296, 390);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(220, 32);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "no account";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm1";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Text = "LoginForm1";
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonCome;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonExpansionForm;
        private System.Windows.Forms.Button buttonTurnForm;
        private System.Windows.Forms.Button buttonClosedForm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button RegisterButton;
    }
}