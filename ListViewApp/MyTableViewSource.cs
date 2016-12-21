//
// MyTableViewSource.cs
//
// Created by Thomas Dubiel on 20.12.2016
// Copyright 2016 Thomas Dubiel. All rights reserved.
//
using System;
using UIKit;
using System.Collections.Generic;
using System.Linq;
using CoreGraphics;
using System.Diagnostics.Contracts;

namespace ListViewApp
{
	public class MyTableViewSource : UITableViewSource
	{
		Dictionary<string, List<string>> indexedTableItems;
		string[] keys;

		public MyTableViewSource(List<string> tableItems)
		{
			indexedTableItems = new Dictionary<string, List<string>>();
			foreach (var t in tableItems)
			{
				if (indexedTableItems.ContainsKey(t[0].ToString()))
				{
					indexedTableItems[t[0].ToString()].Add(t);
				}
				else {
					indexedTableItems.Add(t[0].ToString(), new List<string>() { t });
				}
			}
			keys = indexedTableItems.Keys.ToArray();
		}

		public override nint NumberOfSections(UITableView tableView)
		{
			return keys.Length;  // try Count();
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return indexedTableItems[keys[section]].Count;
		}

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell("tableViewCell", indexPath) as CustomCell;
			//if (cell == null)
			//	cell = new CustomCell(new Foundation.NSString("tableViewCell"));

			cell.UpdateCell(indexedTableItems[keys[indexPath.Section]][indexPath.Row], "schnuffel");

			return cell;
		}

		public override string[] SectionIndexTitles(UITableView tableView)
		{
			return keys;
		}

		public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return 250f;
		}

		public override string TitleForHeader(UITableView tableView, nint section)
		{
			return keys[section];
		}

		public override UIView GetViewForFooter(UITableView tableView, nint section)
		{
			var view = new UIView(new CGRect(0, 0, tableView.Bounds.Width, 44f));
			var label = new UILabel()
			{
				Font = UIFont.FromName("Helvetica", 22f),
				Frame = new CGRect(10, 5, tableView.Bounds.Width, 25),
				TextColor = UIColor.Red,
				Text = keys[section]
			};
			view.Add(label);
			return view;
		}

		public override nfloat GetHeightForFooter(UITableView tableView, nint section)
		{
			return 44f;
		}
	}
}
