using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string gender = "";
            double height = 0;
            double weight = 0;

        start:
            while (true)
            {
                Console.Write("請輸入性別(男M / 女F)：");
                gender = Console.ReadKey().Key.ToString();
                Console.WriteLine();
                if (gender != "M" && gender != "F")
                {
                    Console.WriteLine("格式錯誤，請重新輸入");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                Console.Write("請輸入身高(cm)：");
                bool isHeight = double.TryParse(Console.ReadLine(), out height);

                if (height <= 0 || !isHeight)
                {
                    Console.WriteLine("格式錯誤，請重新輸入");
                }
                else
                {
                    break;
                }
            }


            while (true)
            {
                Console.Write("請輸入體重(kg)：");
                bool isWeight = double.TryParse(Console.ReadLine(), out weight);

                if (weight <= 0 || !isWeight)
                {
                    Console.WriteLine("格式錯誤，請重新輸入");
                }
                else
                {
                    break;
                }
            }

            double BMI = weight / ((height * 0.01) * (height * 0.01));

            Console.WriteLine($"BMI為：{BMI}");

            switch (gender)
            {
                case "M":
                    if (BMI > 25) Console.WriteLine("太胖！");
                    else if (BMI > 20) Console.WriteLine("適中");
                    else Console.WriteLine("太瘦");
                    break;
                case "F":
                    if (BMI > 22) Console.WriteLine("太胖！");
                    else if (BMI > 18) Console.WriteLine("適中");
                    else Console.WriteLine("太瘦");
                    break;
            }

            Console.Write("輸入r重新開始，輸入r以外的鍵結束程式：");
            string restart = Console.ReadKey().Key.ToString();
            Console.WriteLine();
            switch (restart)
            {
                case "R":
                    goto start;
                default:
                    return;
            }
        }


    }
}

