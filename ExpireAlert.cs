Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
Console.WriteLine(daysUntilExpiration);
if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration <= 5)
    {
       if (daysUntilExpiration == 1)
       {
            Console.WriteLine(@"Your subscription expires within a day!");
            discountPercentage = 20;
       }
       else if (daysUntilExpiration == 0)
       {
           Console.WriteLine("Your subscription has expired.");
       }
       else 
       { 
           Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
           discountPercentage = 10;
       }              
    }   
    else
    {          
       Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
    if (discountPercentage > 0)
    {
        Console.WriteLine($" Renew now and save {discountPercentage}%!");
    }
}

// Second Method #########
/*Random random = new Random();
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
}*/