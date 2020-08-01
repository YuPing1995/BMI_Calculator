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

            string animalType = "";
            double height = 0;
            double weight = 0;
           
        start:
            while (true)
            {
                Console.Write("請輸入動物類別 (如：男M / 女F / 貓C)：");
                animalType = Console.ReadKey().Key.ToString();
                Console.WriteLine();
                if (animalType != "M" && animalType != "F" && animalType != "C")
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



            Animal animal = new Man(height, weight); 
            switch (animalType)
            {                
                case "F":
                    animal = new Woman(height, weight);
                    break;
                case "C":
                    animal = new Cat(height, weight);
                    break;
            }
            Console.WriteLine($" BMI值：{animal.bmi}, 計算結果：{animal.GetBmiResult()}");


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

