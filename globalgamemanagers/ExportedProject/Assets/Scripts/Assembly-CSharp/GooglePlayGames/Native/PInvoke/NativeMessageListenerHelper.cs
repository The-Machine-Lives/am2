using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000279")]
	internal class NativeMessageListenerHelper : BaseReferenceHolder
	{
		[Token(Token = "0x200070E")]
		internal delegate void OnMessageReceived(long localClientId, string remoteEndpointId, byte[] data, bool isReliable);

		[Token(Token = "0x60012CE")]
		[Address(RVA = "0xE5A57C", Offset = "0xE5A57C", VA = "0xE5A57C")]
		internal NativeMessageListenerHelper()
		{
		}

		[Token(Token = "0x60012CF")]
		[Address(RVA = "0xE5A5F8", Offset = "0xE5A5F8", VA = "0xE5A5F8", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x60012D0")]
		[Address(RVA = "0xE5A608", Offset = "0xE5A608", VA = "0xE5A608")]
		internal void SetOnMessageReceivedCallback(OnMessageReceived callback)
		{
		}

		[Token(Token = "0x60012D1")]
		[Address(RVA = "0xE5A268", Offset = "0xE5A268", VA = "0xE5A268")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x83643C", Offset = "0x83643C")]
		private static void InternalOnMessageReceivedCallback(long id, string name, IntPtr data, UIntPtr dataLength, bool isReliable, IntPtr userData)
		{
		}

		[Token(Token = "0x60012D2")]
		[Address(RVA = "0xE5AC9C", Offset = "0xE5AC9C", VA = "0xE5AC9C")]
		internal void SetOnDisconnectedCallback(Action<long, string> callback)
		{
		}

		[Token(Token = "0x60012D3")]
		[Address(RVA = "0xE5A41C", Offset = "0xE5A41C", VA = "0xE5A41C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8364A0", Offset = "0x8364A0")]
		private static void InternalOnDisconnectedCallback(long id, string lostEndpointId, IntPtr userData)
		{
		}
	}
}
