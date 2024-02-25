

public class CustomMath
{
    // 1. Method array qebul edir, arrayin icerisindeki tek ededlerin cemini tapin.  
    public static int SumOfOddNumbers(int[] array)
    {
        int sum = 0;

        foreach (int number in array)
        {
            if (number % 2 != 0) // Checking for oddness
            {
                sum += number;
            }
        }

        return sum;
    }


    // 1. Methoda gelen ededin tek ve ya cut olub olmamasini gosterin.
    public static void CheckOddEven(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine(number + " Cut reqem.");
        }
        else
        {
            Console.WriteLine(number + " Tek reqem.");
        }
    }

    // 2. Methoda gelen arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.
    public static int SquareOfSumOfEven(int[] array)
    {
        int sumOfEven = 0;

        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                sumOfEven += number;
            }
        }

        int square = sumOfEven * sumOfEven;
        return square;
    }

    // 3. Methoda gelen arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.
    public static int SquareOfSumOfEvenNumbers(int[] arr)
    {
        int sum = 0;

        //Loopa salirig
        foreach (int num in arr)
        {
            // 2ye bolunurse 
            if (num % 2 == 0)
            {
                sum += num;
            }
        }

        // toplanan reqemi top.req. vurur
        return sum * sum;
    }

    // 4. n faktorialinin hesablanmasi usulu
    public static long CalculateFactorial(int n)
    {
        // eger n 0 ve ya 1-dirse, 0 ve 1-in faktoriali 1 olduğundan 1-i qaytarir
        if (n == 0 || n == 1)
        {
            return 1;
        }

        // resulta yigir 
        long result = 1;

        // 2 den n qeder vurur
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        // cavabi return edir
        return result;
    }
}

