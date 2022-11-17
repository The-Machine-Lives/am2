using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000382")]
	public class PrestigeLevel : RuntimeData<RDPrestigeLevel>, IItemModel, IInfoText
	{
		[Token(Token = "0x4001122")]
		[FieldOffset(Offset = "0x18")]
		private Formula m_machineLevelFormula;

		[Token(Token = "0x4001123")]
		[FieldOffset(Offset = "0x20")]
		private Formula m_powerSpeedFormula;

		[Token(Token = "0x4001124")]
		[FieldOffset(Offset = "0x28")]
		private Formula m_powerBonusSpeedResearchFormula;

		[Token(Token = "0x4001125")]
		[FieldOffset(Offset = "0x30")]
		private Formula m_powerSustainFormula;

		[Token(Token = "0x4001126")]
		[FieldOffset(Offset = "0x38")]
		private Formula m_boostersFormula;

		[Token(Token = "0x4001127")]
		[FieldOffset(Offset = "0x40")]
		private Formula m_shardsFormula;

		[Token(Token = "0x4001128")]
		[FieldOffset(Offset = "0x48")]
		private Formula m_mTokensFormula;

		[Token(Token = "0x4001129")]
		[FieldOffset(Offset = "0x50")]
		private Upgradable machineLevelUpgradable;

		[Token(Token = "0x400112A")]
		[FieldOffset(Offset = "0x58")]
		private Upgradable powerSpeedUpgradeable;

		[Token(Token = "0x400112B")]
		[FieldOffset(Offset = "0x60")]
		private Upgradable powerSpeedBonusUpgradable;

		[Token(Token = "0x400112C")]
		[FieldOffset(Offset = "0x68")]
		private Upgradable powerSustainUpgradable;

		[Token(Token = "0x170004DA")]
		public string readableName
		{
			[Token(Token = "0x6001BA6")]
			[Address(RVA = "0x9B6A90", Offset = "0x9B6A90", VA = "0x9B6A90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DB")]
		public string readableItemName
		{
			[Token(Token = "0x6001BA7")]
			[Address(RVA = "0x9B6ABC", Offset = "0x9B6ABC", VA = "0x9B6ABC", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DC")]
		public string description
		{
			[Token(Token = "0x6001BA8")]
			[Address(RVA = "0x9B6AE8", Offset = "0x9B6AE8", VA = "0x9B6AE8", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DD")]
		public string researchInfoText
		{
			[Token(Token = "0x6001BA9")]
			[Address(RVA = "0x9B6B38", Offset = "0x9B6B38", VA = "0x9B6B38", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DE")]
		public string infoImageSource
		{
			[Token(Token = "0x6001BAA")]
			[Address(RVA = "0x9B6B88", Offset = "0x9B6B88", VA = "0x9B6B88", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DF")]
		public string prestigeTokensReference
		{
			[Token(Token = "0x6001BAB")]
			[Address(RVA = "0x9B6BD8", Offset = "0x9B6BD8", VA = "0x9B6BD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E0")]
		public string shardsItemReference
		{
			[Token(Token = "0x6001BAC")]
			[Address(RVA = "0x9B6C04", Offset = "0x9B6C04", VA = "0x9B6C04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E1")]
		public string mTokensItemReference
		{
			[Token(Token = "0x6001BAD")]
			[Address(RVA = "0x9B6C30", Offset = "0x9B6C30", VA = "0x9B6C30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E2")]
		public List<string> boosterItemReferences
		{
			[Token(Token = "0x6001BAE")]
			[Address(RVA = "0x9B6C5C", Offset = "0x9B6C5C", VA = "0x9B6C5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E3")]
		public long currentPowerSpeedResearchLevel
		{
			[Token(Token = "0x6001BAF")]
			[Address(RVA = "0x9B6C88", Offset = "0x9B6C88", VA = "0x9B6C88")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170004E4")]
		public long currentPowerSustainLevel
		{
			[Token(Token = "0x6001BB0")]
			[Address(RVA = "0x9B6CB8", Offset = "0x9B6CB8", VA = "0x9B6CB8")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6001BB1")]
		[Address(RVA = "0x9B6CE8", Offset = "0x9B6CE8", VA = "0x9B6CE8")]
		public PrestigeLevel()
		{
		}

		[Token(Token = "0x6001BB2")]
		[Address(RVA = "0x9B6D38", Offset = "0x9B6D38", VA = "0x9B6D38", Slot = "4")]
		public override void Initialize(RDPrestigeLevel referenceData)
		{
		}

		[Token(Token = "0x6001BB3")]
		[Address(RVA = "0x9B70B0", Offset = "0x9B70B0", VA = "0x9B70B0")]
		public long CalculateNumberOfPrestigeTokensToAward(long numberOfBoosters, long numberOfShards, long numberOfMTokens)
		{
			return default(long);
		}
	}
}
