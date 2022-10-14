Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "эльза")
{
    Console.WriteLine("Ура, это же ЭЛЬЗА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}