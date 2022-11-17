using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x20002F8")]
	public interface IMessageListener
	{
		[Token(Token = "0x6001758")]
		void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage);

		[Token(Token = "0x6001759")]
		void OnRemoteEndpointDisconnected(string remoteEndpointId);
	}
}
