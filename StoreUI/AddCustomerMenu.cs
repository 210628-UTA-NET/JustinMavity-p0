namespace StoreUI{
    public class AddCustomerMenu : IMenu {
        public void Menu(){

        }

        public MenuType Choice(){
            string userInput = Console.ReadLine();
            switch(userInput){
                default:
                    return MenuType.MainMenu;
            }
        }
    }
}