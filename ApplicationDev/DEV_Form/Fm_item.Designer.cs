
namespace DEV_Form
{
    partial class Fm_item
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
            this.btnAdd = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbEnd = new System.Windows.Forms.RadioButton();
            this.rbProd = new System.Windows.Forms.RadioButton();
            this.chkNameOnly = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbItemDetail = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImgSave = new System.Windows.Forms.Button();
            this.btnImgDel = new System.Windows.Forms.Button();
            this.btnImgLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Controls.Add(this.btnSearch);
            this.btnAdd.Controls.Add(this.groupBox2);
            this.btnAdd.Controls.Add(this.chkNameOnly);
            this.btnAdd.Controls.Add(this.label5);
            this.btnAdd.Controls.Add(this.cmbItemDetail);
            this.btnAdd.Controls.Add(this.label4);
            this.btnAdd.Controls.Add(this.label3);
            this.btnAdd.Controls.Add(this.dtpEnd);
            this.btnAdd.Controls.Add(this.dtpStart);
            this.btnAdd.Controls.Add(this.txtItemName);
            this.btnAdd.Controls.Add(this.label2);
            this.btnAdd.Controls.Add(this.txtItemCode);
            this.btnAdd.Controls.Add(this.label1);
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(963, 220);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "조회";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(537, 131);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 27);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbEnd);
            this.groupBox2.Controls.Add(this.rbProd);
            this.groupBox2.Location = new System.Drawing.Point(384, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 59);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "단종 여부";
            // 
            // rbEnd
            // 
            this.rbEnd.AutoSize = true;
            this.rbEnd.Location = new System.Drawing.Point(81, 27);
            this.rbEnd.Name = "rbEnd";
            this.rbEnd.Size = new System.Drawing.Size(60, 24);
            this.rbEnd.TabIndex = 26;
            this.rbEnd.Text = "단종";
            this.rbEnd.UseVisualStyleBackColor = true;
            // 
            // rbProd
            // 
            this.rbProd.AutoSize = true;
            this.rbProd.Checked = true;
            this.rbProd.Location = new System.Drawing.Point(-1, 27);
            this.rbProd.Name = "rbProd";
            this.rbProd.Size = new System.Drawing.Size(60, 24);
            this.rbProd.TabIndex = 25;
            this.rbProd.TabStop = true;
            this.rbProd.Text = "생산";
            this.rbProd.UseVisualStyleBackColor = true;
            // 
            // chkNameOnly
            // 
            this.chkNameOnly.AutoSize = true;
            this.chkNameOnly.Location = new System.Drawing.Point(225, 131);
            this.chkNameOnly.Name = "chkNameOnly";
            this.chkNameOnly.Size = new System.Drawing.Size(141, 24);
            this.chkNameOnly.TabIndex = 24;
            this.chkNameOnly.Text = "이름으로만 검색";
            this.chkNameOnly.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "품목 상세";
            // 
            // cmbItemDetail
            // 
            this.cmbItemDetail.FormattingEnabled = true;
            this.cmbItemDetail.Location = new System.Drawing.Point(87, 131);
            this.cmbItemDetail.Name = "cmbItemDetail";
            this.cmbItemDetail.Size = new System.Drawing.Size(115, 28);
            this.cmbItemDetail.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(723, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "~";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "출시 일자";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(750, 73);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(202, 27);
            this.dtpEnd.TabIndex = 19;
            this.dtpEnd.Value = new System.DateTime(2021, 5, 24, 0, 0, 0, 0);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(498, 73);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(219, 27);
            this.dtpStart.TabIndex = 18;
            this.dtpStart.Value = new System.DateTime(2021, 5, 24, 0, 0, 0, 0);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(292, 75);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(120, 27);
            this.txtItemName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "품목명";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(86, 75);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(115, 27);
            this.txtItemCode.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "품목 코드";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvGrid);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(963, 207);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "품목정보";
            // 
            // dgvGrid
            // 
            this.dgvGrid.AllowUserToAddRows = false;
            this.dgvGrid.AllowUserToDeleteRows = false;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGrid.Location = new System.Drawing.Point(3, 59);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.RowHeadersWidth = 51;
            this.dgvGrid.RowTemplate.Height = 29;
            this.dgvGrid.Size = new System.Drawing.Size(957, 145);
            this.dgvGrid.TabIndex = 31;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 27);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(167, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 27);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 27);
            this.button1.TabIndex = 28;
            this.button1.Text = "추가";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImgSave);
            this.groupBox1.Controls.Add(this.btnImgDel);
            this.groupBox1.Controls.Add(this.btnImgLoad);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(963, 188);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "품목 이미지 관리";
            // 
            // btnImgSave
            // 
            this.btnImgSave.Location = new System.Drawing.Point(234, 153);
            this.btnImgSave.Name = "btnImgSave";
            this.btnImgSave.Size = new System.Drawing.Size(63, 27);
            this.btnImgSave.TabIndex = 33;
            this.btnImgSave.Text = "저장";
            this.btnImgSave.UseVisualStyleBackColor = true;
            // 
            // btnImgDel
            // 
            this.btnImgDel.Location = new System.Drawing.Point(303, 152);
            this.btnImgDel.Name = "btnImgDel";
            this.btnImgDel.Size = new System.Drawing.Size(63, 27);
            this.btnImgDel.TabIndex = 32;
            this.btnImgDel.Text = "삭제";
            this.btnImgDel.UseVisualStyleBackColor = true;
            // 
            // btnImgLoad
            // 
            this.btnImgLoad.Location = new System.Drawing.Point(21, 153);
            this.btnImgLoad.Name = "btnImgLoad";
            this.btnImgLoad.Size = new System.Drawing.Size(197, 27);
            this.btnImgLoad.TabIndex = 31;
            this.btnImgLoad.Text = "이미지 불러오기";
            this.btnImgLoad.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Fm_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 615);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fm_item";
            this.Text = "품목 관리";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fm_item_Load);
            this.btnAdd.ResumeLayout(false);
            this.btnAdd.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbEnd;
        private System.Windows.Forms.RadioButton rbProd;
        private System.Windows.Forms.CheckBox chkNameOnly;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbItemDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImgSave;
        private System.Windows.Forms.Button btnImgDel;
        private System.Windows.Forms.Button btnImgLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}