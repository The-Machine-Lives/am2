using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002A6")]
	internal static class InternalHooks
	{
		[PreserveSig]
		[Token(Token = "0x600147B")]
		[Address(RVA = "0x1472040", Offset = "0x1472040", VA = "0x1472040")]
		internal static extern void InternalHooks_ConfigureForUnityPlugin(HandleRef builder, string unity_version);

		[PreserveSig]
		[Token(Token = "0x600147C")]
		[Address(RVA = "0x1472100", Offset = "0x1472100", VA = "0x1472100")]
		internal static extern IntPtr InternalHooks_GetApiClient(HandleRef services);
	}
}
