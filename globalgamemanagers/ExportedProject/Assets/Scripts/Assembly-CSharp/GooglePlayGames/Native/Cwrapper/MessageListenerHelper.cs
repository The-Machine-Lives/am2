using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002A9")]
	internal static class MessageListenerHelper
	{
		[Token(Token = "0x200074D")]
		internal delegate void OnMessageReceivedCallback(long arg0, string arg1, IntPtr arg2, UIntPtr arg3, bool arg4, IntPtr arg5);

		[Token(Token = "0x200074E")]
		internal delegate void OnDisconnectedCallback(long arg0, string arg1, IntPtr arg2);

		[PreserveSig]
		[Token(Token = "0x600149D")]
		[Address(RVA = "0x1475C34", Offset = "0x1475C34", VA = "0x1475C34")]
		internal static extern void MessageListenerHelper_SetOnMessageReceivedCallback(HandleRef self, OnMessageReceivedCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600149E")]
		[Address(RVA = "0x1475CF0", Offset = "0x1475CF0", VA = "0x1475CF0")]
		internal static extern void MessageListenerHelper_SetOnDisconnectedCallback(HandleRef self, OnDisconnectedCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600149F")]
		[Address(RVA = "0x1475DAC", Offset = "0x1475DAC", VA = "0x1475DAC")]
		internal static extern IntPtr MessageListenerHelper_Construct();

		[PreserveSig]
		[Token(Token = "0x60014A0")]
		[Address(RVA = "0x1475E38", Offset = "0x1475E38", VA = "0x1475E38")]
		internal static extern void MessageListenerHelper_Dispose(HandleRef self);
	}
}
