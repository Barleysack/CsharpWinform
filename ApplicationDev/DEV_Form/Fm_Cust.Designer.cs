
namespace DEV_Form
{
    partial class Fm_Cust
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPump = new System.Windows.Forms.RadioButton();
            this.rbCut = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbSY = new System.Windows.Forms.RadioButton();
            this.chkCust = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpED = new System.Windows.Forms.DateTimePicker();
            this.dtpSD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustCode = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chkCust);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpED);
            this.groupBox1.Controls.Add(this.dtpSD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCustName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCustCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "거래처 조회";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(605, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 40);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPump);
            this.groupBox2.Controls.Add(this.rbCut);
            this.groupBox2.Controls.Add(this.rbC);
            this.groupBox2.Controls.Add(this.rbSY);
            this.groupBox2.Location = new System.Drawing.Point(149, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 62);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "종목";
            // 
            // rbPump
            // 
            this.rbPump.AutoSize = true;
            this.rbPump.Location = new System.Drawing.Point(326, 26);
            this.rbPump.Name = "rbPump";
            this.rbPump.Size = new System.Drawing.Size(105, 24);
            this.rbPump.TabIndex = 3;
            this.rbPump.TabStop = true;
            this.rbPump.Text = "펌프압축기";
            this.rbPump.UseVisualStyleBackColor = true;
            // 
            // rbCut
            // 
            this.rbCut.AutoSize = true;
            this.rbCut.Location = new System.Drawing.Point(230, 26);
            this.rbCut.Name = "rbCut";
            this.rbCut.Size = new System.Drawing.Size(90, 24);
            this.rbCut.TabIndex = 2;
            this.rbCut.TabStop = true;
            this.rbCut.Text = "절삭가공";
            this.rbCut.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(122, 26);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(105, 24);
            this.rbC.TabIndex = 1;
            this.rbC.TabStop = true;
            this.rbC.Text = "자동차부품";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbSY
            // 
            this.rbSY.AutoSize = true;
            this.rbSY.Location = new System.Drawing.Point(6, 26);
            this.rbSY.Name = "rbSY";
            this.rbSY.Size = new System.Drawing.Size(110, 24);
            this.rbSY.TabIndex = 0;
            this.rbSY.TabStop = true;
            this.rbSY.Text = "상용차 부품";
            this.rbSY.UseVisualStyleBackColor = true;
            // 
            // chkCust
            // 
            this.chkCust.AutoSize = true;
            this.chkCust.Location = new System.Drawing.Point(17, 93);
            this.chkCust.Name = "chkCust";
            this.chkCust.Size = new System.Drawing.Size(126, 24);
            this.chkCust.TabIndex = 8;
            this.chkCust.Text = "고객사만 검색";
            this.chkCust.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(743, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "~";
            // 
            // dtpED
            // 
            this.dtpED.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpED.Location = new System.Drawing.Point(769, 28);
            this.dtpED.Name = "dtpED";
            this.dtpED.Size = new System.Drawing.Size(129, 27);
            this.dtpED.TabIndex = 6;
            // 
            // dtpSD
            // 
            this.dtpSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSD.Location = new System.Drawing.Point(622, 28);
            this.dtpSD.Name = "dtpSD";
            this.dtpSD.Size = new System.Drawing.Size(103, 27);
            this.dtpSD.TabIndex = 5;
            this.dtpSD.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "거래 일자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "거래처 명";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(393, 28);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(143, 27);
            this.txtCustName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "거래처 코드";
            // 
            // txtCustCode
            // 
            this.txtCustCode.Location = new System.Drawing.Point(103, 27);
            this.txtCustCode.Name = "txtCustCode";
            this.txtCustCode.Size = new System.Drawing.Size(209, 27);
            this.txtCustCode.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(981, 71);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "거래처 정보";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(228, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(124, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 39);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(0, 225);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 29;
            this.DGV.Size = new System.Drawing.Size(981, 225);
            this.DGV.TabIndex = 2;
            // 
            // Fm_Cust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fm_Cust";
            this.Text = "거래처 마스터";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fm_Cust_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPump;
        private System.Windows.Forms.RadioButton rbCut;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbSY;
        private System.Windows.Forms.CheckBox chkCust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpED;
        private System.Windows.Forms.DateTimePicker dtpSD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustCode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView DGV;
    }
}