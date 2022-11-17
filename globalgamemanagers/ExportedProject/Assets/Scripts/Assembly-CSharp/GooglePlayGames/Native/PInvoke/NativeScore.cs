using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200027D")]
	internal class NativeScore : BaseReferenceHolder
	{
		[Token(Token = "0x4000D20")]
		private const ulong MinusOne = ulong.MaxValue;

		[Token(Token = "0x60012F8")]
		[Address(RVA = "0xE5B9D4", Offset = "0xE5B9D4", VA = "0xE5B9D4")]
		internal NativeScore(IntPtr selfPtr)
		{
		}

		[Token(Token = "0x60012F9")]
		[Address(RVA = "0xE5BA4C", Offset = "0xE5BA4C", VA = "0xE5BA4C", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x60012FA")]
		[Address(RVA = "0xE5BA68", Offset = "0xE5BA68", VA = "0xE5BA68")]
		internal ulong GetDate()
		{
			return default(ulong);
		}

		[Token(Token = "0x60012FB")]
		[Address(RVA = "0xE5BA70", Offset = "0xE5BA70", VA = "0xE5BA70")]
		internal string GetMetadata()
		{
			return null;
		}

		[Token(Token = "0x60012FC")]
		[Address(RVA = "0xE5BB00", Offset = "0xE5BB00", VA = "0xE5BB00")]
		internal ulong GetRank()
		{
			return default(ulong);
		}

		[Token(Token = "0x60012FD")]
		[Address(RVA = "0xE5BB1C", Offset = "0xE5BB1C", VA = "0xE5BB1C")]
		internal ulong GetValue()
		{
			return default(ulong);
		}

		[Token(Token = "0x60012FE")]
		[Address(RVA = "0xE5BB38", Offset = "0xE5BB38", VA = "0xE5BB38")]
		internal PlayGamesScore AsScore(string leaderboardId, string selfPlayerId)
		{
			return null;
		}

		[Token(Token = "0x60012FF")]
		[Address(RVA = "0xE5BD24", Offset = "0xE5BD24", VA = "0xE5BD24")]
		internal static NativeScore FromPointer(IntPtr pointer)
		{
			return null;
		}

		[Token(Token = "0x6001300")]
		[Address(RVA = "0xE5BDC0", Offset = "0xE5BDC0", VA = "0xE5BDC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836554", Offset = "0x836554")]
		private UIntPtr _003CGetMetadata_003Eb__4_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}
	}
}
