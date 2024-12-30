using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using _4.enumms;
using System.ComponentModel.Design;

namespace _4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region test
            //testclass t = new testclass();
            //t.x = 1;
            //t.print();
            /////////////////
            //st st1 = new st();
            //st1.x = 2;
            //st1.value = 3;
            ///////////////
            test1class t1 = new test1class();
            //t1.print();
            //t1.color1 = (colors)0;
            //Console.WriteLine(t1.color1);
            //t1.color1 = colors.Green;
            //Console.WriteLine(t1.color1);

            ////////////////

            #endregion

            #region 1
            //Part 02
            //1.Create an enum called "WeekDays" with the days of the week
            //(Monday to Sunday) as its members.Then, write a C# program that prints out
            //all the days of the week using this enum.

            //for (int i = 0; i < Enum.GetValues(typeof(WeekDays)).Length; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}
            #endregion


            #region 2

            //2.Create an enum called "Seas on" with the four seasons(Spring, Summer, Autumn
            //, Winter) as  its members.Write a C# program that takes a season name as
            //input
            //from the user and displays the corresponding month range for that season
            //. Note range for seasons ( spring march to may , summer june to august ,
            //autumn September to November , winter December to February)
            //Console.WriteLine("please enter season name");
            //string season = Console.ReadLine();
            //if (Enum.TryParse(typeof(Seas_on),season,true,out object result))
            //{

            //if ((Seas_on)result==Seas_on.Spring)
            //    Console.WriteLine("spring is from march to may");
            //else if ((Seas_on)result == Seas_on.Autumn)
            //    Console.WriteLine("autumn is from june to august");
            //else if ((Seas_on)result == Seas_on.Summer)
            //    Console.WriteLine("summer is from september to November");
            //else if ((Seas_on)result == Seas_on.Winter)
            //    Console.WriteLine("winter is from December to February");
            //else
            //    Console.WriteLine("wrong input");
            //}



            #endregion


            #region 3
            //3. Assign the following Permissions (Read, write, Delete, Execute)
            //in a form of Enum.
            //•	Create Variable from previous Enum to Add and Remove Permission from
            //variable,
            //check if specific Permission is existed inside variable
          //  Console.WriteLine("we have four permission \n 1-read \n 2-write \n 4-delete \n 8-execute");
          //  Console.WriteLine("choose 1 for delete");
          //  Console.WriteLine("choose 2 for add");
          //  Console.WriteLine("choose 3 for check");
          //  int num=int.Parse(Console.ReadLine());
          //  object doo;
          //  //مابيحزفش لييييييييييييييه
          //  if (num == 1) {
          //      Console.WriteLine("enter permission value to  delete if it exist");
          //      bool flag = Enum.TryParse(typeof(permissions), Console.ReadLine(),true, out doo);
          //      if (flag)
          //      {
          //          //t1.permission = t1.permission &~ (permissions)doo;
          //          t1.permission = t1.permission ^ (permissions)doo;
          //          Console.WriteLine(t1.permission);

          //          string[] names = Enum.GetNames(typeof(permissions));
          //          foreach (string name in names)
          //              Console.WriteLine(name);
          //      }
          //      else
          //          Console.WriteLine("wrong input");
          //  }
          // else if (num == 2)
          //  {
          //      Console.WriteLine("enter permision value to add");
          //      bool flag = Enum.TryParse(typeof(permissions), Console.ReadLine(),true, out doo);
          //      if (flag) { 
          //      t1.permission = t1.permission | (permissions)doo;
          //          Console.WriteLine(t1.permission);
          //          string[] names = Enum.GetNames(typeof(permissions));
          //          foreach (string name in names)
          //              Console.WriteLine(name);
          //      }
          //      else
          //          Console.WriteLine("wrong input");
          //  }                                                                                                                                                                   
            
          //else  if (num == 3) { 
            
          //     Console.WriteLine("enter permision value to check");
          //      bool flag = Enum.TryParse(typeof(permissions), Console.ReadLine(),true, out doo);
          //      if (flag)
          //      {
                    
          //       bool isexist=Enum.IsDefined(typeof(permissions),(permissions)doo);
          //        Console.WriteLine(isexist);

                    
          //      }
          //      else
          //          Console.WriteLine("no exist");
          //  }


            #endregion


            #region 4

            //4. Create an enum called "Colors" with the basic colors(Red, Green, Blue) as its members.
            //Write a C# program that takes a color name as input from the user and
            //displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("enter color");
            //string color = Console.ReadLine();
            //if (Enum.TryParse(typeof(colors), color, true, out object result2))
            //{
            //    switch ((colors)result2)
            //    {
            //        case colors.Red:
            //        case colors.Blue:
            //        case colors.Green:
            //            Console.WriteLine($"{color} is basic color");
            //            break;

            //    }
            //    }
            //    else
            //        Console.WriteLine("secondary color");

            #endregion










        }
    }

    }

    
