using pr5_golobokov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashPasswords;

namespace pr5_golobokov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание новой учетной записи для пользователя");

            Console.Write("Введите логин пользователя: ");
            string username = Console.ReadLine();

            Console.Write("Введите пароль пользователя: ");
            string password = Console.ReadLine();

            Hash hashHelper = new Hash();
            string hashedPassword = hashHelper.HashPassword(password);

            Auth newUser = new Auth
            {
                Username = username,
                Password = hashedPassword
            };

            try
            {
                var context = Helper.GetContext();
                context.Auth.Add(newUser);
                context.SaveChanges();

                Console.WriteLine($"Хэшированный пароль пользователя: {hashedPassword}");
                Console.WriteLine("Учетная запись добавлена");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при добавлении учетной записи: {ex.Message}");
            }

            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}
