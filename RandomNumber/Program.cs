Random rnd = new Random();


int myRandomNum;

int randomsum = 0;
for (int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11);// 0-10
    randomsum = randomsum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}
Console.WriteLine($"Random sum total: {randomsum}");