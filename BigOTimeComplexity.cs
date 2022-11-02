namespace TimeComplexity
{
    public class BigOTimeComplexity
    {
        // O(1)
        public void BigO_01(int[] array)
        {
            int count = 0;
            array[0] = 1;
            count++;
            Console.WriteLine("O(1) = " + count.ToString() + " steps.");
        } // End of BigO_O1

        //O(n)
        public void BigO_On(int[] array)
        {
            //O(n)
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count++;
                array[i] = i;
            }
            Console.WriteLine("O(n) = " + count.ToString() + " steps.");
            return;
        }

        // O(n^2)
        public void BigO_On2(int[] array)
        {
            // O(n^2)
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    count++;
                }
            }
            Console.WriteLine("O(n^2) = " + count.ToString() + " steps.");
        } 

        // O(log n)
        public void BigO_Ologn(int[] array)
        {
            int count = 0;
            Random random = new Random();
            int target = random.Next(0, array.Length);
            int Upper = array.Length - 1;
            int Lower = 0;
            int index = (int)Math.Floor(Upper / 2.0);
            while (target != array[index])
            {
                count++;
                if (target < array[index])
                {
                    Upper = index;
                    index = Lower + (int)Math.Floor((Upper - Lower) / 2.0);
                }
                else
                {
                    Lower = index;
                    index = Lower + (int)Math.Floor((Upper - Lower) / 2.0);
                }
            } // End of while loop
            Console.WriteLine("O(log n) = " + count.ToString() + " steps.");
        }
    }
}