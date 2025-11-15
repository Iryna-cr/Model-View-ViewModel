using System.ComponentModel;
using System.Runtime.CompilerServices;


public class UserViewModel : INotifyPropertyChanged
{
private UserModel _user = new UserModel();
private string _greeting;


public event PropertyChangedEventHandler PropertyChanged;


public string Name
{
get => _user.Name;
set
{
_user.Name = value;
Greeting = $"Hello, {value}!";
OnPropertyChanged();
}
}


public string Greeting
{
get => _greeting;
set
{
_greeting = value;
OnPropertyChanged();
}
}


protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
{
PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
}
