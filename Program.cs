using System;


public class Program
{
public static void Main()
{
var vm = new UserViewModel();
var view = new UserView(vm);
view.InputName();
}
}
