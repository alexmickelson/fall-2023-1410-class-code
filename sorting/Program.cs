var tester = new Testing();
tester.RunTests();

var myList = new List<int>();
var menu = new Menu();
while (true)
{
  menu.PrintMenu();
  var option = menu.GetMenuOptionFromUser();
  myList = menu.HandleSelectedMenuOptions(option, myList);
}
