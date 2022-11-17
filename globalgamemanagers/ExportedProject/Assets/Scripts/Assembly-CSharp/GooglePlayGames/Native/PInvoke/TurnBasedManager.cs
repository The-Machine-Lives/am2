using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000295")]
	internal class TurnBasedManager
	{
		[Token(Token = "0x2000727")]
		internal delegate void TurnBasedMatchCallback(TurnBasedMatchResponse response);

		[Token(Token = "0x2000728")]
		internal class MatchInboxUIResponse : BaseReferenceHolder
		{
			[Token(Token = "0x6003052")]
			[Address(RVA = "0xE69494", Offset = "0xE69494", VA = "0xE69494")]
			internal MatchInboxUIResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x6003053")]
			[Address(RVA = "0xE6950C", Offset = "0xE6950C", VA = "0xE6950C")]
			internal CommonErrorStatus.UIStatus UiStatus()
			{
				return default(CommonErrorStatus.UIStatus);
			}

			[Token(Token = "0x6003054")]
			[Address(RVA = "0xE69528", Offset = "0xE69528", VA = "0xE69528")]
			internal NativeTurnBasedMatch Match()
			{
				return null;
			}

			[Token(Token = "0x6003055")]
			[Address(RVA = "0xE695C4", Offset = "0xE695C4", VA = "0xE695C4", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x6003056")]
			[Address(RVA = "0xE695D4", Offset = "0xE695D4", VA = "0xE695D4")]
			internal static MatchInboxUIResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		[Token(Token = "0x2000729")]
		internal class TurnBasedMatchResponse : BaseReferenceHolder
		{
			[Token(Token = "0x6003057")]
			[Address(RVA = "0xE69DE4", Offset = "0xE69DE4", VA = "0xE69DE4")]
			internal TurnBasedMatchResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x6003058")]
			[Address(RVA = "0xE69E5C", Offset = "0xE69E5C", VA = "0xE69E5C")]
			internal CommonErrorStatus.MultiplayerStatus ResponseStatus()
			{
				return default(CommonErrorStatus.MultiplayerStatus);
			}

			[Token(Token = "0x6003059")]
			[Address(RVA = "0xE69E78", Offset = "0xE69E78", VA = "0xE69E78")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			[Token(Token = "0x600305A")]
			[Address(RVA = "0xE69EA0", Offset = "0xE69EA0", VA = "0xE69EA0")]
			internal NativeTurnBasedMatch Match()
			{
				return null;
			}

			[Token(Token = "0x600305B")]
			[Address(RVA = "0xE69F40", Offset = "0xE69F40", VA = "0xE69F40", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x600305C")]
			[Address(RVA = "0xE69F50", Offset = "0xE69F50", VA = "0xE69F50")]
			internal static TurnBasedMatchResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		[Token(Token = "0x200072A")]
		internal class TurnBasedMatchesResponse : BaseReferenceHolder
		{
			[Token(Token = "0x600305D")]
			[Address(RVA = "0xE69FEC", Offset = "0xE69FEC", VA = "0xE69FEC")]
			internal TurnBasedMatchesResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x600305E")]
			[Address(RVA = "0xE6A064", Offset = "0xE6A064", VA = "0xE6A064", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x600305F")]
			[Address(RVA = "0xE6A080", Offset = "0xE6A080", VA = "0xE6A080")]
			internal CommonErrorStatus.MultiplayerStatus Status()
			{
				return default(CommonErrorStatus.MultiplayerStatus);
			}

			[Token(Token = "0x6003060")]
			[Address(RVA = "0xE6A09C", Offset = "0xE6A09C", VA = "0xE6A09C")]
			internal IEnumerable<MultiplayerInvitation> Invitations()
			{
				return null;
			}

			[Token(Token = "0x6003061")]
			[Address(RVA = "0xE6A168", Offset = "0xE6A168", VA = "0xE6A168")]
			internal int InvitationCount()
			{
				return default(int);
			}

			[Token(Token = "0x6003062")]
			[Address(RVA = "0xE6A1A0", Offset = "0xE6A1A0", VA = "0xE6A1A0")]
			internal IEnumerable<NativeTurnBasedMatch> MyTurnMatches()
			{
				return null;
			}

			[Token(Token = "0x6003063")]
			[Address(RVA = "0xE6A26C", Offset = "0xE6A26C", VA = "0xE6A26C")]
			internal int MyTurnMatchesCount()
			{
				return default(int);
			}

			[Token(Token = "0x6003064")]
			[Address(RVA = "0xE6A2A4", Offset = "0xE6A2A4", VA = "0xE6A2A4")]
			internal IEnumerable<NativeTurnBasedMatch> TheirTurnMatches()
			{
				return null;
			}

			[Token(Token = "0x6003065")]
			[Address(RVA = "0xE6A370", Offset = "0xE6A370", VA = "0xE6A370")]
			internal int TheirTurnMatchesCount()
			{
				return default(int);
			}

			[Token(Token = "0x6003066")]
			[Address(RVA = "0xE6A3A8", Offset = "0xE6A3A8", VA = "0xE6A3A8")]
			internal IEnumerable<NativeTurnBasedMatch> CompletedMatches()
			{
				return null;
			}

			[Token(Token = "0x6003067")]
			[Address(RVA = "0xE6A474", Offset = "0xE6A474", VA = "0xE6A474")]
			internal int CompletedMatchesCount()
			{
				return default(int);
			}

			[Token(Token = "0x6003068")]
			[Address(RVA = "0xE6A4AC", Offset = "0xE6A4AC", VA = "0xE6A4AC")]
			internal static TurnBasedMatchesResponse FromPointer(IntPtr pointer)
			{
				return null;
			}

			[Token(Token = "0x6003069")]
			[Address(RVA = "0xE6A540", Offset = "0xE6A540", VA = "0xE6A540")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B74C", Offset = "0x83B74C")]
			private MultiplayerInvitation _003CInvitations_003Eb__3_0(UIntPtr index)
			{
				return null;
			}

			[Token(Token = "0x600306A")]
			[Address(RVA = "0xE6A5D0", Offset = "0xE6A5D0", VA = "0xE6A5D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B75C", Offset = "0x83B75C")]
			private NativeTurnBasedMatch _003CMyTurnMatches_003Eb__5_0(UIntPtr index)
			{
				return null;
			}

			[Token(Token = "0x600306B")]
			[Address(RVA = "0xE6A65C", Offset = "0xE6A65C", VA = "0xE6A65C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B76C", Offset = "0x83B76C")]
			private NativeTurnBasedMatch _003CTheirTurnMatches_003Eb__7_0(UIntPtr index)
			{
				return null;
			}

			[Token(Token = "0x600306C")]
			[Address(RVA = "0xE6A6E8", Offset = "0xE6A6E8", VA = "0xE6A6E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B77C", Offset = "0x83B77C")]
			private NativeTurnBasedMatch _003CCompletedMatches_003Eb__9_0(UIntPtr index)
			{
				return null;
			}
		}

		[Token(Token = "0x4000D28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly GameServices mGameServices;

		[Token(Token = "0x60013E4")]
		[Address(RVA = "0xE6843C", Offset = "0xE6843C", VA = "0xE6843C")]
		internal TurnBasedManager(GameServices services)
		{
		}

		[Token(Token = "0x60013E5")]
		[Address(RVA = "0xE68468", Offset = "0xE68468", VA = "0xE68468")]
		internal void GetMatch(string matchId, Action<TurnBasedMatchResponse> callback)
		{
		}

		[Token(Token = "0x60013E6")]
		[Address(RVA = "0xE6805C", Offset = "0xE6805C", VA = "0xE6805C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8370B0", Offset = "0x8370B0")]
		internal static void InternalTurnBasedMatchCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x60013E7")]
		[Address(RVA = "0xE685D8", Offset = "0xE685D8", VA = "0xE685D8")]
		internal void CreateMatch(TurnBasedMatchConfig config, Action<TurnBasedMatchResponse> callback)
		{
		}

		[Token(Token = "0x60013E8")]
		[Address(RVA = "0xE686C0", Offset = "0xE686C0", VA = "0xE686C0")]
		internal void ShowPlayerSelectUI(uint minimumPlayers, uint maxiumPlayers, bool allowAutomatching, Action<PlayerSelectUIResponse> callback)
		{
		}

		[Token(Token = "0x60013E9")]
		[Address(RVA = "0xE680E4", Offset = "0xE680E4", VA = "0xE680E4")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x837114", Offset = "0x837114")]
		internal static void InternalPlayerSelectUIcallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x60013EA")]
		[Address(RVA = "0xE68804", Offset = "0xE68804", VA = "0xE68804")]
		internal void GetAllTurnbasedMatches(Action<TurnBasedMatchesResponse> callback)
		{
		}

		[Token(Token = "0x60013EB")]
		[Address(RVA = "0xE6816C", Offset = "0xE6816C", VA = "0xE6816C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x837178", Offset = "0x837178")]
		internal static void InternalTurnBasedMatchesCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x60013EC")]
		[Address(RVA = "0xE68928", Offset = "0xE68928", VA = "0xE68928")]
		internal void AcceptInvitation(MultiplayerInvitation invitation, Action<TurnBasedMatchResponse> callback)
		{
		}

		[Token(Token = "0x60013ED")]
		[Address(RVA = "0xE68AB0", Offset = "0xE68AB0", VA = "0xE68AB0")]
		internal void DeclineInvitation(MultiplayerInvitation invitation)
		{
		}

		[Token(Token = "0x60013EE")]
		[Address(RVA = "0xE68B20", Offset = "0xE68B20", VA = "0xE68B20")]
		internal void TakeTurn(NativeTurnBasedMatch match, byte[] data, MultiplayerParticipant nextParticipant, Action<TurnBasedMatchResponse> callback)
		{
		}

		[Token(Token = "0x60013EF")]
		[Address(RVA = "0xE681F4", Offset = "0xE681F4", VA = "0xE681F4")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8371DC", Offset = "0x8371DC")]
		internal static void InternalMatchInboxUICallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x60013F0")]
		[Address(RVA = "0xE68C9C", Offset = "0xE68C9C", VA = "0xE68C9C")]
		internal void ShowInboxUI(Action<MatchInboxUIResponse> callback)
		{
		}

		[Token(Token = "0x60013F1")]
		[Address(RVA = "0xE6827C", Offset = "0xE6827C", VA = "0xE6827C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x837240", Offset = "0x837240")]
		internal static void InternalMultiplayerStatusCallback(CommonErrorStatus.MultiplayerStatus status, IntPtr data)
		{
		}

		[Token(Token = "0x60013F2")]
		[Address(RVA = "0xE68DC0", Offset = "0xE68DC0", VA = "0xE68DC0")]
		internal void LeaveDuringMyTurn(NativeTurnBasedMatch match, MultiplayerParticipant nextParticipant, Action<CommonErrorStatus.MultiplayerStatus> callback)
		{
		}

		[Token(Token = "0x60013F3")]
		[Address(RVA = "0xE68EF0", Offset = "0xE68EF0", VA = "0xE68EF0")]
		internal void FinishMatchDuringMyTurn(NativeTurnBasedMatch match, byte[] data, ParticipantResults results, Action<TurnBasedMatchResponse> callback)
		{
		}

		[Token(Token = "0x60013F4")]
		[Address(RVA = "0xE6903C", Offset = "0xE6903C", VA = "0xE6903C")]
		internal void ConfirmPendingCompletion(NativeTurnBasedMatch match, Action<TurnBasedMatchResponse> callback)
		{
		}

		[Token(Token = "0x60013F5")]
		[Address(RVA = "0xE69124", Offset = "0xE69124", VA = "0xE69124")]
		internal void LeaveMatchDuringTheirTurn(NativeTurnBasedMatch match, Action<CommonErrorStatus.MultiplayerStatus> callback)
		{
		}

		[Token(Token = "0x60013F6")]
		[Address(RVA = "0xE69230", Offset = "0xE69230", VA = "0xE69230")]
		internal void CancelMatch(NativeTurnBasedMatch match, Action<CommonErrorStatus.MultiplayerStatus> callback)
		{
		}

		[Token(Token = "0x60013F7")]
		[Address(RVA = "0xE6933C", Offset = "0xE6933C", VA = "0xE6933C")]
		internal void DismissMatch(NativeTurnBasedMatch match)
		{
		}

		[Token(Token = "0x60013F8")]
		[Address(RVA = "0xE693AC", Offset = "0xE693AC", VA = "0xE693AC")]
		internal void Rematch(NativeTurnBasedMatch match, Action<TurnBasedMatchResponse> callback)
		{
		}

		[Token(Token = "0x60013F9")]
		[Address(RVA = "0xE68530", Offset = "0xE68530", VA = "0xE68530")]
		private static IntPtr ToCallbackPointer(Action<TurnBasedMatchResponse> callback)
		{
			return default(IntPtr);
		}
	}
}
