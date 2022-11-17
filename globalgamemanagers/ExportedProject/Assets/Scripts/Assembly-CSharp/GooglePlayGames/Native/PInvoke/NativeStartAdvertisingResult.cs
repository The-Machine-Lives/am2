using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Nearby;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000284")]
	internal class NativeStartAdvertisingResult : BaseReferenceHolder
	{
		[Token(Token = "0x600132F")]
		[Address(RVA = "0xE5D4E4", Offset = "0xE5D4E4", VA = "0xE5D4E4")]
		internal NativeStartAdvertisingResult(IntPtr pointer)
		{
		}

		[Token(Token = "0x6001330")]
		[Address(RVA = "0xE5D55C", Offset = "0xE5D55C", VA = "0xE5D55C")]
		internal int GetStatus()
		{
			return default(int);
		}

		[Token(Token = "0x6001331")]
		[Address(RVA = "0xE5D578", Offset = "0xE5D578", VA = "0xE5D578")]
		internal string LocalEndpointName()
		{
			return null;
		}

		[Token(Token = "0x6001332")]
		[Address(RVA = "0xE5D608", Offset = "0xE5D608", VA = "0xE5D608", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x6001333")]
		[Address(RVA = "0xE5D618", Offset = "0xE5D618", VA = "0xE5D618")]
		internal AdvertisingResult AsResult()
		{
			return default(AdvertisingResult);
		}

		[Token(Token = "0x6001334")]
		[Address(RVA = "0xE5D794", Offset = "0xE5D794", VA = "0xE5D794")]
		internal static NativeStartAdvertisingResult FromPointer(IntPtr pointer)
		{
			return null;
		}

		[Token(Token = "0x6001335")]
		[Address(RVA = "0xE5D80C", Offset = "0xE5D80C", VA = "0xE5D80C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8365C4", Offset = "0x8365C4")]
		private UIntPtr _003CLocalEndpointName_003Eb__2_0(byte[] out_arg, UIntPtr out_size)
		{
			return default(UIntPtr);
		}
	}
}
