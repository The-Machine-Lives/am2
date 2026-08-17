using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002C7")]
	internal static class TurnBasedMultiplayerManager
	{
		[Token(Token = "0x2000773")]
		internal delegate void TurnBasedMatchCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000774")]
		internal delegate void MultiplayerStatusCallback(CommonErrorStatus.MultiplayerStatus arg0, IntPtr arg1);

		[Token(Token = "0x2000775")]
		internal delegate void TurnBasedMatchesCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000776")]
		internal delegate void MatchInboxUICallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000777")]
		internal delegate void PlayerSelectUICallback(IntPtr arg0, IntPtr arg1);

		[PreserveSig]
		[Token(Token = "0x60015C9")]
		[Address(RVA = "0x132CE14", Offset = "0x132CE14", VA = "0x132CE14")]
		internal static extern void TurnBasedMultiplayerManager_ShowPlayerSelectUI(HandleRef self, uint minimum_players, uint maximum_players, bool allow_automatch, PlayerSelectUICallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x132CEFC", Offset = "0x132CEFC", VA = "0x132CEFC")]
		internal static extern void TurnBasedMultiplayerManager_CancelMatch(HandleRef self, IntPtr match, MultiplayerStatusCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60015CB")]
		[Address(RVA = "0x132CFC8", Offset = "0x132CFC8", VA = "0x132CFC8")]
		internal static extern void TurnBasedMultiplayerManager_DismissMatch(HandleRef self, IntPtr match);

		[PreserveSig]
		[Token(Token = "0x60015CC")]
		[Address(RVA = "0x132D074", Offset = "0x132D074", VA = "0x132D074")]
		internal static extern void TurnBasedMultiplayerManager_ShowMatchInboxUI(HandleRef self, MatchInboxUICallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60015CD")]
		[Address(RVA = "0x132D130", Offset = "0x132D130", VA = "0x132D130")]
		internal static extern void TurnBasedMultiplayerManager_SynchronizeData(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015CE")]
		[Address(RVA = "0x132D1CC", Offset = "0x132D1CC", VA = "0x132D1CC")]
		internal static extern void TurnBasedMultiplayerManager_Rematch(HandleRef self, IntPtr match, TurnBasedMatchCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60015CF")]
		[Address(RVA = "0x132D298", Offset = "0x132D298", VA = "0x132D298")]
		internal static extern void TurnBasedMultiplayerManager_DismissInvitation(HandleRef self, IntPtr invitation);

		[PreserveSig]
		[Token(Token = "0x60015D0")]
		[Address(RVA = "0x132D344", Offset = "0x132D344", VA = "0x132D344")]
		internal static extern void TurnBasedMultiplayerManager_FetchMatch(HandleRef self, string match_id, TurnBasedMatchCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60015D1")]
		[Address(RVA = "0x132D424", Offset = "0x132D424", VA = "0x132D424")]
		internal static extern void TurnBasedMultiplayerManager_DeclineInvitation(HandleRef self, IntPtr invitation);

		[PreserveSig]
		[Token(Token = "0x60015D2")]
		[Address(RVA = "0x132D4D0", Offset = "0x132D4D0", VA = "0x132D4D0")]
		internal static extern void TurnBasedMultiplayerManager_FinishMatchDuringMyTurn(HandleRef self, IntPtr match, byte[] match_data, UIntPtr match_data_size, IntPtr results, TurnBasedMatchCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60015D3")]
		[Address(RVA = "0x132D5C8", Offset = "0x132D5C8", VA = "0x132D5C8")]
		internal static extern void TurnBasedMultiplayerManager_FetchMatches(HandleRef self, TurnBasedMatchesCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60015D4")]
		[Address(RVA = "0x132D684", Offset = "0x132D684", VA = "0x132D684")]
		internal static extern void TurnBasedMultiplayerManager_CreateTurnBasedMatch(HandleRef self, IntPtr config, TurnBasedMatchCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x132D750", Offset = "0x132D750", VA = "0x132D750")]
		internal static extern void TurnBasedMultiplayerManager_AcceptInvitation(HandleRef self, IntPtr invitation, TurnBasedMatchCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60015D6")]
		[Address(RVA = "0x132D81C", Offset = "0x132D81C", VA = "0x132D81C")]
		internal static extern void TurnBasedMultiplayerManager_TakeMyTurn(HandleRef self, IntPtr match, byte[] match_data, UIntPtr match_data_size, IntPtr results, IntPtr next_participant, TurnBasedMatchCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60015D7")]
		[Address(RVA = "0x132D924", Offset = "0x132D924", VA = "0x132D924")]
		internal static extern void TurnBasedMultiplayerManager_ConfirmPendingCompletion(HandleRef self, IntPtr match, TurnBasedMatchCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60015D8")]
		[Address(RVA = "0x132D9F0", Offset = "0x132D9F0", VA = "0x132D9F0")]
		internal static extern void TurnBasedMultiplayerManager_LeaveMatchDuringMyTurn(HandleRef self, IntPtr match, IntPtr next_participant, MultiplayerStatusCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60015D9")]
		[Address(RVA = "0x132DAC4", Offset = "0x132DAC4", VA = "0x132DAC4")]
		internal static extern void TurnBasedMultiplayerManager_LeaveMatchDuringTheirTurn(HandleRef self, IntPtr match, MultiplayerStatusCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60015DA")]
		[Address(RVA = "0x132DB90", Offset = "0x132DB90", VA = "0x132DB90")]
		internal static extern void TurnBasedMultiplayerManager_TurnBasedMatchResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015DB")]
		[Address(RVA = "0x132DC2C", Offset = "0x132DC2C", VA = "0x132DC2C")]
		internal static extern CommonErrorStatus.MultiplayerStatus TurnBasedMultiplayerManager_TurnBasedMatchResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x132DCC8", Offset = "0x132DCC8", VA = "0x132DCC8")]
		internal static extern IntPtr TurnBasedMultiplayerManager_TurnBasedMatchResponse_GetMatch(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x132DD64", Offset = "0x132DD64", VA = "0x132DD64")]
		internal static extern void TurnBasedMultiplayerManager_TurnBasedMatchesResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015DE")]
		[Address(RVA = "0x132DE00", Offset = "0x132DE00", VA = "0x132DE00")]
		internal static extern CommonErrorStatus.MultiplayerStatus TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x132DE9C", Offset = "0x132DE9C", VA = "0x132DE9C")]
		internal static extern UIntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetInvitations_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015E0")]
		[Address(RVA = "0x132DF38", Offset = "0x132DF38", VA = "0x132DF38")]
		internal static extern IntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetInvitations_GetElement(HandleRef self, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x60015E1")]
		[Address(RVA = "0x132DFE4", Offset = "0x132DFE4", VA = "0x132DFE4")]
		internal static extern UIntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetMyTurnMatches_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x132E080", Offset = "0x132E080", VA = "0x132E080")]
		internal static extern IntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetMyTurnMatches_GetElement(HandleRef self, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x60015E3")]
		[Address(RVA = "0x132E12C", Offset = "0x132E12C", VA = "0x132E12C")]
		internal static extern UIntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetTheirTurnMatches_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x132E1C8", Offset = "0x132E1C8", VA = "0x132E1C8")]
		internal static extern IntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetTheirTurnMatches_GetElement(HandleRef self, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x132E274", Offset = "0x132E274", VA = "0x132E274")]
		internal static extern UIntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetCompletedMatches_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015E6")]
		[Address(RVA = "0x132E310", Offset = "0x132E310", VA = "0x132E310")]
		internal static extern IntPtr TurnBasedMultiplayerManager_TurnBasedMatchesResponse_GetCompletedMatches_GetElement(HandleRef self, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x60015E7")]
		[Address(RVA = "0x132E3BC", Offset = "0x132E3BC", VA = "0x132E3BC")]
		internal static extern void TurnBasedMultiplayerManager_MatchInboxUIResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015E8")]
		[Address(RVA = "0x132E458", Offset = "0x132E458", VA = "0x132E458")]
		internal static extern CommonErrorStatus.UIStatus TurnBasedMultiplayerManager_MatchInboxUIResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x132E4F4", Offset = "0x132E4F4", VA = "0x132E4F4")]
		internal static extern IntPtr TurnBasedMultiplayerManager_MatchInboxUIResponse_GetMatch(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x132E590", Offset = "0x132E590", VA = "0x132E590")]
		internal static extern void TurnBasedMultiplayerManager_PlayerSelectUIResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x132E62C", Offset = "0x132E62C", VA = "0x132E62C")]
		internal static extern CommonErrorStatus.UIStatus TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015EC")]
		[Address(RVA = "0x132E6C8", Offset = "0x132E6C8", VA = "0x132E6C8")]
		internal static extern UIntPtr TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetPlayerIds_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015ED")]
		[Address(RVA = "0x132E764", Offset = "0x132E764", VA = "0x132E764")]
		internal static extern UIntPtr TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetPlayerIds_GetElement(HandleRef self, UIntPtr index, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60015EE")]
		[Address(RVA = "0x132E830", Offset = "0x132E830", VA = "0x132E830")]
		internal static extern uint TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetMinimumAutomatchingPlayers(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015EF")]
		[Address(RVA = "0x132E8CC", Offset = "0x132E8CC", VA = "0x132E8CC")]
		internal static extern uint TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetMaximumAutomatchingPlayers(HandleRef self);
	}
}
