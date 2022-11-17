using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x200029F")]
	internal static class Builder
	{
		[Token(Token = "0x2000732")]
		internal delegate void OnLogCallback(Types.LogLevel arg0, string arg1, IntPtr arg2);

		[Token(Token = "0x2000733")]
		internal delegate void OnAuthActionStartedCallback(Types.AuthOperation arg0, IntPtr arg1);

		[Token(Token = "0x2000734")]
		internal delegate void OnAuthActionFinishedCallback(Types.AuthOperation arg0, CommonErrorStatus.AuthStatus arg1, IntPtr arg2);

		[Token(Token = "0x2000735")]
		internal delegate void OnMultiplayerInvitationEventCallback(Types.MultiplayerEvent arg0, string arg1, IntPtr arg2, IntPtr arg3);

		[Token(Token = "0x2000736")]
		internal delegate void OnTurnBasedMatchEventCallback(Types.MultiplayerEvent arg0, string arg1, IntPtr arg2, IntPtr arg3);

		[Token(Token = "0x2000737")]
		internal delegate void OnQuestCompletedCallback(IntPtr arg0, IntPtr arg1);

		[PreserveSig]
		[Token(Token = "0x600144F")]
		[Address(RVA = "0x146C224", Offset = "0x146C224", VA = "0x146C224")]
		internal static extern void GameServices_Builder_SetOnAuthActionStarted(HandleRef self, OnAuthActionStartedCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001450")]
		[Address(RVA = "0x146C2E0", Offset = "0x146C2E0", VA = "0x146C2E0")]
		internal static extern void GameServices_Builder_AddOauthScope(HandleRef self, string scope);

		[PreserveSig]
		[Token(Token = "0x6001451")]
		[Address(RVA = "0x146C3A0", Offset = "0x146C3A0", VA = "0x146C3A0")]
		internal static extern void GameServices_Builder_SetLogging(HandleRef self, OnLogCallback callback, IntPtr callback_arg, Types.LogLevel min_level);

		[PreserveSig]
		[Token(Token = "0x6001452")]
		[Address(RVA = "0x146C46C", Offset = "0x146C46C", VA = "0x146C46C")]
		internal static extern IntPtr GameServices_Builder_Construct();

		[PreserveSig]
		[Token(Token = "0x6001453")]
		[Address(RVA = "0x146C4F8", Offset = "0x146C4F8", VA = "0x146C4F8")]
		internal static extern void GameServices_Builder_EnableSnapshots(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001454")]
		[Address(RVA = "0x146C594", Offset = "0x146C594", VA = "0x146C594")]
		internal static extern void GameServices_Builder_SetOnLog(HandleRef self, OnLogCallback callback, IntPtr callback_arg, Types.LogLevel min_level);

		[PreserveSig]
		[Token(Token = "0x6001455")]
		[Address(RVA = "0x146C660", Offset = "0x146C660", VA = "0x146C660")]
		internal static extern void GameServices_Builder_SetDefaultOnLog(HandleRef self, Types.LogLevel min_level);

		[PreserveSig]
		[Token(Token = "0x6001456")]
		[Address(RVA = "0x146C70C", Offset = "0x146C70C", VA = "0x146C70C")]
		internal static extern void GameServices_Builder_SetOnAuthActionFinished(HandleRef self, OnAuthActionFinishedCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001457")]
		[Address(RVA = "0x146C7C8", Offset = "0x146C7C8", VA = "0x146C7C8")]
		internal static extern void GameServices_Builder_SetOnTurnBasedMatchEvent(HandleRef self, OnTurnBasedMatchEventCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001458")]
		[Address(RVA = "0x146C884", Offset = "0x146C884", VA = "0x146C884")]
		internal static extern void GameServices_Builder_SetOnQuestCompleted(HandleRef self, OnQuestCompletedCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001459")]
		[Address(RVA = "0x146C940", Offset = "0x146C940", VA = "0x146C940")]
		internal static extern void GameServices_Builder_SetOnMultiplayerInvitationEvent(HandleRef self, OnMultiplayerInvitationEventCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600145A")]
		[Address(RVA = "0x146C9FC", Offset = "0x146C9FC", VA = "0x146C9FC")]
		internal static extern void GameServices_Builder_SetShowConnectingPopup(HandleRef self, bool flag);

		[PreserveSig]
		[Token(Token = "0x600145B")]
		[Address(RVA = "0x146CAA8", Offset = "0x146CAA8", VA = "0x146CAA8")]
		internal static extern IntPtr GameServices_Builder_Create(HandleRef self, IntPtr platform);

		[PreserveSig]
		[Token(Token = "0x600145C")]
		[Address(RVA = "0x146CB54", Offset = "0x146CB54", VA = "0x146CB54")]
		internal static extern void GameServices_Builder_Dispose(HandleRef self);
	}
}
