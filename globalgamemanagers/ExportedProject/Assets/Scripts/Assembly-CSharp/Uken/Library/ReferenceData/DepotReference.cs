using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000474")]
	public class DepotReference : DropdownAttribute
	{
		[Token(Token = "0x4001490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool ShowEntity;

		[Token(Token = "0x4001491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type[] RequiredTypes;

		[Token(Token = "0x6002113")]
		[Address(RVA = "0xB37990", Offset = "0xB37990", VA = "0xB37990")]
		public DepotReference([Optional] Type[] requiredTypes, bool _showEntity = true)
		{
		}
	}
}
