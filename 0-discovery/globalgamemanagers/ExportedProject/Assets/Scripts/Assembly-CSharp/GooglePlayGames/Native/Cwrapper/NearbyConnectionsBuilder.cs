using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002AD")]
	internal static class NearbyConnectionsBuilder
	{
		[Token(Token = "0x200074F")]
		internal delegate void OnInitializationFinishedCallback(NearbyConnectionsStatus.InitializationStatus arg0, IntPtr arg1);

		[Token(Token = "0x2000750")]
		internal delegate void OnLogCallback(Types.LogLevel arg0, string arg1, IntPtr arg2);

		[PreserveSig]
		[Token(Token = "0x60014C3")]
		[Address(RVA = "0x1479F80", Offset = "0x1479F80", VA = "0x1479F80")]
		internal static extern void NearbyConnections_Builder_SetOnInitializationFinished(HandleRef self, OnInitializationFinishedCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60014C4")]
		[Address(RVA = "0x147A03C", Offset = "0x147A03C", VA = "0x147A03C")]
		internal static extern IntPtr NearbyConnections_Builder_Construct();

		[PreserveSig]
		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x147A0C8", Offset = "0x147A0C8", VA = "0x147A0C8")]
		internal static extern void NearbyConnections_Builder_SetClientId(HandleRef self, long client_id);

		[PreserveSig]
		[Token(Token = "0x60014C6")]
		[Address(RVA = "0x147A174", Offset = "0x147A174", VA = "0x147A174")]
		internal static extern void NearbyConnections_Builder_SetOnLog(HandleRef self, OnLogCallback callback, IntPtr callback_arg, Types.LogLevel min_level);

		[PreserveSig]
		[Token(Token = "0x60014C7")]
		[Address(RVA = "0x147A240", Offset = "0x147A240", VA = "0x147A240")]
		internal static extern void NearbyConnections_Builder_SetDefaultOnLog(HandleRef self, Types.LogLevel min_level);

		[PreserveSig]
		[Token(Token = "0x60014C8")]
		[Address(RVA = "0x147A2EC", Offset = "0x147A2EC", VA = "0x147A2EC")]
		internal static extern IntPtr NearbyConnections_Builder_Create(HandleRef self, IntPtr platform);

		[PreserveSig]
		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x147A398", Offset = "0x147A398", VA = "0x147A398")]
		internal static extern void NearbyConnections_Builder_Dispose(HandleRef self);
	}
}
