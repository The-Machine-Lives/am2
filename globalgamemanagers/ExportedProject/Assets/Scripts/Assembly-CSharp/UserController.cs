using Il2CppDummyDll;
using Uken.Core;

[Token(Token = "0x200016E")]
public class UserController : UkenController
{
	[Token(Token = "0x40008ED")]
	[FieldOffset(Offset = "0x18")]
	private AM2Game m_game;

	[Token(Token = "0x17000113")]
	public string UserID
	{
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0xAB5484", Offset = "0xAB5484", VA = "0xAB5484")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000114")]
	public long Level
	{
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xAB54BC", Offset = "0xAB54BC", VA = "0xAB54BC")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000115")]
	public long Xp
	{
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xAB5588", Offset = "0xAB5588", VA = "0xAB5588")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000116")]
	public long SoftCurrency
	{
		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0xAB5654", Offset = "0xAB5654", VA = "0xAB5654")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000117")]
	public long HardCurrency
	{
		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0xAB5720", Offset = "0xAB5720", VA = "0xAB5720")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000118")]
	public long MTokens
	{
		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0xAB57EC", Offset = "0xAB57EC", VA = "0xAB57EC")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000119")]
	public long Evos
	{
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0xAB58B8", Offset = "0xAB58B8", VA = "0xAB58B8")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700011A")]
	public long Booster1
	{
		[Token(Token = "0x6000A11")]
		[Address(RVA = "0xAB5984", Offset = "0xAB5984", VA = "0xAB5984")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700011B")]
	public long Booster2
	{
		[Token(Token = "0x6000A12")]
		[Address(RVA = "0xAB5A50", Offset = "0xAB5A50", VA = "0xAB5A50")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700011C")]
	public long Booster3
	{
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0xAB5B1C", Offset = "0xAB5B1C", VA = "0xAB5B1C")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700011D")]
	public long Booster4
	{
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xAB5BE8", Offset = "0xAB5BE8", VA = "0xAB5BE8")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700011E")]
	public long Dust
	{
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xAB5CB4", Offset = "0xAB5CB4", VA = "0xAB5CB4")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700011F")]
	public long PrestigeTokens
	{
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0xAB5D80", Offset = "0xAB5D80", VA = "0xAB5D80")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000120")]
	public string VIPStatus
	{
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0xAB5E4C", Offset = "0xAB5E4C", VA = "0xAB5E4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000121")]
	public int VIPTimeRemainingDays
	{
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xAB5FA4", Offset = "0xAB5FA4", VA = "0xAB5FA4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000122")]
	public long PrestigeLevel
	{
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xAB610C", Offset = "0xAB610C", VA = "0xAB610C")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x6000A05")]
	[Address(RVA = "0xAB5438", Offset = "0xAB5438", VA = "0xAB5438")]
	public UserController(AM2Game game)
	{
	}

	[Token(Token = "0x6000A06")]
	[Address(RVA = "0xAB5464", Offset = "0xAB5464", VA = "0xAB5464", Slot = "4")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6000A07")]
	[Address(RVA = "0xAB546C", Offset = "0xAB546C", VA = "0xAB546C", Slot = "5")]
	public override bool LoadContent()
	{
		return default(bool);
	}

	[Token(Token = "0x6000A08")]
	[Address(RVA = "0xAB5474", Offset = "0xAB5474", VA = "0xAB5474", Slot = "9")]
	public override void OnDataUpdated()
	{
	}

	[Token(Token = "0x6000A09")]
	[Address(RVA = "0xAB547C", Offset = "0xAB547C", VA = "0xAB547C", Slot = "7")]
	public override void Update(float deltaTime)
	{
	}
}
