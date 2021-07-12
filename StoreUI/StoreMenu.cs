namespace StoreUI{
    public class StoreMenu : IMenu {
        public void Menu(){
            Console.Clear();
            Console.WriteLine("----------------Store Menu---------------");
            Console.WriteLine("");
        }

        public MenuType Choice(){

            string userInput = Console.ReadLine();

            switch(userInput){
                default:
                    return MenuType.StoreMenu;
            }
        }
    }
}