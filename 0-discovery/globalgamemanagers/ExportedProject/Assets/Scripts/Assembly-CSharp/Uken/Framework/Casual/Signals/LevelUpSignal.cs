using Il2CppDummyDll;

namespace Uken.Framework.Casual.Signals
{
	[Token(Token = "0x2000588")]
	public class LevelUpSignal : Signal
	{
		[Token(Token = "0x4001A4A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832BF0", Offset = "0x832BF0")]
		private int _003Cm_currentLevel_003Ek__BackingField;

		[Token(Token = "0x4001A4B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832C00", Offset = "0x832C00")]
		private int _003Cm_previousLevel_003Ek__BackingField;

		[Token(Token = "0x1700076B")]
		public int m_currentLevel
		{
			[Token(Token = "0x6002A64")]
			[Address(RVA = "0xA91E38", Offset = "0xA91E38", VA = "0xA91E38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A80C", Offset = "0x83A80C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6002A65")]
			[Address(RVA = "0xA91E40", Offset = "0xA91E40", VA = "0xA91E40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A81C", Offset = "0x83A81C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700076C")]
		public int m_previousLevel
		{
			[Token(Token = "0x6002A66")]
			[Address(RVA = "0xA91E48", Offset = "0xA91E48", VA = "0xA91E48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A82C", Offset = "0x83A82C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6002A67")]
			[Address(RVA = "0xA91E50", Offset = "0xA91E50", VA = "0xA91E50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A83C", Offset = "0x83A83C")]
			private set
			{
			}
		}

		[Token(Token = "0x6002A68")]
		[Address(RVA = "0xA91E58", Offset = "0xA91E58", VA = "0xA91E58")]
		public LevelUpSignal(int currentLevel, int previousLevel)
		{
		}
	}
}
