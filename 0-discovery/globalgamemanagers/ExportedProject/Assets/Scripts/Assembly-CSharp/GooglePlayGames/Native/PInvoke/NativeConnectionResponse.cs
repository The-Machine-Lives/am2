using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000274")]
	internal class NativeConnectionResponse : BaseReferenceHolder
	{
		[Token(Token = "0x60012A3")]
		[Address(RVA = "0xC79124", Offset = "0xC79124", VA = "0xC79124")]
		internal NativeConnectionResponse(IntPtr pointer)
		{
		}

		[Token(Token = "0x60012A4")]
		[Address(RVA = "0xC79198", Offset = "0xC79198", VA = "0xC79198")]
		internal string RemoteEndpointId()
		{
			return null;
		}

		[Token(Token = "0x60012A5")]
		[Address(RVA = "0xC7922C", Offset = "0xC7922C", VA = "0xC7922C")]
		internal NearbyConnectionTypes.ConnectionResponse_ResponseCode ResponseCode()
		{
			return default(NearbyConnectionTypes.ConnectionResponse_ResponseCode);
		}

		[Token(Token = "0x60012A6")]
		[Address(RVA = "0xC79244", Offset = "0xC79244", VA = "0xC79244")]
		internal byte[] Payload()
		{
			return null;
		}

		[Token(Token = "0x60012A7")]
		[Address(RVA = "0xC792E8", Offset = "0xC792E8", VA = "0xC792E8", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x60012A8")]
		[Address(RVA = "0xC792F8", Offset = "0xC792F8", VA = "0xC792F8")]
		internal ConnectionResponse AsResponse(long localClientId)
		{
			return default(ConnectionResponse);
		}

		[Token(Token = "0x60012A9")]
		[Address(RVA = "0xC795F8", Offset = "0xC795F8", VA = "0xC795F8")]
		internal static NativeConnectionResponse FromPointer(IntPtr pointer)
		{
			return null;
		}

		[Token(Token = "0x60012AA")]
		[Address(RVA = "0xC79670", Offset = "0xC79670", VA = "0xC79670")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8362D4", Offset = "0x8362D4")]
		private UIntPtr _003CRemoteEndpointId_003Eb__1_0(byte[] out_arg, UIntPtr out_size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x60012AB")]
		[Address(RVA = "0xC796A0", Offset = "0xC796A0", VA = "0xC796A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8362E4", Offset = "0x8362E4")]
		private UIntPtr _003CPayload_003Eb__3_0(byte[] out_arg, UIntPtr out_size)
		{
			return default(UIntPtr);
		}
	}
}
