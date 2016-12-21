using Foundation;
using System;
using UIKit;

namespace ListViewApp
{
	public partial class CustomCell : UITableViewCell
	{
		public CustomCell(IntPtr handle) : base(handle)
		{
		}

		public void UpdateCell(string heading, string subHeading)
		{
			headingLabel.Text = heading;
			subHeadingLabel.Text = subHeading;
		}
	}
}