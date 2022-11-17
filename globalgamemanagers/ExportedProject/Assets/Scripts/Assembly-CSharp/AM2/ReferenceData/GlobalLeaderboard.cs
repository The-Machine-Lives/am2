using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.Leaderboards;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003B9")]
	public class GlobalLeaderboard : RuntimeData<RDGlobalLeaderboard>
	{
		[Token(Token = "0x40011D2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E190", Offset = "0x82E190")]
		private EventSchedule _003CrepeatingSchedule_003Ek__BackingField;

		[Token(Token = "0x40011D3")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E1A0", Offset = "0x82E1A0")]
		private RewardScaleSet _003Crewards_003Ek__BackingField;

		[Token(Token = "0x40011D4")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E1B0", Offset = "0x82E1B0")]
		private EventQuest _003CeventQuest_003Ek__BackingField;

		[Token(Token = "0x17000560")]
		public EventSchedule repeatingSchedule
		{
			[Token(Token = "0x6001CAE")]
			[Address(RVA = "0x9B4304", Offset = "0x9B4304", VA = "0x9B4304")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838760", Offset = "0x838760")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CAF")]
			[Address(RVA = "0x9B430C", Offset = "0x9B430C", VA = "0x9B430C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838770", Offset = "0x838770")]
			private set
			{
			}
		}

		[Token(Token = "0x17000561")]
		public RewardScaleSet rewards
		{
			[Token(Token = "0x6001CB0")]
			[Address(RVA = "0x9B4314", Offset = "0x9B4314", VA = "0x9B4314")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838780", Offset = "0x838780")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CB1")]
			[Address(RVA = "0x9B431C", Offset = "0x9B431C", VA = "0x9B431C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838790", Offset = "0x838790")]
			private set
			{
			}
		}

		[Token(Token = "0x17000562")]
		public string trackedItem
		{
			[Token(Token = "0x6001CB2")]
			[Address(RVA = "0x9B4324", Offset = "0x9B4324", VA = "0x9B4324")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000563")]
		public string description
		{
			[Token(Token = "0x6001CB3")]
			[Address(RVA = "0x9B4350", Offset = "0x9B4350", VA = "0x9B4350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000564")]
		public string howToPlace
		{
			[Token(Token = "0x6001CB4")]
			[Address(RVA = "0x9B437C", Offset = "0x9B437C", VA = "0x9B437C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000565")]
		public EventQuest eventQuest
		{
			[Token(Token = "0x6001CB5")]
			[Address(RVA = "0x9B43A8", Offset = "0x9B43A8", VA = "0x9B43A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8387A0", Offset = "0x8387A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CB6")]
			[Address(RVA = "0x9B2C6C", Offset = "0x9B2C6C", VA = "0x9B2C6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8387B0", Offset = "0x8387B0")]
			set
			{
			}
		}

		[Token(Token = "0x6001CB7")]
		[Address(RVA = "0x9B43B0", Offset = "0x9B43B0", VA = "0x9B43B0", Slot = "4")]
		public override void Initialize(RDGlobalLeaderboard referenceData)
		{
		}

		[Token(Token = "0x6001CB8")]
		[Address(RVA = "0x9B4594", Offset = "0x9B4594", VA = "0x9B4594")]
		public string GetScoreboardKey()
		{
			return null;
		}

		[Token(Token = "0x6001CB9")]
		[Address(RVA = "0x9B466C", Offset = "0x9B466C", VA = "0x9B466C")]
		public LeaderboardDefinition GetLeaderboard()
		{
			return null;
		}

		[Token(Token = "0x6001CBA")]
		[Address(RVA = "0x9B46D0", Offset = "0x9B46D0", VA = "0x9B46D0")]
		public Dictionary<string, long> GrantRewards(LeaderboardDefinition leaderboard, int rank)
		{
			return null;
		}

		[Token(Token = "0x6001CBB")]
		[Address(RVA = "0x9B4834", Offset = "0x9B4834", VA = "0x9B4834")]
		public GlobalLeaderboard()
		{
		}
	}
}
