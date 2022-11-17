using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002B5")]
	internal static class RealTimeMultiplayerManager
	{
		[Token(Token = "0x200075F")]
		internal delegate void RealTimeRoomCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000760")]
		internal delegate void LeaveRoomCallback(CommonErrorStatus.ResponseStatus arg0, IntPtr arg1);

		[Token(Token = "0x2000761")]
		internal delegate void SendReliableMessageCallback(CommonErrorStatus.MultiplayerStatus arg0, IntPtr arg1);

		[Token(Token = "0x2000762")]
		internal delegate void RoomInboxUICallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000763")]
		internal delegate void PlayerSelectUICallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000764")]
		internal delegate void WaitingRoomUICallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000765")]
		internal delegate void FetchInvitationsCallback(IntPtr arg0, IntPtr arg1);

		[PreserveSig]
		[Token(Token = "0x6001513")]
		[Address(RVA = "0x1320FC0", Offset = "0x1320FC0", VA = "0x1320FC0")]
		internal static extern void RealTimeMultiplayerManager_CreateRealTimeRoom(HandleRef self, IntPtr config, IntPtr helper, RealTimeRoomCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001514")]
		[Address(RVA = "0x1321094", Offset = "0x1321094", VA = "0x1321094")]
		internal static extern void RealTimeMultiplayerManager_LeaveRoom(HandleRef self, IntPtr room, LeaveRoomCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001515")]
		[Address(RVA = "0x1321160", Offset = "0x1321160", VA = "0x1321160")]
		internal static extern void RealTimeMultiplayerManager_SendUnreliableMessage(HandleRef self, IntPtr room, IntPtr[] participants, UIntPtr participants_size, byte[] data, UIntPtr data_size);

		[PreserveSig]
		[Token(Token = "0x6001516")]
		[Address(RVA = "0x1321248", Offset = "0x1321248", VA = "0x1321248")]
		internal static extern void RealTimeMultiplayerManager_ShowWaitingRoomUI(HandleRef self, IntPtr room, uint min_participants_to_start, WaitingRoomUICallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001517")]
		[Address(RVA = "0x132131C", Offset = "0x132131C", VA = "0x132131C")]
		internal static extern void RealTimeMultiplayerManager_ShowPlayerSelectUI(HandleRef self, uint minimum_players, uint maximum_players, bool allow_automatch, PlayerSelectUICallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001518")]
		[Address(RVA = "0x1321404", Offset = "0x1321404", VA = "0x1321404")]
		internal static extern void RealTimeMultiplayerManager_DismissInvitation(HandleRef self, IntPtr invitation);

		[PreserveSig]
		[Token(Token = "0x6001519")]
		[Address(RVA = "0x13214B0", Offset = "0x13214B0", VA = "0x13214B0")]
		internal static extern void RealTimeMultiplayerManager_DeclineInvitation(HandleRef self, IntPtr invitation);

		[PreserveSig]
		[Token(Token = "0x600151A")]
		[Address(RVA = "0x132155C", Offset = "0x132155C", VA = "0x132155C")]
		internal static extern void RealTimeMultiplayerManager_SendReliableMessage(HandleRef self, IntPtr room, IntPtr participant, byte[] data, UIntPtr data_size, SendReliableMessageCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600151B")]
		[Address(RVA = "0x1321654", Offset = "0x1321654", VA = "0x1321654")]
		internal static extern void RealTimeMultiplayerManager_AcceptInvitation(HandleRef self, IntPtr invitation, IntPtr helper, RealTimeRoomCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600151C")]
		[Address(RVA = "0x1321728", Offset = "0x1321728", VA = "0x1321728")]
		internal static extern void RealTimeMultiplayerManager_FetchInvitations(HandleRef self, FetchInvitationsCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600151D")]
		[Address(RVA = "0x13217E4", Offset = "0x13217E4", VA = "0x13217E4")]
		internal static extern void RealTimeMultiplayerManager_SendUnreliableMessageToOthers(HandleRef self, IntPtr room, byte[] data, UIntPtr data_size);

		[PreserveSig]
		[Token(Token = "0x600151E")]
		[Address(RVA = "0x13218B0", Offset = "0x13218B0", VA = "0x13218B0")]
		internal static extern void RealTimeMultiplayerManager_ShowRoomInboxUI(HandleRef self, RoomInboxUICallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600151F")]
		[Address(RVA = "0x132196C", Offset = "0x132196C", VA = "0x132196C")]
		internal static extern void RealTimeMultiplayerManager_RealTimeRoomResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001520")]
		[Address(RVA = "0x1321A08", Offset = "0x1321A08", VA = "0x1321A08")]
		internal static extern CommonErrorStatus.MultiplayerStatus RealTimeMultiplayerManager_RealTimeRoomResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001521")]
		[Address(RVA = "0x1321AA4", Offset = "0x1321AA4", VA = "0x1321AA4")]
		internal static extern IntPtr RealTimeMultiplayerManager_RealTimeRoomResponse_GetRoom(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001522")]
		[Address(RVA = "0x1321B40", Offset = "0x1321B40", VA = "0x1321B40")]
		internal static extern void RealTimeMultiplayerManager_RoomInboxUIResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001523")]
		[Address(RVA = "0x1321BDC", Offset = "0x1321BDC", VA = "0x1321BDC")]
		internal static extern CommonErrorStatus.UIStatus RealTimeMultiplayerManager_RoomInboxUIResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001524")]
		[Address(RVA = "0x1321C78", Offset = "0x1321C78", VA = "0x1321C78")]
		internal static extern IntPtr RealTimeMultiplayerManager_RoomInboxUIResponse_GetInvitation(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001525")]
		[Address(RVA = "0x1321D14", Offset = "0x1321D14", VA = "0x1321D14")]
		internal static extern void RealTimeMultiplayerManager_WaitingRoomUIResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001526")]
		[Address(RVA = "0x1321DB0", Offset = "0x1321DB0", VA = "0x1321DB0")]
		internal static extern CommonErrorStatus.UIStatus RealTimeMultiplayerManager_WaitingRoomUIResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001527")]
		[Address(RVA = "0x1321E4C", Offset = "0x1321E4C", VA = "0x1321E4C")]
		internal static extern IntPtr RealTimeMultiplayerManager_WaitingRoomUIResponse_GetRoom(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001528")]
		[Address(RVA = "0x1321EE8", Offset = "0x1321EE8", VA = "0x1321EE8")]
		internal static extern void RealTimeMultiplayerManager_FetchInvitationsResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001529")]
		[Address(RVA = "0x1321F84", Offset = "0x1321F84", VA = "0x1321F84")]
		internal static extern CommonErrorStatus.ResponseStatus RealTimeMultiplayerManager_FetchInvitationsResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600152A")]
		[Address(RVA = "0x1322020", Offset = "0x1322020", VA = "0x1322020")]
		internal static extern UIntPtr RealTimeMultiplayerManager_FetchInvitationsResponse_GetInvitations_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600152B")]
		[Address(RVA = "0x13220BC", Offset = "0x13220BC", VA = "0x13220BC")]
		internal static extern IntPtr RealTimeMultiplayerManager_FetchInvitationsResponse_GetInvitations_GetElement(HandleRef self, UIntPtr index);
	}
}
