
namespace ApplicationDev
{
    partial class FM_password
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPrevpw = new System.Windows.Forms.TextBox();
            this.txtNewpw = new System.Windows.Forms.TextBox();
            this.btn_pwreg = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "이전 PW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "변경 PW";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(141, 57);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(136, 27);
            this.txtID.TabIndex = 3;
            // 
            // txtPrevpw
            // 
            this.txtPrevpw.Location = new System.Drawing.Point(141, 118);
            this.txtPrevpw.Name = "txtPrevpw";
            this.txtPrevpw.Size = new System.Drawing.Size(135, 27);
            this.txtPrevpw.TabIndex = 4;
            // 
            // txtNewpw
            // 
            this.txtNewpw.Location = new System.Drawing.Point(141, 173);
            this.txtNewpw.Name = "txtNewpw";
            this.txtNewpw.Size = new System.Drawing.Size(135, 27);
            this.txtNewpw.TabIndex = 5;
            // 
            // btn_pwreg
            // 
            this.btn_pwreg.Location = new System.Drawing.Point(114, 230);
            this.btn_pwreg.Name = "btn_pwreg";
            this.btn_pwreg.Size = new System.Drawing.Size(77, 40);
            this.btn_pwreg.TabIndex = 6;
            this.btn_pwreg.Text = "변경등록";
            this.btn_pwreg.UseVisualStyleBackColor = true;
            this.btn_pwreg.Click += new System.EventHandler(this.btn_pwreg_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(210, 230);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(67, 40);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "닫기";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FM_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 308);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_pwreg);
            this.Controls.Add(this.txtNewpw);
            this.Controls.Add(this.txtPrevpw);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FM_password";
            this.Text = "FM_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPrevpw;
        private System.Windows.Forms.TextBox txtNewpw;
        private System.Windows.Forms.Button btn_pwreg;
        private System.Windows.Forms.Button btn_close;
    }
}