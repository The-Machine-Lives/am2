using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000297")]
	internal class TurnBasedMatchConfigBuilder : BaseReferenceHolder
	{
		[Token(Token = "0x6001402")]
		[Address(RVA = "0xE6AA78", Offset = "0xE6AA78", VA = "0xE6AA78")]
		private TurnBasedMatchConfigBuilder(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x6001403")]
		[Address(RVA = "0xE6AAF0", Offset = "0xE6AAF0", VA = "0xE6AAF0")]
		internal TurnBasedMatchConfigBuilder PopulateFromUIResponse(PlayerSelectUIResponse response)
		{
			return null;
		}

		[Token(Token = "0x6001404")]
		[Address(RVA = "0xE6AB58", Offset = "0xE6AB58", VA = "0xE6AB58")]
		internal TurnBasedMatchConfigBuilder SetVariant(uint variant)
		{
			return null;
		}

		[Token(Token = "0x6001405")]
		[Address(RVA = "0xE6AB90", Offset = "0xE6AB90", VA = "0xE6AB90")]
		internal TurnBasedMatchConfigBuilder AddInvitedPlayer(string playerId)
		{
			return null;
		}

		[Token(Token = "0x6001406")]
		[Address(RVA = "0xE6ABC8", Offset = "0xE6ABC8", VA = "0xE6ABC8")]
		internal TurnBasedMatchConfigBuilder SetExclusiveBitMask(ulong bitmask)
		{
			return null;
		}

		[Token(Token = "0x6001407")]
		[Address(RVA = "0xE6AC00", Offset = "0xE6AC00", VA = "0xE6AC00")]
		internal TurnBasedMatchConfigBuilder SetMinimumAutomatchingPlayers(uint minimum)
		{
			return null;
		}

		[Token(Token = "0x6001408")]
		[Address(RVA = "0xE6AC38", Offset = "0xE6AC38", VA = "0xE6AC38")]
		internal TurnBasedMatchConfigBuilder SetMaximumAutomatchingPlayers(uint maximum)
		{
			return null;
		}

		[Token(Token = "0x6001409")]
		[Address(RVA = "0xE6AC70", Offset = "0xE6AC70", VA = "0xE6AC70")]
		internal TurnBasedMatchConfig Build()
		{
			return null;
		}

		[Token(Token = "0x600140A")]
		[Address(RVA = "0xE6ACEC", Offset = "0xE6ACEC", VA = "0xE6ACEC", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x600140B")]
		[Address(RVA = "0xE6ACFC", Offset = "0xE6ACFC", VA = "0xE6ACFC")]
		internal static TurnBasedMatchConfigBuilder Create()
		{
			return null;
		}
	}
}
