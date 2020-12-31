using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vremya = new string[1];

            int counter = 0;
            int N = 0; //проверка на високосность года
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
            FillArrayPlusOne(arr);// запуск метода для заполнения массива 
            int Year = 0; 

            while (Year != 99)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (Year % 4 == 0)
                        N = 0;
                    else
                        N = 1;
                    checkingNumberPiphagore(arr, i, Year, ref vremya, ref counter, N);
                }
                Year += 1;
                
            }
            WriteArray(vremya);
            Console.ReadLine();
        }
        private static void checkingNumberPiphagore(int[][]arr,int i,int Year,ref string[]vremya, ref int Counter, int N)
        {
            for (int j = 0; j < arr[i].Length - N; j++)
            {
                if ((j + 1) * (j + 1) + (i + 1) * (i + 1) == (Year * Year))
                {
                    vremya=IncrArray(vremya);
                    vremya[Counter] = "День: " + (j + 1) + "; Месяц: " + (i + 1) + "; Год: " + Year;
                    Counter += 1;
                }
            }
        }
        public static string[] IncrArray(string []arr)
        {
            string[] Temp = new string[arr.Length+1];
            for (int i = 0; i < arr.Length; i++)
                Temp[i] = arr[i];
            return Temp;
        }
        private static void WriteArray(string[] vremya)
        {
            for (int i = 0; i < vremya.Length; i++)
            {
                Console.WriteLine(vremya[i]);
            }
        }

        private static void FillArrayPlusOne(int[][] arr)
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = j + 1;
                }
            }
        }
    }
}
