using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200027F")]
	internal class NativeScorePage : BaseReferenceHolder
	{
		[Token(Token = "0x6001308")]
		[Address(RVA = "0xE5C150", Offset = "0xE5C150", VA = "0xE5C150")]
		internal NativeScorePage(IntPtr selfPtr)
		{
		}

		[Token(Token = "0x6001309")]
		[Address(RVA = "0xE5C1C8", Offset = "0xE5C1C8", VA = "0xE5C1C8", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x600130A")]
		[Address(RVA = "0xE5C1D8", Offset = "0xE5C1D8", VA = "0xE5C1D8")]
		internal Types.LeaderboardCollection GetCollection()
		{
			return default(Types.LeaderboardCollection);
		}

		[Token(Token = "0x600130B")]
		[Address(RVA = "0xE5C1F4", Offset = "0xE5C1F4", VA = "0xE5C1F4")]
		private UIntPtr Length()
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x600130C")]
		[Address(RVA = "0xE5C210", Offset = "0xE5C210", VA = "0xE5C210")]
		private NativeScoreEntry GetElement(UIntPtr index)
		{
			return null;
		}

		[Token(Token = "0x600130D")]
		[Address(RVA = "0xE5C310", Offset = "0xE5C310", VA = "0xE5C310")]
		public IEnumerator<NativeScoreEntry> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600130E")]
		[Address(RVA = "0xE5C3DC", Offset = "0xE5C3DC", VA = "0xE5C3DC")]
		internal bool HasNextScorePage()
		{
			return default(bool);
		}

		[Token(Token = "0x600130F")]
		[Address(RVA = "0xE5C3F8", Offset = "0xE5C3F8", VA = "0xE5C3F8")]
		internal bool HasPrevScorePage()
		{
			return default(bool);
		}

		[Token(Token = "0x6001310")]
		[Address(RVA = "0xE5C414", Offset = "0xE5C414", VA = "0xE5C414")]
		internal NativeScorePageToken GetNextScorePageToken()
		{
			return null;
		}

		[Token(Token = "0x6001311")]
		[Address(RVA = "0xE5C508", Offset = "0xE5C508", VA = "0xE5C508")]
		internal NativeScorePageToken GetPreviousScorePageToken()
		{
			return null;
		}

		[Token(Token = "0x6001312")]
		[Address(RVA = "0xE5C584", Offset = "0xE5C584", VA = "0xE5C584")]
		internal bool Valid()
		{
			return default(bool);
		}

		[Token(Token = "0x6001313")]
		[Address(RVA = "0xE5C5A0", Offset = "0xE5C5A0", VA = "0xE5C5A0")]
		internal Types.LeaderboardTimeSpan GetTimeSpan()
		{
			return default(Types.LeaderboardTimeSpan);
		}

		[Token(Token = "0x6001314")]
		[Address(RVA = "0xE5C5BC", Offset = "0xE5C5BC", VA = "0xE5C5BC")]
		internal Types.LeaderboardStart GetStart()
		{
			return default(Types.LeaderboardStart);
		}

		[Token(Token = "0x6001315")]
		[Address(RVA = "0xE5C5D8", Offset = "0xE5C5D8", VA = "0xE5C5D8")]
		internal string GetLeaderboardId()
		{
			return null;
		}

		[Token(Token = "0x6001316")]
		[Address(RVA = "0xE5C668", Offset = "0xE5C668", VA = "0xE5C668")]
		internal static NativeScorePage FromPointer(IntPtr pointer)
		{
			return null;
		}

		[Token(Token = "0x6001317")]
		[Address(RVA = "0xE5C704", Offset = "0xE5C704", VA = "0xE5C704")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836574", Offset = "0x836574")]
		private NativeScoreEntry _003CGetEnumerator_003Eb__5_0(UIntPtr index)
		{
			return null;
		}

		[Token(Token = "0x6001318")]
		[Address(RVA = "0xE5C708", Offset = "0xE5C708", VA = "0xE5C708")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836584", Offset = "0x836584")]
		private UIntPtr _003CGetLeaderboardId_003Eb__13_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}
	}
}
