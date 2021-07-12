namespace StoreUI{
    public class MenuFactory : IFactory {
        public IMenu GetMenu(MenuType menu){

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("Reference2DB");

            DbContextOptions<StoreManagerDbContext> options = new DbContextOptionsBuilder<StoreManagerDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            switch(menu){
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.CustomerMenu:
                    return new CustomerMenu();
                case MenuType.StoreMenu:
                    return new StoreMenu();
                case MenuType.AddCustomerMenu:
                    return new AddCustomerMenu(new CustomerBL(new StoreDL.CustomerRepository(new StoreManagerDbContext(options))));
                default:
                    return null;
            }
        }
    }
}