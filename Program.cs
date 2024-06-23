
using System.Transactions;

do
{
    Console.WriteLine("Enter your Name: ");
    var name = Console.ReadLine();
    if(name != string.Empty )
        break;
    else
        continue;
}
while(true);
//Cheking Surname
do
{
    Console.WriteLine("Enter your SurName: ");
    var surname = Console.ReadLine();
    if (surname != string.Empty)
        break;
    else
        continue;
}
while (true);
//ReCaptcha - Uzbek version
do
{
    Console.WriteLine("Enter this - iamnotarobot ");
    var captcha = Console.ReadLine();
    if (captcha != string.Empty)
    {
        if (captcha != "iamnotarobot")
        {
            Console.WriteLine("System blocked for a 5s");
            Thread.Sleep(5000);
            Console.WriteLine("Exit from app and try again!");
            break;
        }
        else if (captcha == "iamnotarobot")
        {
            Console.WriteLine($"Welcome to OnionS");
            break;
        }
            
    }
}
while (true);