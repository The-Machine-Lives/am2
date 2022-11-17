using System;
using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000470")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x81FB30", Offset = "0x81FB30")]
	public abstract class DropdownAttribute : Attribute
	{
		[Token(Token = "0x400148C")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E7B8", Offset = "0x82E7B8")]
		private bool _003CshouldShowListWindow_003Ek__BackingField;

		[Token(Token = "0x170005D6")]
		public bool shouldShowListWindow
		{
			[Token(Token = "0x600210D")]
			[Address(RVA = "0xB37A68", Offset = "0xB37A68", VA = "0xB37A68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839444", Offset = "0x839444")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600210E")]
			[Address(RVA = "0xB37A70", Offset = "0xB37A70", VA = "0xB37A70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839454", Offset = "0x839454")]
			protected set
			{
			}
		}

		[Token(Token = "0x600210F")]
		[Address(RVA = "0xB37988", Offset = "0xB37988", VA = "0xB37988")]
		protected DropdownAttribute()
		{
		}
	}
}
