﻿namespace SamorodinkaTech.CodeGenerator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

        Shell.SetNavBarIsVisible(MainPage, false);
    }
}

