
Add();
Add();
Add();
Add();
var result = Add2(20, 30);
var defaultResult = Add2();
Console.WriteLine(result);
Console.WriteLine(defaultResult);
Console.ReadLine();


static void Add()
{
    Console.WriteLine("Added!!!");
}


// Default değerler en sonunda olmalı.

static int Add2(int number1 = 20, int number2 = 30)
{
    var result = number1 + number2;
    return result;
}