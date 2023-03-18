using System;
using ObjCRuntime;

namespace Drastic.PlayIndicator.iOS
{
    public class VYTableViewController : UITableViewController
    {
        private const string CellIdentifier = "cellIdentifier";

        public VYTableViewController()
        {
        }

        public VYTableViewController(NSCoder coder) : base(coder)
        {
        }

        protected VYTableViewController(NSObjectFlag t) : base(t)
        {
        }

        protected internal VYTableViewController(NativeHandle handle) : base(handle)
        {
        }

        public VYTableViewController(string? nibName, NSBundle? bundle) : base(nibName, bundle)
        {
        }

        public VYTableViewController(UITableViewStyle withStyle) : base(withStyle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            TableView.RegisterClassForCellReuse(typeof(VYTableViewCell), CellIdentifier);
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 50;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (VYTableViewCell)tableView.DequeueReusableCell(CellIdentifier, indexPath);
            cell.TextLabel.Text = $"Track No {indexPath.Row}";
            return cell;
        }
    }
}