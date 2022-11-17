using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x20002F7")]
	public interface INearbyConnectionClient
	{
		[Token(Token = "0x6001749")]
		int MaxUnreliableMessagePayloadLength();

		[Token(Token = "0x600174A")]
		int MaxReliableMessagePayloadLength();

		[Token(Token = "0x600174B")]
		void SendReliable(List<string> recipientEndpointIds, byte[] payload);

		[Token(Token = "0x600174C")]
		void SendUnreliable(List<string> recipientEndpointIds, byte[] payload);

		[Token(Token = "0x600174D")]
		void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback);

		[Token(Token = "0x600174E")]
		void StopAdvertising();

		[Token(Token = "0x600174F")]
		void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener);

		[Token(Token = "0x6001750")]
		void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener);

		[Token(Token = "0x6001751")]
		void StartDiscovery(string serviceId, TimeSpan? advertisingTimeout, IDiscoveryListener listener);

		[Token(Token = "0x6001752")]
		void StopDiscovery(string serviceId);

		[Token(Token = "0x6001753")]
		void RejectConnectionRequest(string requestingEndpointId);

		[Token(Token = "0x6001754")]
		void DisconnectFromEndpoint(string remoteEndpointId);

		[Token(Token = "0x6001755")]
		void StopAllConnections();

		[Token(Token = "0x6001756")]
		string GetAppBundleId();

		[Token(Token = "0x6001757")]
		string GetServiceId();
	}
}
