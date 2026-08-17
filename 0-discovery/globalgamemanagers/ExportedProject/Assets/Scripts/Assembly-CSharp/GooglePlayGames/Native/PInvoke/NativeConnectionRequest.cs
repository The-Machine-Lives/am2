using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Nearby;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000273")]
	internal class NativeConnectionRequest : BaseReferenceHolder
	{
		[Token(Token = "0x6001299")]
		[Address(RVA = "0xC78D08", Offset = "0xC78D08", VA = "0xC78D08")]
		internal NativeConnectionRequest(IntPtr pointer)
		{
		}

		[Token(Token = "0x600129A")]
		[Address(RVA = "0xC78D7C", Offset = "0xC78D7C", VA = "0xC78D7C")]
		internal string RemoteEndpointId()
		{
			return null;
		}

		[Token(Token = "0x600129B")]
		[Address(RVA = "0xC78E10", Offset = "0xC78E10", VA = "0xC78E10")]
		internal string RemoteEndpointName()
		{
			return null;
		}

		[Token(Token = "0x600129C")]
		[Address(RVA = "0xC78EA4", Offset = "0xC78EA4", VA = "0xC78EA4")]
		internal byte[] Payload()
		{
			return null;
		}

		[Token(Token = "0x600129D")]
		[Address(RVA = "0xC78F48", Offset = "0xC78F48", VA = "0xC78F48", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x600129E")]
		[Address(RVA = "0xC78F58", Offset = "0xC78F58", VA = "0xC78F58")]
		internal ConnectionRequest AsRequest()
		{
			return default(ConnectionRequest);
		}

		[Token(Token = "0x600129F")]
		[Address(RVA = "0xC7901C", Offset = "0xC7901C", VA = "0xC7901C")]
		internal static NativeConnectionRequest FromPointer(IntPtr pointer)
		{
			return null;
		}

		[Token(Token = "0x60012A0")]
		[Address(RVA = "0xC79094", Offset = "0xC79094", VA = "0xC79094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8362A4", Offset = "0x8362A4")]
		private UIntPtr _003CRemoteEndpointId_003Eb__1_0(byte[] out_arg, UIntPtr out_size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x60012A1")]
		[Address(RVA = "0xC790C4", Offset = "0xC790C4", VA = "0xC790C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8362B4", Offset = "0x8362B4")]
		private UIntPtr _003CRemoteEndpointName_003Eb__2_0(byte[] out_arg, UIntPtr out_size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x60012A2")]
		[Address(RVA = "0xC790F4", Offset = "0xC790F4", VA = "0xC790F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8362C4", Offset = "0x8362C4")]
		private UIntPtr _003CPayload_003Eb__3_0(byte[] out_arg, UIntPtr out_size)
		{
			return default(UIntPtr);
		}
	}
}
