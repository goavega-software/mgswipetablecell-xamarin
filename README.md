# Xamarin.iOS Bindings for MGSwipeTableCell

[MGSwipeTableCell](https://github.com/MortimerGoro/MGSwipeTableCell) is an easy to use UITableViewCell subclass that allows to display swippable buttons with a variety of transitions. This project allows it to be used with Xamarin.iOS. Contains two projects:

 * MGSwipeCell.Xamarin.Binding (the actual binding)
 * MGSwipeCell.Xamarin.Demo (demo project with storyboard)

### Sample usage

```C#
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
```

## License
Both MGSwipeTableCell and the Bindings are MIT Licensed.

