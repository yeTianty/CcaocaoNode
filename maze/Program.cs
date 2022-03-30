using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[,] wall = new string[20, 20];
            int[] ppPos = new int[2] { -1, -1 };
            //生成迷宫
            wall = createMaze(wall);
            Console.WriteLine("迷宫生成完毕");
            //存储小人坐标
            ppPos = createPeople(wall, ppPos);
            while (true)
            {//小人移动
                openKey(wall, ppPos);
            }
        }

        #region 生成迷宫 createMaze()
        //生成迷宫
        static string[,] createMaze(string[,] wall)
        {
            Console.Clear();
            for (int i = 0; i < wall.GetLength(0); i++)
            {
                for (int j = 0; j < wall.GetLength(1); j++)
                {
                    //随机选择方块挖空 且不为最边上方块
                    Random r = new Random();
                    int t = r.Next(2);
                    if (t > 0.05 && i != 0 && i != 19 && j != 0 && j != 19)
                    {
                        wall[i, j] = "  ";
                    }
                    else
                    {
                        wall[i, j] = "■";
                    }
                    Console.Write(wall[i, j]);
                }
                Console.Write("\n");
            }
            return wall;
        }
        #endregion

        #region 生成小人 createPeople()
        static int[] createPeople(string[,] wall, int[] ppPos)
        {
            int[] pos = new int[2];
            Console.WriteLine("想要生成小人的位置（x,y)");
            Console.WriteLine("请输入行：（1-18）");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入列：（1-18）");
            int y = int.Parse(Console.ReadLine());
            if (x < 1 || x > 18 || y < 1 || y > 18)
            {
                Console.WriteLine("您输入的坐标不存在，请重新输入");
                return createPeople(wall, ppPos);
            }
            else
            {
                pos[0] = y;
                pos[1] = x;
                reMap(wall, pos);
                return pos;
            }
        }
        #endregion

        #region 刷新地图
        static void reMap(string[,] wall, int[] pos)
        {
            Console.Clear();
            for (int i = 0; i < wall.GetLength(1); i++)
            {
                for (int j = 0; j < wall.GetLength(0); j++)
                {
                    if (wall[i, j] == "♂")
                    {
                        wall[i, j] = "  ";
                    }
                    if (i == pos[0] && j == pos[1])
                    {
                        wall[i, j] = "♂";
                    }
                    Console.Write(wall[i, j]);
                }
                Console.Write("\n");
            }
        }
        #endregion
        //移动小人 peopleMove()
        #region 启用键盘
        static void openKey(string[,] wall, int[] ppPos)
        {
            ConsoleKeyInfo info = Console.ReadKey(true);
            switch (info.Key)
            {
                case ConsoleKey.A:
                    Console.Clear();
                    ppPos[1] -= 1;
                    if (wall[ppPos[0], ppPos[1]] == "■")
                    {
                        ppPos[1] += 1;
                    }
                    reMap(wall, ppPos);
                    break;
                case ConsoleKey.D:
                    Console.Clear();
                    ppPos[1] += 1;
                    if (wall[ppPos[0], ppPos[1]] == "■")
                    {
                        ppPos[1] -= 1;
                    }
                    reMap(wall, ppPos);
                    break;
                case ConsoleKey.S:
                    Console.Clear();
                    ppPos[0] += 1;
                    if (wall[ppPos[0], ppPos[1]] == "■")
                    {
                        ppPos[0] -= 1;
                    }
                    reMap(wall, ppPos);
                    break;
                case ConsoleKey.W:
                    Console.Clear();
                    ppPos[0] -= 1;
                    if (wall[ppPos[0], ppPos[1]] == "■")
                    {
                        ppPos[0] += 1;
                    }
                    reMap(wall, ppPos);
                    break;
            }
        }
        #endregion
    }
}
