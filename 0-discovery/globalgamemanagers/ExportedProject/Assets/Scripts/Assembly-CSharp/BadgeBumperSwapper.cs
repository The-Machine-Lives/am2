using AM2.ReferenceData;
using Il2CppDummyDll;

[Token(Token = "0x20000F1")]
public class BadgeBumperSwapper : ColoredPrefabSwapper<BadgeBumperView>
{
	[Token(Token = "0x4000597")]
	[FieldOffset(Offset = "0x48")]
	private ProfilePageController m_profilePageController;

	[Token(Token = "0x4000598")]
	[FieldOffset(Offset = "0x50")]
	private Dye m_currentDye;

	[Token(Token = "0x600066E")]
	[Address(RVA = "0xA446B4", Offset = "0xA446B4", VA = "0xA446B4")]
	public void Initialize(Dye dye)
	{
	}

	[Token(Token = "0x600066F")]
	[Address(RVA = "0xA447F8", Offset = "0xA447F8", VA = "0xA447F8")]
	public void UpdateWithDye(Dye dye)
	{
	}

	[Token(Token = "0x6000670")]
	[Address(RVA = "0xA448DC", Offset = "0xA448DC", VA = "0xA448DC")]
	public BadgeBumperSwapper()
	{
	}
}
