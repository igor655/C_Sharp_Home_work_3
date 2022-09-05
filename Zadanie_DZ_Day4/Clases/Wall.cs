using System;


namespace Zadanie_DZ_Day4
{
    internal class Wall : IPart
    {
        float height;
        float width;
        float length;


        public Wall() { }

        public Wall(float height, float width ,float length)
        {
            this.height = height;
            this.width = width;
            this.length = length;

        }

        public float Height
        {
            get { return height; }
            set { height = value; }
        }  
        public float Width
        {
            get { return width; }
            set { width = value; }
            
        }
        public float Length
        {
            get { return length; }
            set { length = value; }
        }



        public void print_info()
        {
            Console.WriteLine("Wall infor : ");
            Console.WriteLine($"Width = {width} ");
            Console.WriteLine($"Height = {height}");
            Console.WriteLine($"lenght  = {length}");
        }

    }
}
