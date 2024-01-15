// C# konsol uygulamalarında değişken verilerle çalışma (C#, Bölüm 4 ile çalışmaya başlama) 
// C# kodunuzda doğru veri türünü seçme 
// HEDEFLER
//Değer türleri ve başvuru türleri arasındaki temel farklılıkları öğrenme.
//Yeni tam sayı türleri ve kayan nokta türleri dahil olmak üzere çok sayıda yeni sayısal veri türünün özelliklerini açıklama.
//Sayısal veri türlerinin depolayabileceği maksimum ve minimum değerleri döndüren kodu yazma.
//Yeni bir başvuru türünün yeni örneklerini oluşturmak için new anahtar sözcüğünü kullanma.
//Belirli bir uygulama için hangi veri türünü seçmeniz gerektiğini belirleme.
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");

Console.WriteLine("_______________");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte: {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort: {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint: {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong: {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

//3E+4 = 3 * 10^4 = 30,000
//1.5E-3 = 1.5 * 10^(-3) = 0.0015

/*Başvuru Türlerinin Değer Türlerinden Farkı:
Değer türü değişkeni, değerlerini doğrudan "yığın" adı verilen bir depolama alanında depolar. 
Yığın, CPU üzerinde çalışan belleği temsil eder ve koda ayrılmıştır.
Yığın çerçevesi, kodun yürütülmesi tamamlandığında değerleri kaldırır.

Başvuru türü değişkeni ise değerlerini "heap" adı verilen ayrı bir bellek bölgesinde depolar. 
Heap, işletim sistemi üzerinde çalışan çok sayıda uygulama tarafından paylaşılan bir bellek alanıdır. 
*/

int[] data = new int[3];
string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);