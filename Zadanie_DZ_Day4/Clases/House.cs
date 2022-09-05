using System;


namespace Zadanie_DZ_Day4
{
    internal class House
    {
      private  Window[] windows;
      private  int windows_number;

        private Wall[] walls;
        private int walls_number;

        private Basement? basement;

        private Roof? m_roof;
        private Door? m_door;


        

       
        public House(int walls_num, int windows_num )
        {
            walls_number = walls_num;
            windows_number = windows_num;
            walls = new Wall[walls_number];
            windows = new Window[windows_number];

           

        }


        public void setWindows(Window window, int windows_number)
        {
            windows[windows_number] = window;
        }

        public Window GetWindow(int n)
        {
            return windows[n];
        }


        public void setWall( Wall wall,  int n_wall)
        {
            //walls[0] = new Wall();
           
            walls[n_wall] = wall;

        }

      

        public Wall GetWal(int n)
        {
            return walls[n];
        }

        public void SetBasement (Basement bs)
        {
            this.basement = bs;
        }

        //public Basement GetBasement() { return basement; }

        public void setRoof(Roof roof)
        {
            m_roof = roof;
        }

        public Roof? GetRoof() { return m_roof; }


        public void SetDoor(Door door)
        { m_door = door; }
        public Door? GetDoor() { return m_door; }









        public void house_info()
        {

            if (basement != null)
            {
                Console.WriteLine("Фундамент заложен");
                basement.print_info();

            }
            else
            {
                Console.WriteLine("В доме пока нет фундамента");
            }
            Console.WriteLine("-----");

            int wall_count = 0;
            for (int i = 0; i < walls_number; i++)
            {
                if (GetWal(i) != null)
                {
                    Console.WriteLine("Высота стены " + (i + 1) + " = " + GetWal(i).Height);
                    Console.WriteLine("Ширина стены " + (i + 1) + " = " + GetWal(i).Width);
                    Console.WriteLine("Длина стены " + (i + 1) + " = " + GetWal(i).Length);

                    wall_count++;
                }

            }
            Console.WriteLine("-----");
            int window_count = 0;
            for (int i = 0; i < 4; i++)
            {
                if (GetWindow(i) != null)
                {
                    Console.WriteLine("Высота окна " + (i + 1) + " = " + GetWindow(i).WindowHeight);
                    Console.WriteLine("Ширина окна " + (i + 1) + " = " + GetWindow(i).WindowLength);
                   

                    window_count++;
                }
            }


            Console.WriteLine($"В доме {wall_count}  стены");
            Console.WriteLine($"В доме {window_count}  окна");

            Console.WriteLine("-----");
            if (m_roof !=null)
            {

            m_roof.print_info();
            }
            else
            {
                Console.WriteLine("Дом пока без крыши");
            }

            // door
            if (m_door != null)
            {
                Console.WriteLine("дверь поставленна");
                m_door.print_info();
            }
            else
            {
                Console.WriteLine("Дом пока без двери");
            }



            //bool house_built = teamLeader.CheckJob(house1.GetWindow(0))

            //if (m_roof != null && walls != null && basement != null && windows != null)
            //{
            //    Console.WriteLine("Дом построен");
            //}
            //else
            //    Console.WriteLine("Дом не построен");

            //if (m_roof != null && walls != null && basement != null && windows != null)
            //{
            //    Console.WriteLine("Дом построен");
            //}
            //else
            //    Console.WriteLine("Дом не построен");




            Console.WriteLine();

            
        }

    }
}
