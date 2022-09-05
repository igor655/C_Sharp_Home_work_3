using System;


namespace Zadanie_DZ_Day4
{
    internal class Roof :IPart
    {
        public string Roof_type { get; set; }
        public string Roof_name { get; set; }


        public Roof()
        {

        }
        public Roof(string r_type , string r_name)
        {
            Roof_type = r_type;
            Roof_name = r_name;

        }
        
        public void print_info()
        {
            Console.WriteLine($"Тип крыши:  {Roof_type}  Название крыши :  {Roof_name} ");
        }
    }
}
