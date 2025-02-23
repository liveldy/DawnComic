using Sunny.UI;
using System.Diagnostics;
using System.IO.Compression;
namespace DawnComic
{
    public partial class MainForm : UIForm
    {
        public string assetsPath = Path.Combine(Application.StartupPath, "assets");
        public static string? comicPath;

        public MainForm()
        {
            InitializeComponent();
            InitializeData();
            InitializeUI();
        }

        private void InitializeData()
        {
            if (!Directory.Exists(assetsPath))
            {
                Directory.CreateDirectory(assetsPath);
            }
            DirectoryInfo assetsDir = new DirectoryInfo(assetsPath);
            foreach (DirectoryInfo comicDir in assetsDir.GetDirectories())
            {
                STAStripComboBox.Items.Add(comicDir.Name);
                STAStripComboBox.SelectedIndex = 0;
            }
        }

        private void InitializeItem()
        {
            if (STAStripComboBox.Items == null || STAStripComboBox.SelectedIndex == -1) return;
            ViewFlowLayoutPanel.Clear();
            DirectoryInfo comicDir = new DirectoryInfo(Path.Combine(assetsPath, STAStripComboBox.SelectedItem.ToString()));
            foreach (DirectoryInfo comic in comicDir.GetDirectories())
            {
                PictureBox viewpic = new PictureBox();
                viewpic.ImageLocation = Path.Combine(comic.FullName, "1.jpg");
                viewpic.Size = new Size(ViewFlowLayoutPanel.Width / 3 - 16, (int)((ViewFlowLayoutPanel.Width / 3 - 16) * 1.4));
                viewpic.SizeMode = PictureBoxSizeMode.StretchImage;
                viewpic.Name = comic.FullName;
                viewpic.Click += Viewpic_Click;
                ViewFlowLayoutPanel.Controls.Add(viewpic);
            }
        }

        private void InitializeUI()
        {
            ViewFlowLayoutPanel.Location = new Point(20, 50);
            ViewFlowLayoutPanel.Size = new Size(this.Width / 4 * 3, this.Height - 80);
            ViewPictureBox.Location = new Point(40 + this.Width / 4 * 3, 50);
            ViewPictureBox.Size = new Size(this.Width / 4 - 60, (int)((this.Width / 4 - 80) * 1.4));
            ViewLabel.Location = new Point(40 + this.Width / 4 * 3, 80 + (int)((this.Width / 4 - 80) * 1.4));
            ViewLabel.Size = new Size(this.Width / 4 - 60, this.Width / 10);
            ViewButton.Location = new Point(40 + this.Width / 4 * 3, this.Height / 5 * 4);
            ViewButton.Size = new Size(this.Width / 4 - 60, this.Height / 16);
            InitializeItem();
        }

        private void Viewpic_Click(object? sender, EventArgs e)
        {
            if (sender is PictureBox viewpic)
            {
                DirectoryInfo tempDir = new DirectoryInfo(viewpic.Name);
                ViewLabel.Text = tempDir.Name;
                ViewPictureBox.Image = viewpic.Image;
                comicPath = tempDir.FullName;
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (comicPath == null) return;
            ComicForm comicForm = new ComicForm();
            comicForm.Text = ViewLabel.Text;
            comicForm.Size = this.Size;
            comicForm.Show();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIMessageBox.Show("DawnComic 破晓壁纸 V1.0.3.0 20250223\n" +
                "Copyright 2025 All Rights Reserved. 哀歌殇年 版权所有\n" +
                "官网: https://agsn.site/\n" +
                "作者QQ：2690034441\n" +
                "更新内容：\n" +
                "修复了STA服务查询问题", "关于");
        }

        private void STAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dawnserverpath = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName).FullName, "DawnServer.exe");
            if (File.Exists(dawnserverpath))
            {
                IniFile Info = new IniFile(Path.Combine(assetsPath, "data.ini"));
                Process.Start(dawnserverpath, $"-sta DawnComic {Info.ReadString("main", "url", "")}");
            }
            else
            {
                UIMessageBox.ShowInfo("当前应用没有STA服务，如需获取，请前往agsn.site下载破晓应用中心");
            }
        }

        private void STAStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeItem();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            InitializeUI();
        }
    }
}
