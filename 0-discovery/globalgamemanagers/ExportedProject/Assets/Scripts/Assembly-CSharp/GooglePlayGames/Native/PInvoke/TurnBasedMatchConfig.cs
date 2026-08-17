using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000296")]
	internal class TurnBasedMatchConfig : BaseReferenceHolder
	{
		[Token(Token = "0x200072B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820EA8", Offset = "0x820EA8")]
		private sealed class _003C_003Ec__DisplayClass1_0
		{
			[Token(Token = "0x400211B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TurnBasedMatchConfig _003C_003E4__this;

			[Token(Token = "0x400211C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIntPtr index;

			[Token(Token = "0x600306D")]
			[Address(RVA = "0xE6A8CC", Offset = "0xE6A8CC", VA = "0xE6A8CC")]
			public _003C_003Ec__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600306E")]
			[Address(RVA = "0xE6AA20", Offset = "0xE6AA20", VA = "0xE6AA20")]
			internal UIntPtr _003CPlayerIdAtIndex_003Eb__0(byte[] out_string, UIntPtr size)
			{
				return default(UIntPtr);
			}
		}

		[Token(Token = "0x60013FA")]
		[Address(RVA = "0xE6A774", Offset = "0xE6A774", VA = "0xE6A774")]
		internal TurnBasedMatchConfig(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x60013FB")]
		[Address(RVA = "0xE6A7EC", Offset = "0xE6A7EC", VA = "0xE6A7EC")]
		private string PlayerIdAtIndex(UIntPtr index)
		{
			return null;
		}

		[Token(Token = "0x60013FC")]
		[Address(RVA = "0xE6A8D4", Offset = "0xE6A8D4", VA = "0xE6A8D4")]
		internal IEnumerator<string> PlayerIdsToInvite()
		{
			return null;
		}

		[Token(Token = "0x60013FD")]
		[Address(RVA = "0xE6A9A0", Offset = "0xE6A9A0", VA = "0xE6A9A0")]
		internal uint Variant()
		{
			return default(uint);
		}

		[Token(Token = "0x60013FE")]
		[Address(RVA = "0xE6A9BC", Offset = "0xE6A9BC", VA = "0xE6A9BC")]
		internal long ExclusiveBitMask()
		{
			return default(long);
		}

		[Token(Token = "0x60013FF")]
		[Address(RVA = "0xE6A9D8", Offset = "0xE6A9D8", VA = "0xE6A9D8")]
		internal uint MinimumAutomatchingPlayers()
		{
			return default(uint);
		}

		[Token(Token = "0x6001400")]
		[Address(RVA = "0xE6A9F4", Offset = "0xE6A9F4", VA = "0xE6A9F4")]
		internal uint MaximumAutomatchingPlayers()
		{
			return default(uint);
		}

		[Token(Token = "0x6001401")]
		[Address(RVA = "0xE6AA10", Offset = "0xE6AA10", VA = "0xE6AA10", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}
	}
}
