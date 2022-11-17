using Il2CppDummyDll;

[Token(Token = "0x200010F")]
public interface ISlottableView<TSlottedItem> where TSlottedItem : ISlottedItem
{
	[Token(Token = "0x6000776")]
	void OnClickedItemView(int sourceIndex, TSlottedItem item, int clickCount, SlottedItemView<TSlottedItem> itemView);
}
