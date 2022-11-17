using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000278")]
	internal class NativeLeaderboard : BaseReferenceHolder
	{
		[Token(Token = "0x60012C9")]
		[Address(RVA = "0xE59E34", Offset = "0xE59E34", VA = "0xE59E34")]
		internal NativeLeaderboard(IntPtr selfPtr)
		{
		}

		[Token(Token = "0x60012CA")]
		[Address(RVA = "0xE59EAC", Offset = "0xE59EAC", VA = "0xE59EAC", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x60012CB")]
		[Address(RVA = "0xE59EBC", Offset = "0xE59EBC", VA = "0xE59EBC")]
		internal string Title()
		{
			return null;
		}

		[Token(Token = "0x60012CC")]
		[Address(RVA = "0xE5A198", Offset = "0xE5A198", VA = "0xE5A198")]
		internal static NativeLeaderboard FromPointer(IntPtr pointer)
		{
			return null;
		}

		[Token(Token = "0x60012CD")]
		[Address(RVA = "0xE5A234", Offset = "0xE5A234", VA = "0xE5A234")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83642C", Offset = "0x83642C")]
		private UIntPtr _003CTitle_003Eb__2_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}
	}
}
