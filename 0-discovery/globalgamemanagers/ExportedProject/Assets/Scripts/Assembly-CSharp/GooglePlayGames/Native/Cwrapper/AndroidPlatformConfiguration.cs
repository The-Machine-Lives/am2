using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x200029E")]
	internal static class AndroidPlatformConfiguration
	{
		[Token(Token = "0x200072F")]
		internal delegate void IntentHandler(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000730")]
		internal delegate void OnLaunchedWithSnapshotCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000731")]
		internal delegate void OnLaunchedWithQuestCallback(IntPtr arg0, IntPtr arg1);

		[PreserveSig]
		[Token(Token = "0x6001447")]
		[Address(RVA = "0x146AD60", Offset = "0x146AD60", VA = "0x146AD60")]
		internal static extern void AndroidPlatformConfiguration_SetOnLaunchedWithSnapshot(HandleRef self, OnLaunchedWithSnapshotCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001448")]
		[Address(RVA = "0x146AE1C", Offset = "0x146AE1C", VA = "0x146AE1C")]
		internal static extern IntPtr AndroidPlatformConfiguration_Construct();

		[PreserveSig]
		[Token(Token = "0x6001449")]
		[Address(RVA = "0x146AEA8", Offset = "0x146AEA8", VA = "0x146AEA8")]
		internal static extern void AndroidPlatformConfiguration_SetOptionalIntentHandlerForUI(HandleRef self, IntentHandler intent_handler, IntPtr intent_handler_arg);

		[PreserveSig]
		[Token(Token = "0x600144A")]
		[Address(RVA = "0x146AF64", Offset = "0x146AF64", VA = "0x146AF64")]
		internal static extern void AndroidPlatformConfiguration_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600144B")]
		[Address(RVA = "0x146B000", Offset = "0x146B000", VA = "0x146B000")]
		internal static extern bool AndroidPlatformConfiguration_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600144C")]
		[Address(RVA = "0x146B0A4", Offset = "0x146B0A4", VA = "0x146B0A4")]
		internal static extern void AndroidPlatformConfiguration_SetActivity(HandleRef self, IntPtr android_app_activity);

		[PreserveSig]
		[Token(Token = "0x600144D")]
		[Address(RVA = "0x146B150", Offset = "0x146B150", VA = "0x146B150")]
		internal static extern void AndroidPlatformConfiguration_SetOnLaunchedWithQuest(HandleRef self, OnLaunchedWithQuestCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600144E")]
		[Address(RVA = "0x146B20C", Offset = "0x146B20C", VA = "0x146B20C")]
		internal static extern void AndroidPlatformConfiguration_SetOptionalViewForPopups(HandleRef self, IntPtr android_view);
	}
}
