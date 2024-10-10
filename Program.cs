namespace PB503_Data_Types_and_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region task 1:

            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //#endregion

            #region task 2: 

            var studentsGrade = 96;

            if (studentsGrade < 65)
            {
                Console.WriteLine("Kesildin");
            }

            else if (studentsGrade >= 65 && studentsGrade <= 85)
            {
                Console.WriteLine("Adi Diplom");
            }

            else if (studentsGrade > 85 && studentsGrade <= 95)
            {
                Console.WriteLine("Şərəf Diplomu (Honour)");
            }

            else
            {
                Console.WriteLine("Yüksək Şərəf Diplomu (High Honour)");
            }

            #endregion
        }
    }
}
