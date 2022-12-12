using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Layouts;

namespace Maui.Controls.Sample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			for (int i = 0; i < 15000; i++)
			{
				Button button = new Button();
				FlexLayout.SetAlignSelf(button, FlexAlignSelf.Center);
				FlexLayout.SetBasis(button, 80);
				flxlayout.Add(button);
			}




			
			Stopwatch timer = new Stopwatch();
			timer.Start();

			flxlayout.Clear();
			
			timer.Stop();

			TimeSpan timeTaken = timer.Elapsed;
			Debug.WriteLine("*** page Time taken: " + timeTaken.ToString(@"m\:ss\.fff"));
			
			

			/*
		for (int i = 0; i < 20000; i++)
		{
			flxlayout2.Add(new Button());
		}


		Stopwatch timer2 = new Stopwatch();
		timer2.Start();


		flxlayout.Children.Clear();

		timer2.Stop();

		TimeSpan timeTaken2 = timer2.Elapsed;
		Debug.WriteLine("*** Time taken: " + timeTaken2.ToString(@"m\:ss\.fff"));
			*/

		}
		void TestFunction()
		{

		}
	}
}