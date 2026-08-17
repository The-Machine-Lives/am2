using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x200017D")]
public class MiniEventItem : Item
{
	[Token(Token = "0x4000911")]
	public new const string mc_sItemType = "MiniEventItem";

	[Token(Token = "0x4000912")]
	private const string c_itemReferencePrefix = "mini_event_item_";

	[Token(Token = "0x4000913")]
	private const string c_miniEventReference = "miniEvent_ref";

	[Token(Token = "0x4000914")]
	private const string c_timeRemainingInSeconds = "remaining";

	[Token(Token = "0x4000915")]
	private const string c_seen = "seen";

	[Token(Token = "0x17000131")]
	public string reference
	{
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x99B7BC", Offset = "0x99B7BC", VA = "0x99B7BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000132")]
	public double timeRemainingInSeconds
	{
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x99B7C4", Offset = "0x99B7C4", VA = "0x99B7C4")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x99B81C", Offset = "0x99B81C", VA = "0x99B81C")]
		set
		{
		}
	}

	[Token(Token = "0x17000133")]
	public string miniEventReference
	{
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x99B880", Offset = "0x99B880", VA = "0x99B880")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x99B8E0", Offset = "0x99B8E0", VA = "0x99B8E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000134")]
	public bool seen
	{
		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x99B944", Offset = "0x99B944", VA = "0x99B944")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x99B99C", Offset = "0x99B99C", VA = "0x99B99C")]
		set
		{
		}
	}

	[Token(Token = "0x17000135")]
	public bool IsMarkedAsExpired
	{
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x99BA00", Offset = "0x99BA00", VA = "0x99BA00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000A5D")]
	[Address(RVA = "0x99B734", Offset = "0x99B734", VA = "0x99B734")]
	public static string GetItemReference(int index)
	{
		return null;
	}

	[Token(Token = "0x6000A66")]
	[Address(RVA = "0x99BA58", Offset = "0x99BA58", VA = "0x99BA58", Slot = "4")]
	public override void ResetTraits(bool resetLifeTimeQuantity = false)
	{
	}

	[Token(Token = "0x6000A67")]
	[Address(RVA = "0x99BB20", Offset = "0x99BB20", VA = "0x99BB20")]
	public MiniEventItem()
	{
	}
}
