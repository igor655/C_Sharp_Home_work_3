using System;


namespace Zadanie_DZ_Day4
{
    internal class Door : IPart
    {
        public float Width { get;  set; }
        public float Height { get;  set; }


        public Door(float Width, float Height )
        {
            this.Width = Width;
            this.Height = Height;

        }


        public void print_info()
        {
            Console.WriteLine("Door infor : ");
            Console.WriteLine($"Door Width = {Width} ");
            Console.WriteLine($"Door Height = {Height}");
          
        }
    }
}
