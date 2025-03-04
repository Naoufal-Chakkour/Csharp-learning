using System;
string fruit = "banana";
 switch (fruit)
 {
    case "Apple":
    Console.WriteLine("The App will display informationen for apple");
    break;
    case "fraise":
    Console.WriteLine("The App will display informationen for faise");
    break;
    case "banana":
    Console.WriteLine("The App will display informationen for banana");
    break;
 }
 Console.Write("Enter your level: ");
 int employeeLevel = int.Parse(Console.ReadLine());
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
// Convert if-else if-else to switch-case
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch(product[0])
{
    case "01":
    type = "Sweat shirt";
    break;
    case "02":
    type = "T-Shirt";
    break;
    case "03":
    type = "Sweat pants";
    break;
    default:
    type = "other";
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

switch (product[2] )
{
    case "S":
    size = "Small";
    break;
    case "M": 
    size = "Medium";
    break;
    case "L": 
    size = "Large";
    break;
    default:
    size = "One Size Fits All";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");
 