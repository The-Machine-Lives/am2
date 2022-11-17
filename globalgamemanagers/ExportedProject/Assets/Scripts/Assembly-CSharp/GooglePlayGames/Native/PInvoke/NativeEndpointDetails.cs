using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Nearby;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000275")]
	internal class NativeEndpointDetails : BaseReferenceHolder
	{
		[Token(Token = "0x60012AC")]
		[Address(RVA = "0xC796D0", Offset = "0xC796D0", VA = "0xC796D0")]
		internal NativeEndpointDetails(IntPtr pointer)
		{
		}

		[Token(Token = "0x60012AD")]
		[Address(RVA = "0xC79744", Offset = "0xC79744", VA = "0xC79744")]
		internal string EndpointId()
		{
			return null;
		}

		[Token(Token = "0x60012AE")]
		[Address(RVA = "0xC797D8", Offset = "0xC797D8", VA = "0xC797D8")]
		internal string Name()
		{
			return null;
		}

		[Token(Token = "0x60012AF")]
		[Address(RVA = "0xC7986C", Offset = "0xC7986C", VA = "0xC7986C")]
		internal string ServiceId()
		{
			return null;
		}

		[Token(Token = "0x60012B0")]
		[Address(RVA = "0xC79900", Offset = "0xC79900", VA = "0xC79900", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x60012B1")]
		[Address(RVA = "0xC79910", Offset = "0xC79910", VA = "0xC79910")]
		internal EndpointDetails ToDetails()
		{
			return default(EndpointDetails);
		}

		[Token(Token = "0x60012B2")]
		[Address(RVA = "0xC79970", Offset = "0xC79970", VA = "0xC79970")]
		internal static NativeEndpointDetails FromPointer(IntPtr pointer)
		{
			return null;
		}

		[Token(Token = "0x60012B3")]
		[Address(RVA = "0xC79A0C", Offset = "0xC79A0C", VA = "0xC79A0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8362F4", Offset = "0x8362F4")]
		private UIntPtr _003CEndpointId_003Eb__1_0(byte[] out_arg, UIntPtr out_size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x60012B4")]
		[Address(RVA = "0xC79A3C", Offset = "0xC79A3C", VA = "0xC79A3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836304", Offset = "0x836304")]
		private UIntPtr _003CName_003Eb__2_0(byte[] out_arg, UIntPtr out_size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x60012B5")]
		[Address(RVA = "0xC79A6C", Offset = "0xC79A6C", VA = "0xC79A6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836314", Offset = "0x836314")]
		private UIntPtr _003CServiceId_003Eb__3_0(byte[] out_arg, UIntPtr out_size)
		{
			return default(UIntPtr);
		}
	}
}
