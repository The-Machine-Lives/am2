using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004A7")]
	[IsReadOnly]
	public struct DynamicAdState
	{
		[Token(Token = "0x4001580")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EABC", Offset = "0x82EABC")]
		private readonly bool _003CisActive_003Ek__BackingField;

		[Token(Token = "0x170005F4")]
		public bool isActive
		{
			[Token(Token = "0x6002279")]
			[Address(RVA = "0x89BCF0", Offset = "0x89BCF0", VA = "0x89BCF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8395D4", Offset = "0x8395D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600227A")]
		[Address(RVA = "0x89BCF8", Offset = "0x89BCF8", VA = "0x89BCF8")]
		public DynamicAdState(bool isActiveIn)
		{
		}

		[Token(Token = "0x600227B")]
		[Address(RVA = "0xA5B560", Offset = "0xA5B560", VA = "0xA5B560")]
		public static implicit operator DynamicAdState(bool isActive)
		{
			return default(DynamicAdState);
		}
	}
}
