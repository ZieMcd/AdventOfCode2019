using System;
using System.Collections.Generic;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            int temp,pos1,pos2;
          
            


          
            //----------DATA INTO LIST-----------------------

            string text = System.IO.File.ReadAllText(@"C:\Users\Admin\Code projects\C#\Advent of code\Day Two\1202 Program.txt");
            var nums = new List<int>();

            while (text.IndexOf(",") != -1)
            {
               
                nums.Add(Convert.ToInt32(text.Substring(0, text.IndexOf(","))));
                text=text.Remove(0, text.IndexOf(",") + 1);
                     
            }
            nums.Add(Convert.ToInt32(text)); 
            //---------------------------------------------------



            /*  TEST DISPLAY OF DATA 
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            } 
            */


            //---------------PROCESSING DATA---------------------------------//
            for (int j = 0; j < nums.Count; j++)
            {
                if (j % 4 == 0)
                {
                    if (nums[j] == 1)
                    {
                        pos1 = nums[j + 1];
                        pos2 = nums[j + 2];

                        temp = nums[pos1] + nums[pos2];
                        nums[nums[j + 3]] = temp;

                        //Console.WriteLine(nums[j]);
                       

                    }
                    else if (nums[j] == 2)
                    {
                        pos1 = nums[j + 1];
                        pos2 = nums[j + 2];

                        temp = nums[pos1] * nums[pos2];
                        nums[nums[j + 3]] = temp;

                        //Console.WriteLine(nums[j]);
                    }
                    else if (nums[j] == 99)
                    {
                       //   j++;
                       // break;
                    }
                    else
                    {
                        Console.WriteLine("error at " + j);
                    }


                }
            }
            //------------------------------------------------------------------

            /* foreach (int num in nums)
             {
                 Console.WriteLine(num);
             }*/


            //Console.WriteLine(text);
        }


    }
}
