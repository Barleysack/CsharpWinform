
namespace ApplicationDev
{
    partial class Fm_main
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.M_SYSTEM = new System.Windows.Forms.ToolStripMenuItem();
            this.MDI_TEST1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TESTYME = new System.Windows.Forms.ToolStripMenuItem();
            this.Fm_item = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolstrip = new System.Windows.Forms.ToolStrip();
            this.stbSearch = new System.Windows.Forms.ToolStripButton();
            this.stbInsert = new System.Windows.Forms.ToolStripButton();
            this.stbDel = new System.Windows.Forms.ToolStripButton();
            this.stbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stbClose = new System.Windows.Forms.ToolStripButton();
            this.stbExit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsspring = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsusername = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsdatenow = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MDI_TEST = new System.Windows.Forms.ToolStripMenuItem();
            this.mytabcontrol1 = new ApplicationDev.mytabcontrol();
            this.MenuStrip.SuspendLayout();
            this.Toolstrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_SYSTEM});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(817, 28);
            this.MenuStrip.TabIndex = 0;
            // 
            // M_SYSTEM
            // 
            this.M_SYSTEM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MDI_TEST1,
            this.TESTYME,
            this.Fm_item});
            this.M_SYSTEM.Name = "M_SYSTEM";
            this.M_SYSTEM.Size = new System.Drawing.Size(104, 24);
            this.M_SYSTEM.Text = "시스템_관리";
            // 
            // MDI_TEST1
            // 
            this.MDI_TEST1.Name = "MDI_TEST1";
            this.MDI_TEST1.Size = new System.Drawing.Size(172, 26);
            this.MDI_TEST1.Text = "시험용 화면";
            // 
            // TESTYME
            // 
            this.TESTYME.Name = "TESTYME";
            this.TESTYME.Size = new System.Drawing.Size(172, 26);
            this.TESTYME.Text = "Testyme";
            // 
            // Fm_item
            // 
            this.Fm_item.Name = "Fm_item";
            this.Fm_item.Size = new System.Drawing.Size(172, 26);
            this.Fm_item.Text = "품목 관리";
            // 
            // Toolstrip
            // 
            this.Toolstrip.AutoSize = false;
            this.Toolstrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbSearch,
            this.stbInsert,
            this.stbDel,
            this.stbSave,
            this.toolStripSeparator1,
            this.stbClose,
            this.stbExit});
            this.Toolstrip.Location = new System.Drawing.Point(0, 28);
            this.Toolstrip.Name = "Toolstrip";
            this.Toolstrip.Size = new System.Drawing.Size(817, 86);
            this.Toolstrip.TabIndex = 1;
            this.Toolstrip.Text = "toolStrip1";
            this.Toolstrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Toolstrip_ItemClicked);
            // 
            // stbSearch
            // 
            this.stbSearch.Image = global::ApplicationDev.Properties.Resources.BtnSearch;
            this.stbSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stbSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbSearch.Name = "stbSearch";
            this.stbSearch.Size = new System.Drawing.Size(54, 83);
            this.stbSearch.Text = "조회";
            this.stbSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // stbInsert
            // 
            this.stbInsert.Image = global::ApplicationDev.Properties.Resources.BtnAdd;
            this.stbInsert.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stbInsert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbInsert.Name = "stbInsert";
            this.stbInsert.Size = new System.Drawing.Size(54, 83);
            this.stbInsert.Text = "추가";
            this.stbInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // stbDel
            // 
            this.stbDel.Image = global::ApplicationDev.Properties.Resources.BtnDelete;
            this.stbDel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stbDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbDel.Name = "stbDel";
            this.stbDel.Size = new System.Drawing.Size(54, 83);
            this.stbDel.Text = "삭제";
            this.stbDel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // stbSave
            // 
            this.stbSave.Image = global::ApplicationDev.Properties.Resources.BtnSaveB;
            this.stbSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbSave.Name = "stbSave";
            this.stbSave.Size = new System.Drawing.Size(54, 83);
            this.stbSave.Text = "저장";
            this.stbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 86);
            // 
            // stbClose
            // 
            this.stbClose.Image = global::ApplicationDev.Properties.Resources.BtnClose;
            this.stbClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stbClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbClose.Name = "stbClose";
            this.stbClose.Size = new System.Drawing.Size(54, 83);
            this.stbClose.Text = "닫기";
            this.stbClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // stbExit
            // 
            this.stbExit.Image = global::ApplicationDev.Properties.Resources.BtcExit;
            this.stbExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbExit.Name = "stbExit";
            this.stbExit.Size = new System.Drawing.Size(54, 83);
            this.stbExit.Text = "종료";
            this.stbExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsspring,
            this.tsusername,
            this.tsdatenow});
            this.statusStrip.Location = new System.Drawing.Point(0, 400);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(817, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsspring
            // 
            this.tsspring.AutoSize = false;
            this.tsspring.Name = "tsspring";
            this.tsspring.Size = new System.Drawing.Size(202, 20);
            this.tsspring.Spring = true;
            // 
            // tsusername
            // 
            this.tsusername.AutoSize = false;
            this.tsusername.Name = "tsusername";
            this.tsusername.Size = new System.Drawing.Size(300, 20);
            // 
            // tsdatenow
            // 
            this.tsdatenow.AutoSize = false;
            this.tsdatenow.Name = "tsdatenow";
            this.tsdatenow.Size = new System.Drawing.Size(300, 20);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MDI_TEST
            // 
            this.MDI_TEST.Name = "MDI_TEST";
            this.MDI_TEST.Size = new System.Drawing.Size(172, 26);
            this.MDI_TEST.Text = "테스트 화면";
            // 
            // mytabcontrol1
            // 
            this.mytabcontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mytabcontrol1.Location = new System.Drawing.Point(0, 114);
            this.mytabcontrol1.Name = "mytabcontrol1";
            this.mytabcontrol1.SelectedIndex = 0;
            this.mytabcontrol1.Size = new System.Drawing.Size(817, 286);
            this.mytabcontrol1.TabIndex = 4;
            // 
            // Fm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 426);
            this.Controls.Add(this.mytabcontrol1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.Toolstrip);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Fm_main";
            this.Text = "Application devy v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.Toolstrip.ResumeLayout(false);
            this.Toolstrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem M_SYSTEM;
        private System.Windows.Forms.ToolStrip Toolstrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripButton stbSearch;
        private System.Windows.Forms.ToolStripButton stbInsert;
        private System.Windows.Forms.ToolStripButton stbDel;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton stbExit;
        private System.Windows.Forms.ToolStripButton stbSave;
        private System.Windows.Forms.ToolStripButton stbClose;
        private System.Windows.Forms.ToolStripStatusLabel tsspring;
        private System.Windows.Forms.ToolStripStatusLabel tsusername;
        private System.Windows.Forms.ToolStripStatusLabel tsdatenow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem MDI_TEST;
        private System.Windows.Forms.ToolStripMenuItem MDI_TEST1;
        private System.Windows.Forms.ToolStripMenuItem TESTYME;
        private mytabcontrol mytabcontrol1;
        private System.Windows.Forms.ToolStripMenuItem Fm_item;
    }
}