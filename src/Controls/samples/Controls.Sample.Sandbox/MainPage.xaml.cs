using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
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


			//BenchmarkStrings();

		}


		void BenchmarkStrings()
		{
			string x = "Par1 test";
			string y = "Par2 test";

			Stopwatch timer = new Stopwatch();
			timer.Start();

			for (int i = 0; i < 10000; i++)
			{
				Debug.WriteLine("Benchmark test par1: {0}  par2: {1}", x, y);
			}

			timer.Stop();
			TimeSpan timeTaken = timer.Elapsed;
			Debug.WriteLine("Composite formatting - Time taken: " + timeTaken.ToString(@"m\:ss\.fff"));

			timer.Reset();
			timer.Start();

			for (int i = 0; i < 10000; i++)
			{
				Debug.WriteLine($"Benchmark test par1: {x}  par2: {y}");
			}

			timer.Stop();
			timeTaken = timer.Elapsed;
			Debug.WriteLine("String interpolation - Time taken: " + timeTaken.ToString(@"m\:ss\.fff"));


			timer.Reset();
			timer.Start();

			for (int i = 0; i < 10000; i++)
			{
				Debug.WriteLine(string.Format("Benchmark test par1: %s  par2: %s", x, y));
			}

			timer.Stop();
			timeTaken = timer.Elapsed;
			Debug.WriteLine("String Format - Time taken: " + timeTaken.ToString(@"m\:ss\.fff"));


			timer.Reset();
			timer.Start();

			for (int i = 0; i < 10000; i++)
			{
				Debug.WriteLine("Benchmark test par1: " + x + "  par2: " + y);
			}

			timer.Stop();
			timeTaken = timer.Elapsed;
			Debug.WriteLine("String + String - Time taken: " + timeTaken.ToString(@"m\:ss\.fff"));


			timer.Reset();
			timer.Start();

			for (int i = 0; i < 10000; i++)
			{
				Debug.WriteLine(new StringBuilder().AppendFormat("Benchmark test par1: {0}  par2: {1}", x, y).ToString());
			}

			timer.Stop();
			timeTaken = timer.Elapsed;
			Debug.WriteLine("StringBuilder - Time taken: " + timeTaken.ToString(@"m\:ss\.fff"));
		}
	}
}