using System;

namespace HW_3
{
    internal partial class Car
    {
        //1.1 Разработать один из классов, в соответствии с полученным вариантом.

        /*
         * 1.2 Реализовать не менее пяти закрытых полей (различных типов), представляющих
            основные характеристики рассматриваемого класса.

        1.3 Создать не менее трех методов управления классом и методы доступа к его
        закрытым полям.

        1.4 Создать метод, в который передаются аргументы по ссылке.

        1.5 Создать не менее двух статических полей (различных типов), представляющих
            общие характеристики объектов данного класса.

        1.6 Обязательным требованием является реализация нескольких перегруженных
            конструкторов, аргументы которых определяются студентом, исходя из
            пецифики реализуемого класса, а так же реализация конструктора по
            умолчанию.

        1.7 Создать статический конструктор.

        1.8 Создать массив (не менее 5 элементов) объектов созданного класса.
         * 
         */

        private string brand;
        private string model;
        private int factory_number; 
        private decimal price;
        private string color;
        private bool is_manual_tansmission;
        private bool is_car_sold;

        // static field number of cars built
        internal static int car_count;
        // количество проданных автомобилей
        public static int number_of_sold_cars;

        public  void sell_car()
        {
            is_car_sold = true;
            if (is_car_sold)
            {
                number_of_sold_cars++;

            }

        }

        // статический конструктор
        static Car()
        {
            Console.WriteLine("вызван статический конструктор\nсознан новый автомобиль");
        }

        // консрукторы
        public Car() : this("undefined") { }  
       
        public Car(string brand) : this(brand, "undefined") { }
        public Car(string brand, string model) : this(brand, model, 0) { }
        public Car(string brand, string model, int Ffactory_number) :
            this(brand, model, Ffactory_number, 0) { }

        public Car(string brand, string model, int Ffactory_number, decimal price) : 
            this(brand, model, Ffactory_number, price, "undefined") { }

        public Car(string brand, string model, int Ffactory_number, decimal price, string color) :
            this(brand, model, Ffactory_number, price, color, false)
        { }

        public Car(string brand, string model, int Ffactory_number, 
            decimal price, string color, bool is_manual_tansmission)
        {
            this.brand = brand; 
            this.model = model;
            this.factory_number = Ffactory_number;
            this.price = price;
            this.color = color;
            this.is_manual_tansmission = is_manual_tansmission;
            car_count++;

          

        }
        
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }   
            set { model = value; }

        }
        public int Factory_number
        {
            get { return factory_number; } 
            set { factory_number = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public bool Is_manual_tansmission { get; set; }

        public bool Is_car_sold { get; set; }




        public void display() => 
            Console.WriteLine("brand = {0} \nmodel = {1}\nfactory_number = {2}" +
                    "\nprice = {3}\ncolor = {4}\nmanual_transmission {5} ", 
                brand, model, factory_number, price, color, is_manual_tansmission);



        // 1.4 Создать метод, в который передаются аргументы по ссылке.
        internal void change_transmission(ref bool is_manual_tansmission)
        {
            is_manual_tansmission = true;

        }





        //private string _model;

        //public Car(string model)
        //{
        //    _model = model;


        //}
        //public string get_model()
        //{
        //    return _model;  
        //}
    }
}
