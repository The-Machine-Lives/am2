using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002A3")]
	internal static class Event
	{
		[PreserveSig]
		[Token(Token = "0x6001464")]
		[Address(RVA = "0x147014C", Offset = "0x147014C", VA = "0x147014C")]
		internal static extern ulong Event_Count(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001465")]
		[Address(RVA = "0x14701E8", Offset = "0x14701E8", VA = "0x14701E8")]
		internal static extern UIntPtr Event_Description(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x6001466")]
		[Address(RVA = "0x14702A4", Offset = "0x14702A4", VA = "0x14702A4")]
		internal static extern UIntPtr Event_ImageUrl(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x6001467")]
		[Address(RVA = "0x1470360", Offset = "0x1470360", VA = "0x1470360")]
		internal static extern Types.EventVisibility Event_Visibility(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001468")]
		[Address(RVA = "0x14703FC", Offset = "0x14703FC", VA = "0x14703FC")]
		internal static extern UIntPtr Event_Id(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x6001469")]
		[Address(RVA = "0x14704B8", Offset = "0x14704B8", VA = "0x14704B8")]
		internal static extern bool Event_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600146A")]
		[Address(RVA = "0x147055C", Offset = "0x147055C", VA = "0x147055C")]
		internal static extern void Event_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600146B")]
		[Address(RVA = "0x14705F8", Offset = "0x14705F8", VA = "0x14705F8")]
		internal static extern IntPtr Event_Copy(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600146C")]
		[Address(RVA = "0x1470694", Offset = "0x1470694", VA = "0x1470694")]
		internal static extern UIntPtr Event_Name(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);
	}
}
