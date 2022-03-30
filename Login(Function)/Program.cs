using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Login
{
    class Program
    {
        private static string myPsw;
        private static string myUsername;
        private static string choose;

        static void Main(string[] args)
        {
            Console.WriteLine("请输入1登录 2注册");
            choose = Console.ReadLine();
            Start();

        }

        static void Start()
        {
            if (choose == "1")
            {
                Login();
            }else if(choose == "2")
            {
                sinIn();
            }
        }
        static void Login()
        {
            Console.WriteLine("登录界面");
            Console.WriteLine("请输入账号");
            string username = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string psw = Console.ReadLine();

            if (username == myUsername && psw == myPsw)
            {
                Console.WriteLine("登录成功");
                return;
            }
            else
            {
                Console.WriteLine("没有注册账户，跳转注册界面");
                sinIn();
            }
        }

        static void sinIn()
        {
            Console.WriteLine("注册界面");
            Console.WriteLine("请输入账号");
            string username = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string psw = Console.ReadLine();
            Console.WriteLine("请再次输入密码");
            string repsw = Console.ReadLine();
            if (psw == repsw)
            {
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(psw))
                {
                    myUsername = username;
                    myPsw = psw;
                    Console.WriteLine("注册成功，返回开始界面");
                    Start();
                }
            }
            else
            {
                Console.WriteLine("注册失败，返回注册界面");
                sinIn();
            }
        }
    }
}