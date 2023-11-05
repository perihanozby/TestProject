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


string[] sahtesipariskimligi = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

foreach (string sahtekisi in sahtesipariskimligi)
{
    if (sahtekisi.StartsWith("B"))
{
    Console.WriteLine($"Sahte kisilerden 'B':{sahtekisi}");
}
}



