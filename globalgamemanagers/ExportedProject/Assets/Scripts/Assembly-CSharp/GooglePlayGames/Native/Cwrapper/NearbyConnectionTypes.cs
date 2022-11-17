using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002AF")]
	internal static class NearbyConnectionTypes
	{
		[Token(Token = "0x2000752")]
		internal enum ConnectionResponse_ResponseCode
		{
			[Token(Token = "0x4002160")]
			ACCEPTED = 1,
			[Token(Token = "0x4002161")]
			REJECTED = 2,
			[Token(Token = "0x4002162")]
			ERROR_INTERNAL = -1,
			[Token(Token = "0x4002163")]
			ERROR_NETWORK_NOT_CONNECTED = -2,
			[Token(Token = "0x4002164")]
			ERROR_ENDPOINT_ALREADY_CONNECTED = -3,
			[Token(Token = "0x4002165")]
			ERROR_ENDPOINT_NOT_CONNECTED = -4
		}

		[Token(Token = "0x2000753")]
		internal delegate void ConnectionRequestCallback(long arg0, IntPtr arg1, IntPtr arg2);

		[Token(Token = "0x2000754")]
		internal delegate void StartAdvertisingCallback(long arg0, IntPtr arg1, IntPtr arg2);

		[Token(Token = "0x2000755")]
		internal delegate void ConnectionResponseCallback(long arg0, IntPtr arg1, IntPtr arg2);

		[PreserveSig]
		[Token(Token = "0x60014CA")]
		[Address(RVA = "0x1477984", Offset = "0x1477984", VA = "0x1477984")]
		internal static extern void AppIdentifier_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014CB")]
		[Address(RVA = "0x1477A20", Offset = "0x1477A20", VA = "0x1477A20")]
		internal static extern UIntPtr AppIdentifier_GetIdentifier(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60014CC")]
		[Address(RVA = "0x1477ADC", Offset = "0x1477ADC", VA = "0x1477ADC")]
		internal static extern void StartAdvertisingResult_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014CD")]
		[Address(RVA = "0x1477B78", Offset = "0x1477B78", VA = "0x1477B78")]
		internal static extern int StartAdvertisingResult_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014CE")]
		[Address(RVA = "0x1477C14", Offset = "0x1477C14", VA = "0x1477C14")]
		internal static extern UIntPtr StartAdvertisingResult_GetLocalEndpointName(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60014CF")]
		[Address(RVA = "0x1477CD0", Offset = "0x1477CD0", VA = "0x1477CD0")]
		internal static extern void EndpointDetails_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014D0")]
		[Address(RVA = "0x1477D6C", Offset = "0x1477D6C", VA = "0x1477D6C")]
		internal static extern UIntPtr EndpointDetails_GetEndpointId(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60014D1")]
		[Address(RVA = "0x1477E28", Offset = "0x1477E28", VA = "0x1477E28")]
		internal static extern UIntPtr EndpointDetails_GetName(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60014D2")]
		[Address(RVA = "0x1477EE4", Offset = "0x1477EE4", VA = "0x1477EE4")]
		internal static extern UIntPtr EndpointDetails_GetServiceId(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60014D3")]
		[Address(RVA = "0x1477FA0", Offset = "0x1477FA0", VA = "0x1477FA0")]
		internal static extern void ConnectionRequest_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014D4")]
		[Address(RVA = "0x147803C", Offset = "0x147803C", VA = "0x147803C")]
		internal static extern UIntPtr ConnectionRequest_GetRemoteEndpointId(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60014D5")]
		[Address(RVA = "0x14780F8", Offset = "0x14780F8", VA = "0x14780F8")]
		internal static extern UIntPtr ConnectionRequest_GetRemoteEndpointName(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60014D6")]
		[Address(RVA = "0x14781B4", Offset = "0x14781B4", VA = "0x14781B4")]
		internal static extern UIntPtr ConnectionRequest_GetPayload(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60014D7")]
		[Address(RVA = "0x1478270", Offset = "0x1478270", VA = "0x1478270")]
		internal static extern void ConnectionResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014D8")]
		[Address(RVA = "0x147830C", Offset = "0x147830C", VA = "0x147830C")]
		internal static extern UIntPtr ConnectionResponse_GetRemoteEndpointId(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60014D9")]
		[Address(RVA = "0x14783C8", Offset = "0x14783C8", VA = "0x14783C8")]
		internal static extern ConnectionResponse_ResponseCode ConnectionResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014DA")]
		[Address(RVA = "0x1478464", Offset = "0x1478464", VA = "0x1478464")]
		internal static extern UIntPtr ConnectionResponse_GetPayload(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);
	}
}
