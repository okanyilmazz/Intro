// Value Types

// int sınırı = -2147483648 ~ 214748347 aralığındadır.
// 32 bit yer kaplar

int number1 = 10;
Console.WriteLine("Number1 is {0}", number1);

// -9223372036854775808 ~ 9223372036854775807 aralığındadır.
// 64 bit yer kaplar

long number2 = 214748347;
Console.WriteLine("Number1 is {0}", number2);


// -32768 ~ 32767 aralığındadır.
// 16 bit yer kaplar

short number3 = 32767;
Console.WriteLine("Number3 is {0}", number3);

// 0 ~ 255 aralığındadır.
// 8 bit yer kaplar

byte number4 = 255;
Console.WriteLine("Number4 is {0}", number4);

// true yada false değerini tutar.
// mantıksal veri tipidir.
// karşılaştırma bloklarında kullanılır

bool condition = true;

// int değerine çevrilebilir.
// Dönüşüm esnasında ASCII sayısal karşılığını bize verir

char character = 'A';
Console.WriteLine("Character is : {0}", character);
Console.WriteLine("Character is : {0}", (int)character);

// Ondalıklı sayıları tutar
// 64 bit yer kaplar
// Virgülden sonra 15-16 karakter tutar

double number5 = 10.4;
Console.WriteLine("Number5 is {0}", number5);

// Int - Long ilişkisi double - decimal içinde geçerlidir.
// Hassas değerler için kullanabilir (Para vs.)
// Virgülden sonra 28-29 karakter tutar.
// Ondalıklı yazmak istediğimizde " m " veya " M " harfini sonuna getirmeliyiz.

decimal number6 = 10.4m;
Console.WriteLine("Number6 is {0}", number6);