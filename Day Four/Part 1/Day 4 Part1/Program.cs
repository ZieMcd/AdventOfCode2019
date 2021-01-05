using System;

namespace Day_4_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            var cCount = new Char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var iCount = new int[9];

            for (int i = 357253; i < 892942; i++)
            {

                string iStr = Convert.ToString(i);

                bool isAss = true;

                bool doulbCheck = false;

                int p = 0;


                for (int j = 0; j < iStr.Length; j++)
                {
                    if (j == 0)
                    {

                    }
                    else
                    {
                        if (Convert.ToInt32(iStr[j - 1]) > Convert.ToInt32(iStr[j]))
                        {
                            isAss = false;
                            
                        }

                        if (Convert.ToInt32(iStr[j - 1]) == Convert.ToInt32(iStr[j]))
                        {

                            if (j == 1)
                            {
                                if (Convert.ToInt32(iStr[j]) != Convert.ToInt32(iStr[j + 1]))
                                {
                                    doulbCheck = true;

                                }
                            }
                            else if (j == 5)
                            {
                                if (Convert.ToInt32(iStr[j]) != Convert.ToInt32(iStr[j - 2]))
                                {
                                    doulbCheck = true;

                                }
                            }

                            else
                            {
                                if (Convert.ToInt32(iStr[j]) != Convert.ToInt32(iStr[j - 2]) && Convert.ToInt32(iStr[j]) != Convert.ToInt32(iStr[j + 1]))
                                {
                                    doulbCheck = true;
                                }
                            }
                        }
                    }

                }//end of letters check

                if (doulbCheck==true && isAss == true)
                {
                    k++;
                }
        

            }// end looking though all nums 

            Console.WriteLine(k);
           // Console.WriteLine(892942 - 357253);







        }
    }
}
