﻿Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("УРА!!!! Маша пришла!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}