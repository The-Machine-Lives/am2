using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002B8")]
	internal static class RealTimeRoomConfigBuilder
	{
		[PreserveSig]
		[Token(Token = "0x6001540")]
		[Address(RVA = "0x13253A8", Offset = "0x13253A8", VA = "0x13253A8")]
		internal static extern void RealTimeRoomConfig_Builder_PopulateFromPlayerSelectUIResponse(HandleRef self, IntPtr response);

		[PreserveSig]
		[Token(Token = "0x6001541")]
		[Address(RVA = "0x1325454", Offset = "0x1325454", VA = "0x1325454")]
		internal static extern void RealTimeRoomConfig_Builder_SetVariant(HandleRef self, uint variant);

		[PreserveSig]
		[Token(Token = "0x6001542")]
		[Address(RVA = "0x1325500", Offset = "0x1325500", VA = "0x1325500")]
		internal static extern void RealTimeRoomConfig_Builder_AddPlayerToInvite(HandleRef self, string player_id);

		[PreserveSig]
		[Token(Token = "0x6001543")]
		[Address(RVA = "0x13255C0", Offset = "0x13255C0", VA = "0x13255C0")]
		internal static extern IntPtr RealTimeRoomConfig_Builder_Construct();

		[PreserveSig]
		[Token(Token = "0x6001544")]
		[Address(RVA = "0x132564C", Offset = "0x132564C", VA = "0x132564C")]
		internal static extern void RealTimeRoomConfig_Builder_SetExclusiveBitMask(HandleRef self, ulong exclusive_bit_mask);

		[PreserveSig]
		[Token(Token = "0x6001545")]
		[Address(RVA = "0x13256F8", Offset = "0x13256F8", VA = "0x13256F8")]
		internal static extern void RealTimeRoomConfig_Builder_SetMaximumAutomatchingPlayers(HandleRef self, uint maximum_automatching_players);

		[PreserveSig]
		[Token(Token = "0x6001546")]
		[Address(RVA = "0x13257A4", Offset = "0x13257A4", VA = "0x13257A4")]
		internal static extern IntPtr RealTimeRoomConfig_Builder_Create(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001547")]
		[Address(RVA = "0x1325840", Offset = "0x1325840", VA = "0x1325840")]
		internal static extern void RealTimeRoomConfig_Builder_SetMinimumAutomatchingPlayers(HandleRef self, uint minimum_automatching_players);

		[PreserveSig]
		[Token(Token = "0x6001548")]
		[Address(RVA = "0x13258EC", Offset = "0x13258EC", VA = "0x13258EC")]
		internal static extern void RealTimeRoomConfig_Builder_Dispose(HandleRef self);
	}
}
