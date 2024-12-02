using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using demo0212.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace demo0212;

public partial class Zayavka : Window
{
    public List<Employee1> employees = Helper.user11037.Employee1s.ToList();
   // public List<Emplyee> departments = Helper.user11037.Emplyees.ToList();
    public Zayavka()
    {
        InitializeComponent();
    }
    private void vyhod_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        CurrentZayavki currentzayavki = new CurrentZayavki();
        currentzayavki.Show();
        this.Close();
    }


    private void Ok_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        bool check = true;
     /*   DateOnly srokNach = DateOnly.FromDateTime((DateTime)nachD.SelectedDate.Value.DateTime);
        DateOnly srokKon = DateOnly.FromDateTime((DateTime)endD.SelectedDate.Value.DateTime);
        Zayavka zayavka = new Zayavka();
        zayavka.IdZayavka = Helper.context.Zayavkas.OrderBy(x => x.IdZayavka).Last().IdZayavka + 1;
        zayavka.IdAimNavigation = Helper.context.Aims.Where(x => x.Name == aimCB.SelectedValue.ToString()).First();
        zayavka.IdAim = Helper.context.Aims.Where(x => x.Name == aimCB.SelectedValue.ToString()).First().IdAim;
        zayavka.SrokNach = srokNach;
        zayavka.SrokKonets = srokKon;
        zayavka.IdPodrazdNavigation = Helper.context.Podrazds.Where(x => x.Name == podrCB.SelectedValue.ToString()).First();
        zayavka.IdPodrazd = Helper.context.Podrazds.Where(x => x.Name == podrCB.SelectedValue.ToString()).First().IdPodrazd;
        zayavka.IdStatNavigation = Helper.context.Statuses.Where(x => x.IdStat == 1).First();
        zayavka.IdStat = 1;
        Helper.context.Zayavkas.Add(zayavka);*/

    }

}