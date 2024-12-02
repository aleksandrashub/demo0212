using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using demo0212.Models;
using demo0212.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace demo0212;

public partial class CurrentZayavki : Window
{
    public List<Order> zayavkas = Helper.user11037.Orders.Where(x => x.IdUser == Helper.curruser.IdUser)
        .Include(x => x.IdEmployeeNavigation).Include(x => x.IdEmployeeNavigation.EmployeeCodeNavigation).
        Include(x => x.IdStatusNavigation).ToList();
        //Helper.user11037.Orders.Where(x => x.IdUser == Helper.curruser.IdUser).
      //  Include(x => x.IdEmployeeNavigation).Include(x => x.IdStatusNavigation).ToList();
    public CurrentZayavki()
    {
        InitializeComponent();
    }

    private void update()
    {
        var list = zayavkas;
        //Helper.context.Zayavkas;
        listB.ItemsSource = list.ToList();
    }

    private void vyhod_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow main = new MainWindow();
        main.Show();
        this.Close();
    }

    private void NewZ_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {


    }
}