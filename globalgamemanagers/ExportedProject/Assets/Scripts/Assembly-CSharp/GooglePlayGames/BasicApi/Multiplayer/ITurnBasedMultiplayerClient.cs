using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	[Token(Token = "0x20002FE")]
	public interface ITurnBasedMultiplayerClient
	{
		[Token(Token = "0x6001779")]
		void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, Action<bool, TurnBasedMatch> callback);

		[Token(Token = "0x600177A")]
		void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitmask, Action<bool, TurnBasedMatch> callback);

		[Token(Token = "0x600177B")]
		void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, Action<bool, TurnBasedMatch> callback);

		[Token(Token = "0x600177C")]
		void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, Action<UIStatus, TurnBasedMatch> callback);

		[Token(Token = "0x600177D")]
		void GetAllInvitations(Action<Invitation[]> callback);

		[Token(Token = "0x600177E")]
		void GetAllMatches(Action<TurnBasedMatch[]> callback);

		[Token(Token = "0x600177F")]
		void GetMatch(string matchId, Action<bool, TurnBasedMatch> callback);

		[Token(Token = "0x6001780")]
		void AcceptFromInbox(Action<bool, TurnBasedMatch> callback);

		[Token(Token = "0x6001781")]
		void AcceptInvitation(string invitationId, Action<bool, TurnBasedMatch> callback);

		[Token(Token = "0x6001782")]
		void RegisterMatchDelegate(MatchDelegate del);

		[Token(Token = "0x6001783")]
		void TakeTurn(TurnBasedMatch match, byte[] data, string pendingParticipantId, Action<bool> callback);

		[Token(Token = "0x6001784")]
		int GetMaxMatchDataSize();

		[Token(Token = "0x6001785")]
		void Finish(TurnBasedMatch match, byte[] data, MatchOutcome outcome, Action<bool> callback);

		[Token(Token = "0x6001786")]
		void AcknowledgeFinished(TurnBasedMatch match, Action<bool> callback);

		[Token(Token = "0x6001787")]
		void Leave(TurnBasedMatch match, Action<bool> callback);

		[Token(Token = "0x6001788")]
		void LeaveDuringTurn(TurnBasedMatch match, string pendingParticipantId, Action<bool> callback);

		[Token(Token = "0x6001789")]
		void Cancel(TurnBasedMatch match, Action<bool> callback);

		[Token(Token = "0x600178A")]
		void Dismiss(TurnBasedMatch match);

		[Token(Token = "0x600178B")]
		void Rematch(TurnBasedMatch match, Action<bool, TurnBasedMatch> callback);

		[Token(Token = "0x600178C")]
		void DeclineInvitation(string invitationId);
	}
}
