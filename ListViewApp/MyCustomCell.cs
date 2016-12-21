//
// MyCustomCell.cs
//
// Created by Thomas Dubiel on 20.12.2016
// Copyright 2016 Thomas Dubiel. All rights reserved.
//
using System;
using UIKit;
using Foundation;
using CoreGraphics;

namespace ListViewApp
{
	public class MyCustomCell : UITableViewCell
	{
		UILabel headingLabel, subHeadingLabel;

		public MyCustomCell(NSString cellId) : base(UITableViewCellStyle.Default, cellId)
		{
			SelectionStyle = UITableViewCellSelectionStyle.Blue;
			ContentView.BackgroundColor = UIColor.Cyan;

			headingLabel = new UILabel()
			{
				Font = UIFont.FromName("Helvetica", 17f),
				TextColor = UIColor.Red,
				BackgroundColor = UIColor.Clear
			};

			subHeadingLabel = new UILabel()
			{
				Font = UIFont.FromName("AmericanTypewriter", 12f),
				TextAlignment = UITextAlignment.Center,
				TextColor = UIColor.Blue,
				BackgroundColor = UIColor.Clear
			};

			ContentView.AddSubviews(new UIView[] { headingLabel, subHeadingLabel });
		}

		public void UpdateCell(string heading, string subHeading)
		{
			headingLabel.Text = heading;
			subHeadingLabel.Text = subHeading;
		}

		public override void LayoutSubviews()
		{
			//base.LayoutSubviews();
			headingLabel.Frame = new CGRect(5, 5, ContentView.Bounds.Width, 25);
			subHeadingLabel.Frame = new CGRect(100, 22, 100, 20);
		}
	}
}
