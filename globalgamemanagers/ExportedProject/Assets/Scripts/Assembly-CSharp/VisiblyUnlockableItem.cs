using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x2000190")]
public class VisiblyUnlockableItem : Item
{
	[Token(Token = "0x4000969")]
	protected const string c_visible = "visible";

	[Token(Token = "0x400096A")]
	private const bool c_defaultVisible = false;

	[Token(Token = "0x1700015C")]
	public virtual bool visible
	{
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0xAB8D8C", Offset = "0xAB8D8C", VA = "0xAB8D8C", Slot = "8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0xAB8D90", Offset = "0xAB8D90", VA = "0xAB8D90", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x6000ADE")]
	[Address(RVA = "0xAB8CC8", Offset = "0xAB8CC8", VA = "0xAB8CC8")]
	public static bool GetVisible(Item item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000ADF")]
	[Address(RVA = "0xAB8D34", Offset = "0xAB8D34", VA = "0xAB8D34", Slot = "4")]
	public override void ResetTraits(bool resetLifeTimeQuantity = false)
	{
	}

	[Token(Token = "0x6000AE2")]
	[Address(RVA = "0xAB8DF4", Offset = "0xAB8DF4", VA = "0xAB8DF4")]
	public VisiblyUnlockableItem()
	{
	}
}
