using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x2000172")]
public class BadgeItem : Item
{
	[Token(Token = "0x40008F3")]
	public new const string mc_sItemType = "BadgeItem";

	[Token(Token = "0x40008F4")]
	private const string c_activeDye = "dye";

	[Token(Token = "0x17000124")]
	public string activeDyeRef
	{
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xA458DC", Offset = "0xA458DC", VA = "0xA458DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xA45934", Offset = "0xA45934", VA = "0xA45934")]
		set
		{
		}
	}

	[Token(Token = "0x6000A26")]
	[Address(RVA = "0xA45998", Offset = "0xA45998", VA = "0xA45998")]
	public BadgeItem()
	{
	}
}
