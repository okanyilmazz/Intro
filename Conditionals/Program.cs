// Mantıksal Operatörler : && ve , || veya , ! değil
// Karşılaştırma Operatörler : < küçüktür, > büyüktür, <= küçük veya eşittir, >= büyük veya eşittir, == eşittir, != eşit değildir

var number = 10;

if (number == 10)
{
    Console.WriteLine("Number is 10");

}
else
{
    Console.WriteLine("Number is not 10");
}


// Single Line
//                               True           : False

Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");


// Else if
// Else olduğu için mutlaka biri çalışacak
if (number == 10)
{
    Console.WriteLine("Number is 10");
}
else if (number == 20)
{
    Console.WriteLine("Number is 20");
}
else
{
    Console.WriteLine("Number is not 10 or 20");
}

// Switch

var numberSwitch = 11;

switch (numberSwitch)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;
    case 20:
        Console.WriteLine("Number is 20");
        break;

    default:
        Console.WriteLine("Number is not 10 or 20");
        break;
}

// Multiple Conditions

if (number >= 0 && number <= 100)
{
    Console.WriteLine("Number is between 0-100");
}
else if (number > 100 && number <= 200)
{
    Console.WriteLine("Number is between 101-200");
}
else if (number > 200 || number < 0)
{
    Console.WriteLine("Number is less than 0 or greater than 200");
}

Console.ReadLine();