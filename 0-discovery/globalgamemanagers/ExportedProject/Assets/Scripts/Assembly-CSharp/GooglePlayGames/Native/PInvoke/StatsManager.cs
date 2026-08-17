using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000294")]
	internal class StatsManager
	{
		[Token(Token = "0x2000726")]
		internal class FetchForPlayerResponse : BaseReferenceHolder
		{
			[Token(Token = "0x6003049")]
			[Address(RVA = "0xE67EA0", Offset = "0xE67EA0", VA = "0xE67EA0")]
			internal FetchForPlayerResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x600304A")]
			[Address(RVA = "0xE67F18", Offset = "0xE67F18", VA = "0xE67F18")]
			internal CommonErrorStatus.ResponseStatus Status()
			{
				return default(CommonErrorStatus.ResponseStatus);
			}

			[Token(Token = "0x600304B")]
			[Address(RVA = "0xE67F34", Offset = "0xE67F34", VA = "0xE67F34")]
			internal NativePlayerStats PlayerStats()
			{
				return null;
			}

			[Token(Token = "0x600304C")]
			[Address(RVA = "0xE67FB0", Offset = "0xE67FB0", VA = "0xE67FB0", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x600304D")]
			[Address(RVA = "0xE67FC0", Offset = "0xE67FC0", VA = "0xE67FC0")]
			internal static FetchForPlayerResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		[Token(Token = "0x4000D27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly GameServices mServices;

		[Token(Token = "0x60013E1")]
		[Address(RVA = "0xE67CF4", Offset = "0xE67CF4", VA = "0xE67CF4")]
		internal StatsManager(GameServices services)
		{
		}

		[Token(Token = "0x60013E2")]
		[Address(RVA = "0xE67D64", Offset = "0xE67D64", VA = "0xE67D64")]
		internal void FetchForPlayer(Action<FetchForPlayerResponse> callback)
		{
		}

		[Token(Token = "0x60013E3")]
		[Address(RVA = "0xE67C6C", Offset = "0xE67C6C", VA = "0xE67C6C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x83704C", Offset = "0x83704C")]
		private static void InternalFetchForPlayerCallback(IntPtr response, IntPtr data)
		{
		}
	}
}
