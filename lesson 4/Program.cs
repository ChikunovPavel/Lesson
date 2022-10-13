Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if  (username.ToLower() == "света")
{
    Console.WriteLine("Ура, это же Света");
}
else
{
    Console.Write("привет,");
    Console.WriteLine(username);
}