using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vremya = new string[1000];
            
            int jopa = 0;
            int[][] arr = new int[12][];
            arr[0] = new int[31];//январь
            arr[1] = new int[29];
            arr[2] = new int[31];
            arr[3] = new int[30];
            arr[4] = new int[31];
            arr[5] = new int[30];
            arr[6] = new int[31];
            arr[7] = new int[31];
            arr[8] = new int[30];
            arr[9] = new int[31];
            arr[10] = new int[30];
            arr[11] = new int[31];//декабрь
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = j + 1;
                }
            }
            int Year = 0;
            
            while (Year != 99)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (Year % 4== 0)
                    {
                        for (int j = 0; j < arr[i].Length; j++)
                        {
                            if ((j + 1) * (j + 1) + (i + 1) * (i + 1) == (Year *Year))
                            {
                                if (jopa < vremya.Length)
                                {
                                    vremya[jopa] = "День: " + (j + 1) + "; Месяц: " + (i + 1) + "; Год: " + Year;
                                    jopa += 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < arr[i].Length - 1; j++)
                        {
                            if ((j + 1)* (j + 1) + (i + 1)* (i + 1) == ( Year * Year))
                            {
                                if (jopa < vremya.Length)
                                {
                                    vremya[jopa] = "День: " + (j + 1) + "; Месяц: " + (i + 1) + "; Год: " + Year;
                                    jopa += 1;
                                }
                            }
                        }
                    }
                }



                Year += 1;
            }
            for (int i=0;i<vremya.Length;i++)
            {
                Console.WriteLine(vremya[i]);
            }
            
            Console.ReadLine();


        }
        
    }
}
