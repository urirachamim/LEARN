using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace My_project
{
    internal class Program
    {

        //int array 
        //static void Main(string[] args)
        //{

        //    int[] arr = new int[3];
        //    arr[0] = 5;
        //    arr[1] = 2;
        //    arr[2] = 10;

        //    Console.WriteLine(arr[0]);


        //    int sum = arr[0] + arr[1] + arr[2];
        //    int avg = sum / 3;

        //    Console.WriteLine(sum + avg);

        //}




        //string array

        //static void Main()
        //{

        //    string [] nameArr = new string[4];

        //    nameArr[0] = "Uri";
        //    nameArr[1] = "David";
        //    nameArr[2] = "Lior";



        //    Console.WriteLine(nameArr[0] + nameArr[2]);





        //}



        // while 


        static void Main(string[] args)
        {


            //int i = 0;

            //while (i < 10)
            //{

            //    Console.WriteLine("hellow"+i);

            //    i++;
            //    if (i == 5)

            //        Console.WriteLine(i+"="+"1+2+3+4");

            //}



            //......................................................



            //int i = 0;

            //while (i < 3)
            //{

            //    i++;


            //    if (i == 3)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("loop done");
            //    }



            //........................................


            ////מספר זוגי
            //int i = 1;

            //while (i < 10)  

            //    {
            //        if (i % 2 == 0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //      i++;
            //    }



            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''



            //for (int i = 0; i < 3; i++)
            //{

            //    Console.WriteLine(i + "uri");


            //}


            //''''''''''חילוק ב3 ''''''''''''''''''''''''''''''''''''''''''''''

            //for (int i = 0; i < 50; i++)

            //    //if (i % 3 == 0)
            //    //{
            //    //    Console.WriteLine(i);


            //        if (i % 10 == 0)
            //        {
            //            Console.WriteLine(i+"Ya habibi");
            //        }



            // }


            //    //''''''שמרית נתונים בקונסול'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //    Console.WriteLine("please implement a number");

            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("please implement second number");
            //    int num2 = int.Parse(Console.ReadLine());

            //    for (int i = num1; i <= num2; i++)
            //    {
            //        //Console.WriteLine(i);

            //    }


            //    int max;
            //    int min;




            //    if (num1 >= num2)
            //    {

            //        max = num1;
            //        min = num2;
            //    }
            //    else
            //    {
            //        max = num2;
            //        min = num1;
            //    }


            //    for (int i = min; i <= max; i++)
            //    {
            //        Console.WriteLine(i);

            //    }
            //}




            //''''''''''''' ומערך ולולאה מודפסת

            //  int name = 0;

            //  string[] namesArr = new string[5];
            //  namesArr[0] = "uri";
            //  namesArr[1] = "eli";
            //  namesArr[2] = "mama";
            //  namesArr[3] = "nana";
            //  namesArr[4] = "david";


            //  //string sum = namesArr[0] + namesArr[1]+ namesArr[2] + namesArr[3];


            //  for (int i = 0; i > namesArr.Length; i++) ;




            //  double[] arr = new double[5];
            //  arr[0] = 95.9;
            //  arr[1] = 71;
            //  arr[2] = 88.4;
            //  arr[3] = 12.5;
            //  arr[4] = 51;



            //double sum = arr[0]+ arr[1]+ arr[2] + arr[3]+ arr[4];
            //double avag = sum / 5;




            //  for (int i = 0; i < arr.Length; i++)


            //  {
            //      Console.WriteLine(namesArr[i]);

            //      Console.WriteLine(arr[i]);

            //  }

            //  Console.WriteLine("The avag student grade is :  " +  avag);







            //Console.WriteLine("set number");
            //int newarray = int.Parse(Console.ReadLine());


            //arr[5] = newarray;

            ////if (newarray == 6)

            ////{

            ////    arr[0] = 1;
            ////    arr[1] = 2;
            ////    arr[2] = 3;
            ////    arr[3] = 4;
            ////    arr[4] = 5;
            ////    arr[5] = 6;

            ////    Console.WriteLine("new array as been detrmine");
            ////    Console.WriteLine(arr);

            ////}






            //int num;

            //num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Set number ");


            //if (num != -1)

            //{

            //    Console.WriteLine("the value is :  " + num);

            //}

            //else
            //{

            //    Console.WriteLine("wrong value");

            //}

            ///////////////////////////////////////////////////////////////////////////

            /////////////do and  while
            /////

            //int num1;


            //do
            //{
            //    Console.WriteLine("write number");
            //    num1 = int.Parse(Console.ReadLine());



            //} while (num1 != -1);// if value = -1 than ->  out of the loop
            //Console.WriteLine("out of range ");



            //int num2;


            //do
            //{
            //    Console.WriteLine("implement a value ");
            //    num2 = int.Parse(Console.ReadLine());


            //} while (num2 % 2 == 0); 

            //Console.WriteLine("out ");




            //איתור מספר גבוה במערך 


            //int[] arr = new int[] { 1, 2, 3, 5, 44 };

            //int max = arr[0];    

            //for(int i = 0; i < arr.Length; i++)

            //{
            //    if(arr[i] > max)
            //    {
            //        max = arr[i];
            //    }


            //}
            //Console.WriteLine(max);
















            ////////////////////////////////////////////////////////////////////////////////////
            //יצירת פונקציה אחת לאיתור מספר גבוה ב מספר מערכים 


            int[] arr = new int[] { 1, 2, 3, 5, 44 };
            int[] arr1 = new int[] { 1, 2, 4 };
            int[] arr2 = new int[] { 3, 5, 99 };



            int max1 = Getmax(arr);
            int max2 = Getmax(arr1);
            int max3 = Getmax(arr2);



            Console.WriteLine(max1);
            Console.WriteLine(max2);
            Console.WriteLine(max3);
        }

        //הפונקציה 
            static int Getmax(int[] arr)
            {

                int max = arr[0];

                for (int i = 0; i < arr.Length; i++)

                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                  
                }

             return max;
          ////////////////////////////////////////////////////////////////////////////////////
        }






        }

    }



        
        



         
            








        
             
    

    

    







    
    

