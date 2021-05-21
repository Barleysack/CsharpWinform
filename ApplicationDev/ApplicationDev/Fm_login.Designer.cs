
namespace ApplicationDev
{
    partial class Fm_login
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
            this.Btn_pwchange = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.lblpw = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_pwchange
            // 
            this.Btn_pwchange.Location = new System.Drawing.Point(173, 162);
            this.Btn_pwchange.Name = "Btn_pwchange";
            this.Btn_pwchange.Size = new System.Drawing.Size(172, 63);
            this.Btn_pwchange.TabIndex = 0;
            this.Btn_pwchange.Text = "비밀번호 변경";
            this.Btn_pwchange.UseVisualStyleBackColor = true;
            this.Btn_pwchange.Click += new System.EventHandler(this.Btn_pwchange_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(407, 162);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(157, 60);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(57, 52);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(69, 20);
            this.lblid.TabIndex = 2;
            this.lblid.Text = "사용자ID";
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.Location = new System.Drawing.Point(57, 112);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(77, 20);
            this.lblpw.TabIndex = 3;
            this.lblpw.Text = "사용자PW";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(182, 52);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(382, 27);
            this.txtid.TabIndex = 4;
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(182, 109);
            this.txtpw.Name = "txtpw";
            this.txtpw.PasswordChar = '*';
            this.txtpw.Size = new System.Drawing.Size(382, 27);
            this.txtpw.TabIndex = 5;
            this.txtpw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpw_KeyDown);
            // 
            // Fm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 231);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblpw);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.Btn_pwchange);
            this.Name = "Fm_login";
            this.Text = "LOG IN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_pwchange;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtpw;
    }
}

