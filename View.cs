using System;


public class UserView
{
private UserViewModel _vm;


public UserView(UserViewModel vm)
{
_vm = vm;
_vm.PropertyChanged += (s, e) =>
{
if (e.PropertyName == "Greeting")
Console.WriteLine("View Updated: " + _vm.Greeting);
};
}


public void InputName()
{
Console.Write("Enter your name: ");
_vm.Name = Console.ReadLine();
}
}
