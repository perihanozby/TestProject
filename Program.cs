/*
Random dice= new Random();

int roll1 = dice.Next(1,7);
int roll2= dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"dice roll: {roll1} + {roll2} + {roll3} = {total}");

if(total>14){
    Console.WriteLine("You Win!");
}else{
    Console.WriteLine("Sorry,you lose.");
}
*/


/////////////////////////////////////////////////////////


/* 
string message = "the wuick brown fox jumpsover the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if(message.Contains("fox")){
    Console.WriteLine("what does the fox say");
}
*/


////////////////////////////////////////////////////////////
/*
Random dice= new Random();

int roll1 = dice.Next(1,7);
int roll2= dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"dice roll: {roll1} + {roll2} + {roll3} = {total}");


if((roll1==roll2) || (roll2==roll3) || (roll1==roll3)){
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total +=2;
}


if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}    
*/



//////////////////////////////////////////////////////



/*
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
*/


//////////////////////////////////////////////////////////////////////////


// C# dilinde Dizileri ve foreach deyimini kullanarak veri dizilerini depolama ve yineleme

//____DİZİlER_____:
/*string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0]="a123";
fraudulentOrderIDs[1]="b123";
fraudulentOrderIDs[2]="c123";*/

/*string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"first:{fraudulentOrderIDs[0]}");
Console.WriteLine($"second:{fraudulentOrderIDs[1]}");
Console.WriteLine($"third:{fraudulentOrderIDs[2]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");*/


// ______FOREACH DEYİMİ_____:
// ---->> Foreach ifadesi, bir koleksiyondaki her bir eleman için istenilen kod bloğunu döndürür.



/*
string[] names ={"ali","ayse","fatma"};
foreach (string name in names)
{
    Console.WriteLine(name);
}*/

/*int[] inventory = { 20, 40, 70, 17, 20 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");*/


/*string[] sahtesipariskimligi = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

foreach (string sahtekisi in sahtesipariskimligi)
{
    if (sahtekisi.StartsWith("B"))
{
    Console.WriteLine($"Sahte kisilerden 'B':{sahtekisi}");
}
}*/


///////////////////////////////////

//:::::C# dilinde kurallar, boşluklar ve açıklamalar ile okunabilir kod oluşturma :::::

/*string firstName = "Bob";
int widgetsPurchased = 7;
// Mesajdaki değişikliği test ediyoruz.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");*/

/*Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}*/

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

/*string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");


*/

/////  C# dilinde kararlar almak için Boole ifadelerini değerlendirme 

//Console.WriteLine("a" == "a");
//Console.WriteLine("a" == "A");
//Console.WriteLine(1 == 2);

//string myValue = "a";
//Console.WriteLine(myValue == "a");

/*string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());*/




////////  Eşitsizlik işlecini kullanma

/*Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");*/




/////   Karşılaştırmaları değerlendirme

/*Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);*/




//////    Boole değeri döndüren yöntemler

/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
Console.WriteLine(!pangram.Contains("cow")); // Mantıksal olumsuzlama= çıktının tersini alma işlemidir.

*/

/*int saleAmount = 1001;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {discount}");

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");*/




/*Random random=new Random();
Console.WriteLine((random.Next(0, 2) == 0) ? "yazi" : "tura");*/








////  Alıştırma - Boole ifadelerini kullanarak sınama etkinliğini tamamlama

/*string permission = "Admin|Manager";
int level = 55;


if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}*/


////7 Kod bloğunun içinde değişken oluşturma

/*bool flag =true;
int value = 0;
if (flag)
{
    value= 10;
    Console.WriteLine("Inside of code block:"+value);
}
Console.WriteLine("outside of code block:"+value);*/


/*int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
       bool found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");*/ // YERİNE

/*int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");*/

//////////////////////////////////////

//                   SWİTCH_CASE              

/*int employeelevel = 100;
string employeename = "perihan ozbay";

string title = "";

switch (employeelevel)
{
    case 100:
    //title = "Junior Associate";
    //break;

    case 200:
    title = "Senior Associate";
    break;

    case 300:
    title = "Manager";
    break;

    case 400:
    title = "Senior manager";
    break;
    
    default:
    title = "Associate";
    break;
}

Console.WriteLine($"{employeename},{title}");


///////////////////////////////////////////


// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";
switch (product[0])
{
    case "01":
    type = "Sweat shirt";
    break;

    case "02":
    type = "Sweat shirt";
    break;

    case "03":
    type = "Sweat shirt";
    break;

    default:
    type = "Other";
    break;
    
}


switch (product[1])
{
    case "BL":
    color = "Black";
    break;

    case "MN":
    color = "Maroon";
    break;
    
    default:
    color = "White";
    break;
}

switch(product[2])
{
    case "S":
    size = "Small";
    break;

    case "M":
    size = "Medium";
    break;

    case "L":
    size ="Large";
    break;

    default:
    size = "One Size Fits All";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");*/

/*
///////       FOR DEYİMİ     ///////////


for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if(i == 7)
    break;
}

//////////////////////


string[] names = {"ali", "ayse", "elif", "mert"};

for (int j = names.Length-1; j >= 0; j--)   //names.lenght 0 tabanlı sayma yaptığı için 
{                                           //(names.lenght-1() ifadesini kullanıyoruz.
    Console.WriteLine(names[j]);
    if(names[j] == "elif") names[j] = "salih";
}
Console.WriteLine("----------------------");
foreach (var name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("_________________________________");

///////////////////////////////////////////////////////////
//   for ve if deyimlerini kullanarak sınama etkinliğini tamamlama   //


for(int k=1; k<=100; k++)
{

    if ((k % 3 == 0) && (k % 5 == 0))
        Console.WriteLine($"{k} - FizzBuzz");
    else if (k % 3 == 0)
        Console.WriteLine($"{k} - Fizz");
    else if (k % 5 == 0)
        Console.WriteLine($"{k} - Buzz");
    else
        Console.WriteLine($"{k}");
}

*/





///////////////////////////////////////////////////
//          DO-WHİLE && WHİLE         //

//do
//{
//    
//} while (true);


// 1-11 arasinda rastgele sayi oluştur.
// sayi 7'ye eşit oluncaya kadar çalıştır ve 7'de durakla.



///
/// Yazı-tura oyunu
/// 
//Random random = new Random();
//int sayi = random.Next(1, 11);

/*do
{
    sayi = random.Next(1, 11);
    Console.WriteLine(sayi);
    
} while (sayi != 7);
*/
/////// VEYA

/*while (sayi >= 3)
{
    Console.WriteLine(sayi);
    sayi = random.Next(1, 11);
}
Console.WriteLine($"son numara:{sayi}");*/

/////// VEYA

/*do
{
    sayi=random.Next(1, 11);
    if(sayi >=8) continue;
    Console.WriteLine(sayi);
    
} while (sayi != 7);*/

/////////// Rol yapma oyunu mücadelesi sınaması   ///

/* 
-Deyimini do-while veya deyimini while bir dış oyun döngüsü olarak kullanmanız gerekir.
-Hem karakter hem de canavar oyuna 10 can puanıyla başlar.
-Tüm saldırılar 1 ila 10 arasında bir değere sahip olur.
-İlk saldırıyı karakter yapar.
-Canavarın kaybettiği can puanı ve kalan can puanı yazdırılır.
-Canavarın can puanı sıfırdan büyükse canavar karaktere saldırır.
-Karakterin kaybettiği can puanı ve kalan can puanı yazdırılır.
-Canavarın veya karakterin can puanı sıfıra veya altına düşene kadar bu saldırı dizisi devam eder.
-Kazanan taraf yazdırılır.*/


Random random = new Random();
int karakter = 10;
int düsman = 10;

do
{
    int karakteratıs = random.Next(1, 11);
    Console.WriteLine($"Düşman kaybettiği can puanı: {karakteratıs}"+$" Düşman kalan can puanı: {düsman-karakteratıs}");
    if(düsman <= 0) continue;
    
    int düsmanatıs = random.Next(1, 11);
    Console.WriteLine($"Karakterin kaybettiği can puanı: {düsmanatıs}"+ $" Karakterin kalan can puanı:{karakter-düsmanatıs} ");
} while (karakter == 0 && düsman == 0);

Console.WriteLine(karakter>düsman ? "karakter kazandi!": "düsman kazandi:()");

/*
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");*/


