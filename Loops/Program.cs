// Şart sağlanmasa bile 1 kere işlemi gerçekleştirir.

int number = 10;
do
{
    Console.WriteLine(number);
    number--;
} while (number >= 11);


//WhileLoop();
//ForLoop();


static void ForLoop()
{
    for (int i = 2; i <= 100; i += 2)
    {
        Console.WriteLine(i);
    }

    for (int i = 100; i >= 0; i -= 2)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished!");
    Console.ReadLine();
}

static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
    Console.WriteLine("Now number is {0}", number);
}