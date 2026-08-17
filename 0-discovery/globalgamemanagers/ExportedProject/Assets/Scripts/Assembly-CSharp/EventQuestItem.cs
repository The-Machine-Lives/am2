using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x2000179")]
public class EventQuestItem : Item
{
	[Token(Token = "0x4000906")]
	public new const string mc_sItemType = "EventQuestItem";

	[Token(Token = "0x4000907")]
	private const string c_iterationKey = "iteration";

	[Token(Token = "0x4000908")]
	private const string c_isActiveKey = "active";

	[Token(Token = "0x4000909")]
	private const string c_complete = "complete";

	[Token(Token = "0x1700012C")]
	public int iteration
	{
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x9C7F18", Offset = "0x9C7F18", VA = "0x9C7F18")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x9C7F70", Offset = "0x9C7F70", VA = "0x9C7F70")]
		set
		{
		}
	}

	[Token(Token = "0x1700012D")]
	public bool isComplete
	{
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x9C7FD4", Offset = "0x9C7FD4", VA = "0x9C7FD4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x9C802C", Offset = "0x9C802C", VA = "0x9C802C")]
		set
		{
		}
	}

	[Token(Token = "0x1700012E")]
	public bool isActive
	{
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x9C8090", Offset = "0x9C8090", VA = "0x9C8090")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x9C80E8", Offset = "0x9C80E8", VA = "0x9C80E8")]
		set
		{
		}
	}

	[Token(Token = "0x6000A4D")]
	[Address(RVA = "0x9C814C", Offset = "0x9C814C", VA = "0x9C814C")]
	public bool HasIsActiveTrait()
	{
		return default(bool);
	}

	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0x9C81AC", Offset = "0x9C81AC", VA = "0x9C81AC")]
	public EventQuestItem()
	{
	}
}
