namespace StoreUI{
    public class MainMenu : IMenu {
        public void Menu(){
            Console.WriteLine("<------------------> Welcome to the Main Menu <--------------------->");
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("   [1] Go to the Customer Menu");
            Console.WriteLine("   [2] Go to the Store Menu");
            Console.WriteLine("   [0] Exit");

        }

        public MenuType Choice(){
            string userInput = Console.ReadLine();

            switch(userInput){
                case "0":
                    return MenuType.Exit;
                case "1":
                    return MenuType.CustomerMenu;
                case "2":
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("Input was not valid");
                    Console.WriteLine("Press Any key to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}