
class Program

{

    static void Main()
    {
        //1. ---------------------------------------------------------------------------
        {

            //  Array tek ededlerin cemini 
            int[] numbersArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 4, 5, 6, 7, 8, 9 };

            int sumOfOdd = CustomMath.SumOfOddNumbers(numbersArray);

            Console.WriteLine("Massivdeki butun tek ededlerin cemi: " + sumOfOdd);
        }
        //2. ---------------------------------------------------------------------------
        {
            // Tek cut Metodunu cagirir
            int num = 5;

            CustomMath.CheckOddEven(num);

        }
        //3. ---------------------------------------------------------------------------
        {
            // array reqemleri
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // cüt ededlerin ceminin kvadratini hesablamaq üçün CustomMath sinfinden metod çağirin
            int result = CustomMath.SquareOfSumOfEvenNumbers(numbers);

            // neticenin çixişi
            Console.WriteLine("Massivdeki cut ededlerin ceminin kvadrati: " + result);
        }
        //4. ---------------------------------------------------------------------------
        {
            // readlina metod ucun eded daxil edilsin 
            Console.WriteLine("Reqem daxil edin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // result yaradib metodu istifade edirem 1-den n qeder daxil olan reqemlerin factoriali 
            long result = CustomMath.CalculateFactorial(n);

            // consola resultdan n ededinden qeder factoriali qostersin 
            Console.WriteLine($"1 den {n} qeder olan Factorial: {result}");
        }
        //bu klass ucun numane yaradiriq 
        Employee employee = new Employee(1, "Vasif", "Vaqifli", "Daglidas 57", "vaqif11@gmail.com", 25);
        Employee employee1 = new Employee(2, "Vaqif", "Vaqifli", "Daglidas 55", "Vaqif211@gmail.com", 22);
        Employee employee2 = new Employee(3, "Asif", "Vaqifli", "Daglidas 45", "Asif53@gmail.com", 28);
        Employee employee3 = new Employee(4, "Tertemir", "Vaqifli", "Daglidas 35", "Tertemir23@gmail.com", 33);
        Employee employee4 = new Employee(5, "Dasdivar", "Emrahle", "Daglidas 25", "Dasdivar88@gmail.com", 21);
        Employee employee5 = new Employee(6, "Bulbul", "Qaranguslu", "Daglidas 15", "Bulbul55@gmail.com", 44);
        Employee employee6 = new Employee(7, "Asiman", "Yertemiz", "Daglidas 55", "Asiman22@gmail.com", 33);
        //metodu cagimaq
        employee.DisplayInfo();
        employee1.DisplayInfo();
        employee2.DisplayInfo();
        employee3.DisplayInfo();
        employee4.DisplayInfo();
        employee5.DisplayInfo();
        employee6.DisplayInfo();
        
    }



}



