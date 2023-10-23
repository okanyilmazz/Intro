
//Add();
//Add();
//Add();
//Add();
//var result = Add2(20, 30);

//var defaultResult = Add2();
//Console.WriteLine(defaultResult);

int number1 = 20;
int number2 = 100;

var result2 = Add3(out number1, number2);
Console.WriteLine(result2);
Console.WriteLine(number1);

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

// ref, Değer tiplerini referans tip gibi kullanmaya yarar

// out, method içerisinde bir defa set edilmesi gerekir.
static int Add3(out int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}