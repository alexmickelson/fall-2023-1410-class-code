

using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;

var menu = new Menu();
while(true)
{
  menu.PrintMenu();
  var menuOption = menu.GetMenuOptionFromUser();
  menu.HandleMenuOption(menuOption);

}