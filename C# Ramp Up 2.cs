using System;

public class HelloWorld
{
public static void Main(string[] args)
{
Console.Write("Weight in pounds (lbs):");
int lbs = Convert.ToInt32(Console.ReadLine()) ;
Console.WriteLine("Weight in kg: " + lbs * .453592);

Console.Write("Lenght in Miles (mi):");
int mi = Convert.ToInt32(Console.ReadLine()) ;
Console.WriteLine("Lenght in km: " + mi * 1.60934);

Console.Write("Temperature in Farenheit ():");
int F = Convert.ToInt32(Console.ReadLine()) ;
Console.WriteLine("Temperature in Celsius: " + (F-32)/ 1.8000);

Console.Write("Enter age of student 1:");
int age = Convert.ToInt32(Console.ReadLine()) ;

Console.Write("Enter age of student 2:");
int age2 = Convert.ToInt32(Console.ReadLine()) ;

Console.Write("Enter age of student 3:");
int age3 = Convert.ToInt32(Console.ReadLine()) ;

Console.Write("Enter age of student 4:");
int age4 = Convert.ToInt32(Console.ReadLine()) ;

Console.Write("Enter age of student 5:");
int age5 = Convert.ToInt32(Console.ReadLine()) ;

Console.Write("Enter age of student 6:");
int age6 = Convert.ToInt32(Console.ReadLine()) ;

Console.Write("Enter age of student 7:");
int age7 = Convert.ToInt32(Console.ReadLine()) ;

Console.Write("Enter age of student 8:");
int age8 = Convert.ToInt32(Console.ReadLine()) ;

Console.Write("Enter age of student 9:");
int age9 = Convert.ToInt32(Console.ReadLine()) ;

Console.Write("Enter age of student 10:");
int age10 = Convert.ToInt32(Console.ReadLine()) ;

int ave = age + age2 + age3 + age4 + age5 + age6 + age7 + age8 + age9 + age10;
Console.WriteLine(ave / 10);

       Console.WriteLine("\nFantasy Story Part:");
        string heroName = "Sora";
        string heroineName = "Lysandra";
        string villainName = "Malvador";
        string weaponName = "Stormbreaker";
        string abilityName = "Shadowstep";

        string story = @"
    Once upon a time, in the kingdom of Aranthia, there lived a young hero named {heroName}. He
    was known for wielding the legendary {weaponName} and possessing the extraordinary ability of
    {abilityName}.

    {heroName} embarked on a quest to rescue the beautiful princess, {heroineName}, who had been
    captured by the wicked sorcerer, {villainName}. Along his journey, he encountered many trials
    and challenges, but with his courage and determination, he overcame them all.

    In a final showdown, {heroName} faced {villainName} in a battle of epic proportions. With a
    swift strike of {weaponName}, he defeated the villain and rescued {heroineName}, restoring
    peace to the kingdom of Aranthia once more.

    And so, {heroName} and {heroineName} returned home as heroes, their names forever remembered
    in the annals of history.";
        Console.WriteLine(story);

Console.WriteLine("Part 2: Number Patterns\n");

       
Console.Write("Enter a positive integer for Pattern 1: ");
 int pattern1Rows = int.Parse(Console.ReadLine());

        if (pattern1Rows <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for Pattern 1.\n");
        }
        else
        {
            Console.WriteLine("Pattern 1:");
            for (int i = 1; i <= pattern1Rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        // Pattern 2
        Console.WriteLine("\nEnter a positive integer for Pattern 2: ");
        int pattern2Rows = int.Parse(Console.ReadLine());

        if (pattern2Rows <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for Pattern 2.\n");
        }
        else
        {
            int sum = 0;

            Console.WriteLine("Pattern 2:");
            for (int i = 1; i <= pattern2Rows; i++)
            {
                sum += i;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nFormula: 1 + 2 + ... + {pattern2Rows}");
            Console.WriteLine($"Output: {sum}\n");
        }

        // Pattern 3
        Console.WriteLine("Enter a positive integer for Pattern 3: ");
        int pattern3Rows = int.Parse(Console.ReadLine());

        if (pattern3Rows <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for Pattern 3.\n");
        }
        else
        {
            Console.WriteLine("Pattern 3:");
            for (int i = pattern3Rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
}
}
