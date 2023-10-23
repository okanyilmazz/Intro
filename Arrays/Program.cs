string[] students = new string[3] { "Engin", "Derin", "Salih" }; ;
//students[0] = "Engin";
//students[1] = "Derin";
//students[2] = "Salih";

string[] students2 = { "Engin", "Derin", "Salih" };
// Verilen eleman sayısından fazla ekleyemiyoruz.
students2[3] = "Ahmet";

foreach (var student in students2)
{
    Console.WriteLine(student);
}
Console.WriteLine();
Console.ReadLine();