using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002C1")]
	internal static class StatsManager
	{
		[Token(Token = "0x200076B")]
		internal delegate void FetchForPlayerCallback(IntPtr arg0, IntPtr arg1);

		[PreserveSig]
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x132ABEC", Offset = "0x132ABEC", VA = "0x132ABEC")]
		internal static extern void StatsManager_FetchForPlayer(HandleRef self, Types.DataSource data_source, FetchForPlayerCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600159D")]
		[Address(RVA = "0x132ACB8", Offset = "0x132ACB8", VA = "0x132ACB8")]
		internal static extern void StatsManager_FetchForPlayerResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600159E")]
		[Address(RVA = "0x132AD54", Offset = "0x132AD54", VA = "0x132AD54")]
		internal static extern CommonErrorStatus.ResponseStatus StatsManager_FetchForPlayerResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600159F")]
		[Address(RVA = "0x132ADF0", Offset = "0x132ADF0", VA = "0x132ADF0")]
		internal static extern IntPtr StatsManager_FetchForPlayerResponse_GetData(HandleRef self);
	}
}
