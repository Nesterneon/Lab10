using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle();
            angle.Gradus=10;
            angle.Min = 16;
            angle.Sec = 24;
            angle.ToRedians();
            Console.ReadKey();
        }
    }
    class Angle
    {
        int gradus;
        int min;
        int sec;
        public int Gradus
        {
            set
            {
                if (value < 360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Градусов не может быть больше 360!");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value < 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Минут не может быть больше 60!");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value < 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Секунд не может быть больше 60!");
                }
            }
            get
            {
                return sec;
            }
        }
        public void ToRedians()
        {
            double Rad = gradus * Math.PI / 180 + min * Math.PI / 180 / 60 + sec * Math.PI / 180 / 360;
            Console.WriteLine("радиан={0}",Rad);
        }
    }
}
