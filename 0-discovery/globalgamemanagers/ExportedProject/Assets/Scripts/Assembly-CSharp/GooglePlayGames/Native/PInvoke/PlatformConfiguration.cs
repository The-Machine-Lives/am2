using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200028C")]
	internal abstract class PlatformConfiguration : BaseReferenceHolder
	{
		[Token(Token = "0x600138D")]
		[Address(RVA = "0xE61220", Offset = "0xE61220", VA = "0xE61220")]
		protected PlatformConfiguration(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x600138E")]
		[Address(RVA = "0xE61298", Offset = "0xE61298", VA = "0xE61298")]
		internal HandleRef AsHandle()
		{
			return default(HandleRef);
		}
	}
}
