// See https://aka.ms/new-console-template for more information
using Zadanie_DZ_Day4;
using System;

namespace Zadanie_DZ_Day4 {

    class Program {

      static  bool chack_part<T>(  T part )
        {
            bool chack = false;
            if ( part != null )
            {
                chack = true;
            }

            return chack;
        
        }

        static void Main(string[] args)
        {


           

            //Worker br2 = new Worker(new DateTime(2003, 11, 09), "Консантин", "Иванович",
            //    "Тяпляпов", "Каменщик");


            // создаем обьект  дом
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("Начало строительства дома");
            int walls_num = 4;
            int windows_num = 4;
            House house1 = new House(walls_num, windows_num);
            Console.WriteLine("__ house1  информация о доме________________________________________________");
            house1.house_info();


            Console.WriteLine("___basement2 разнорабочий делает фундамент_______________________________________________");
            // создаём рабочего, который делает фундамент
            Worker simpleWorker1 = new Worker(new DateTime(2003, 10, 29), 
                "Аркадий", "Иванович", "Райкин", "Разнорабочий");

            simpleWorker1.display();

            Basement? basement = null;  // объект basement

            // проверка построет ли фундамент

            Console.WriteLine("___team leader Прораб _______________________________________________");

            Team_leader teamLeader = new Team_leader();
            teamLeader.setBirthday(new DateTime(1993, 10, 03));
            teamLeader.First_name = "Григорий";
            teamLeader.Second_name = "Федорович";
            teamLeader.Lastt_name = "Солженицин";
            teamLeader.Profession = "Прораб";

            teamLeader.display();
            Console.WriteLine(teamLeader.DoJob("Планирую дом, составляю сметы "));


            //bool isBasement = chack_part(basement);

            //  teamLeader проверяет работу (построен ли фундамент)
            bool isBasement = teamLeader.CheckJob(basement); 


            // если  фундамент не построен -> строим 
            if (!isBasement)
            {
                //Console.WriteLine("фундамент не построен " + isBasement);
                // инициализация basement
                basement = simpleWorker1.DoJob(new Basement(0.5f, 1.5f, 9.2f, 10.4f));
                house1.SetBasement(basement);
                isBasement = true;
                Console.WriteLine("фундамент  построен " + isBasement);

            }
            else
            {
                Console.WriteLine("фундамент уже  построен");
               

            }

  
            Console.WriteLine("__ house1  информация о доме________________________________________________");
            house1.house_info();




            Console.WriteLine("___каменщик выкладывает 4 стены  _______________________________________________");
            Worker br1 = new Worker();
            br1.setBirthday(new DateTime(1999, 10, 09));
            br1.First_name = "Василий";
            br1.Second_name = "Иванович";
            br1.Lastt_name = "Чапаев";
            br1.Profession = "Каменщик";
            //информация о каменщике
            br1.display();


            // если построен фундамент то
            // каменщик выкладывает 4 стены
            // возникает проблема хардкод (если стены не 4 а 3 или 5 )
            // то надо переписывать код

            Wall? wall1 = null;
            Wall? wall2 = null;

            Wall? wall3 = null;
            Wall? wall4 = null;


            //bool isWall = chack_part(wall1);  

            //  teamLeader проверяет работу (построена ли стена)
            bool isWall = teamLeader.CheckJob(wall1);


            isWall = teamLeader.CheckJob(wall2);
            isWall = teamLeader.CheckJob(wall3);
            isWall = teamLeader.CheckJob(wall4);

            Console.WriteLine($" teamLeader проверяет работу (построена ли стена) {isWall}");


            //
            // если построен фундамент а стены не построины то
            // каменщик выкладывает 4 стены
            if (!isWall && isBasement)
            {
                wall1 = br1.DoJob(new Wall(4.5f, 0.7f, 8.2f));
                wall2 = br1.DoJob(new Wall(3.8f, 0.5f, 9.2f));

                wall3 = br1.DoJob(new Wall(4.5f, 0.7f, 8.2f));
                wall4 = br1.DoJob(new Wall(3.8f, 0.5f, 9.2f));
                 
                // устанавливаем 4 стены
                house1.setWall(wall1, 0);
                house1.setWall(wall2, 1);
                house1.setWall(wall3, 2);
                house1.setWall(wall4, 3);

                isWall = teamLeader.CheckJob(wall4);

            }
            Console.WriteLine($" teamLeader проверяет работу (построена ли стена) {isWall}");








            Console.WriteLine("__ house1  информация о доме________________________________________________");
       
        
            // информация о доме
            house1.house_info();


            Console.WriteLine("___ Плотник ставит Окно Window_______________________________________________");
            Worker windows_maker = new Worker(new DateTime(2004, 04, 19),
                "Алексей", "Петрович", "Пряников", "Плотник");
            windows_maker.display();
            Console.WriteLine("__ house1  информация о доме________________________________________________");

            Window wind1 = windows_maker.DoJob(new Window(0.8f, 1.2f));
            Window wind2 = windows_maker.DoJob(new Window(1.2f, 1.5f));
            Window wind3 = windows_maker.DoJob(new Window(0.8f, 1.5f));
            Window wind4 = windows_maker.DoJob(new Window(0.9f, 1.1f));

            house1.setWindows(wind1, 0);
            house1.setWindows(wind2, 1);
            house1.setWindows(wind3, 2);
            house1.setWindows(wind4, 3);
        

            house1.house_info();


            Console.WriteLine("__Дверь ________________________________________________");
            Worker door_maker = new Worker(new DateTime(2014, 03, 15),
                "Валерий", "Павлович", "Синицин", "Плотник");
            door_maker.display();
            Door door = door_maker.DoJob(new Door(2.2f, 0.9f));
            house1.SetDoor(door);
            house1.house_info();

            

       
            



            Console.WriteLine("__Крыша ________________________________________________");
            Worker roof_maker = new Worker(new DateTime(2009, 02, 17),
                "Сергей", "Иванович", "Верхолазов", "Кровельщик");
            roof_maker.display();

            // make roof
          
            Roof roof = roof_maker.DoJob(new Roof("Евро - чердак", "Эко солома"));
            house1.setRoof(roof);

            house1.house_info();



            //Console.WriteLine("___team leader Прораб _______________________________________________");

            //Team_leader teamLeader = new Team_leader();
            //teamLeader.setBirthday(new DateTime(1993, 10, 03));
            //teamLeader.First_name = "Григорий";
            //teamLeader.Second_name = "Федорович";
            //teamLeader.Lastt_name = "Солженицин";
            //teamLeader.Profession = "Прораб";

            //teamLeader.display();
            //Console.WriteLine(teamLeader.DoJob("Планирую дом, составляю сметы "));


            //Roof roof2 = new Roof();
            //Roof roof2;
            //string str = "some text";
            //Console.WriteLine(teamLeader.CheckJob(house1.GetWindow(0)));

            bool house_built = teamLeader.CheckJob(house1.GetWindow(0));

            if (house_built)
            {
                Console.WriteLine("Дом построен");
            }
            else
                Console.WriteLine("Дом не построен");




        }
    }
}
