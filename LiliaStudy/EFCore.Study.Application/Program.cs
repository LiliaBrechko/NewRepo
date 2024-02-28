//Download install https://marketplace.visualstudio.com/items?itemName=ErikEJ.SQLServerCompactSQLiteToolbox
//Close visual studio to continue installation
//Search for sqllite/SQL Server compact toolbox
//Right mouse click -> Add SQLLite Connection -> Find Db file in EFCore.Study.Application bin folder with other dll files.
using EFCore.Study.Domain.Models;
using EFCore.Study.Infrastructure.DB;

using (ApplicationContext db = new ApplicationContext())
{
    // создаем два объекта User
    User tom = new User { Name = "Tom", Age = 33 };
    User alice = new User { Name = "Alice", Age = 26 };
    User pasha = new User { Name = "Pasha", Age = 33 };
    User lilia = new User { Name = "Lilia", Age = 31 };

    // добавляем их в бд
    db.Users.Add(tom);
    db.Users.Add(alice);
    db.Users.Add(pasha);
    db.Users.Add(lilia);
    db.SaveChanges();
    Console.WriteLine("Объекты успешно сохранены");

    // получаем объекты из бд и выводим на консоль
    var users = db.Users.ToList();
    Console.WriteLine("Список объектов:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}