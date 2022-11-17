using Il2CppDummyDll;

namespace Uken.Library.Inventory
{
	[Token(Token = "0x2000451")]
	public interface IInventoryProgressTracker
	{
		[Token(Token = "0x6001FEC")]
		void TrackProgress(string reference, long delta, ItemMinimalDetails itemDetails);
	}
}
