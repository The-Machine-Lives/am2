using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x20002F9")]
	public interface IDiscoveryListener
	{
		[Token(Token = "0x600175A")]
		void OnEndpointFound(EndpointDetails discoveredEndpoint);

		[Token(Token = "0x600175B")]
		void OnEndpointLost(string lostEndpointId);
	}
}
