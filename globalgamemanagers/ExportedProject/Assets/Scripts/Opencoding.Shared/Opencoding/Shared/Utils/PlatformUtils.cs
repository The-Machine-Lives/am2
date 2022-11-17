using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Shared.Utils
{
	[Token(Token = "0x2000005")]
	public static class PlatformUtils
	{
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x808328", Offset = "0x808328")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x808328", Offset = "0x808328")]
		private static bool _003CIsDesktop_003Ek__BackingField;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x808364", Offset = "0x808364")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x808364", Offset = "0x808364")]
		private static bool _003CIsMobile_003Ek__BackingField;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly RuntimePlatform[] _desktopRuntimePlatforms;

		[Token(Token = "0x17000009")]
		public static bool IsDesktop
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x1812454", Offset = "0x1812454", VA = "0x1812454")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x808490", Offset = "0x808490")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x18124BC", Offset = "0x18124BC", VA = "0x18124BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8084A0", Offset = "0x8084A0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public static bool IsMobile
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x181252C", Offset = "0x181252C", VA = "0x181252C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8084B0", Offset = "0x8084B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x1812594", Offset = "0x1812594", VA = "0x1812594")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8084C0", Offset = "0x8084C0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1812604", Offset = "0x1812604", VA = "0x1812604")]
		static PlatformUtils()
		{
		}
	}
}
