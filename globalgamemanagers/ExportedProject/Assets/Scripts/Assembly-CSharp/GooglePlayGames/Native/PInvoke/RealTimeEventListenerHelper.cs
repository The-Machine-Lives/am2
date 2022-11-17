using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200028F")]
	internal class RealTimeEventListenerHelper : BaseReferenceHolder
	{
		[Token(Token = "0x200071B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E88", Offset = "0x820E88")]
		private sealed class _003C_003Ec__DisplayClass15_0
		{
			[Token(Token = "0x4002118")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<NativeRealTimeRoom> callback;

			[Token(Token = "0x6003009")]
			[Address(RVA = "0xE63C84", Offset = "0xE63C84", VA = "0xE63C84")]
			public _003C_003Ec__DisplayClass15_0()
			{
			}

			[Token(Token = "0x600300A")]
			[Address(RVA = "0xE63CF8", Offset = "0xE63CF8", VA = "0xE63CF8")]
			internal void _003CToCallbackPointer_003Eb__0(IntPtr result)
			{
			}
		}

		[Token(Token = "0x60013A1")]
		[Address(RVA = "0xE631A0", Offset = "0xE631A0", VA = "0xE631A0")]
		internal RealTimeEventListenerHelper(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x60013A2")]
		[Address(RVA = "0xE63218", Offset = "0xE63218", VA = "0xE63218", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x60013A3")]
		[Address(RVA = "0xE63228", Offset = "0xE63228", VA = "0xE63228")]
		internal RealTimeEventListenerHelper SetOnRoomStatusChangedCallback(Action<NativeRealTimeRoom> callback)
		{
			return null;
		}

		[Token(Token = "0x60013A4")]
		[Address(RVA = "0xE62A9C", Offset = "0xE62A9C", VA = "0xE62A9C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836944", Offset = "0x836944")]
		internal static void InternalOnRoomStatusChangedCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x60013A5")]
		[Address(RVA = "0xE633A8", Offset = "0xE633A8", VA = "0xE633A8")]
		internal RealTimeEventListenerHelper SetOnRoomConnectedSetChangedCallback(Action<NativeRealTimeRoom> callback)
		{
			return null;
		}

		[Token(Token = "0x60013A6")]
		[Address(RVA = "0xE62B24", Offset = "0xE62B24", VA = "0xE62B24")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8369A8", Offset = "0x8369A8")]
		internal static void InternalOnRoomConnectedSetChangedCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x60013A7")]
		[Address(RVA = "0xE63460", Offset = "0xE63460", VA = "0xE63460")]
		internal RealTimeEventListenerHelper SetOnP2PConnectedCallback(Action<NativeRealTimeRoom, MultiplayerParticipant> callback)
		{
			return null;
		}

		[Token(Token = "0x60013A8")]
		[Address(RVA = "0xE62BAC", Offset = "0xE62BAC", VA = "0xE62BAC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836A0C", Offset = "0x836A0C")]
		internal static void InternalOnP2PConnectedCallback(IntPtr room, IntPtr participant, IntPtr data)
		{
		}

		[Token(Token = "0x60013A9")]
		[Address(RVA = "0xE63974", Offset = "0xE63974", VA = "0xE63974")]
		internal RealTimeEventListenerHelper SetOnP2PDisconnectedCallback(Action<NativeRealTimeRoom, MultiplayerParticipant> callback)
		{
			return null;
		}

		[Token(Token = "0x60013AA")]
		[Address(RVA = "0xE62C14", Offset = "0xE62C14", VA = "0xE62C14")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836A70", Offset = "0x836A70")]
		internal static void InternalOnP2PDisconnectedCallback(IntPtr room, IntPtr participant, IntPtr data)
		{
		}

		[Token(Token = "0x60013AB")]
		[Address(RVA = "0xE63A50", Offset = "0xE63A50", VA = "0xE63A50")]
		internal RealTimeEventListenerHelper SetOnParticipantStatusChangedCallback(Action<NativeRealTimeRoom, MultiplayerParticipant> callback)
		{
			return null;
		}

		[Token(Token = "0x60013AC")]
		[Address(RVA = "0xE62C7C", Offset = "0xE62C7C", VA = "0xE62C7C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836AD4", Offset = "0x836AD4")]
		internal static void InternalOnParticipantStatusChangedCallback(IntPtr room, IntPtr participant, IntPtr data)
		{
		}

		[Token(Token = "0x60013AD")]
		[Address(RVA = "0xE6353C", Offset = "0xE6353C", VA = "0xE6353C")]
		internal static void PerformRoomAndParticipantCallback(string callbackName, IntPtr room, IntPtr participant, IntPtr data)
		{
		}

		[Token(Token = "0x60013AE")]
		[Address(RVA = "0xE63B2C", Offset = "0xE63B2C", VA = "0xE63B2C")]
		internal RealTimeEventListenerHelper SetOnDataReceivedCallback(Action<NativeRealTimeRoom, MultiplayerParticipant, byte[], bool> callback)
		{
			return null;
		}

		[Token(Token = "0x60013AF")]
		[Address(RVA = "0xE62CE4", Offset = "0xE62CE4", VA = "0xE62CE4")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836B38", Offset = "0x836B38")]
		internal static void InternalOnDataReceived(IntPtr room, IntPtr participant, IntPtr data, UIntPtr dataLength, bool isReliable, IntPtr userData)
		{
		}

		[Token(Token = "0x60013B0")]
		[Address(RVA = "0xE632E0", Offset = "0xE632E0", VA = "0xE632E0")]
		private static IntPtr ToCallbackPointer(Action<NativeRealTimeRoom> callback)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60013B1")]
		[Address(RVA = "0xE63C8C", Offset = "0xE63C8C", VA = "0xE63C8C")]
		internal static RealTimeEventListenerHelper Create()
		{
			return null;
		}
	}
}
