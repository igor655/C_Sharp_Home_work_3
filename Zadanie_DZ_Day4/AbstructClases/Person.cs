using System;

namespace Zadanie_DZ_Day4
{
    internal abstract class Person
    {
        protected private  string? first_name;
        protected private string? second_name;
        protected private string? last_name;
        protected private DateTime birthday;


        public Person() { }
        public Person(DateTime birthday, string first_name = "name",
           string second_name = "second_name",
           string last_name = "last name")
        {
            this.first_name = first_name;
            this.second_name = second_name;
            this.last_name = last_name;
            this.birthday = birthday;


        }

        public string? First_name { get => first_name; set => first_name = value; }
        public string? Second_name { get => second_name; set => second_name = value; }
        public string? Lastt_name { get => last_name; set => last_name = value; }

        public void setBirthday(DateTime b)
        {
            this.birthday = b;
        }





        public abstract void display();
        


    }
}
