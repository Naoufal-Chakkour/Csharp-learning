using System;

for (int i = 10; i > 0 ; i -= 3){
Console.WriteLine(i);
if (i == 6) break;}
for (int j = 0; j < 10 ; j += 3){
Console.WriteLine(j);
if (j == 6) break;}

// array Length
string[] names = {"ahmed", "karim", "naoufal", "rabiae"};

for (int i =0 ;i <= names.Length - 1; i++)
   Console.WriteLine(names[i]);
   // change a value in array
   string[] Names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < Names.Length; i++)
{
    if (Names[i] == "David")
    {
        Names[i] = "Sammy";
    }
}

foreach (var name in Names)
{
    Console.WriteLine(name);
}
// Fizzbuzz challenge
string input = "";
for (int i = 0; i < 101; i++)
{
    if ((i%3==0) && (i%5==0))
    input = "FizzBuzz";
    else if (i%3==0)
    input = "Fizz";
    else if (i%5==0)
    input = "Buzz";
    else
    input = "";
    

Console.WriteLine($"{i} {input}");
}