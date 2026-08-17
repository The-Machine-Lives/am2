using Il2CppDummyDll;
using Uken.Framework.Casual.Leaderboards;

namespace Uken.Framework.Casual.Signals
{
	[Token(Token = "0x2000585")]
	public class LeaderboardBatchableOperation : BatchableOperation
	{
		[Token(Token = "0x4001A3F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832B40", Offset = "0x832B40")]
		private string _003Cm_entityID_003Ek__BackingField;

		[Token(Token = "0x4001A40")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832B50", Offset = "0x832B50")]
		private string _003Cm_entityData_003Ek__BackingField;

		[Token(Token = "0x4001A41")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832B60", Offset = "0x832B60")]
		private long _003Cm_value_003Ek__BackingField;

		[Token(Token = "0x4001A42")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832B70", Offset = "0x832B70")]
		private LeaderboardDefinition _003Cm_leaderboard_003Ek__BackingField;

		[Token(Token = "0x17000760")]
		public string m_entityID
		{
			[Token(Token = "0x6002A4B")]
			[Address(RVA = "0xA91DA8", Offset = "0xA91DA8", VA = "0xA91DA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A6AC", Offset = "0x83A6AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A4C")]
			[Address(RVA = "0xA91DB0", Offset = "0xA91DB0", VA = "0xA91DB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A6BC", Offset = "0x83A6BC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000761")]
		public string m_entityData
		{
			[Token(Token = "0x6002A4D")]
			[Address(RVA = "0xA91DB8", Offset = "0xA91DB8", VA = "0xA91DB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A6CC", Offset = "0x83A6CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A4E")]
			[Address(RVA = "0xA91DC0", Offset = "0xA91DC0", VA = "0xA91DC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A6DC", Offset = "0x83A6DC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000762")]
		public long m_value
		{
			[Token(Token = "0x6002A4F")]
			[Address(RVA = "0xA91DC8", Offset = "0xA91DC8", VA = "0xA91DC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A6EC", Offset = "0x83A6EC")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6002A50")]
			[Address(RVA = "0xA91DD0", Offset = "0xA91DD0", VA = "0xA91DD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A6FC", Offset = "0x83A6FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000763")]
		public LeaderboardDefinition m_leaderboard
		{
			[Token(Token = "0x6002A51")]
			[Address(RVA = "0xA91DD8", Offset = "0xA91DD8", VA = "0xA91DD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A70C", Offset = "0x83A70C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A52")]
			[Address(RVA = "0xA91DE0", Offset = "0xA91DE0", VA = "0xA91DE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A71C", Offset = "0x83A71C")]
			private set
			{
			}
		}

		[Token(Token = "0x6002A53")]
		[Address(RVA = "0xA91DE8", Offset = "0xA91DE8", VA = "0xA91DE8")]
		public LeaderboardBatchableOperation(string entityID, string entityData, long value, LeaderboardDefinition leaderboard)
		{
		}
	}
}
