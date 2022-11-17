using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200031A")]
	public class DiffHealth : AbilityEffect<RDDiffHealth>
	{
		[Token(Token = "0x4000F62")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8273D8", Offset = "0x8273D8")]
		private Tag _003CdiffType_003Ek__BackingField;

		[Token(Token = "0x4000F63")]
		[FieldOffset(Offset = "0x40")]
		private Formula m_minDiffFormula;

		[Token(Token = "0x4000F64")]
		[FieldOffset(Offset = "0x48")]
		private Formula m_maxDiffFormula;

		[Token(Token = "0x4000F65")]
		[FieldOffset(Offset = "0x50")]
		private Localizations m_localizationController;

		[Token(Token = "0x170003BB")]
		public bool isDamage
		{
			[Token(Token = "0x6001923")]
			[Address(RVA = "0x9AF124", Offset = "0x9AF124", VA = "0x9AF124")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003BC")]
		public bool interrupts
		{
			[Token(Token = "0x6001924")]
			[Address(RVA = "0x9AF150", Offset = "0x9AF150", VA = "0x9AF150")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003BD")]
		public bool isPercentage
		{
			[Token(Token = "0x6001925")]
			[Address(RVA = "0x9AF17C", Offset = "0x9AF17C", VA = "0x9AF17C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003BE")]
		public Tag diffType
		{
			[Token(Token = "0x6001926")]
			[Address(RVA = "0x9AF1A8", Offset = "0x9AF1A8", VA = "0x9AF1A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837A90", Offset = "0x837A90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001927")]
			[Address(RVA = "0x9AF1B0", Offset = "0x9AF1B0", VA = "0x9AF1B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837AA0", Offset = "0x837AA0")]
			private set
			{
			}
		}

		[Token(Token = "0x170003BF")]
		public BISoundEvents.EventKey dealDamageSoundEventOverride
		{
			[Token(Token = "0x6001928")]
			[Address(RVA = "0x9AF1B8", Offset = "0x9AF1B8", VA = "0x9AF1B8")]
			get
			{
				return default(BISoundEvents.EventKey);
			}
		}

		[Token(Token = "0x170003C0")]
		public bool canDoNegativeDiff
		{
			[Token(Token = "0x6001929")]
			[Address(RVA = "0x9AF1E4", Offset = "0x9AF1E4", VA = "0x9AF1E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600192A")]
		[Address(RVA = "0x9AF210", Offset = "0x9AF210", VA = "0x9AF210")]
		public DiffHealth()
		{
		}

		[Token(Token = "0x600192B")]
		[Address(RVA = "0x9AF278", Offset = "0x9AF278", VA = "0x9AF278", Slot = "4")]
		public override void Initialize(RDDiffHealth referenceData)
		{
		}

		[Token(Token = "0x600192C")]
		[Address(RVA = "0x9AF4E0", Offset = "0x9AF4E0", VA = "0x9AF4E0")]
		public long MinDiff(long level)
		{
			return default(long);
		}

		[Token(Token = "0x600192D")]
		[Address(RVA = "0x9AF51C", Offset = "0x9AF51C", VA = "0x9AF51C")]
		public long MaxDiff(long level)
		{
			return default(long);
		}

		[Token(Token = "0x600192E")]
		[Address(RVA = "0x9AF558", Offset = "0x9AF558", VA = "0x9AF558")]
		public long GetDiffAmount(long level)
		{
			return default(long);
		}

		[Token(Token = "0x600192F")]
		[Address(RVA = "0x9AF670", Offset = "0x9AF670", VA = "0x9AF670", Slot = "14")]
		public override string GetSimpleDisplayText(long level)
		{
			return null;
		}

		[Token(Token = "0x6001930")]
		[Address(RVA = "0x9AF974", Offset = "0x9AF974", VA = "0x9AF974", Slot = "16")]
		public override List<AbilityTraitDisplay> GetDetailedDisplayText(long level, bool isSelf, bool isPassive)
		{
			return null;
		}

		[Token(Token = "0x6001931")]
		[Address(RVA = "0x9AFC58", Offset = "0x9AFC58", VA = "0x9AFC58", Slot = "15")]
		protected override string CreateAbilityTraitTitle(string name, bool isSelf, bool isPassive)
		{
			return null;
		}

		[Token(Token = "0x6001932")]
		[Address(RVA = "0x9AF6EC", Offset = "0x9AF6EC", VA = "0x9AF6EC")]
		private string GetTitleText()
		{
			return null;
		}

		[Token(Token = "0x6001933")]
		[Address(RVA = "0x9AF7F0", Offset = "0x9AF7F0", VA = "0x9AF7F0")]
		private string GetDamageText(long level)
		{
			return null;
		}
	}
}
