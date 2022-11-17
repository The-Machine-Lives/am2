using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000276")]
	internal class NativeEndpointDiscoveryListenerHelper : BaseReferenceHolder
	{
		[Token(Token = "0x60012B6")]
		[Address(RVA = "0xC79C98", Offset = "0xC79C98", VA = "0xC79C98")]
		internal NativeEndpointDiscoveryListenerHelper()
		{
		}

		[Token(Token = "0x60012B7")]
		[Address(RVA = "0xC79D10", Offset = "0xC79D10", VA = "0xC79D10", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x60012B8")]
		[Address(RVA = "0xC79D20", Offset = "0xC79D20", VA = "0xC79D20")]
		internal void SetOnEndpointFound(Action<long, NativeEndpointDetails> callback)
		{
		}

		[Token(Token = "0x60012B9")]
		[Address(RVA = "0xC79A9C", Offset = "0xC79A9C", VA = "0xC79A9C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836324", Offset = "0x836324")]
		private static void InternalOnEndpointFoundCallback(long id, IntPtr data, IntPtr userData)
		{
		}

		[Token(Token = "0x60012BA")]
		[Address(RVA = "0xC79E30", Offset = "0xC79E30", VA = "0xC79E30")]
		internal void SetOnEndpointLostCallback(Action<long, string> callback)
		{
		}

		[Token(Token = "0x60012BB")]
		[Address(RVA = "0xC79B34", Offset = "0xC79B34", VA = "0xC79B34")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836388", Offset = "0x836388")]
		private static void InternalOnEndpointLostCallback(long id, string lostEndpointId, IntPtr userData)
		{
		}
	}
}
