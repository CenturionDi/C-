namespace Onlineshop
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ContextShop : DbContext
    {
        // Контекст настроен для использования строки подключения "ContextShop" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Onlineshop.ContextShop" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "ContextShop" 
        // в файле конфигурации приложения.
        public ContextShop()
            : base("name=ContextShop")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Order> Orders { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}