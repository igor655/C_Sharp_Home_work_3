using System;


namespace Zadanie_DZ_Day4
{
    internal class Window 
    {
        float m_window_height;
        float m_window_length;

        public Window(float window_height, float window_length)
        {
            m_window_height = window_height;
            m_window_length = window_length;


        }
        public float WindowHeight 
        { get { return m_window_height; } 
            set { m_window_height = value; }
        
        }
        public float WindowLength { 
            get { return m_window_length;}
            set { m_window_length = value; }
        
        }

        public override string ToString()
        {
           
            return $"Высота окна: {m_window_height } " +
                $"Ширина окна: {m_window_length} ";
        }
    }
}
