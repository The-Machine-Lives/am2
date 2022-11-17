using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002B2")]
	internal static class PlayerManager
	{
		[Token(Token = "0x2000756")]
		internal delegate void FetchSelfCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000757")]
		internal delegate void FetchCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000758")]
		internal delegate void FetchListCallback(IntPtr arg0, IntPtr arg1);

		[PreserveSig]
		[Token(Token = "0x60014EC")]
		[Address(RVA = "0x147BAA4", Offset = "0x147BAA4", VA = "0x147BAA4")]
		internal static extern void PlayerManager_FetchInvitable(HandleRef self, Types.DataSource data_source, FetchListCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60014ED")]
		[Address(RVA = "0x147BB6C", Offset = "0x147BB6C", VA = "0x147BB6C")]
		internal static extern void PlayerManager_FetchConnected(HandleRef self, Types.DataSource data_source, FetchListCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60014EE")]
		[Address(RVA = "0x147BC34", Offset = "0x147BC34", VA = "0x147BC34")]
		internal static extern void PlayerManager_Fetch(HandleRef self, Types.DataSource data_source, string player_id, FetchCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60014EF")]
		[Address(RVA = "0x147BD1C", Offset = "0x147BD1C", VA = "0x147BD1C")]
		internal static extern void PlayerManager_FetchRecentlyPlayed(HandleRef self, Types.DataSource data_source, FetchListCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60014F0")]
		[Address(RVA = "0x147BDE8", Offset = "0x147BDE8", VA = "0x147BDE8")]
		internal static extern void PlayerManager_FetchSelf(HandleRef self, Types.DataSource data_source, FetchSelfCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60014F1")]
		[Address(RVA = "0x147BEB4", Offset = "0x147BEB4", VA = "0x147BEB4")]
		internal static extern void PlayerManager_FetchSelfResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014F2")]
		[Address(RVA = "0x147BF50", Offset = "0x147BF50", VA = "0x147BF50")]
		internal static extern CommonErrorStatus.ResponseStatus PlayerManager_FetchSelfResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014F3")]
		[Address(RVA = "0x147BFEC", Offset = "0x147BFEC", VA = "0x147BFEC")]
		internal static extern IntPtr PlayerManager_FetchSelfResponse_GetData(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014F4")]
		[Address(RVA = "0x147C088", Offset = "0x147C088", VA = "0x147C088")]
		internal static extern void PlayerManager_FetchResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x147C124", Offset = "0x147C124", VA = "0x147C124")]
		internal static extern CommonErrorStatus.ResponseStatus PlayerManager_FetchResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014F6")]
		[Address(RVA = "0x147C1C0", Offset = "0x147C1C0", VA = "0x147C1C0")]
		internal static extern IntPtr PlayerManager_FetchResponse_GetData(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014F7")]
		[Address(RVA = "0x147C25C", Offset = "0x147C25C", VA = "0x147C25C")]
		internal static extern void PlayerManager_FetchListResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014F8")]
		[Address(RVA = "0x147C2F8", Offset = "0x147C2F8", VA = "0x147C2F8")]
		internal static extern CommonErrorStatus.ResponseStatus PlayerManager_FetchListResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014F9")]
		[Address(RVA = "0x147C394", Offset = "0x147C394", VA = "0x147C394")]
		internal static extern UIntPtr PlayerManager_FetchListResponse_GetData_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014FA")]
		[Address(RVA = "0x147C430", Offset = "0x147C430", VA = "0x147C430")]
		internal static extern IntPtr PlayerManager_FetchListResponse_GetData_GetElement(HandleRef self, UIntPtr index);
	}
}
