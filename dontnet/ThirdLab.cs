using System;

namespace dontnet
{
    class ThirdLab
    {
        static public void FirstPart()
        {
            try
            {
                int a = 1;
                int b = 0;
                Console.WriteLine(a / b);

            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static public void SecondPart()
        {
            try
            {
                int[] array = new int[1];
                Console.WriteLine(array[2]);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static public void SecondExercise()
        {
            try
            {
                int[] array = new int[10];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Int32.Parse(Console.ReadLine());
                }

                // sorting
                int temp;
                for (int write = 0; write < array.Length; write++)
                {
                    for (int sort = 0; sort < array.Length - 1; sort++)
                    {
                        if (array[sort] > array[sort + 1])
                        {
                            temp = array[sort + 1];
                            array[sort + 1] = array[sort];
                            array[sort] = temp;
                        }
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
