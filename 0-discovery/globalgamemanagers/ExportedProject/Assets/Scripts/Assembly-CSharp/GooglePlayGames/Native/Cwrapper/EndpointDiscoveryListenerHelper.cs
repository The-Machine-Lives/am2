using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002A2")]
	internal static class EndpointDiscoveryListenerHelper
	{
		[Token(Token = "0x2000741")]
		internal delegate void OnEndpointFoundCallback(long arg0, IntPtr arg1, IntPtr arg2);

		[Token(Token = "0x2000742")]
		internal delegate void OnEndpointLostCallback(long arg0, string arg1, IntPtr arg2);

		[PreserveSig]
		[Token(Token = "0x6001460")]
		[Address(RVA = "0x146F3C0", Offset = "0x146F3C0", VA = "0x146F3C0")]
		internal static extern IntPtr EndpointDiscoveryListenerHelper_Construct();

		[PreserveSig]
		[Token(Token = "0x6001461")]
		[Address(RVA = "0x146F44C", Offset = "0x146F44C", VA = "0x146F44C")]
		internal static extern void EndpointDiscoveryListenerHelper_SetOnEndpointLostCallback(HandleRef self, OnEndpointLostCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001462")]
		[Address(RVA = "0x146F508", Offset = "0x146F508", VA = "0x146F508")]
		internal static extern void EndpointDiscoveryListenerHelper_SetOnEndpointFoundCallback(HandleRef self, OnEndpointFoundCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001463")]
		[Address(RVA = "0x146F5C4", Offset = "0x146F5C4", VA = "0x146F5C4")]
		internal static extern void EndpointDiscoveryListenerHelper_Dispose(HandleRef self);
	}
}
