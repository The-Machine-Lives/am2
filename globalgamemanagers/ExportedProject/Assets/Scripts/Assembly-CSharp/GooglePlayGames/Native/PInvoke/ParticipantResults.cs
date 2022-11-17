using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200028A")]
	internal class ParticipantResults : BaseReferenceHolder
	{
		[Token(Token = "0x600137C")]
		[Address(RVA = "0xE5DA8C", Offset = "0xE5DA8C", VA = "0xE5DA8C")]
		internal ParticipantResults(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x600137D")]
		[Address(RVA = "0xE610E8", Offset = "0xE610E8", VA = "0xE610E8")]
		internal bool HasResultsForParticipant(string participantId)
		{
			return default(bool);
		}

		[Token(Token = "0x600137E")]
		[Address(RVA = "0xE61114", Offset = "0xE61114", VA = "0xE61114")]
		internal uint PlacingForParticipant(string participantId)
		{
			return default(uint);
		}

		[Token(Token = "0x600137F")]
		[Address(RVA = "0xE61140", Offset = "0xE61140", VA = "0xE61140")]
		internal Types.MatchResult ResultsForParticipant(string participantId)
		{
			return default(Types.MatchResult);
		}

		[Token(Token = "0x6001380")]
		[Address(RVA = "0xE6116C", Offset = "0xE6116C", VA = "0xE6116C")]
		internal ParticipantResults WithResult(string participantId, uint placing, Types.MatchResult result)
		{
			return null;
		}

		[Token(Token = "0x6001381")]
		[Address(RVA = "0xE61210", Offset = "0xE61210", VA = "0xE61210", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}
	}
}
