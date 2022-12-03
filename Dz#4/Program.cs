
void Zadacha25()
{
    Console.WriteLine("Введите натуральное число");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("В какую степень вы хотите озвести это число?");
    int numberB = Convert.ToInt32(Console.ReadLine());
    int counter = 0;
    int result = 1;

    while (counter < numberB)
    {
        result = numberA * result;
        counter++;
    }

    Console.WriteLine($"{numberA} в степени {numberB} =" + result);

    Console.WriteLine();
    Console.WriteLine();
}
Zadacha25();



void Zadacha27()
{

    Random rand = new Random();
    int number = rand.Next(1, 16654834);

    Console.WriteLine(number);

    int sum = 0;

    while (0 < number)
    {
        sum = sum + number % 10;

        number = number / 10;
    }
    Console.WriteLine("Сумма цифр в числе = " + sum);
    Console.WriteLine();
    Console.WriteLine();
}

Zadacha27();


void Zadacha29()
{
    int length = 8;
    int[] nums = new int[length];

    Fill(nums);
    Sort(nums);
    Print(nums);



}
    void Fill(int[] arr)
    {
        Random rand = new Random();
        int length = arr.Length;

        for (int i = 0; i < length; i++)
        {
            arr[i] = rand.Next(-99, 100);

        }

        Console.WriteLine();

    }

    void Print(int[] arr)
    {
        int length = arr.Length;
        for (int i = 0; i < length; i++)
        {
            Console.Write($"{arr[i]}" + "  ");
        }
    }



    void Sort(int[] arr)
    {
        int length = arr.Length;
        for (int i = 0; i < length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < length; j++)
            {
                if (Math.Abs(arr[j]) < Math.Abs(arr[min]))
                {
                    min = j;
                }
            }
            int z = arr[i];
            arr[i] = arr[min];
            arr[min] = z;

        }

    }



Zadacha29();


