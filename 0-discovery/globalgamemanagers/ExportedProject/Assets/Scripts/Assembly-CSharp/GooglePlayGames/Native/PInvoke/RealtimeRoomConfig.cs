using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000291")]
	internal class RealtimeRoomConfig : BaseReferenceHolder
	{
		[Token(Token = "0x60013C6")]
		[Address(RVA = "0xE65A84", Offset = "0xE65A84", VA = "0xE65A84")]
		internal RealtimeRoomConfig(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x60013C7")]
		[Address(RVA = "0xE65AFC", Offset = "0xE65AFC", VA = "0xE65AFC", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x60013C8")]
		[Address(RVA = "0xE65B0C", Offset = "0xE65B0C", VA = "0xE65B0C")]
		internal static RealtimeRoomConfig FromPointer(IntPtr selfPointer)
		{
			return null;
		}
	}
}
