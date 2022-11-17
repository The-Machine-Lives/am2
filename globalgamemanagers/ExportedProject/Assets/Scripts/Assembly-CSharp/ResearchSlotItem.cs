using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x2000186")]
public class ResearchSlotItem : Item
{
	[Token(Token = "0x400093B")]
	public new const string mc_sItemType = "ResearchSlotItem";

	[Token(Token = "0x400093C")]
	private const string c_refDataRef = "refd";

	[Token(Token = "0x400093D")]
	private const string c_refDataType = "ref_type";

	[Token(Token = "0x400093E")]
	[FieldOffset(Offset = "0x20")]
	private string c_currentRate;

	[Token(Token = "0x400093F")]
	[FieldOffset(Offset = "0x28")]
	private long c_defaultRate;

	[Token(Token = "0x4000940")]
	[FieldOffset(Offset = "0x30")]
	private string c_defaultRefDataRef;

	[Token(Token = "0x4000941")]
	[FieldOffset(Offset = "0x38")]
	private long c_defaultRefDataType;

	[Token(Token = "0x17000148")]
	public string refDataRef
	{
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x9F5B8C", Offset = "0x9F5B8C", VA = "0x9F5B8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x9F5BE4", Offset = "0x9F5BE4", VA = "0x9F5BE4")]
		set
		{
		}
	}

	[Token(Token = "0x17000149")]
	public long refDataType
	{
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x9F5C48", Offset = "0x9F5C48", VA = "0x9F5C48")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x9F5CA0", Offset = "0x9F5CA0", VA = "0x9F5CA0")]
		set
		{
		}
	}

	[Token(Token = "0x1700014A")]
	public long currentRate
	{
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x9F5B68", Offset = "0x9F5B68", VA = "0x9F5B68")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x9F5B74", Offset = "0x9F5B74", VA = "0x9F5B74")]
		set
		{
		}
	}

	[Token(Token = "0x6000A9E")]
	[Address(RVA = "0x9F5ACC", Offset = "0x9F5ACC", VA = "0x9F5ACC", Slot = "4")]
	public override void ResetTraits(bool resetLifeTimeQuantity = false)
	{
	}

	[Token(Token = "0x6000AA5")]
	[Address(RVA = "0x9F5D04", Offset = "0x9F5D04", VA = "0x9F5D04")]
	public ResearchSlotItem()
	{
	}
}
