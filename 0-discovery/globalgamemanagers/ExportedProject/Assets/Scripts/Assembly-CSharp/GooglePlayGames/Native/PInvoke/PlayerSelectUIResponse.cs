using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200028E")]
	internal class PlayerSelectUIResponse : BaseReferenceHolder, IEnumerable<string>, IEnumerable
	{
		[Token(Token = "0x200071A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E78", Offset = "0x820E78")]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[Token(Token = "0x4002116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlayerSelectUIResponse _003C_003E4__this;

			[Token(Token = "0x4002117")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIntPtr index;

			[Token(Token = "0x6003007")]
			[Address(RVA = "0xE62890", Offset = "0xE62890", VA = "0xE62890")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6003008")]
			[Address(RVA = "0xE62A44", Offset = "0xE62A44", VA = "0xE62A44")]
			internal UIntPtr _003CPlayerIdAtIndex_003Eb__0(byte[] out_string, UIntPtr size)
			{
				return default(UIntPtr);
			}
		}

		[Token(Token = "0x6001398")]
		[Address(RVA = "0xE6271C", Offset = "0xE6271C", VA = "0xE6271C")]
		internal PlayerSelectUIResponse(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x6001399")]
		[Address(RVA = "0xE62794", Offset = "0xE62794", VA = "0xE62794")]
		internal CommonErrorStatus.UIStatus Status()
		{
			return default(CommonErrorStatus.UIStatus);
		}

		[Token(Token = "0x600139A")]
		[Address(RVA = "0xE627B0", Offset = "0xE627B0", VA = "0xE627B0")]
		private string PlayerIdAtIndex(UIntPtr index)
		{
			return null;
		}

		[Token(Token = "0x600139B")]
		[Address(RVA = "0xE62898", Offset = "0xE62898", VA = "0xE62898", Slot = "6")]
		public IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600139C")]
		[Address(RVA = "0xE62964", Offset = "0xE62964", VA = "0xE62964", Slot = "7")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600139D")]
		[Address(RVA = "0xE62968", Offset = "0xE62968", VA = "0xE62968")]
		internal uint MinimumAutomatchingPlayers()
		{
			return default(uint);
		}

		[Token(Token = "0x600139E")]
		[Address(RVA = "0xE62984", Offset = "0xE62984", VA = "0xE62984")]
		internal uint MaximumAutomatchingPlayers()
		{
			return default(uint);
		}

		[Token(Token = "0x600139F")]
		[Address(RVA = "0xE629A0", Offset = "0xE629A0", VA = "0xE629A0", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x60013A0")]
		[Address(RVA = "0xE629B0", Offset = "0xE629B0", VA = "0xE629B0")]
		internal static PlayerSelectUIResponse FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
