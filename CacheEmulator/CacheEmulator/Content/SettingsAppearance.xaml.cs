﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CacheEmulator.Content
{
	/// <summary>
	/// Interaction logic for SettingsAppearance.xaml
	/// </summary>
	public partial class SettingsAppearance : UserControl
	{
		public SettingsAppearance()
		{
			InitializeComponent();

			// create and assign the appearance view model
			this.DataContext = new SettingsAppearanceViewModel();
		}
	}
}
