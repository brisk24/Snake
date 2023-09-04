using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_videosharp.info_
{
    internal class Map
    {
        static int cellSize = 30;
       public int width { get; }
       public int height { get; }

        Panel panel;
        Cell[,] cells;
        PictureBox[,] boxes;
        Random random = new Random();     
        public Map(Panel panel)
        {
            this.panel = panel;
            width = panel.Width / cellSize;
            height = panel.Height / cellSize;
            cells = new Cell[width, height];
            boxes = new PictureBox[width, height];

            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    cells[x, y] = Cell.Empty;
                    boxes[x, y] = NewBox(x, y);
                }
            AddWalls();
        }

        public int widthCount()
        {
            return width;
        }

        public int heightCount()
        {
            return height;
        }

        PictureBox NewBox(int x, int y)
        {
            PictureBox box = new PictureBox();
            box.Size = new Size(cellSize, cellSize);
            box.Location = new Point(x * cellSize, y * cellSize);
            LoadImage(box, Cell.Empty);
            panel.Controls.Add(box);
            return box;
        }

        void AddWalls()
        {
            for (int x = 0; x < width; x++)
            {
                Place(x, 0, Cell.Wall);
                Place(x, height - 1, Cell.Wall);
            }

            for (int y = 1; y < height; y++)
            {
                Place(0, y, Cell.Wall);
                Place(width - 1, y, Cell.Wall);
            }

        }

        public void Place(int x, int y, Cell cell)
        {
            if (x < 0 || x >= width || y < 0 || y > height)
                return;
            cells[x, y] = cell;
            LoadImage(boxes[x, y], cell);
        }

        public void Place(Body body)
        {
            Place(body.x, body.y, body.cell);
        }
        public void AddRabbit()
        {
            int x, y, loop = 100;
            do
            {
                x = random.Next(0, width);
                y = random.Next(0, height);
            } while (!IsEmpty(x, y));
            if (loop > 0)
                Place(x, y, Cell.Rabbit);
        }

        public bool IsEmpty(int x, int y)
        {
            if (x < 0 || x >= width || y < 0 || y > height)
                return false;
            return cells[x, y] == Cell.Empty;
        }

        public bool IsEmptyMove(int x, int y)
        {
            if (x < 0 || x >= width || y < 0 || y > height)
                return false;

            return cells[x, y] == Cell.Empty || cells[x, y] == Cell.Rabbit;
        }

        public bool IsRabbit(int x, int y)
        {
            if (x < 0 || x >= width || y < 0 || y > height)
                return false;
            return cells[x, y] == Cell.Rabbit;
        }

        public bool IsStone(int x, int y)
        {
            if (x < 0 || x >= width || y < 0 || y > height)
                return false;
            return cells[x, y] == Cell.stone;
        }

        void LoadImage(PictureBox box, Cell cell)
        {
            switch (cell)
            {
                case Cell.Empty: box.Image = Properties.Resources.empty; break;
                case Cell.Rabbit: box.Image = Properties.Resources.rabbit; break;
                case Cell.Wall: box.Image = Properties.Resources.wall; break;
                case Cell.body: box.Image = Properties.Resources.body; break;
                case Cell.head: box.Image = Properties.Resources.head; break;
                case Cell.tail: box.Image = Properties.Resources.tail; break;             
                case Cell.stone:box.Image = 
                        DateTime.Now.Second % 2 == 0 ? 
                        Properties.Resources.stone : 
                        Properties.Resources.stone2; break;
            }
        }

        internal void AddStone()
        {
                int x, y, loop = 100;
                do
                {
                    x = random.Next(0, width);
                    y = random.Next(0, height);
                } while (!IsEmpty(x, y));
            if (loop > 0)
                Place(x, y, Cell.stone);   
        }

        internal bool IsSmall(int x, int y)
        {
            if (x < 0 || x >= width || y < 0 || y > height)
                return false;
            return cells[x, y] == Cell.small3;
        }
    }
}
