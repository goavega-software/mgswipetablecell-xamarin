/*
 * MGSwipeTableCell.Xamarin is licensed under MIT license. See LICENSE.md file for more information.
 * Copyright (c) 2017 Goavega Software
 */
using System;
using System.Collections.Generic;
using UIKit;
using MGSwipeCell.Xamarin.Binding;

namespace MGSwipeCell.Xamarin.Demo
{
	public partial class ViewController : UIViewController, IUITableViewDelegate
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			var source = new TableDataSource();
			tableView.Source = source;
			tableView.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;
			List<TestData> tests = new List<TestData>();
			for (var i = 0; i < 5; i++)
			{
				var test = new TestData(i);
				tests.Add(test);
			}
			source.tests = tests;
			tableView.ReloadData();
		}

	}

	public class TableDataSource : UITableViewSource
	{
		//List<TestData> tests = new List<TestData>();  

		public List<TestData> tests { get; set; } 

		public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return 60;
		}

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			string Id = "programmaticCell";
			var cell = tableView.DequeueReusableCell(Id, indexPath) as MGSwipeTableCell;
			if (cell == null)
			{
				cell = new MGSwipeTableCell(UITableViewCellStyle.Default, Id);

			}
			var test = tests[indexPath.Row];
			cell.TextLabel.Text = test.Title;
			cell.RightSwipeSettings.Transition = MGSwipeTransition.Drag;
			cell.RightExpansion.ButtonIndex = 0;
			cell.RightExpansion.FillOnTrigger = true;
			cell.RightButtons = new MGSwipeButton[] {
				MGSwipeButton.ButtonWithTitle("", UIImage.FromBundle("Fav"), UIColor.Green, 15,
											  (tableCell) => {
					Console.WriteLine(tableView.IndexPathForCell(tableCell).Row);
					Console.WriteLine("hello clicked");
					return true;
				}),
				MGSwipeButton.ButtonWithTitle("", UIImage.FromBundle("Menu"), UIColor.Red, 15, (arg0) => {
					return false;
				})
			};
			return cell;
		}

		public override nint NumberOfSections(UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection(UITableView tableView, nint section)
		{
			return tests == null ? 0 : tests.Count;
		}
	}

	public class TestData
	{
		public int index;

		public TestData(int i)
		{
			index = i;
		}

		public string Title
		{
			get
			{
				return $"Item {index}";
			}
		}
	}
}
