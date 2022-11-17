using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000475")]
	public class EnumDropdownAttribute : DropdownAttribute
	{
		[Token(Token = "0x4001492")]
		[FieldOffset(Offset = "0x18")]
		public List<Type> enumTypes;

		[Token(Token = "0x6002114")]
		[Address(RVA = "0xB37B14", Offset = "0xB37B14", VA = "0xB37B14")]
		public EnumDropdownAttribute(Type _enumType)
		{
		}

		[Token(Token = "0x6002115")]
		[Address(RVA = "0xB37BB8", Offset = "0xB37BB8", VA = "0xB37BB8")]
		public EnumDropdownAttribute(List<Type> _enumTypes)
		{
		}
	}
}
