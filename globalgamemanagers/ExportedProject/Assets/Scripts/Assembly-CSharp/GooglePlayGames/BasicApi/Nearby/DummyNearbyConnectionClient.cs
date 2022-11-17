using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x20002F5")]
	public class DummyNearbyConnectionClient : INearbyConnectionClient
	{
		[Token(Token = "0x6001733")]
		[Address(RVA = "0x1464310", Offset = "0x1464310", VA = "0x1464310", Slot = "4")]
		public int MaxUnreliableMessagePayloadLength()
		{
			return default(int);
		}

		[Token(Token = "0x6001734")]
		[Address(RVA = "0x1464318", Offset = "0x1464318", VA = "0x1464318", Slot = "5")]
		public int MaxReliableMessagePayloadLength()
		{
			return default(int);
		}

		[Token(Token = "0x6001735")]
		[Address(RVA = "0x1464320", Offset = "0x1464320", VA = "0x1464320", Slot = "6")]
		public void SendReliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Token(Token = "0x6001736")]
		[Address(RVA = "0x146438C", Offset = "0x146438C", VA = "0x146438C", Slot = "7")]
		public void SendUnreliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Token(Token = "0x6001737")]
		[Address(RVA = "0x14643F8", Offset = "0x14643F8", VA = "0x14643F8", Slot = "8")]
		public void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback)
		{
		}

		[Token(Token = "0x6001738")]
		[Address(RVA = "0x1464498", Offset = "0x1464498", VA = "0x1464498", Slot = "9")]
		public void StopAdvertising()
		{
		}

		[Token(Token = "0x6001739")]
		[Address(RVA = "0x1464504", Offset = "0x1464504", VA = "0x1464504", Slot = "10")]
		public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener)
		{
		}

		[Token(Token = "0x600173A")]
		[Address(RVA = "0x14645F0", Offset = "0x14645F0", VA = "0x14645F0", Slot = "11")]
		public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener)
		{
		}

		[Token(Token = "0x600173B")]
		[Address(RVA = "0x146465C", Offset = "0x146465C", VA = "0x146465C", Slot = "12")]
		public void StartDiscovery(string serviceId, TimeSpan? advertisingTimeout, IDiscoveryListener listener)
		{
		}

		[Token(Token = "0x600173C")]
		[Address(RVA = "0x14646C8", Offset = "0x14646C8", VA = "0x14646C8", Slot = "13")]
		public void StopDiscovery(string serviceId)
		{
		}

		[Token(Token = "0x600173D")]
		[Address(RVA = "0x1464734", Offset = "0x1464734", VA = "0x1464734", Slot = "14")]
		public void RejectConnectionRequest(string requestingEndpointId)
		{
		}

		[Token(Token = "0x600173E")]
		[Address(RVA = "0x14647A0", Offset = "0x14647A0", VA = "0x14647A0", Slot = "15")]
		public void DisconnectFromEndpoint(string remoteEndpointId)
		{
		}

		[Token(Token = "0x600173F")]
		[Address(RVA = "0x146480C", Offset = "0x146480C", VA = "0x146480C", Slot = "16")]
		public void StopAllConnections()
		{
		}

		[Token(Token = "0x6001740")]
		[Address(RVA = "0x1464878", Offset = "0x1464878", VA = "0x1464878")]
		public string LocalEndpointId()
		{
			return null;
		}

		[Token(Token = "0x6001741")]
		[Address(RVA = "0x14648C8", Offset = "0x14648C8", VA = "0x14648C8")]
		public string LocalDeviceId()
		{
			return null;
		}

		[Token(Token = "0x6001742")]
		[Address(RVA = "0x1464910", Offset = "0x1464910", VA = "0x1464910", Slot = "17")]
		public string GetAppBundleId()
		{
			return null;
		}

		[Token(Token = "0x6001743")]
		[Address(RVA = "0x1464958", Offset = "0x1464958", VA = "0x1464958", Slot = "18")]
		public string GetServiceId()
		{
			return null;
		}

		[Token(Token = "0x6001744")]
		[Address(RVA = "0x14649A0", Offset = "0x14649A0", VA = "0x14649A0")]
		public DummyNearbyConnectionClient()
		{
		}
	}
}
