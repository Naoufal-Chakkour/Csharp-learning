Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"random: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
       Console.WriteLine("You are amazing and win +6 points bonus");
       total += 6;
    }
    else
    {
      Console.WriteLine("You are lucky and win +2 points bonus");
      total += 2;
    }
    Console.WriteLine($"Your total including the bonus: {total}");
}

if (total > 15){
    Console.WriteLine("Congratulation! You win a new car");
}
else if (total >= 10){
    Console.WriteLine("Congratulation! You win a laptop");
}
else if (total == 7){
    Console.WriteLine("Congratulation! You win a Trip");
}
else {
    Console.WriteLine("Sorry, You lose");
}
