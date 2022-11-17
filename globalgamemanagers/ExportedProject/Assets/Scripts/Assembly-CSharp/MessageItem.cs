using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x2000215")]
public class MessageItem : Item
{
	[Token(Token = "0x4000BE0")]
	public new const string mc_sItemType = "MessageItem";

	[Token(Token = "0x4000BE1")]
	public const string c_referencePrefix = "message:";

	[Token(Token = "0x4000BE2")]
	public const string c_refdataSource = "refdata";

	[Token(Token = "0x4000BE3")]
	private const string c_from = "from";

	[Token(Token = "0x4000BE4")]
	private const string c_subject = "subject";

	[Token(Token = "0x4000BE5")]
	private const string c_messageCount = "message_count";

	[Token(Token = "0x4000BE6")]
	private const string c_messagePrefix = "message_";

	[Token(Token = "0x4000BE7")]
	private const string c_expiration = "expiration";

	[Token(Token = "0x4000BE8")]
	private const string c_rewardItemReference = "reward_item_reference";

	[Token(Token = "0x4000BE9")]
	private const string c_rewardAmount = "reward_amount";

	[Token(Token = "0x4000BEA")]
	private const string c_claimed = "claimed";

	[Token(Token = "0x4000BEB")]
	private const string c_seen = "seen";

	[Token(Token = "0x4000BEC")]
	private const string c_source = "src";

	[Token(Token = "0x4000BED")]
	private const string c_iteration = "itr";

	[Token(Token = "0x4000BEE")]
	private const string c_deleteButtonPressed = "msg_del";

	[Token(Token = "0x4000BEF")]
	private const int c_characterLimit = 100;

	[Token(Token = "0x170001C7")]
	public string ID
	{
		[Token(Token = "0x6000E30")]
		[Address(RVA = "0x988270", Offset = "0x988270", VA = "0x988270")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C8")]
	public bool MessageDeleted
	{
		[Token(Token = "0x6000E31")]
		[Address(RVA = "0x989F1C", Offset = "0x989F1C", VA = "0x989F1C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001C9")]
	public bool IsRefDataSource
	{
		[Token(Token = "0x6000E32")]
		[Address(RVA = "0x99B06C", Offset = "0x99B06C", VA = "0x99B06C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001CA")]
	public string From
	{
		[Token(Token = "0x6000E33")]
		[Address(RVA = "0x99B124", Offset = "0x99B124", VA = "0x99B124")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E34")]
		[Address(RVA = "0x99B184", Offset = "0x99B184", VA = "0x99B184")]
		set
		{
		}
	}

	[Token(Token = "0x170001CB")]
	public string Subject
	{
		[Token(Token = "0x6000E35")]
		[Address(RVA = "0x98813C", Offset = "0x98813C", VA = "0x98813C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E36")]
		[Address(RVA = "0x99B1E8", Offset = "0x99B1E8", VA = "0x99B1E8")]
		set
		{
		}
	}

	[Token(Token = "0x170001CC")]
	public string Message
	{
		[Token(Token = "0x6000E37")]
		[Address(RVA = "0x988030", Offset = "0x988030", VA = "0x988030")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x99B24C", Offset = "0x99B24C", VA = "0x99B24C")]
		set
		{
		}
	}

	[Token(Token = "0x170001CD")]
	public int Expiration
	{
		[Token(Token = "0x6000E39")]
		[Address(RVA = "0x99B41C", Offset = "0x99B41C", VA = "0x99B41C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x99B474", Offset = "0x99B474", VA = "0x99B474")]
		set
		{
		}
	}

	[Token(Token = "0x170001CE")]
	public string RewardItemReference
	{
		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x9895AC", Offset = "0x9895AC", VA = "0x9895AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x99B4D8", Offset = "0x99B4D8", VA = "0x99B4D8")]
		set
		{
		}
	}

	[Token(Token = "0x170001CF")]
	public long RewardAmount
	{
		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0x98960C", Offset = "0x98960C", VA = "0x98960C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0x99B53C", Offset = "0x99B53C", VA = "0x99B53C")]
		set
		{
		}
	}

	[Token(Token = "0x170001D0")]
	public string Source
	{
		[Token(Token = "0x6000E3F")]
		[Address(RVA = "0x99B0C4", Offset = "0x99B0C4", VA = "0x99B0C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E40")]
		[Address(RVA = "0x99B5A0", Offset = "0x99B5A0", VA = "0x99B5A0")]
		set
		{
		}
	}

	[Token(Token = "0x170001D1")]
	public bool Claimed
	{
		[Token(Token = "0x6000E41")]
		[Address(RVA = "0x9893F4", Offset = "0x9893F4", VA = "0x9893F4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E42")]
		[Address(RVA = "0x98979C", Offset = "0x98979C", VA = "0x98979C")]
		set
		{
		}
	}

	[Token(Token = "0x170001D2")]
	public bool Seen
	{
		[Token(Token = "0x6000E43")]
		[Address(RVA = "0x989554", Offset = "0x989554", VA = "0x989554")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E44")]
		[Address(RVA = "0x98944C", Offset = "0x98944C", VA = "0x98944C")]
		set
		{
		}
	}

	[Token(Token = "0x170001D3")]
	public int Iteration
	{
		[Token(Token = "0x6000E45")]
		[Address(RVA = "0x99B604", Offset = "0x99B604", VA = "0x99B604")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x99B65C", Offset = "0x99B65C", VA = "0x99B65C")]
		set
		{
		}
	}

	[Token(Token = "0x170001D4")]
	public bool WasDeleteButtonPressed
	{
		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x98AD00", Offset = "0x98AD00", VA = "0x98AD00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E48")]
		[Address(RVA = "0x99B6C0", Offset = "0x99B6C0", VA = "0x99B6C0")]
		set
		{
		}
	}

	[Token(Token = "0x6000E49")]
	[Address(RVA = "0x99B724", Offset = "0x99B724", VA = "0x99B724")]
	public MessageItem()
	{
	}
}
