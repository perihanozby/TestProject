/*C# derleyicisinin güvenli dönüştürmeler gerçekleştirdiği, özellikle string ve int dönüşümlerinde dikkatli olunması gerektiği,
 daha güvenli bir işlem için dikkat gerektiren durumların bulunduğu ve veri dönüştürme işlemi için çeşitli tekniklerin kullanılabileceği anlaşılabilir.*/

//int first = 2;
//string second = "4";
//string result = first + second;   //Output:24
//Console.WriteLine(result);

/*int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;  // output:int: 3  decimal: 3
Console.WriteLine($"decimal: {myDecimal}");*/
//decimal myDecimal = 3.14m;
//Console.WriteLine($"decimal: {myDecimal}");

//int myInt = (int)myDecimal; //output: decimal: 3,14  int: 3
//Console.WriteLine($"int: {myInt}");

/*decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;
//output: Decimal: 1,23456789   Float  : 1,2345679
Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");*/
/*
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message); //Output: 57

string afirst = "5";
string asecond = "7";
int sum = int.Parse(afirst) + int.Parse(asecond);
Console.WriteLine(sum); //Output: 12

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);//Output: 35

int value = (int)1.5m; //// casting truncates
Console.WriteLine(value);//Output: 1

int valuex = Convert.ToInt32(1.5m); //// converting rounds up
Console.WriteLine(valuex); //Output: 2
*/

//string value = "102";
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}");
