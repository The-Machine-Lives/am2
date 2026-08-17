using Il2CppDummyDll;

namespace Uken.Library.Inventory
{
	[Token(Token = "0x2000456")]
	public interface ITraitAppender
	{
		[Token(Token = "0x6001FF9")]
		void AppendTraitsToItem(string itemModelReference, string reference, ItemMinimalDetails details);
	}
}
