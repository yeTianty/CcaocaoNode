using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Work
{
    public class Day1Work
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1计算器，2进入登录注册系统");
            string kon = Console.ReadLine();
            if (kon == "2")
            {
                #region login

                string result = "";
                string zh = "";
                string ps = "";
                bool succeed = false;
                while (succeed == false)
                {
                    Console.WriteLine("请输入：1.登录；2.注册");
                    string choose = Console.ReadLine();
                    while (result == "")
                    {
                        if (choose == "1" || choose == "2")
                        {
                            result = choose;
                        }
                        else
                        {
                            Console.WriteLine("你输入有误");
                            choose = Console.ReadLine();
                        }
                    }
                    switch (result)
                    {
                        case "2":
                            Console.WriteLine("注册");
                            Console.WriteLine("输入账号");
                            string zhanghao = Console.ReadLine();
                            Console.WriteLine("输入密码");
                            string psw = Console.ReadLine();
                            Console.WriteLine("确认密码");
                            string repsw = Console.ReadLine();
                            while (psw != repsw)
                            {
                                Console.WriteLine("输入密码");
                                psw = Console.ReadLine();
                                Console.WriteLine("确认密码");
                                repsw = Console.ReadLine();
                            }
                            zh = zhanghao;
                            ps = psw;
                            result = "";
                            break;
                        case "1":
                            Console.WriteLine("输入登录账号");
                            string zhanghao1 = Console.ReadLine();
                            while (zhanghao1 != zh)
                            {
                                Console.WriteLine("账号不存在，请重新输入账号");
                                zhanghao1 = Console.ReadLine();
                            }
                            Console.WriteLine("输入密码");
                            string psw1 = Console.ReadLine();
                            while (psw1 != ps)
                            {
                                Console.WriteLine("密码不存在，请重新输入密码");
                                psw1 = Console.ReadLine();
                            }
                            Console.WriteLine("账号：{0},密码：{1},登录成功", zh, ps);
                            succeed = true;
                            break;
                    }
                }
                #endregion
            }
            else if (kon == "1")
            {
                #region 计算器
                Console.WriteLine("请输入第一个数");
                var num1 = Console.ReadLine();
                Console.WriteLine("请输入第二个数");
                var num2 = Console.ReadLine();
                Console.WriteLine("请输入符号");
                var code = Console.ReadLine();
                var result = 0;
                if (code == "+")
                {
                    result = int.Parse(num1) + int.Parse(num2);
                }
                else if (code == "-")
                {
                    result = int.Parse(num1) - int.Parse(num2);
                }
                else if (code == "*")
                {
                    result = int.Parse(num1) * int.Parse(num2);
                }
                else if (code == "/")
                {
                    result = int.Parse(num1) / int.Parse(num2);
                }

                //}
                Console.WriteLine(num1 + " " + code + " " + num2 + "= " + result);
                #endregion
            }

        }
    }
}
