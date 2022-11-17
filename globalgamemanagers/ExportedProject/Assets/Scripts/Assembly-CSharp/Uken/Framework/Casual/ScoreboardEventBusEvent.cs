using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000567")]
	public sealed class ScoreboardEventBusEvent
	{
		[Token(Token = "0x400199F")]
		[FieldOffset(Offset = "0x10")]
		private readonly int m_eventType;

		[Token(Token = "0x40019A0")]
		[FieldOffset(Offset = "0x14")]
		private readonly int m_eventValue;

		[Token(Token = "0x1700074A")]
		public int EventType
		{
			[Token(Token = "0x6002941")]
			[Address(RVA = "0xA91BF8", Offset = "0xA91BF8", VA = "0xA91BF8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700074B")]
		public int EventValue
		{
			[Token(Token = "0x6002942")]
			[Address(RVA = "0xA91C00", Offset = "0xA91C00", VA = "0xA91C00")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6002940")]
		[Address(RVA = "0xA91518", Offset = "0xA91518", VA = "0xA91518")]
		public ScoreboardEventBusEvent(int eventType, int eventValue)
		{
		}
	}
}
