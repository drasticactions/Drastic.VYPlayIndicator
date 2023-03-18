using CoreAnimation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Drastic.VYPlayIndicator
{
	// @interface VYPlayIndicator : CALayer
	[BaseType (typeof(CALayer))]
	interface VYPlayIndicator
	{
		// @property (readwrite, nonatomic, strong) UIColor * color;
		[Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// @property (assign, readwrite, nonatomic) VYPlayState state;
		[Export ("state", ArgumentSemantic.Assign)]
		VYPlayState State { get; set; }

		// @property (assign, readwrite, nonatomic) VYPlayStyle indicatorStyle;
		[Export ("indicatorStyle", ArgumentSemantic.Assign)]
		VYPlayStyle IndicatorStyle { get; set; }

		// @property (readwrite, copy, nonatomic) dispatch_block_t completionBlock;
		[Export ("completionBlock", ArgumentSemantic.Copy)]
		dispatch_block_t CompletionBlock { get; set; }

		// -(void)animatePlayback;
		[Export ("animatePlayback")]
		void AnimatePlayback ();

		// -(void)stopPlayback;
		[Export ("stopPlayback")]
		void StopPlayback ();

		// -(void)pausePlayback;
		[Export ("pausePlayback")]
		void PausePlayback ();

		// -(void)reset;
		[Export ("reset")]
		void Reset ();
	}
}
