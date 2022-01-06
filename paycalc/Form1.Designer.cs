namespace paycalc
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lblRegister = new System.Windows.Forms.Label();
            this.txtboxFullname = new System.Windows.Forms.TextBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLoginInstead = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtboxRepeat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegister.Location = new System.Drawing.Point(226, 134);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(191, 50);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "REGISTER";
            // 
            // txtboxFullname
            // 
            this.txtboxFullname.ForeColor = System.Drawing.Color.Black;
            this.txtboxFullname.Location = new System.Drawing.Point(192, 205);
            this.txtboxFullname.Multiline = true;
            this.txtboxFullname.Name = "txtboxFullname";
            this.txtboxFullname.Size = new System.Drawing.Size(250, 33);
            this.txtboxFullname.TabIndex = 1;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.ForeColor = System.Drawing.Color.Black;
            this.txtboxUsername.Location = new System.Drawing.Point(192, 254);
            this.txtboxUsername.Multiline = true;
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(250, 35);
            this.txtboxUsername.TabIndex = 2;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.ForeColor = System.Drawing.Color.Black;
            this.txtboxPassword.Location = new System.Drawing.Point(192, 305);
            this.txtboxPassword.Multiline = true;
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(250, 37);
            this.txtboxPassword.TabIndex = 3;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegister.Location = new System.Drawing.Point(192, 428);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(250, 44);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLoginInstead
            // 
            this.btnLoginInstead.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoginInstead.Location = new System.Drawing.Point(192, 488);
            this.btnLoginInstead.Name = "btnLoginInstead";
            this.btnLoginInstead.Size = new System.Drawing.Size(250, 44);
            this.btnLoginInstead.TabIndex = 6;
            this.btnLoginInstead.Text = "LOGIN INSTEAD";
            this.btnLoginInstead.UseVisualStyleBackColor = true;
            this.btnLoginInstead.Click += new System.EventHandler(this.btnLoginInstead_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::paycalc.Properties.Resources.pcalc;
            this.pictureBox1.Location = new System.Drawing.Point(167, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtboxRepeat
            // 
            this.txtboxRepeat.ForeColor = System.Drawing.Color.Black;
            this.txtboxRepeat.Location = new System.Drawing.Point(192, 358);
            this.txtboxRepeat.Multiline = true;
            this.txtboxRepeat.Name = "txtboxRepeat";
            this.txtboxRepeat.Size = new System.Drawing.Size(250, 37);
            this.txtboxRepeat.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 573);
            this.Controls.Add(this.txtboxRepeat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoginInstead);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.txtboxFullname);
            this.Controls.Add(this.lblRegister);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ImageList imageList1;
        private ImageList imageList2;
        private Label lblRegister;
        private TextBox txtboxFullname;
        private TextBox txtboxUsername;
        private TextBox txtboxPassword;
        private Button btnRegister;
        private Button btnLoginInstead;
        private PictureBox pictureBox1;
        private TextBox txtboxRepeat;
    }
}