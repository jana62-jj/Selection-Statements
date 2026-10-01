using System.ComponentModel.Design;

Console.WriteLine("How old are you?");
int age = Convert.ToInt32(Console.ReadLine());


if (age< 0 || age >= 110)
{
    Console.WriteLine("invalid age");
}
else if (age < 13)
{
    Console.WriteLine("You are a CHILD ");
}
else if (age <= 19)
    {
    Console.WriteLine("you are a teenager");
}
else
{
    Console.WriteLine("you are an adult");
}

