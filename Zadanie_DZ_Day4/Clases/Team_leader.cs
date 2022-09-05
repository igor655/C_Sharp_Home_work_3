using System;

namespace Zadanie_DZ_Day4
{
    internal class Team_leader : Person, IWorker
    {

        public string? Profession { get; set; }


        public Team_leader() { }

        public Team_leader(
         DateTime birthday, string first_name, string second_name,
         string last_name, string profession = " profession")
        : base(birthday, first_name, second_name, last_name)


        {
            this.Profession = profession;

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

            return item;
        }

        public bool CheckJob<T> (T i)
        {

            bool b = false;
            if (i != null)
            {
                b = true;
            }
            return b;
        }

    }
}


//Ошибка	CS0161	"Team_leader.CheckJob<T>(T)": не все пути к коду возвращают значение.	Zadanie_DZ_Day4	C:\Users\bells\source\repos\HW_3\Zadanie_DZ_Day4\Clases\Team_leader.cs  39  Активные

