using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000292")]
	internal class RealtimeRoomConfigBuilder : BaseReferenceHolder
	{
		[Token(Token = "0x60013C9")]
		[Address(RVA = "0xE65BA8", Offset = "0xE65BA8", VA = "0xE65BA8")]
		internal RealtimeRoomConfigBuilder(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x60013CA")]
		[Address(RVA = "0xE65C20", Offset = "0xE65C20", VA = "0xE65C20")]
		internal RealtimeRoomConfigBuilder PopulateFromUIResponse(PlayerSelectUIResponse response)
		{
			return null;
		}

		[Token(Token = "0x60013CB")]
		[Address(RVA = "0xE65C88", Offset = "0xE65C88", VA = "0xE65C88")]
		internal RealtimeRoomConfigBuilder SetVariant(uint variantValue)
		{
			return null;
		}

		[Token(Token = "0x60013CC")]
		[Address(RVA = "0xE65CC4", Offset = "0xE65CC4", VA = "0xE65CC4")]
		internal RealtimeRoomConfigBuilder AddInvitedPlayer(string playerId)
		{
			return null;
		}

		[Token(Token = "0x60013CD")]
		[Address(RVA = "0xE65CFC", Offset = "0xE65CFC", VA = "0xE65CFC")]
		internal RealtimeRoomConfigBuilder SetExclusiveBitMask(ulong bitmask)
		{
			return null;
		}

		[Token(Token = "0x60013CE")]
		[Address(RVA = "0xE65D34", Offset = "0xE65D34", VA = "0xE65D34")]
		internal RealtimeRoomConfigBuilder SetMinimumAutomatchingPlayers(uint minimum)
		{
			return null;
		}

		[Token(Token = "0x60013CF")]
		[Address(RVA = "0xE65D6C", Offset = "0xE65D6C", VA = "0xE65D6C")]
		internal RealtimeRoomConfigBuilder SetMaximumAutomatchingPlayers(uint maximum)
		{
			return null;
		}

		[Token(Token = "0x60013D0")]
		[Address(RVA = "0xE65DA4", Offset = "0xE65DA4", VA = "0xE65DA4")]
		internal RealtimeRoomConfig Build()
		{
			return null;
		}

		[Token(Token = "0x60013D1")]
		[Address(RVA = "0xE65E20", Offset = "0xE65E20", VA = "0xE65E20", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x60013D2")]
		[Address(RVA = "0xE65E30", Offset = "0xE65E30", VA = "0xE65E30")]
		internal static RealtimeRoomConfigBuilder Create()
		{
			return null;
		}
	}
}
