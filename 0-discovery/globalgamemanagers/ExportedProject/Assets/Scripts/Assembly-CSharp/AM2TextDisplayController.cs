using Il2CppDummyDll;
using Uken.Core;
using Uken.Framework.Casual;

[Token(Token = "0x200009F")]
public class AM2TextDisplayController : UkenController
{
	[Token(Token = "0x40002C2")]
	[FieldOffset(Offset = "0x18")]
	private Localizations m_localizationController;

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0xAC5D74", Offset = "0xAC5D74", VA = "0xAC5D74")]
	public AM2TextDisplayController(Localizations localizationController)
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0xAC5DA0", Offset = "0xAC5DA0", VA = "0xAC5DA0")]
	public string CostDisplay(string readableName, long amount)
	{
		return null;
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0xAC60A0", Offset = "0xAC60A0", VA = "0xAC60A0")]
	public string CostDisplay(long amount)
	{
		return null;
	}
}
