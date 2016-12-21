//
// ViewController.cs
//
// Created by Thomas Dubiel on 20.12.2016
// Copyright 2016 Thomas Dubiel. All rights reserved.
//
using System;

using UIKit;
using System.Collections.Generic;

namespace ListViewApp
{
	public partial class ViewController : UIViewController
	{

		List<string> tableItems;

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
			tableItems = new List<string>() {
				"Apple",
				"Zebra",
				"Buterfly",
				"Whatever",
				"Nice Girl"
			};

		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			tableView.Source = new MyTableViewSource(tableItems);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
