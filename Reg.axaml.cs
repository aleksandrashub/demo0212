using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using demo0212.Models;

//using demo0212.Models;
using System.Linq;

namespace demo0212;

public partial class Reg : Window
{
    public Reg()
    {
        InitializeComponent();
    }
    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        User user = new User();
        if (Helper.user11037.Users.Count() > 0)
        {
            user.IdUser = Helper.user11037.Users.OrderBy(x => x.IdUser).Last().IdUser + 1;
        }
        else
        {
            user.IdUser = 0;
        }
        user.Mail = mail.Text;
        user.Login = login.Text;
        user.Passwd = passwd.Text;
        Helper.user11037.Users.Add(user);
        Helper.user11037.SaveChanges();

        MainWindow mainW = new MainWindow();
        mainW.Show();
        this.Close();

    }

}