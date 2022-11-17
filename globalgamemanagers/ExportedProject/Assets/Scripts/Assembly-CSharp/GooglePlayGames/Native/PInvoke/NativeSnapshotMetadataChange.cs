using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.SavedGame;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000283")]
	internal class NativeSnapshotMetadataChange : BaseReferenceHolder
	{
		[Token(Token = "0x200070F")]
		internal class Builder : BaseReferenceHolder
		{
			[Token(Token = "0x6002FD5")]
			[Address(RVA = "0xE5D1B8", Offset = "0xE5D1B8", VA = "0xE5D1B8")]
			internal Builder()
			{
			}

			[Token(Token = "0x6002FD6")]
			[Address(RVA = "0xE5D234", Offset = "0xE5D234", VA = "0xE5D234", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x6002FD7")]
			[Address(RVA = "0xE5D244", Offset = "0xE5D244", VA = "0xE5D244")]
			internal Builder SetDescription(string description)
			{
				return null;
			}

			[Token(Token = "0x6002FD8")]
			[Address(RVA = "0xE5D27C", Offset = "0xE5D27C", VA = "0xE5D27C")]
			internal Builder SetPlayedTime(ulong playedTime)
			{
				return null;
			}

			[Token(Token = "0x6002FD9")]
			[Address(RVA = "0xE5D2B4", Offset = "0xE5D2B4", VA = "0xE5D2B4")]
			internal Builder SetCoverImageFromPngData(byte[] pngData)
			{
				return null;
			}

			[Token(Token = "0x6002FDA")]
			[Address(RVA = "0xE5D36C", Offset = "0xE5D36C", VA = "0xE5D36C")]
			internal Builder From(SavedGameMetadataUpdate update)
			{
				return null;
			}

			[Token(Token = "0x6002FDB")]
			[Address(RVA = "0xE5D4C4", Offset = "0xE5D4C4", VA = "0xE5D4C4")]
			internal NativeSnapshotMetadataChange Build()
			{
				return null;
			}
		}

		[Token(Token = "0x600132C")]
		[Address(RVA = "0xE5D094", Offset = "0xE5D094", VA = "0xE5D094")]
		internal NativeSnapshotMetadataChange(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x600132D")]
		[Address(RVA = "0xE5D10C", Offset = "0xE5D10C", VA = "0xE5D10C", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x600132E")]
		[Address(RVA = "0xE5D11C", Offset = "0xE5D11C", VA = "0xE5D11C")]
		internal static NativeSnapshotMetadataChange FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
