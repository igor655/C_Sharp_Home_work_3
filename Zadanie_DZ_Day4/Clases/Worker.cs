using System;


namespace Zadanie_DZ_Day4
{
    internal class Worker : Person, IWorker
    {

        public string? Profession { get; set; }

        public Worker() { }
        public Worker(DateTime birthday, string first_name = "name",
           string second_name = "second_name",
           string last_name = "last name", string profession = "profession") :
            base(birthday, first_name, second_name, last_name)
        {

            Profession = profession;
        }

        public override void display()
        {
            Console.WriteLine("Имя : " + first_name);
            Console.WriteLine("Отчество : " + second_name);
            Console.WriteLine("Фамилия : " + last_name);
            Console.WriteLine("Специальность : " + Profession);
            Console.WriteLine("Дата рождения : " + birthday.ToShortDateString());
        }



        public Item DoJob<Item>(Item item)
        {
            //throw new NotImplementedException();
            return item;
        }
    }
}
