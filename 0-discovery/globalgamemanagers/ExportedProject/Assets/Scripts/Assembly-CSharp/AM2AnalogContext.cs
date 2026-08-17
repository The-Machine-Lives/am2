using System.Collections.Generic;
using Com.Uken.Analog;
using Com.Uken.Core;
using Il2CppDummyDll;

[Token(Token = "0x20000A2")]
public class AM2AnalogContext : RuntimeContext
{
	[Token(Token = "0x40002E8")]
	private const string c_vipStatus = "vip_status";

	[Token(Token = "0x40002E9")]
	private const string c_vipRemaining = "vip_remaining";

	[Token(Token = "0x40002EA")]
	[FieldOffset(Offset = "0xD0")]
	private Dictionary<string, string> abOverride;

	[Token(Token = "0x40002EB")]
	[FieldOffset(Offset = "0xD8")]
	private Dictionary<string, object> contextOverride;

	[Token(Token = "0x40002EC")]
	[FieldOffset(Offset = "0xE0")]
	private UserController m_user;

	[Token(Token = "0x40002ED")]
	[FieldOffset(Offset = "0xE8")]
	private Com.Uken.Core.Device ukenDevice;

	[Token(Token = "0x170000BC")]
	public override Dictionary<string, object> Context
	{
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x978B6C", Offset = "0x978B6C", VA = "0x978B6C", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x978FEC", Offset = "0x978FEC", VA = "0x978FEC", Slot = "5")]
		protected set
		{
		}
	}

	[Token(Token = "0x170000BD")]
	public override string Adid
	{
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x979150", Offset = "0x979150", VA = "0x979150", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000BE")]
	public override string Idfa
	{
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x9791BC", Offset = "0x9791BC", VA = "0x9791BC", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000BF")]
	public override string Ifv
	{
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x979228", Offset = "0x979228", VA = "0x979228", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C0")]
	public override string AndroidId
	{
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x979294", Offset = "0x979294", VA = "0x979294", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C1")]
	public override string UserId
	{
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x979300", Offset = "0x979300", VA = "0x979300", Slot = "11")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x979364", Offset = "0x979364", VA = "0x979364", Slot = "12")]
		set
		{
		}
	}

	[Token(Token = "0x170000C2")]
	public override int Level
	{
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x979368", Offset = "0x979368", VA = "0x979368", Slot = "13")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x979388", Offset = "0x979388", VA = "0x979388", Slot = "14")]
		set
		{
		}
	}

	[Token(Token = "0x170000C3")]
	public override long Xp
	{
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x97938C", Offset = "0x97938C", VA = "0x97938C", Slot = "15")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x9793A0", Offset = "0x9793A0", VA = "0x9793A0", Slot = "16")]
		set
		{
		}
	}

	[Token(Token = "0x170000C4")]
	public override long SoftCurrency
	{
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x9793A4", Offset = "0x9793A4", VA = "0x9793A4", Slot = "17")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x9793B8", Offset = "0x9793B8", VA = "0x9793B8", Slot = "18")]
		set
		{
		}
	}

	[Token(Token = "0x170000C5")]
	public override long HardCurrency
	{
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x9793BC", Offset = "0x9793BC", VA = "0x9793BC", Slot = "19")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x9793D0", Offset = "0x9793D0", VA = "0x9793D0", Slot = "20")]
		set
		{
		}
	}

	[Token(Token = "0x170000C6")]
	public override Dictionary<string, string> AbTests
	{
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x9793D4", Offset = "0x9793D4", VA = "0x9793D4", Slot = "25")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x9793DC", Offset = "0x9793DC", VA = "0x9793DC", Slot = "26")]
		set
		{
		}
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x9789C8", Offset = "0x9789C8", VA = "0x9789C8")]
	public AM2AnalogContext(UserController userController, App.GameName game, App.EnvironmentName environment, string user_id, string app_version, int level, long xp, long soft_currency, long hard_currency, string user_agent, string locale_identifier, string adid, string idfa, string ifv, string androidID, string adjustID)
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x978FF0", Offset = "0x978FF0", VA = "0x978FF0")]
	private string getDeviceIdendifier(Dictionary<string, string> ids, string id)
	{
		return null;
	}
}
