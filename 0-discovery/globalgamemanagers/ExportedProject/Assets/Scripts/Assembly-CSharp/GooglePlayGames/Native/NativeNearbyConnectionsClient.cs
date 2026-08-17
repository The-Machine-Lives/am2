using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	[Token(Token = "0x200025B")]
	internal class NativeNearbyConnectionsClient : INearbyConnectionClient
	{
		[Token(Token = "0x20006AC")]
		protected class OnGameThreadMessageListener : IMessageListener
		{
			[Token(Token = "0x2000889")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8216E8", Offset = "0x8216E8")]
			private sealed class _003C_003Ec__DisplayClass2_0
			{
				[Token(Token = "0x4002459")]
				[FieldOffset(Offset = "0x10")]
				public OnGameThreadMessageListener _003C_003E4__this;

				[Token(Token = "0x400245A")]
				[FieldOffset(Offset = "0x18")]
				public string remoteEndpointId;

				[Token(Token = "0x400245B")]
				[FieldOffset(Offset = "0x20")]
				public byte[] data;

				[Token(Token = "0x400245C")]
				[FieldOffset(Offset = "0x28")]
				public bool isReliableMessage;

				[Token(Token = "0x60033C4")]
				[Address(RVA = "0x133ADF4", Offset = "0x133ADF4", VA = "0x133ADF4")]
				public _003C_003Ec__DisplayClass2_0()
				{
				}

				[Token(Token = "0x60033C5")]
				[Address(RVA = "0x133AEE8", Offset = "0x133AEE8", VA = "0x133AEE8")]
				internal void _003COnMessageReceived_003Eb__0()
				{
				}
			}

			[Token(Token = "0x200088A")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8216F8", Offset = "0x8216F8")]
			private sealed class _003C_003Ec__DisplayClass3_0
			{
				[Token(Token = "0x400245D")]
				[FieldOffset(Offset = "0x10")]
				public OnGameThreadMessageListener _003C_003E4__this;

				[Token(Token = "0x400245E")]
				[FieldOffset(Offset = "0x18")]
				public string remoteEndpointId;

				[Token(Token = "0x60033C6")]
				[Address(RVA = "0x133AEE0", Offset = "0x133AEE0", VA = "0x133AEE0")]
				public _003C_003Ec__DisplayClass3_0()
				{
				}

				[Token(Token = "0x60033C7")]
				[Address(RVA = "0x133AFCC", Offset = "0x133AFCC", VA = "0x133AFCC")]
				internal void _003COnRemoteEndpointDisconnected_003Eb__0()
				{
				}
			}

			[Token(Token = "0x4002031")]
			[FieldOffset(Offset = "0x10")]
			private readonly IMessageListener mListener;

			[Token(Token = "0x6002E89")]
			[Address(RVA = "0x1339C44", Offset = "0x1339C44", VA = "0x1339C44")]
			public OnGameThreadMessageListener(IMessageListener listener)
			{
			}

			[Token(Token = "0x6002E8A")]
			[Address(RVA = "0x133ACD8", Offset = "0x133ACD8", VA = "0x133ACD8", Slot = "4")]
			public void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage)
			{
			}

			[Token(Token = "0x6002E8B")]
			[Address(RVA = "0x133ADFC", Offset = "0x133ADFC", VA = "0x133ADFC", Slot = "5")]
			public void OnRemoteEndpointDisconnected(string remoteEndpointId)
			{
			}
		}

		[Token(Token = "0x20006AD")]
		protected class OnGameThreadDiscoveryListener : IDiscoveryListener
		{
			[Token(Token = "0x200088B")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821708", Offset = "0x821708")]
			private sealed class _003C_003Ec__DisplayClass2_0
			{
				[Token(Token = "0x400245F")]
				[FieldOffset(Offset = "0x10")]
				public OnGameThreadDiscoveryListener _003C_003E4__this;

				[Token(Token = "0x4002460")]
				[FieldOffset(Offset = "0x18")]
				public EndpointDetails discoveredEndpoint;

				[Token(Token = "0x60033C8")]
				[Address(RVA = "0x133AA0C", Offset = "0x133AA0C", VA = "0x133AA0C")]
				public _003C_003Ec__DisplayClass2_0()
				{
				}

				[Token(Token = "0x60033C9")]
				[Address(RVA = "0x133AB00", Offset = "0x133AB00", VA = "0x133AB00")]
				internal void _003COnEndpointFound_003Eb__0()
				{
				}
			}

			[Token(Token = "0x200088C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821718", Offset = "0x821718")]
			private sealed class _003C_003Ec__DisplayClass3_0
			{
				[Token(Token = "0x4002461")]
				[FieldOffset(Offset = "0x10")]
				public OnGameThreadDiscoveryListener _003C_003E4__this;

				[Token(Token = "0x4002462")]
				[FieldOffset(Offset = "0x18")]
				public string lostEndpointId;

				[Token(Token = "0x60033CA")]
				[Address(RVA = "0x133AAF8", Offset = "0x133AAF8", VA = "0x133AAF8")]
				public _003C_003Ec__DisplayClass3_0()
				{
				}

				[Token(Token = "0x60033CB")]
				[Address(RVA = "0x133AC08", Offset = "0x133AC08", VA = "0x133AC08")]
				internal void _003COnEndpointLost_003Eb__0()
				{
				}
			}

			[Token(Token = "0x4002032")]
			[FieldOffset(Offset = "0x10")]
			private readonly IDiscoveryListener mListener;

			[Token(Token = "0x6002E8C")]
			[Address(RVA = "0x133A118", Offset = "0x133A118", VA = "0x133A118")]
			public OnGameThreadDiscoveryListener(IDiscoveryListener listener)
			{
			}

			[Token(Token = "0x6002E8D")]
			[Address(RVA = "0x133A8E8", Offset = "0x133A8E8", VA = "0x133A8E8", Slot = "4")]
			public void OnEndpointFound(EndpointDetails discoveredEndpoint)
			{
			}

			[Token(Token = "0x6002E8E")]
			[Address(RVA = "0x133AA14", Offset = "0x133AA14", VA = "0x133AA14", Slot = "5")]
			public void OnEndpointLost(string lostEndpointId)
			{
			}
		}

		[Token(Token = "0x20006AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8209B8", Offset = "0x8209B8")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x4002033")]
			[FieldOffset(Offset = "0x10")]
			public Action<AdvertisingResult> resultCallback;

			[Token(Token = "0x4002034")]
			[FieldOffset(Offset = "0x18")]
			public Action<ConnectionRequest> requestCallback;

			[Token(Token = "0x6002E8F")]
			[Address(RVA = "0x13396E4", Offset = "0x13396E4", VA = "0x13396E4")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6002E90")]
			[Address(RVA = "0x133A7B4", Offset = "0x133A7B4", VA = "0x133A7B4")]
			internal void _003CStartAdvertising_003Eb__0(long localClientId, NativeStartAdvertisingResult result)
			{
			}

			[Token(Token = "0x6002E91")]
			[Address(RVA = "0x133A848", Offset = "0x133A848", VA = "0x133A848")]
			internal void _003CStartAdvertising_003Eb__1(long localClientId, NativeConnectionRequest request)
			{
			}
		}

		[Token(Token = "0x20006AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8209C8", Offset = "0x8209C8")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x4002035")]
			[FieldOffset(Offset = "0x10")]
			public Action<ConnectionResponse> responseCallback;

			[Token(Token = "0x6002E92")]
			[Address(RVA = "0x1339AC0", Offset = "0x1339AC0", VA = "0x1339AC0")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6002E93")]
			[Address(RVA = "0x133A390", Offset = "0x133A390", VA = "0x133A390")]
			internal void _003CSendConnectionRequest_003Eb__0(long localClientId, NativeConnectionResponse response)
			{
			}
		}

		[Token(Token = "0x20006B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8209D8", Offset = "0x8209D8")]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x4002036")]
			[FieldOffset(Offset = "0x10")]
			public IMessageListener listener;

			[Token(Token = "0x6002E94")]
			[Address(RVA = "0x1339C3C", Offset = "0x1339C3C", VA = "0x1339C3C")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6002E95")]
			[Address(RVA = "0x133A438", Offset = "0x133A438", VA = "0x133A438")]
			internal void _003CToMessageListener_003Eb__0(long localClientId, string endpointId, byte[] data, bool isReliable)
			{
			}

			[Token(Token = "0x6002E96")]
			[Address(RVA = "0x133A514", Offset = "0x133A514", VA = "0x133A514")]
			internal void _003CToMessageListener_003Eb__1(long localClientId, string endpointId)
			{
			}
		}

		[Token(Token = "0x20006B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8209E8", Offset = "0x8209E8")]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			[Token(Token = "0x4002037")]
			[FieldOffset(Offset = "0x10")]
			public IDiscoveryListener listener;

			[Token(Token = "0x6002E97")]
			[Address(RVA = "0x133A110", Offset = "0x133A110", VA = "0x133A110")]
			public _003C_003Ec__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6002E98")]
			[Address(RVA = "0x133A5DC", Offset = "0x133A5DC", VA = "0x133A5DC")]
			internal void _003CToDiscoveryListener_003Eb__0(long localClientId, NativeEndpointDetails endpoint)
			{
			}

			[Token(Token = "0x6002E99")]
			[Address(RVA = "0x133A6EC", Offset = "0x133A6EC", VA = "0x133A6EC")]
			internal void _003CToDiscoveryListener_003Eb__1(long localClientId, string lostEndpointId)
			{
			}
		}

		[Token(Token = "0x4000D07")]
		[FieldOffset(Offset = "0x10")]
		private readonly NearbyConnectionsManager mManager;

		[Token(Token = "0x6001182")]
		[Address(RVA = "0x1338D24", Offset = "0x1338D24", VA = "0x1338D24")]
		internal NativeNearbyConnectionsClient(NearbyConnectionsManager manager)
		{
		}

		[Token(Token = "0x6001183")]
		[Address(RVA = "0x1339074", Offset = "0x1339074", VA = "0x1339074", Slot = "4")]
		public int MaxUnreliableMessagePayloadLength()
		{
			return default(int);
		}

		[Token(Token = "0x6001184")]
		[Address(RVA = "0x133907C", Offset = "0x133907C", VA = "0x133907C", Slot = "5")]
		public int MaxReliableMessagePayloadLength()
		{
			return default(int);
		}

		[Token(Token = "0x6001185")]
		[Address(RVA = "0x1339084", Offset = "0x1339084", VA = "0x1339084", Slot = "6")]
		public void SendReliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Token(Token = "0x6001186")]
		[Address(RVA = "0x13393A0", Offset = "0x13393A0", VA = "0x13393A0", Slot = "7")]
		public void SendUnreliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Token(Token = "0x6001187")]
		[Address(RVA = "0x133908C", Offset = "0x133908C", VA = "0x133908C")]
		private void InternalSend(List<string> recipientEndpointIds, byte[] payload, bool isReliable)
		{
		}

		[Token(Token = "0x6001188")]
		[Address(RVA = "0x13393A8", Offset = "0x13393A8", VA = "0x13393A8", Slot = "8")]
		public void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> requestCallback)
		{
		}

		[Token(Token = "0x6001189")]
		[Address(RVA = "0x13396EC", Offset = "0x13396EC", VA = "0x13396EC")]
		private static long ToTimeoutMillis(TimeSpan? span)
		{
			return default(long);
		}

		[Token(Token = "0x600118A")]
		[Address(RVA = "0x133979C", Offset = "0x133979C", VA = "0x133979C", Slot = "9")]
		public void StopAdvertising()
		{
		}

		[Token(Token = "0x600118B")]
		[Address(RVA = "0x13397CC", Offset = "0x13397CC", VA = "0x13397CC", Slot = "10")]
		public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener)
		{
		}

		[Token(Token = "0x600118C")]
		[Address(RVA = "0x1339AC8", Offset = "0x1339AC8", VA = "0x1339AC8")]
		private static NativeMessageListenerHelper ToMessageListener(IMessageListener listener)
		{
			return null;
		}

		[Token(Token = "0x600118D")]
		[Address(RVA = "0x1339CB4", Offset = "0x1339CB4", VA = "0x1339CB4", Slot = "11")]
		public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener)
		{
		}

		[Token(Token = "0x600118E")]
		[Address(RVA = "0x1339DE8", Offset = "0x1339DE8", VA = "0x1339DE8", Slot = "12")]
		public void StartDiscovery(string serviceId, TimeSpan? advertisingTimeout, IDiscoveryListener listener)
		{
		}

		[Token(Token = "0x600118F")]
		[Address(RVA = "0x1339F94", Offset = "0x1339F94", VA = "0x1339F94")]
		private static NativeEndpointDiscoveryListenerHelper ToDiscoveryListener(IDiscoveryListener listener)
		{
			return null;
		}

		[Token(Token = "0x6001190")]
		[Address(RVA = "0x133A188", Offset = "0x133A188", VA = "0x133A188", Slot = "13")]
		public void StopDiscovery(string serviceId)
		{
		}

		[Token(Token = "0x6001191")]
		[Address(RVA = "0x133A210", Offset = "0x133A210", VA = "0x133A210", Slot = "14")]
		public void RejectConnectionRequest(string requestingEndpointId)
		{
		}

		[Token(Token = "0x6001192")]
		[Address(RVA = "0x133A298", Offset = "0x133A298", VA = "0x133A298", Slot = "15")]
		public void DisconnectFromEndpoint(string remoteEndpointId)
		{
		}

		[Token(Token = "0x6001193")]
		[Address(RVA = "0x133A2D0", Offset = "0x133A2D0", VA = "0x133A2D0", Slot = "16")]
		public void StopAllConnections()
		{
		}

		[Token(Token = "0x6001194")]
		[Address(RVA = "0x133A300", Offset = "0x133A300", VA = "0x133A300", Slot = "17")]
		public string GetAppBundleId()
		{
			return null;
		}

		[Token(Token = "0x6001195")]
		[Address(RVA = "0x133A330", Offset = "0x133A330", VA = "0x133A330", Slot = "18")]
		public string GetServiceId()
		{
			return null;
		}
	}
}
