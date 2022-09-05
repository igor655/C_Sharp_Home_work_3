//See https://aka.ms/new-console-template for more information
//using HW_3;
using System;

namespace HW_3
{
    class Program
    {

        public static void Main(String[] args)
        {
            //Console.WriteLine("Hello, World!");


            Car mers = new Car("Mercedes", "s206", 1351472110, 1422655.3m, "wite");
            mers.display();
            Console.WriteLine("------------------------------------------");
            mers.Color = "Black";
            mers.display();


            Console.WriteLine("------------------------------------------");
            bool is_manual_trnsmission = mers.Is_manual_tansmission;
            // до изменения is_manual_trnsmission
            Console.WriteLine("variable is_manual_trnsmission = " + is_manual_trnsmission);

            mers.change_transmission(ref is_manual_trnsmission);
            // после изменения is_manual_trnsmission
            // изменяет значение переменной  is_manual_trnsmission но не поля класса
            Console.WriteLine("variable is_manual_trnsmission = " + is_manual_trnsmission);


            Console.WriteLine("------------------------------------------");
            mers.display();

            Car bmw = new Car();
            bmw.sell_car();

            Car bmw1 = new Car();
            bmw1.sell_car();

            Car zapor = new Car("Запорожец", "M1956", 7, 300, "Red");
            zapor.sell_car();

            //static 
            Console.WriteLine("статическое поле car_count =  " + Car.car_count);

            // независимо от марки, общее количество проданных автомобилей
            Console.WriteLine("статическое поле количество проданных автомобилей =  " + Car.number_of_sold_cars);

            //------------------
            //1.8 Создать массив(не менее 5 элементов) объектов созданного класса.


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Массив автомобилей");
            int car_mum = 7;
            Car[] cars = new Car[car_mum];
            for (int i = 0; i < car_mum; i++)
            {
                cars[i] = new Car("Audi " + (i + 1));
            }

            foreach (Car car in cars)
            {
                car.display();
                Console.WriteLine("------------------");

            }

            zapor.do_something();
        }
    }
}




