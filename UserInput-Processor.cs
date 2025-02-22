/*string[] array = new string[3];
array[0] = "dr435";
array[1] = "A654j";
array[2] = "Gro765";*/
//array[3] = "kjh345";   "Index was outside the bounds of the array"

string[] array = ["Enter your name: ", "Enter your Email: ", "Enter your job: "]; // this is work also "string[] array = {"ggfdtu", "hg765", "hgg45"};
Console.Write($"{array[0]}");
string input1 = Console.ReadLine();
Console.Write($"{array[1]}");
string input2 = Console.ReadLine();
Console.Write($"{array[2]}");
string input3 = Console.ReadLine();
Console.WriteLine($"Your name is {input1} and your email is {input2} and your job is {input3}");

string[] array1 = {"Enter your age: ", "Enter your number: "};
Console.Write(array1[0]);
int input4 = int.Parse(Console.ReadLine());
Console.WriteLine($"Your age is {input4}");
Console.Write(array1[1]);
int input5 = int.Parse(Console.ReadLine());
Console.WriteLine($"Your number is {input5}");
Console.WriteLine($"There are {array.Length} fraudulent orders to process");

int age = input4;
if (age <= 18)
{
    Console.WriteLine("You are under the age limit!");
}
else
{
    Console.WriteLine("Welcom!");
}

string[] array2 = ["Enter number1: ", "Enter number2: ", "Enter number3: ", "Enter number4: "];
Console.Write(array2[0]);
int num1 = int.Parse(Console.ReadLine());
Console.Write(array2[1]);
int num2 = int.Parse(Console.ReadLine());
Console.Write(array2[2]);
int num3 = int.Parse(Console.ReadLine());
Console.Write(array2[3]);
int num4 = int.Parse(Console.ReadLine());
int[] array3 = {num1, num2, num3, num4};
foreach (int num in array3)
{
    if (num.ToString().StartsWith("6"))
    {
        Console.WriteLine($"This number {num} is correct");
    }
    else
    {
        Console.WriteLine($"This number {num} is Fake");
    }
}