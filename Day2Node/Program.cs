using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yunsuanCode
//运算符
{
    class Program
    {
        public void a()
        {
            Console.WriteLine(1);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.a();


            #region 运算符
            //1.赋值运算符
            //2.算数运算符（+-*/）
            //3.逻辑运算符（&& || ！）注意：只运用与bool
            //4.比较运算符 （ > < == <= >= !=)
            //5.位运算符 （ & | ^ ~ << >> )

            //int[] array = new int[11] { 5, 1, 3, 4, 5, 2, 1, 4, 5, 2, 6 };
            //Array.Sort(array);
            //int result = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    result ^= array[i];
            //}
            //Console.WriteLine(result);

            //分支语句 if else switch

            //循环语句  do while while for for each

            #endregion

            #region 数组

            //数组：将相同数据类型的数据，形成一个个有序的集合称之为数组（连续的内存空间）
            //注意：C#中数组长度确定之后不可修改
            //当定义数组是，不手动初始化数组中的元素值，那么会根据当前数组的数据类型来赋予默认值
            //定义方式
            //方法一：
            //int[] arr1 = { 1, 2, 3 };
            ////方法二：
            //int[] arr2 = new int[] { 1, 2, 3 };
            ////方法三：
            //int[] arr3 = new int[6];
            ////二维数组的定义：每一个元素的个数必须相同
            //int[,] arr4 = { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
            //int[,] arr5 = new int[3, 3];
            //int[,] arr6 = new int[3, 3] { { 1, 2, 3 }, { 2, 3, 4 }, { 1, 2, 3 } };



            //int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 2, 3, 4 }, { 1, 2, 3 } };
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine(arr[i, j]);
            //    }
            //}
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine(arr[i, j]);
            //    }
            //}
            #endregion

            #region 函数

            //函数：返回值类型  函数名 参数列表
            //void：当一个函数不需要有返回值时，返回void，如果需要有返回值，使用对应的数据类型
            //在C#中，如果需要给函数参数的话，必须在定义的时候明确的写出参数类型
            static void Test()
            {

            }
            

            #endregion
        }
        
    }
}