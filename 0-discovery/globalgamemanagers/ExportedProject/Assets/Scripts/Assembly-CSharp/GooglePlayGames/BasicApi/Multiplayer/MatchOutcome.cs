using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	[Token(Token = "0x2000300")]
	public class MatchOutcome
	{
		[Token(Token = "0x20007A0")]
		public enum ParticipantResult
		{
			[Token(Token = "0x4002228")]
			Unset = -1,
			[Token(Token = "0x4002229")]
			None = 0,
			[Token(Token = "0x400222A")]
			Win = 1,
			[Token(Token = "0x400222B")]
			Loss = 2,
			[Token(Token = "0x400222C")]
			Tie = 3
		}

		[Token(Token = "0x4000DFA")]
		public const uint PlacementUnset = 0u;

		[Token(Token = "0x4000DFB")]
		[FieldOffset(Offset = "0x10")]
		private List<string> mParticipantIds;

		[Token(Token = "0x4000DFC")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, uint> mPlacements;

		[Token(Token = "0x4000DFD")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, ParticipantResult> mResults;

		[Token(Token = "0x17000307")]
		public List<string> ParticipantIds
		{
			[Token(Token = "0x6001795")]
			[Address(RVA = "0x14628CC", Offset = "0x14628CC", VA = "0x14628CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001791")]
		[Address(RVA = "0x14626F0", Offset = "0x14626F0", VA = "0x14626F0")]
		public MatchOutcome()
		{
		}

		[Token(Token = "0x6001792")]
		[Address(RVA = "0x14627B0", Offset = "0x14627B0", VA = "0x14627B0")]
		public void SetParticipantResult(string participantId, ParticipantResult result, uint placement)
		{
		}

		[Token(Token = "0x6001793")]
		[Address(RVA = "0x14628B4", Offset = "0x14628B4", VA = "0x14628B4")]
		public void SetParticipantResult(string participantId, ParticipantResult result)
		{
		}

		[Token(Token = "0x6001794")]
		[Address(RVA = "0x14628BC", Offset = "0x14628BC", VA = "0x14628BC")]
		public void SetParticipantResult(string participantId, uint placement)
		{
		}

		[Token(Token = "0x6001796")]
		[Address(RVA = "0x14628D4", Offset = "0x14628D4", VA = "0x14628D4")]
		public ParticipantResult GetResultFor(string participantId)
		{
			return default(ParticipantResult);
		}

		[Token(Token = "0x6001797")]
		[Address(RVA = "0x1462984", Offset = "0x1462984", VA = "0x1462984")]
		public uint GetPlacementFor(string participantId)
		{
			return default(uint);
		}

		[Token(Token = "0x6001798")]
		[Address(RVA = "0x1462A34", Offset = "0x1462A34", VA = "0x1462A34", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
