using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Animal
    {
        public double bmi;
        public Animal(double height, double weight)
        {
            this.bmi = weight / ((height * 0.01) * (height * 0.01));
        }

        //計算結果
        public string CalculateBMI(double BMI, double fatBMI, double thinBMI)
        {
            if (BMI > fatBMI) return "太胖！";
            else if (BMI > thinBMI) return "適中";
            else return "太瘦";
        }

        //取得結果
        internal abstract string GetBmiResult();

    }

    internal class Woman : Animal
    {
        public Woman(double height, double weight) : base(height, weight)
        { }

        internal override string GetBmiResult()
        {
            return CalculateBMI(bmi, 22, 18);
        }

    }

    internal class Man : Animal
    {
        public Man(double height, double weight) : base(height, weight)
        { }

        internal override string GetBmiResult()
        {
            return CalculateBMI(bmi, 25, 20);
        }

    }
    internal class Cat : Animal
    {

        public Cat(double height, double weight) : base(height, weight)
        { }

        internal override string GetBmiResult()
        {
            return CalculateBMI(bmi, 15, 10);
        }

    }


}



