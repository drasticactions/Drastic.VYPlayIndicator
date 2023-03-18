using ObjCRuntime;

namespace Drastic.VYPlayIndicator
{
	[Native]
	public enum VYPlayState : ulong
	{
		Stopped = 0,
		Playing = 1,
		Paused = 2
	}

	[Native]
	public enum VYPlayStyle : ulong
	{
		Legacy = 0,
		Modern = 1
	}
}
