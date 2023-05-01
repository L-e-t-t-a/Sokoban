using System.Numerics;

namespace Sokoban
{
    public partial class SokobanMenu : Form
    {
        public SokobanMenu()
        {
            InitializeComponent();
        }
        private void SokobanMenu_Load(object sender, EventArgs e)
        {
            Level_comboBox.SelectedIndex = 0;
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            string filename = "Resources/Level1.txt";
            // определяем имя файла в зависимости от выбранного элемента в Level_comboBox
            if (Level_comboBox.SelectedIndex == 1)
            {
                filename = "Resources/Level1.txt";
            }
            else if (Level_comboBox.SelectedIndex == 2)
            {
                filename = "Resources/Level2.txt";
            }

            // считываем матрицу из файла
            string[] lines = File.ReadAllLines(filename);
            int k = int.Parse(lines[0]); // количество строк матрицы
            int l = int.Parse(lines[1]); // количество столбцов матрицы
            int[,] matrix = new int[k, l];

            for (int i = 2; i < k; i++)
            {
                string[] values = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < l; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            // создаем новую форму
            int n = (k - 1) * 50;
            int m = (l - 1) * 50;

            Level levelForm = new Level();
            levelForm.ClientSize = new Size(n, m);
            levelForm.StartPosition = FormStartPosition.CenterScreen;

            // добавляем лейблы на форму
            for (int i = 2; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        PictureBox block = new PictureBox();
                        block.Image = Image.FromFile("Resources/terr_w.png");
                        block.Location = new Point(j * 50, (i - 2) * 50);
                        block.Size = new Size(50, 50);
                        levelForm.Controls.Add(block);
                    }
                    else if (matrix[i, j] == 2)
                    {
                        PictureBox player = new PictureBox();
                        player.Image = Image.FromFile("Resources/player.png");
                        player.Location = new Point(j * 50, (i - 2) * 50);
                        player.Size = new Size(50, 50);
                        levelForm.Controls.Add(player);
                    }
                    else if (matrix[i, j] == 3)
                    {
                        PictureBox chest = new PictureBox();
                        chest.Image = Image.FromFile("Resources/block.png");
                        chest.Location = new Point(j * 50, (i - 2) * 50);
                        chest.Size = new Size(50, 50);
                        levelForm.Controls.Add(chest);
                    }
                    else if (matrix[i, j] == 4)
                    {
                        PictureBox EndBlock = new PictureBox();
                        EndBlock.Image = Image.FromFile("Resources/terr_d.png");
                        EndBlock.Location = new Point(j * 50, (i - 2) * 50);
                        EndBlock.Size = new Size(50, 50);
                        levelForm.Controls.Add(EndBlock);
                    }
                    else
                    {
                        PictureBox ground = new PictureBox();
                        ground.Image = Image.FromFile("Resources/terr_c.png");
                        ground.Location = new Point(j * 50, (i - 2) * 50);
                        ground.Size = new Size(50, 50);
                        levelForm.Controls.Add(ground);
                    }
                }
            }
            // отображаем форму
            levelForm.ShowDialog();
        }
    }
}