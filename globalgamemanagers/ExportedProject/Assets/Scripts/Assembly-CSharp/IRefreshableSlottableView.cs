using Il2CppDummyDll;

[Token(Token = "0x200010E")]
public interface IRefreshableSlottableView<TSlottedItem> : ISlottableView<TSlottedItem> where TSlottedItem : ISlottedItem
{
	[Token(Token = "0x6000775")]
	void RefreshSlots();
}
