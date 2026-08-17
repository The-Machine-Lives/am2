using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002AC")]
	internal static class NearbyConnections
	{
		[PreserveSig]
		[Token(Token = "0x60014B7")]
		[Address(RVA = "0x1479594", Offset = "0x1479594", VA = "0x1479594")]
		internal static extern void NearbyConnections_StartDiscovery(HandleRef self, string service_id, long duration, IntPtr helper);

		[PreserveSig]
		[Token(Token = "0x60014B8")]
		[Address(RVA = "0x1479668", Offset = "0x1479668", VA = "0x1479668")]
		internal static extern void NearbyConnections_RejectConnectionRequest(HandleRef self, string remote_endpoint_id);

		[PreserveSig]
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x1479728", Offset = "0x1479728", VA = "0x1479728")]
		internal static extern void NearbyConnections_Disconnect(HandleRef self, string remote_endpoint_id);

		[PreserveSig]
		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x14797E8", Offset = "0x14797E8", VA = "0x14797E8")]
		internal static extern void NearbyConnections_SendUnreliableMessage(HandleRef self, string remote_endpoint_id, byte[] payload, UIntPtr payload_size);

		[PreserveSig]
		[Token(Token = "0x60014BB")]
		[Address(RVA = "0x14798C8", Offset = "0x14798C8", VA = "0x14798C8")]
		internal static extern void NearbyConnections_StopAdvertising(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014BC")]
		[Address(RVA = "0x1479964", Offset = "0x1479964", VA = "0x1479964")]
		internal static extern void NearbyConnections_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014BD")]
		[Address(RVA = "0x1479A00", Offset = "0x1479A00", VA = "0x1479A00")]
		internal static extern void NearbyConnections_SendReliableMessage(HandleRef self, string remote_endpoint_id, byte[] payload, UIntPtr payload_size);

		[PreserveSig]
		[Token(Token = "0x60014BE")]
		[Address(RVA = "0x1479AE0", Offset = "0x1479AE0", VA = "0x1479AE0")]
		internal static extern void NearbyConnections_StopDiscovery(HandleRef self, string service_id);

		[PreserveSig]
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x1479BA0", Offset = "0x1479BA0", VA = "0x1479BA0")]
		internal static extern void NearbyConnections_SendConnectionRequest(HandleRef self, string name, string remote_endpoint_id, byte[] payload, UIntPtr payload_size, NearbyConnectionTypes.ConnectionResponseCallback callback, IntPtr callback_arg, IntPtr helper);

		[PreserveSig]
		[Token(Token = "0x60014C0")]
		[Address(RVA = "0x1479CD0", Offset = "0x1479CD0", VA = "0x1479CD0")]
		internal static extern void NearbyConnections_StartAdvertising(HandleRef self, string name, IntPtr[] app_identifiers, UIntPtr app_identifiers_size, long duration, NearbyConnectionTypes.StartAdvertisingCallback start_advertising_callback, IntPtr start_advertising_callback_arg, NearbyConnectionTypes.ConnectionRequestCallback request_callback, IntPtr request_callback_arg);

		[PreserveSig]
		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x1479DFC", Offset = "0x1479DFC", VA = "0x1479DFC")]
		internal static extern void NearbyConnections_Stop(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014C2")]
		[Address(RVA = "0x1479E98", Offset = "0x1479E98", VA = "0x1479E98")]
		internal static extern void NearbyConnections_AcceptConnectionRequest(HandleRef self, string remote_endpoint_id, byte[] payload, UIntPtr payload_size, IntPtr helper);
	}
}
