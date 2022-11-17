using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000288")]
	internal class NearbyConnectionsManager : BaseReferenceHolder
	{
		[Serializable]
		[Token(Token = "0x2000710")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E38", Offset = "0x820E38")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4002104")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4002105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<NativeAppIdentifier, IntPtr> _003C_003E9__5_0;

			[Token(Token = "0x6002FDD")]
			[Address(RVA = "0xE60374", Offset = "0xE60374", VA = "0xE60374")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6002FDE")]
			[Address(RVA = "0xE6037C", Offset = "0xE6037C", VA = "0xE6037C")]
			internal IntPtr _003CStartAdvertising_003Eb__5_0(NativeAppIdentifier id)
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x4000D22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string sServiceId;

		[Token(Token = "0x170002AB")]
		public string AppBundleId
		{
			[Token(Token = "0x6001371")]
			[Address(RVA = "0xE5FB80", Offset = "0xE5FB80", VA = "0xE5FB80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002AC")]
		public static string ServiceId
		{
			[Token(Token = "0x6001373")]
			[Address(RVA = "0xE60254", Offset = "0xE60254", VA = "0xE60254")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001360")]
		[Address(RVA = "0xE5F3C8", Offset = "0xE5F3C8", VA = "0xE5F3C8")]
		internal NearbyConnectionsManager(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x6001361")]
		[Address(RVA = "0xE5F440", Offset = "0xE5F440", VA = "0xE5F440", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x6001362")]
		[Address(RVA = "0xE5F450", Offset = "0xE5F450", VA = "0xE5F450")]
		internal void SendUnreliable(string remoteEndpointId, byte[] payload)
		{
		}

		[Token(Token = "0x6001363")]
		[Address(RVA = "0xE5F4CC", Offset = "0xE5F4CC", VA = "0xE5F4CC")]
		internal void SendReliable(string remoteEndpointId, byte[] payload)
		{
		}

		[Token(Token = "0x6001364")]
		[Address(RVA = "0xE5F548", Offset = "0xE5F548", VA = "0xE5F548")]
		internal void StartAdvertising(string name, List<NativeAppIdentifier> appIds, long advertisingDuration, Action<long, NativeStartAdvertisingResult> advertisingCallback, Action<long, NativeConnectionRequest> connectionRequestCallback)
		{
		}

		[Token(Token = "0x6001365")]
		[Address(RVA = "0xE5F200", Offset = "0xE5F200", VA = "0xE5F200")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836624", Offset = "0x836624")]
		private static void InternalStartAdvertisingCallback(long id, IntPtr result, IntPtr userData)
		{
		}

		[Token(Token = "0x6001366")]
		[Address(RVA = "0xE5F298", Offset = "0xE5F298", VA = "0xE5F298")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836688", Offset = "0x836688")]
		private static void InternalConnectionRequestCallback(long id, IntPtr result, IntPtr userData)
		{
		}

		[Token(Token = "0x6001367")]
		[Address(RVA = "0xE5F80C", Offset = "0xE5F80C", VA = "0xE5F80C")]
		internal void StopAdvertising()
		{
		}

		[Token(Token = "0x6001368")]
		[Address(RVA = "0xE5F828", Offset = "0xE5F828", VA = "0xE5F828")]
		internal void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<long, NativeConnectionResponse> callback, NativeMessageListenerHelper listener)
		{
		}

		[Token(Token = "0x6001369")]
		[Address(RVA = "0xE5F330", Offset = "0xE5F330", VA = "0xE5F330")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8366EC", Offset = "0x8366EC")]
		private static void InternalConnectResponseCallback(long localClientId, IntPtr response, IntPtr userData)
		{
		}

		[Token(Token = "0x600136A")]
		[Address(RVA = "0xE5F9B4", Offset = "0xE5F9B4", VA = "0xE5F9B4")]
		internal void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, NativeMessageListenerHelper listener)
		{
		}

		[Token(Token = "0x600136B")]
		[Address(RVA = "0xE5FA50", Offset = "0xE5FA50", VA = "0xE5FA50")]
		internal void DisconnectFromEndpoint(string remoteEndpointId)
		{
		}

		[Token(Token = "0x600136C")]
		[Address(RVA = "0xE5FA7C", Offset = "0xE5FA7C", VA = "0xE5FA7C")]
		internal void StopAllConnections()
		{
		}

		[Token(Token = "0x600136D")]
		[Address(RVA = "0xE5FA98", Offset = "0xE5FA98", VA = "0xE5FA98")]
		internal void StartDiscovery(string serviceId, long duration, NativeEndpointDiscoveryListenerHelper listener)
		{
		}

		[Token(Token = "0x600136E")]
		[Address(RVA = "0xE5FB0C", Offset = "0xE5FB0C", VA = "0xE5FB0C")]
		internal void StopDiscovery(string serviceId)
		{
		}

		[Token(Token = "0x600136F")]
		[Address(RVA = "0xE5FB38", Offset = "0xE5FB38", VA = "0xE5FB38")]
		internal void RejectConnectionRequest(string remoteEndpointId)
		{
		}

		[Token(Token = "0x6001370")]
		[Address(RVA = "0xE5FB64", Offset = "0xE5FB64", VA = "0xE5FB64")]
		internal void Shutdown()
		{
		}

		[Token(Token = "0x6001372")]
		[Address(RVA = "0xE5FD28", Offset = "0xE5FD28", VA = "0xE5FD28")]
		internal static string ReadServiceId()
		{
			return null;
		}
	}
}
