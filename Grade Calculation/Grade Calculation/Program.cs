// See https://aka.ms/new-console-template for more information

// Calculate grades and thier occurences by accepting scores.

int n; // Number of students.
int score;
char grade;
int occA = 0, occB = 0, occC = 0, occD = 0, occF = 0;
do
{
    Console.WriteLine("Enter the number of students Please: ");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 0)
    {
        Console.WriteLine("Error - Number of students shouldn't be below zero!!! Please re-enter:\n");
        n = Convert.ToInt32(Console.ReadLine());
    }
} while (n < 0);

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Score of Student " + (i + 1));
    do
    {
        score = Convert.ToInt32(Console.ReadLine());
        if (score > 100 || score < 0)
        {
            Console.WriteLine("Scores should be in (0 - 100) range! Please re-enter: ");
            score = Convert.ToInt32(Console.ReadLine());
        }
    } while (score > 100 || score < 0);

    if (score >= 80)
        occA++;
    else if (score >= 70)
        occB++;
    else if (score >= 55)
        occC++;
    else if (score >= 40)
        occD++;
    else
        occF++;

}
Console.Clear();
Console.WriteLine("Out of " + n + " students that are graded\n");
Console.WriteLine("\t\t" + occA + " of them got A\n");
Console.WriteLine("\t\t" + occB + " of them got B\n");
Console.WriteLine("\t\t" + occC + " of them got C\n");
Console.WriteLine("\t\t" + occD + " of them got D\n");
Console.WriteLine("\t\t" + "The remaining " + occF + " have failed this course\n");


