using Sunny.UI;

namespace DawnComic
{
    public partial class ComicForm : UIForm
    {
        private int Index = 0;

        public ComicForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            ComicPicLoad();
        }

        private void ComicForm_SizeChanged(object sender, EventArgs e)
        {
            ComicFlowLayoutPanel.Location = new Point(this.Width / 5, 40);
            ComicFlowLayoutPanel.Size = new Size(this.Width / 5 * 3, this.Height - 60);
            UpButton.Location = new Point(this.Width / 15, this.Height / 2);
            DownButton.Location = new Point(this.Width / 15 * 13, this.Height / 2);
            ComicPicLoad();
        }

        private void ComicPicLoad()
        {
            ComicFlowLayoutPanel.Clear();
            for (int i = 1 + Index * 10; i <= (Index + 1) * 10; i++)
            {
                string comicPaths = Path.Combine(MainForm.comicPath, i + ".jpg");
                if (!File.Exists(comicPaths)) break;
                PictureBox comicpic = new PictureBox();
                comicpic.ImageLocation = comicPaths;
                using (Stream stream = File.OpenRead(comicPaths))
                {
                    using (Image sourceImage = Image.FromStream(stream, false, false))
                    {
                        comicpic.Size = new Size(ComicFlowLayoutPanel.Width - 10, (int)((ComicFlowLayoutPanel.Width - 10) * (sourceImage.Height * 1.0 / sourceImage.Width)));
                        comicpic.SizeMode = PictureBoxSizeMode.StretchImage;
                        ComicFlowLayoutPanel.Controls.Add(comicpic);
                    }
                }
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            if (Index == 0) return;
            Index--;
            ComicPicLoad();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(MainForm.comicPath, 1 + (Index + 1) * 10 + ".jpg"))) return;
            Index++;
            ComicPicLoad();
        }
    }
}
