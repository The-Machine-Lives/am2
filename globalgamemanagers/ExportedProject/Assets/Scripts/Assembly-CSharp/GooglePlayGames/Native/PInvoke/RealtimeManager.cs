using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000290")]
	internal class RealtimeManager
	{
		[Token(Token = "0x200071C")]
		internal class RealTimeRoomResponse : BaseReferenceHolder
		{
			[Token(Token = "0x600300B")]
			[Address(RVA = "0xE654D0", Offset = "0xE654D0", VA = "0xE654D0")]
			internal RealTimeRoomResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x600300C")]
			[Address(RVA = "0xE65548", Offset = "0xE65548", VA = "0xE65548")]
			internal CommonErrorStatus.MultiplayerStatus ResponseStatus()
			{
				return default(CommonErrorStatus.MultiplayerStatus);
			}

			[Token(Token = "0x600300D")]
			[Address(RVA = "0xE65564", Offset = "0xE65564", VA = "0xE65564")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			[Token(Token = "0x600300E")]
			[Address(RVA = "0xE6558C", Offset = "0xE6558C", VA = "0xE6558C")]
			internal NativeRealTimeRoom Room()
			{
				return null;
			}

			[Token(Token = "0x600300F")]
			[Address(RVA = "0xE6562C", Offset = "0xE6562C", VA = "0xE6562C", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x6003010")]
			[Address(RVA = "0xE6563C", Offset = "0xE6563C", VA = "0xE6563C")]
			internal static RealTimeRoomResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		[Token(Token = "0x200071D")]
		internal class RoomInboxUIResponse : BaseReferenceHolder
		{
			[Token(Token = "0x6003011")]
			[Address(RVA = "0xE656D8", Offset = "0xE656D8", VA = "0xE656D8")]
			internal RoomInboxUIResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x6003012")]
			[Address(RVA = "0xE65750", Offset = "0xE65750", VA = "0xE65750")]
			internal CommonErrorStatus.UIStatus ResponseStatus()
			{
				return default(CommonErrorStatus.UIStatus);
			}

			[Token(Token = "0x6003013")]
			[Address(RVA = "0xE6576C", Offset = "0xE6576C", VA = "0xE6576C")]
			internal MultiplayerInvitation Invitation()
			{
				return null;
			}

			[Token(Token = "0x6003014")]
			[Address(RVA = "0xE6580C", Offset = "0xE6580C", VA = "0xE6580C", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x6003015")]
			[Address(RVA = "0xE6581C", Offset = "0xE6581C", VA = "0xE6581C")]
			internal static RoomInboxUIResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		[Token(Token = "0x200071E")]
		internal class WaitingRoomUIResponse : BaseReferenceHolder
		{
			[Token(Token = "0x6003016")]
			[Address(RVA = "0xE658B0", Offset = "0xE658B0", VA = "0xE658B0")]
			internal WaitingRoomUIResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x6003017")]
			[Address(RVA = "0xE65928", Offset = "0xE65928", VA = "0xE65928")]
			internal CommonErrorStatus.UIStatus ResponseStatus()
			{
				return default(CommonErrorStatus.UIStatus);
			}

			[Token(Token = "0x6003018")]
			[Address(RVA = "0xE65944", Offset = "0xE65944", VA = "0xE65944")]
			internal NativeRealTimeRoom Room()
			{
				return null;
			}

			[Token(Token = "0x6003019")]
			[Address(RVA = "0xE659E0", Offset = "0xE659E0", VA = "0xE659E0", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x600301A")]
			[Address(RVA = "0xE659F0", Offset = "0xE659F0", VA = "0xE659F0")]
			internal static WaitingRoomUIResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		[Token(Token = "0x200071F")]
		internal class FetchInvitationsResponse : BaseReferenceHolder
		{
			[Token(Token = "0x600301B")]
			[Address(RVA = "0xE65214", Offset = "0xE65214", VA = "0xE65214")]
			internal FetchInvitationsResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x600301C")]
			[Address(RVA = "0xE6528C", Offset = "0xE6528C", VA = "0xE6528C")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			[Token(Token = "0x600301D")]
			[Address(RVA = "0xE652B4", Offset = "0xE652B4", VA = "0xE652B4")]
			internal CommonErrorStatus.ResponseStatus ResponseStatus()
			{
				return default(CommonErrorStatus.ResponseStatus);
			}

			[Token(Token = "0x600301E")]
			[Address(RVA = "0xE652D0", Offset = "0xE652D0", VA = "0xE652D0")]
			internal IEnumerable<MultiplayerInvitation> Invitations()
			{
				return null;
			}

			[Token(Token = "0x600301F")]
			[Address(RVA = "0xE6539C", Offset = "0xE6539C", VA = "0xE6539C", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x6003020")]
			[Address(RVA = "0xE653AC", Offset = "0xE653AC", VA = "0xE653AC")]
			internal static FetchInvitationsResponse FromPointer(IntPtr pointer)
			{
				return null;
			}

			[Token(Token = "0x6003021")]
			[Address(RVA = "0xE65440", Offset = "0xE65440", VA = "0xE65440")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B70C", Offset = "0x83B70C")]
			private MultiplayerInvitation _003CInvitations_003Eb__3_0(UIntPtr index)
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x2000720")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E98", Offset = "0x820E98")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4002119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400211A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<MultiplayerParticipant, IntPtr> _003C_003E9__19_0;

			[Token(Token = "0x6003023")]
			[Address(RVA = "0xE651DC", Offset = "0xE651DC", VA = "0xE651DC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6003024")]
			[Address(RVA = "0xE651E4", Offset = "0xE651E4", VA = "0xE651E4")]
			internal IntPtr _003CSendUnreliableMessageToSpecificParticipants_003Eb__19_0(MultiplayerParticipant r)
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x4000D25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly GameServices mGameServices;

		[Token(Token = "0x60013B2")]
		[Address(RVA = "0xE64374", Offset = "0xE64374", VA = "0xE64374")]
		internal RealtimeManager(GameServices gameServices)
		{
		}

		[Token(Token = "0x60013B3")]
		[Address(RVA = "0xE643E4", Offset = "0xE643E4", VA = "0xE643E4")]
		internal void CreateRoom(RealtimeRoomConfig config, RealTimeEventListenerHelper helper, Action<RealTimeRoomResponse> callback)
		{
		}

		[Token(Token = "0x60013B4")]
		[Address(RVA = "0xE64598", Offset = "0xE64598", VA = "0xE64598")]
		internal void ShowPlayerSelectUI(uint minimumPlayers, uint maxiumPlayers, bool allowAutomatching, Action<PlayerSelectUIResponse> callback)
		{
		}

		[Token(Token = "0x60013B5")]
		[Address(RVA = "0xE63D98", Offset = "0xE63D98", VA = "0xE63D98")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836B9C", Offset = "0x836B9C")]
		internal static void InternalPlayerSelectUIcallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x60013B6")]
		[Address(RVA = "0xE63E20", Offset = "0xE63E20", VA = "0xE63E20")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836C00", Offset = "0x836C00")]
		internal static void InternalRealTimeRoomCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x60013B7")]
		[Address(RVA = "0xE63EA8", Offset = "0xE63EA8", VA = "0xE63EA8")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836C64", Offset = "0x836C64")]
		internal static void InternalRoomInboxUICallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x60013B8")]
		[Address(RVA = "0xE646DC", Offset = "0xE646DC", VA = "0xE646DC")]
		internal void ShowRoomInboxUI(Action<RoomInboxUIResponse> callback)
		{
		}

		[Token(Token = "0x60013B9")]
		[Address(RVA = "0xE64800", Offset = "0xE64800", VA = "0xE64800")]
		internal void ShowWaitingRoomUI(NativeRealTimeRoom room, uint minimumParticipantsBeforeStarting, Action<WaitingRoomUIResponse> callback)
		{
		}

		[Token(Token = "0x60013BA")]
		[Address(RVA = "0xE63F30", Offset = "0xE63F30", VA = "0xE63F30")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836CC8", Offset = "0x836CC8")]
		internal static void InternalWaitingRoomUICallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x60013BB")]
		[Address(RVA = "0xE63FB8", Offset = "0xE63FB8", VA = "0xE63FB8")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836D2C", Offset = "0x836D2C")]
		internal static void InternalFetchInvitationsCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x60013BC")]
		[Address(RVA = "0xE64970", Offset = "0xE64970", VA = "0xE64970")]
		internal void FetchInvitations(Action<FetchInvitationsResponse> callback)
		{
		}

		[Token(Token = "0x60013BD")]
		[Address(RVA = "0xE64040", Offset = "0xE64040", VA = "0xE64040")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836D90", Offset = "0x836D90")]
		internal static void InternalLeaveRoomCallback(CommonErrorStatus.ResponseStatus response, IntPtr data)
		{
		}

		[Token(Token = "0x60013BE")]
		[Address(RVA = "0xE64A94", Offset = "0xE64A94", VA = "0xE64A94")]
		internal void LeaveRoom(NativeRealTimeRoom room, Action<CommonErrorStatus.ResponseStatus> callback)
		{
		}

		[Token(Token = "0x60013BF")]
		[Address(RVA = "0xE64BA0", Offset = "0xE64BA0", VA = "0xE64BA0")]
		internal void AcceptInvitation(MultiplayerInvitation invitation, RealTimeEventListenerHelper listener, Action<RealTimeRoomResponse> callback)
		{
		}

		[Token(Token = "0x60013C0")]
		[Address(RVA = "0xE64CAC", Offset = "0xE64CAC", VA = "0xE64CAC")]
		internal void DeclineInvitation(MultiplayerInvitation invitation)
		{
		}

		[Token(Token = "0x60013C1")]
		[Address(RVA = "0xE64D1C", Offset = "0xE64D1C", VA = "0xE64D1C")]
		internal void SendReliableMessage(NativeRealTimeRoom room, MultiplayerParticipant participant, byte[] data, Action<CommonErrorStatus.MultiplayerStatus> callback)
		{
		}

		[Token(Token = "0x60013C2")]
		[Address(RVA = "0xE641C0", Offset = "0xE641C0", VA = "0xE641C0")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836DF4", Offset = "0x836DF4")]
		internal static void InternalSendReliableMessageCallback(CommonErrorStatus.MultiplayerStatus response, IntPtr data)
		{
		}

		[Token(Token = "0x60013C3")]
		[Address(RVA = "0xE64EA8", Offset = "0xE64EA8", VA = "0xE64EA8")]
		internal void SendUnreliableMessageToAll(NativeRealTimeRoom room, byte[] data)
		{
		}

		[Token(Token = "0x60013C4")]
		[Address(RVA = "0xE64F88", Offset = "0xE64F88", VA = "0xE64F88")]
		internal void SendUnreliableMessageToSpecificParticipants(NativeRealTimeRoom room, List<MultiplayerParticipant> recipients, byte[] data)
		{
		}

		[Token(Token = "0x60013C5")]
		[Address(RVA = "0xE644F0", Offset = "0xE644F0", VA = "0xE644F0")]
		private static IntPtr ToCallbackPointer(Action<RealTimeRoomResponse> callback)
		{
			return default(IntPtr);
		}
	}
}
