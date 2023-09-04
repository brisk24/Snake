using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_videosharp.info_
{
    internal class Snake
    {
        Map map;
        int lehgthMax = 9999;
        public int length;
        int stepX = 0, stepY = 0;
        int headX = 0;
        int headY = 0;
        Body[] body;

        Random random = new Random();     
        public Snake(Map map)
        {
            body = new Body[lehgthMax];
            length = 3;
            this.map = map;
            int x, y, loop = 100;
            do
            {
                x = random.Next(1, map.width - 5);
                y = random.Next(1, map.height - 1);
            } while (!(map.IsEmpty(x, y) &&
                       map.IsEmpty(x + 1, y) &&
                       map.IsEmpty(x + 2, y)) && --loop > 0);
            length = 3;
            body[0] = new Body(x, y, Cell.tail);
            body[1] = new Body(x + 1, y, Cell.body);
            body[2] = new Body(x + 2, y, Cell.head);
            map.Place(body[0]);
            map.Place(body[1]);
            map.Place(body[2]);
            headX = x + 2;
            headY = y;
        }

        public bool GameOver()
        {
            if (map.IsEmptyMove(headX - 1, headY) ||
                map.IsEmptyMove(headX, headY - 1) ||
                map.IsEmptyMove(headX + 1, headY) ||
                map.IsEmptyMove(headX, headY + 1))
                return false;
            else
                return true;
        }

        public bool MoveSnake()
        {
            if (stepX == 0 && stepY == 0)
                return true;
            int newHeadX = headX + stepX;
            int newHeadY = headY + stepY;


            if (map.IsEmpty(newHeadX, newHeadY))
            {

                headX = newHeadX;
                headY = newHeadY;
                MoveTail();
                MoveBody();
                MoveHead();
                return true;
            }

            if (map.IsRabbit(newHeadX, newHeadY))
            {
                headX = newHeadX;
                headY = newHeadY;
                LongSnake();
                return true;
            }          
            return false;
        }
        private void MoveHead()
        {
            body[length - 1].x = headX;
            body[length - 1].y = headY;
            map.Place(body[length - 1]);
        }

        private void MoveBody()
        {
            for (int s = 1; s < length - 1; s++)
            {
                body[s].x = body[s + 1].x;
                body[s].y = body[s + 1].y;

            }
            map.Place(body[length - 2]);
        }

        private void MoveTail()
        {
            map.Place(body[0].x, body[0].y, Cell.Empty);
            body[0].x = body[1].x;
            body[0].y = body[1].y;
            map.Place(body[0]);
        }

        public void TurnSnake(int sx, int sy)
        {
            if (Math.Abs(sx) + Math.Abs(sy) != 1)
                return;
            stepX = sx;
            stepY = sy;
        }

        public void LongSnake()
        {
            length++;
            body[length - 1] = new Body(headX, headY, Cell.head);
            map.Place(body[length - 1]);
            body[length - 2].cell = Cell.body;
            map.Place(body[length - 2]);
            map.AddRabbit();
            int r = new Random().Next(2);
            if (r == 0)
                map.AddRabbit();
            else
                map.AddStone();
        }
    }
}
