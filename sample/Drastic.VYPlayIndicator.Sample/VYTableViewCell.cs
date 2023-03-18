using System;
using CoreAnimation;
using ObjCRuntime;
using Drastic.VYPlayIndicator;

namespace Drastic.PlayIndicator.iOS
{
    [Register("VYTableViewCell")]
    public class VYTableViewCell : UITableViewCell
    {
		public VYTableViewCell()
		{
        }

        public VYTableViewCell(UITableViewCellStyle style, string reuseIdentifier) : base(style, reuseIdentifier)
        {
        }

        public VYTableViewCell(NSCoder coder) : base(coder)
        {
        }

        protected VYTableViewCell(NSObjectFlag t) : base(t)
        {
        }

        protected internal VYTableViewCell(NativeHandle handle) : base(handle)
        {
            AccessoryView = new UIView(new CoreGraphics.CGRect(0, 0, 15, 15));
            PlayIndicator = new Drastic.VYPlayIndicator.VYPlayIndicator() { Frame = AccessoryView.Bounds, IndicatorStyle = VYPlayStyle.Modern };
            AccessoryView.Layer.AddSublayer(PlayIndicator);
        }

        public VYTableViewCell(CGRect frame) : base(frame)
        {
        }

        public VYTableViewCell(UITableViewCellStyle style, NSString? reuseIdentifier) : base(style, reuseIdentifier)
        {
        }

        public Drastic.VYPlayIndicator.VYPlayIndicator PlayIndicator { get; private set; }

        public override void SetSelected(bool selected, bool animated)
        {
            base.SetSelected(selected, animated);
            PlayIndicator.State = selected ? VYPlayState.Playing : VYPlayState.Stopped;
        }

        public override void PrepareForReuse()
        {
            base.PrepareForReuse();
            PlayIndicator.Reset();
        }

        public override void LayoutSublayersOfLayer(CALayer layer)
        {
            base.LayoutSublayersOfLayer(layer);
            PlayIndicator.Frame = AccessoryView!.Bounds;
        }
    }
}

