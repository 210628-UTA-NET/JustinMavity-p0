using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using BL;
using DL;
using DL.Entities;
using Models;
namespace StoreUI
{
    public class MenuFactory : IFactory {
        public IMenu GetMenu(MenuType menu){

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("Reference2DB");

            DbContextOptions<DL.Entities.StoreManagerDbContext> options = new DbContextOptionsBuilder<DL.Entities.StoreManagerDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            switch(menu){
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.CustomerMenu:
                    return new CustomerMenu();
                case MenuType.StoreMenu:
                    return new StoreMenu();
                case MenuType.ShowCustomerMenu:
                    return new ShowCustomerMenu(new CustomerBL(new CustomerRepository(new DL.Entities.StoreManagerDbContext(options))));
                case MenuType.AddCustomerMenu:
                    return new AddCustomerMenu(new CustomerBL(new CustomerRepository(new DL.Entities.StoreManagerDbContext(options))));
                case MenuType.Exit:
                    return new Exit();
                
                default:
                    return null;
            }
        }
    }
}