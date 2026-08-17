using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002A4")]
	internal static class EventManager
	{
		[Token(Token = "0x2000743")]
		internal delegate void FetchAllCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000744")]
		internal delegate void FetchCallback(IntPtr arg0, IntPtr arg1);

		[PreserveSig]
		[Token(Token = "0x600146D")]
		[Address(RVA = "0x1470750", Offset = "0x1470750", VA = "0x1470750")]
		internal static extern void EventManager_FetchAll(HandleRef self, Types.DataSource data_source, FetchAllCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600146E")]
		[Address(RVA = "0x147081C", Offset = "0x147081C", VA = "0x147081C")]
		internal static extern void EventManager_Fetch(HandleRef self, Types.DataSource data_source, string event_id, FetchCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600146F")]
		[Address(RVA = "0x1470904", Offset = "0x1470904", VA = "0x1470904")]
		internal static extern void EventManager_Increment(HandleRef self, string event_id, uint steps);

		[PreserveSig]
		[Token(Token = "0x6001470")]
		[Address(RVA = "0x14709CC", Offset = "0x14709CC", VA = "0x14709CC")]
		internal static extern void EventManager_FetchAllResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001471")]
		[Address(RVA = "0x1470A68", Offset = "0x1470A68", VA = "0x1470A68")]
		internal static extern CommonErrorStatus.ResponseStatus EventManager_FetchAllResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001472")]
		[Address(RVA = "0x1470B04", Offset = "0x1470B04", VA = "0x1470B04")]
		internal static extern UIntPtr EventManager_FetchAllResponse_GetData(HandleRef self, IntPtr[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x6001473")]
		[Address(RVA = "0x1470BC0", Offset = "0x1470BC0", VA = "0x1470BC0")]
		internal static extern void EventManager_FetchResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001474")]
		[Address(RVA = "0x1470C5C", Offset = "0x1470C5C", VA = "0x1470C5C")]
		internal static extern CommonErrorStatus.ResponseStatus EventManager_FetchResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001475")]
		[Address(RVA = "0x1470CF8", Offset = "0x1470CF8", VA = "0x1470CF8")]
		internal static extern IntPtr EventManager_FetchResponse_GetData(HandleRef self);
	}
}
