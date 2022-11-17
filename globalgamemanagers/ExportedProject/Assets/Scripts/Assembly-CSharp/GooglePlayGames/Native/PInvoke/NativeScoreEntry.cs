using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200027E")]
	internal class NativeScoreEntry : BaseReferenceHolder
	{
		[Token(Token = "0x4000D21")]
		private const ulong MinusOne = ulong.MaxValue;

		[Token(Token = "0x6001301")]
		[Address(RVA = "0xE5BDF4", Offset = "0xE5BDF4", VA = "0xE5BDF4")]
		internal NativeScoreEntry(IntPtr selfPtr)
		{
		}

		[Token(Token = "0x6001302")]
		[Address(RVA = "0xE5BE6C", Offset = "0xE5BE6C", VA = "0xE5BE6C", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x6001303")]
		[Address(RVA = "0xE5BE7C", Offset = "0xE5BE7C", VA = "0xE5BE7C")]
		internal ulong GetLastModifiedTime()
		{
			return default(ulong);
		}

		[Token(Token = "0x6001304")]
		[Address(RVA = "0xE5BE98", Offset = "0xE5BE98", VA = "0xE5BE98")]
		internal string GetPlayerId()
		{
			return null;
		}

		[Token(Token = "0x6001305")]
		[Address(RVA = "0xE5BF28", Offset = "0xE5BF28", VA = "0xE5BF28")]
		internal NativeScore GetScore()
		{
			return null;
		}

		[Token(Token = "0x6001306")]
		[Address(RVA = "0xE5BFA4", Offset = "0xE5BFA4", VA = "0xE5BFA4")]
		internal PlayGamesScore AsScore(string leaderboardId)
		{
			return null;
		}

		[Token(Token = "0x6001307")]
		[Address(RVA = "0xE5C11C", Offset = "0xE5C11C", VA = "0xE5C11C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836564", Offset = "0x836564")]
		private UIntPtr _003CGetPlayerId_003Eb__4_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}
	}
}
