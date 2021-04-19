
namespace WindowsFormsAutorization
{
    partial class MainForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClosedForm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonTurnForm = new System.Windows.Forms.Button();
            this.buttonExpansionForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
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
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Keyboard Trainer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonClosedForm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonTurnForm;
        private System.Windows.Forms.Button buttonExpansionForm;
        private System.Windows.Forms.Label label1;
    }
}