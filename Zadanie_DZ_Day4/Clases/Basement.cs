using System;


namespace Zadanie_DZ_Day4
{
    internal class Basement : IPart
    {
        protected float m_basement_depth;
        protected float m_basement_width;
        protected float m_basement_lenth_a;
        protected float m_basement_lenth_b;
       
        //ctor
       
        public Basement(float basement_depth, float basement_width,
          float basement_lenth_a, float basement_lenth_b)
        {
            m_basement_depth = basement_depth;
            m_basement_width = basement_width;
            m_basement_lenth_a = basement_lenth_a;
            m_basement_lenth_b = basement_lenth_b;


        }

      

        public void print_info()
        {
           
            Console.WriteLine($"Basement depth = {m_basement_depth}");
            Console.WriteLine($"Basement width = {m_basement_width}");
            Console.WriteLine($"Basement lenth_a = {m_basement_lenth_a} ");
            Console.WriteLine($"Basement lenth_b = {m_basement_lenth_b}" );
        }
    }
}
