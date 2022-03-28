using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello_World;
using Test;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //快速注释：ctrl + K +C 
            //取消注释： CTRL + K + U；

            #region 整数类型
            //整数类型
            //无符号  1字节 = 8位   
            byte byteValue = 1;         //0 ~ 2 ^ 8 - 1;
            //有符号
            sbyte byteValue2 = -2;      //-2 ^ 7 ~ 2 ^ 7 - 1;
            //有符号 2字节 = 16位
            short shortValue3 = -3;     //0 ~ 2 ^ 16 - 1;
            //无符号
            ushort ushortValue4 = 4;    //-2 ^ 7 ~ 2 ^ 7 - 1;
            //有符号   4字节 = 32位     
            int intValue5 = -5;         //-2 ^ 31 ~ 2 ^ 31 - 1;
            //无符号
            uint uintValue6 = 6;        //0 ~ 2 ^ 32 - 1;
            //有符号   8字节 = 64位
            long longValue7 = -7;       //-2 ^ 63 ~ 2 ^ 63 - 1;
            //无符号
            ulong ulongValue8 = 8;      //0 ~ 2 ^ 64 - 1;

            #endregion

            #region 浮点类型
            //浮点数类型  4个字节
            float floatValue = 9.14f;
            //8字节
            double doubleValue = 3.14;
            //16字节
            decimal decimalValue = 3.14m;

            //小数默认位double， float+f，decimal+m

            //为什么说浮点数是不精准的小数类型：因为小数部分无法精准的用二进制数据表示出来
            //如何做到精确的存储小数：把小数转为字符串存储
            //小数点比较
            if (Math.Abs(floatValue - doubleValue) <= 0.000000001f) { };
            #endregion

            #region 字符(串)类型
            char charValue = 't'; //2个字节
            //字符串类型：char数组
            string stringValue = "ttttt";
            //布尔 一个字节
            bool boolValue = false;
            #endregion

            #region 类型转换
            //根据sbyte数据类型，在内存空间上开一段1个字节的内存空间，将这段空间命名为num1，
            //把10转换成对应的二进制数据对这段内存空间进行填充
            sbyte num1 = 10;
            //根据int数据类型，在内存空间上开一段4个字节的内存空间，将这段空间命名为num2，
            //在内存空间中找到命名为num1的空间，把num1中的值取出，转换成对应的二进制数据进行填充
            int num2 = num1;

            //显示转换
            long num3 = 10;
            num2 = (int)num3;

            //隐式转换：未经过显示转换的方式叫隐式转换
            //取值范围小的转取值范围大的是隐式转换

            //显示转换：经过了显示转换的转换方式叫显示转换
            //取值范围大的转取值范围小的是显示转换
            //会存在数据丢失

            //char 可以转换为数值类型，取值为对应的ascll表
            char charValue1 = 'a';
            ushort num4 = charValue1;
            #endregion
            Class1 class1 = new Class1();
            class1.sayHello(3, 4);

            //特殊转换
            //string 不能隐式转换为其他数据类型
            string stringValue1 = num1.ToString();
            string stringValue2 = num1 + "";
            int intValue1 = int.Parse(stringValue1);
            //decimal取值范围很小，所以在数据类型转换中大部分都是强制转换
            long longValue1 = 1000;
            decimal decimalValue1 = (decimal)intValue1;

            //在C#中 \\表示的是 '\' 来避免和转义字符冲突
            //在字符串前加 @ 符号，表示该段字符中的所有转义字符失效
            Console.WriteLine(@"D:\a\s\d");

            //输入语句
            //Console.ReadLine();

            Console.WriteLine(num4 + "hello world" + class1.sayHello(3, 10));
        }
    }
}