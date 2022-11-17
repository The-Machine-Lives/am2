using Il2CppDummyDll;

namespace Uken.Framework.Casual.Signals
{
	[Token(Token = "0x2000584")]
	public class BatchableOperation
	{
		[Token(Token = "0x2000863")]
		public enum Type
		{
			[Token(Token = "0x400240F")]
			Leaderboard = 0,
			[Token(Token = "0x4002410")]
			Inventory = 1
		}

		[Token(Token = "0x4001A3E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832B30", Offset = "0x832B30")]
		private Type _003Cm_operationType_003Ek__BackingField;

		[Token(Token = "0x1700075F")]
		public Type m_operationType
		{
			[Token(Token = "0x6002A48")]
			[Address(RVA = "0xA91C68", Offset = "0xA91C68", VA = "0xA91C68")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A68C", Offset = "0x83A68C")]
			get
			{
				return default(Type);
			}
			[Token(Token = "0x6002A49")]
			[Address(RVA = "0xA91C70", Offset = "0xA91C70", VA = "0xA91C70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A69C", Offset = "0x83A69C")]
			private set
			{
			}
		}

		[Token(Token = "0x6002A4A")]
		[Address(RVA = "0xA91C78", Offset = "0xA91C78", VA = "0xA91C78")]
		public BatchableOperation(Type operationType)
		{
		}
	}
}
