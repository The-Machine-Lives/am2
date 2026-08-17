using Il2CppDummyDll;

[Token(Token = "0x2000107")]
public interface IResearchableItemView
{
	[Token(Token = "0x170000E6")]
	IResearchable researchable
	{
		[Token(Token = "0x600072E")]
		get;
	}

	[Token(Token = "0x600072F")]
	void RefreshView();
}
