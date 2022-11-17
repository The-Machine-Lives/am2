using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	[Token(Token = "0x20002FD")]
	public interface IRealTimeMultiplayerClient
	{
		[Token(Token = "0x6001767")]
		void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, RealTimeMultiplayerListener listener);

		[Token(Token = "0x6001768")]
		void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitMask, RealTimeMultiplayerListener listener);

		[Token(Token = "0x6001769")]
		void CreateWithInvitationScreen(uint minOpponents, uint maxOppponents, uint variant, RealTimeMultiplayerListener listener);

		[Token(Token = "0x600176A")]
		void ShowWaitingRoomUI();

		[Token(Token = "0x600176B")]
		void GetAllInvitations(Action<Invitation[]> callback);

		[Token(Token = "0x600176C")]
		void AcceptFromInbox(RealTimeMultiplayerListener listener);

		[Token(Token = "0x600176D")]
		void AcceptInvitation(string invitationId, RealTimeMultiplayerListener listener);

		[Token(Token = "0x600176E")]
		void SendMessageToAll(bool reliable, byte[] data);

		[Token(Token = "0x600176F")]
		void SendMessageToAll(bool reliable, byte[] data, int offset, int length);

		[Token(Token = "0x6001770")]
		void SendMessage(bool reliable, string participantId, byte[] data);

		[Token(Token = "0x6001771")]
		void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length);

		[Token(Token = "0x6001772")]
		List<Participant> GetConnectedParticipants();

		[Token(Token = "0x6001773")]
		Participant GetSelf();

		[Token(Token = "0x6001774")]
		Participant GetParticipant(string participantId);

		[Token(Token = "0x6001775")]
		Invitation GetInvitation();

		[Token(Token = "0x6001776")]
		void LeaveRoom();

		[Token(Token = "0x6001777")]
		bool IsRoomConnected();

		[Token(Token = "0x6001778")]
		void DeclineInvitation(string invitationId);
	}
}
