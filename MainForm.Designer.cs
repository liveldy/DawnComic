namespace DawnComic
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ViewFlowLayoutPanel = new Sunny.UI.UIFlowLayoutPanel();
            ViewPictureBox = new PictureBox();
            ViewLabel = new Sunny.UI.UILabel();
            ViewButton = new Sunny.UI.UIButton();
            ViewContextMenuStrip = new Sunny.UI.UIContextMenuStrip();
            STAToolStripMenuItem = new ToolStripMenuItem();
            STAStripComboBox = new ToolStripComboBox();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)ViewPictureBox).BeginInit();
            ViewContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ViewFlowLayoutPanel
            // 
            ViewFlowLayoutPanel.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ViewFlowLayoutPanel.Location = new Point(20, 50);
            ViewFlowLayoutPanel.Margin = new Padding(4, 5, 4, 5);
            ViewFlowLayoutPanel.MinimumSize = new Size(1, 1);
            ViewFlowLayoutPanel.Name = "ViewFlowLayoutPanel";
            ViewFlowLayoutPanel.Padding = new Padding(2);
            ViewFlowLayoutPanel.ShowText = false;
            ViewFlowLayoutPanel.Size = new Size(850, 730);
            ViewFlowLayoutPanel.TabIndex = 0;
            ViewFlowLayoutPanel.Text = "uiFlowLayoutPanel1";
            ViewFlowLayoutPanel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ViewPictureBox
            // 
            ViewPictureBox.Location = new Point(900, 50);
            ViewPictureBox.Name = "ViewPictureBox";
            ViewPictureBox.Size = new Size(250, 350);
            ViewPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ViewPictureBox.TabIndex = 1;
            ViewPictureBox.TabStop = false;
            // 
            // ViewLabel
            // 
            ViewLabel.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ViewLabel.ForeColor = Color.FromArgb(48, 48, 48);
            ViewLabel.Location = new Point(900, 432);
            ViewLabel.Name = "ViewLabel";
            ViewLabel.Size = new Size(250, 100);
            ViewLabel.TabIndex = 2;
            ViewLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ViewButton
            // 
            ViewButton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ViewButton.Location = new Point(900, 720);
            ViewButton.MinimumSize = new Size(1, 1);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(250, 60);
            ViewButton.TabIndex = 3;
            ViewButton.Text = "观看";
            ViewButton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ViewButton.Click += ViewButton_Click;
            // 
            // ViewContextMenuStrip
            // 
            ViewContextMenuStrip.BackColor = Color.FromArgb(243, 249, 255);
            ViewContextMenuStrip.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ViewContextMenuStrip.ImageScalingSize = new Size(24, 24);
            ViewContextMenuStrip.Items.AddRange(new ToolStripItem[] { STAToolStripMenuItem, STAStripComboBox, AboutToolStripMenuItem });
            ViewContextMenuStrip.Name = "ViewContextMenuStrip";
            ViewContextMenuStrip.Size = new Size(182, 102);
            // 
            // STAToolStripMenuItem
            // 
            STAToolStripMenuItem.Name = "STAToolStripMenuItem";
            STAToolStripMenuItem.Size = new Size(181, 30);
            STAToolStripMenuItem.Text = "STA订阅";
            STAToolStripMenuItem.Click += STAToolStripMenuItem_Click;
            // 
            // STAStripComboBox
            // 
            STAStripComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            STAStripComboBox.Name = "STAStripComboBox";
            STAStripComboBox.Size = new Size(121, 32);
            STAStripComboBox.SelectedIndexChanged += STAStripComboBox_SelectedIndexChanged;
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(181, 30);
            AboutToolStripMenuItem.Text = "关于";
            AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1200, 800);
            Controls.Add(ViewButton);
            Controls.Add(ViewLabel);
            Controls.Add(ViewPictureBox);
            Controls.Add(ViewFlowLayoutPanel);
            ExtendBox = true;
            ExtendMenu = ViewContextMenuStrip;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "破晓漫画";
            ZoomScaleRect = new Rectangle(22, 22, 800, 450);
            SizeChanged += MainForm_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)ViewPictureBox).EndInit();
            ViewContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIFlowLayoutPanel ViewFlowLayoutPanel;
        private PictureBox ViewPictureBox;
        private Sunny.UI.UILabel ViewLabel;
        private Sunny.UI.UIButton ViewButton;
        private Sunny.UI.UIContextMenuStrip ViewContextMenuStrip;
        private ToolStripMenuItem STAToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private ToolStripComboBox STAStripComboBox;
    }
}
