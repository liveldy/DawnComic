namespace DawnComic
{
    partial class ComicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComicForm));
            ComicFlowLayoutPanel = new Sunny.UI.UIFlowLayoutPanel();
            UpButton = new Sunny.UI.UIButton();
            DownButton = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // ComicFlowLayoutPanel
            // 
            ComicFlowLayoutPanel.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ComicFlowLayoutPanel.Location = new Point(280, 40);
            ComicFlowLayoutPanel.Margin = new Padding(4, 5, 4, 5);
            ComicFlowLayoutPanel.MinimumSize = new Size(1, 1);
            ComicFlowLayoutPanel.Name = "ComicFlowLayoutPanel";
            ComicFlowLayoutPanel.Padding = new Padding(2);
            ComicFlowLayoutPanel.ShowText = false;
            ComicFlowLayoutPanel.Size = new Size(650, 750);
            ComicFlowLayoutPanel.TabIndex = 0;
            ComicFlowLayoutPanel.Text = "uiFlowLayoutPanel1";
            ComicFlowLayoutPanel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // UpButton
            // 
            UpButton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpButton.Location = new Point(80, 350);
            UpButton.MinimumSize = new Size(1, 1);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(150, 52);
            UpButton.TabIndex = 1;
            UpButton.Text = "<<<";
            UpButton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpButton.Click += UpButton_Click;
            // 
            // DownButton
            // 
            DownButton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            DownButton.Location = new Point(1000, 350);
            DownButton.MinimumSize = new Size(1, 1);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(150, 52);
            DownButton.TabIndex = 2;
            DownButton.Text = ">>>";
            DownButton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            DownButton.Click += DownButton_Click;
            // 
            // ComicForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1200, 800);
            Controls.Add(DownButton);
            Controls.Add(UpButton);
            Controls.Add(ComicFlowLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ComicForm";
            Text = "破晓漫画";
            ZoomScaleRect = new Rectangle(22, 22, 800, 450);
            SizeChanged += ComicForm_SizeChanged;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIFlowLayoutPanel ComicFlowLayoutPanel;
        private Sunny.UI.UIButton UpButton;
        private Sunny.UI.UIButton DownButton;
    }
}