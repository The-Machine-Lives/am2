using Il2CppDummyDll;

[Token(Token = "0x2000106")]
public interface IResearchableView
{
	[Token(Token = "0x600072C")]
	void OnSelectResearch(IResearchableItemView selectedItem);

	[Token(Token = "0x600072D")]
	void OnSelectResearchBulk(IResearchableItemView selectedItem);
}
