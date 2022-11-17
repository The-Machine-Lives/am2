using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002B4")]
	internal static class RealTimeEventListenerHelper
	{
		[Token(Token = "0x2000759")]
		internal delegate void OnRoomStatusChangedCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x200075A")]
		internal delegate void OnRoomConnectedSetChangedCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x200075B")]
		internal delegate void OnP2PConnectedCallback(IntPtr arg0, IntPtr arg1, IntPtr arg2);

		[Token(Token = "0x200075C")]
		internal delegate void OnP2PDisconnectedCallback(IntPtr arg0, IntPtr arg1, IntPtr arg2);

		[Token(Token = "0x200075D")]
		internal delegate void OnParticipantStatusChangedCallback(IntPtr arg0, IntPtr arg1, IntPtr arg2);

		[Token(Token = "0x200075E")]
		internal delegate void OnDataReceivedCallback(IntPtr arg0, IntPtr arg1, IntPtr arg2, UIntPtr arg3, bool arg4, IntPtr arg5);

		[PreserveSig]
		[Token(Token = "0x600150B")]
		[Address(RVA = "0x131E934", Offset = "0x131E934", VA = "0x131E934")]
		internal static extern void RealTimeEventListenerHelper_SetOnParticipantStatusChangedCallback(HandleRef self, OnParticipantStatusChangedCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600150C")]
		[Address(RVA = "0x131E9F0", Offset = "0x131E9F0", VA = "0x131E9F0")]
		internal static extern IntPtr RealTimeEventListenerHelper_Construct();

		[PreserveSig]
		[Token(Token = "0x600150D")]
		[Address(RVA = "0x131EA7C", Offset = "0x131EA7C", VA = "0x131EA7C")]
		internal static extern void RealTimeEventListenerHelper_SetOnP2PDisconnectedCallback(HandleRef self, OnP2PDisconnectedCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600150E")]
		[Address(RVA = "0x131EB38", Offset = "0x131EB38", VA = "0x131EB38")]
		internal static extern void RealTimeEventListenerHelper_SetOnDataReceivedCallback(HandleRef self, OnDataReceivedCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600150F")]
		[Address(RVA = "0x131EBF4", Offset = "0x131EBF4", VA = "0x131EBF4")]
		internal static extern void RealTimeEventListenerHelper_SetOnRoomStatusChangedCallback(HandleRef self, OnRoomStatusChangedCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001510")]
		[Address(RVA = "0x131ECB0", Offset = "0x131ECB0", VA = "0x131ECB0")]
		internal static extern void RealTimeEventListenerHelper_SetOnP2PConnectedCallback(HandleRef self, OnP2PConnectedCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001511")]
		[Address(RVA = "0x131ED6C", Offset = "0x131ED6C", VA = "0x131ED6C")]
		internal static extern void RealTimeEventListenerHelper_SetOnRoomConnectedSetChangedCallback(HandleRef self, OnRoomConnectedSetChangedCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001512")]
		[Address(RVA = "0x131EE28", Offset = "0x131EE28", VA = "0x131EE28")]
		internal static extern void RealTimeEventListenerHelper_Dispose(HandleRef self);
	}
}
