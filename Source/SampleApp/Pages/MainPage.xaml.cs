﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SampleApp.Pages
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
			webView.Eval ("var i = 0;");

		}
	}
}
