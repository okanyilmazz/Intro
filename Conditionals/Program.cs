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
Console.ReadLine();

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