using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	[Token(Token = "0x2000303")]
	public interface RealTimeMultiplayerListener
	{
		[Token(Token = "0x60017A5")]
		void OnRoomSetupProgress(float percent);

		[Token(Token = "0x60017A6")]
		void OnRoomConnected(bool success);

		[Token(Token = "0x60017A7")]
		void OnLeftRoom();

		[Token(Token = "0x60017A8")]
		void OnParticipantLeft(Participant participant);

		[Token(Token = "0x60017A9")]
		void OnPeersConnected(string[] participantIds);

		[Token(Token = "0x60017AA")]
		void OnPeersDisconnected(string[] participantIds);

		[Token(Token = "0x60017AB")]
		void OnRealTimeMessageReceived(bool isReliable, string senderId, byte[] data);
	}
}
