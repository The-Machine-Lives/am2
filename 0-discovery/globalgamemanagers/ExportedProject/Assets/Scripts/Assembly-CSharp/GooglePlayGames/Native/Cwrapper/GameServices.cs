using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002A5")]
	internal static class GameServices
	{
		[Token(Token = "0x2000745")]
		internal delegate void FlushCallback(CommonErrorStatus.FlushStatus arg0, IntPtr arg1);

		[PreserveSig]
		[Token(Token = "0x6001476")]
		[Address(RVA = "0x14717DC", Offset = "0x14717DC", VA = "0x14717DC")]
		internal static extern void GameServices_Flush(HandleRef self, FlushCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001477")]
		[Address(RVA = "0x1471898", Offset = "0x1471898", VA = "0x1471898")]
		internal static extern bool GameServices_IsAuthorized(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001478")]
		[Address(RVA = "0x147193C", Offset = "0x147193C", VA = "0x147193C")]
		internal static extern void GameServices_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001479")]
		[Address(RVA = "0x14719D8", Offset = "0x14719D8", VA = "0x14719D8")]
		internal static extern void GameServices_SignOut(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600147A")]
		[Address(RVA = "0x1471A74", Offset = "0x1471A74", VA = "0x1471A74")]
		internal static extern void GameServices_StartAuthorizationUI(HandleRef self);
	}
}
