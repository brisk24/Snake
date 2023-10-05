using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_videosharp.info_
{
    public partial class Form1 : Form
    {
        Map map;
        Snake snake;
        Stopwatch stopwatch;
        public int Scope = 0;
        //todo: Сделать рейтинг игроков
        //todo: Добавить тайтл уменьшения тела
        //todo: Новая игра
        public Form1(Form f)
        {
            InitializeComponent();
            this.Left = f.Left;
            this.Top= f.Top;
            stopwatch = new Stopwatch();
            stopwatch.Start();
            map = new Map(panel1);
            int countRabbit = 0;
            for (int r = 0; r < 5; r++)
            {
                map.AddRabbit();
                countRabbit++;
            }
            snake = new Snake(map);
            timer.Enabled = true;
            labelWidth.Text = $"Ширина: {map.widthCount().ToString()} (квадратов)";
            labelHeight.Text = $"Высота: {map.heightCount().ToString()} (квадратов)";
            labelSize.Text = $"Размер: {snake.length}";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                snake.TurnSnake(-1, 0);
            }

            if (e.KeyCode == Keys.Right)
            {
                snake.TurnSnake(1, 0);
            }

            if (e.KeyCode == Keys.Up)
            {
                snake.TurnSnake(0, -1);
            }

            if (e.KeyCode == Keys.Down)
            {
                snake.TurnSnake(0, 1);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (snake.GameOver())
            {
                timer.Enabled = false;
                MessageBox.Show("Конец игры!", "Информация");
                this.Close();
            }

            int size = snake.length;
            Scope = (snake.length * 10) + Convert.ToInt32(stopwatch.Elapsed.TotalSeconds);
            snake.MoveSnake();
            if (size < snake.length)
            {
                labelSize.Text = $"Размер: {snake.length}";
                labelScope.Text = $"Очки: {Scope}";
            }

        }
    }
}
