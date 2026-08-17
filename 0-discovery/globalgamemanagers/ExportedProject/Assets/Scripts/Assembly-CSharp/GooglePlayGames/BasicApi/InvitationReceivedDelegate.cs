using GooglePlayGames.BasicApi.Multiplayer;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20002E1")]
	public delegate void InvitationReceivedDelegate(Invitation invitation, bool shouldAutoAccept);
}
