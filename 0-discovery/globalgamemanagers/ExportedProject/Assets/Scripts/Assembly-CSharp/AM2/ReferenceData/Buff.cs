using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000317")]
	public class Buff : AbilityEffect<RDBuff>
	{
		[Serializable]
		[Token(Token = "0x20007A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820F78", Offset = "0x820F78")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4002248")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4002249")]
			[FieldOffset(Offset = "0x8")]
			public static Func<IEnumerable<IStatusEffect>, IEnumerable<IStatusEffect>> _003C_003E9__20_0;

			[Token(Token = "0x400224A")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<StatusEffectImmuneToBuff> _003C_003E9__48_0;

			[Token(Token = "0x60031A4")]
			[Address(RVA = "0x9AE3A0", Offset = "0x9AE3A0", VA = "0x9AE3A0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60031A5")]
			[Address(RVA = "0x9AE3A8", Offset = "0x9AE3A8", VA = "0x9AE3A8")]
			internal IEnumerable<IStatusEffect> _003Cget_statusEffects_003Eb__20_0(IEnumerable<IStatusEffect> e)
			{
				return null;
			}

			[Token(Token = "0x60031A6")]
			[Address(RVA = "0x9AE3B0", Offset = "0x9AE3B0", VA = "0x9AE3B0")]
			internal bool _003CHasImmuneToAllBuffsEffect_003Eb__48_0(StatusEffectImmuneToBuff immunity)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000F4C")]
		public const float c_hideBuffDurationBelowTime = 0.1f;

		[Token(Token = "0x4000F4D")]
		public const string c_hideBuffDurationBelowTimeString = "0.1";

		[Token(Token = "0x4000F4E")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8270F0", Offset = "0x8270F0")]
		private Dictionary<StatModifierKey, StatusEffectStatModifier> _003CstatModifierStatusEffects_003Ek__BackingField;

		[Token(Token = "0x4000F4F")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x827100", Offset = "0x827100")]
		private List<StatusEffectImmuneToBuff> _003CimmuneToBuffStatusEffects_003Ek__BackingField;

		[Token(Token = "0x4000F50")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x827110", Offset = "0x827110")]
		private List<StatusEffectStun> _003CstunStatusEffects_003Ek__BackingField;

		[Token(Token = "0x4000F51")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x827120", Offset = "0x827120")]
		private List<StatusEffectReflectDamage> _003CreflectDamageStatusEffects_003Ek__BackingField;

		[Token(Token = "0x4000F52")]
		[FieldOffset(Offset = "0x58")]
		private IEnumerable<IStatusEffect>[] statusEffectCollections;

		[Token(Token = "0x4000F53")]
		[FieldOffset(Offset = "0x60")]
		private Localizations m_localizationController;

		[Token(Token = "0x4000F54")]
		[FieldOffset(Offset = "0x68")]
		private Formula m_durationInSecondsFormula;

		[Token(Token = "0x4000F55")]
		[FieldOffset(Offset = "0x70")]
		private Formula m_maxStacksFormula;

		[Token(Token = "0x4000F56")]
		[FieldOffset(Offset = "0x78")]
		private Formula m_stacksToApplyFormula;

		[Token(Token = "0x170003AE")]
		public Dictionary<StatModifierKey, StatusEffectStatModifier> statModifierStatusEffects
		{
			[Token(Token = "0x6001900")]
			[Address(RVA = "0x9AC8DC", Offset = "0x9AC8DC", VA = "0x9AC8DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837A10", Offset = "0x837A10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001901")]
			[Address(RVA = "0x9AC8E4", Offset = "0x9AC8E4", VA = "0x9AC8E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837A20", Offset = "0x837A20")]
			private set
			{
			}
		}

		[Token(Token = "0x170003AF")]
		public List<StatusEffectImmuneToBuff> immuneToBuffStatusEffects
		{
			[Token(Token = "0x6001902")]
			[Address(RVA = "0x9AC8EC", Offset = "0x9AC8EC", VA = "0x9AC8EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837A30", Offset = "0x837A30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001903")]
			[Address(RVA = "0x9AC8F4", Offset = "0x9AC8F4", VA = "0x9AC8F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837A40", Offset = "0x837A40")]
			private set
			{
			}
		}

		[Token(Token = "0x170003B0")]
		public List<StatusEffectStun> stunStatusEffects
		{
			[Token(Token = "0x6001904")]
			[Address(RVA = "0x9AC8FC", Offset = "0x9AC8FC", VA = "0x9AC8FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837A50", Offset = "0x837A50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001905")]
			[Address(RVA = "0x9AC904", Offset = "0x9AC904", VA = "0x9AC904")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837A60", Offset = "0x837A60")]
			private set
			{
			}
		}

		[Token(Token = "0x170003B1")]
		public List<StatusEffectReflectDamage> reflectDamageStatusEffects
		{
			[Token(Token = "0x6001906")]
			[Address(RVA = "0x9AC90C", Offset = "0x9AC90C", VA = "0x9AC90C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837A70", Offset = "0x837A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001907")]
			[Address(RVA = "0x9AC914", Offset = "0x9AC914", VA = "0x9AC914")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x837A80", Offset = "0x837A80")]
			private set
			{
			}
		}

		[Token(Token = "0x170003B2")]
		public IEnumerable<IStatusEffect> statusEffects
		{
			[Token(Token = "0x6001908")]
			[Address(RVA = "0x9AC91C", Offset = "0x9AC91C", VA = "0x9AC91C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003B3")]
		public string icon
		{
			[Token(Token = "0x6001909")]
			[Address(RVA = "0x9ACA0C", Offset = "0x9ACA0C", VA = "0x9ACA0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003B4")]
		public Color iconColor
		{
			[Token(Token = "0x600190A")]
			[Address(RVA = "0x9ACA38", Offset = "0x9ACA38", VA = "0x9ACA38")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x170003B5")]
		public string readableName
		{
			[Token(Token = "0x600190B")]
			[Address(RVA = "0x9ACAD8", Offset = "0x9ACAD8", VA = "0x9ACAD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003B6")]
		public bool shouldShowBuffIcon
		{
			[Token(Token = "0x600190C")]
			[Address(RVA = "0x9ACB04", Offset = "0x9ACB04", VA = "0x9ACB04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003B7")]
		public string overtimeAbility
		{
			[Token(Token = "0x600190D")]
			[Address(RVA = "0x9ACB30", Offset = "0x9ACB30", VA = "0x9ACB30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003B8")]
		public float overtimeAbilityTickInterval
		{
			[Token(Token = "0x600190E")]
			[Address(RVA = "0x9ACB5C", Offset = "0x9ACB5C", VA = "0x9ACB5C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170003B9")]
		public string buffEndAbility
		{
			[Token(Token = "0x600190F")]
			[Address(RVA = "0x9ACB88", Offset = "0x9ACB88", VA = "0x9ACB88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003BA")]
		public BISoundEvents.EventKey buffAppliedSoundEventOverride
		{
			[Token(Token = "0x6001910")]
			[Address(RVA = "0x9ACBB4", Offset = "0x9ACBB4", VA = "0x9ACBB4")]
			get
			{
				return default(BISoundEvents.EventKey);
			}
		}

		[Token(Token = "0x6001911")]
		[Address(RVA = "0x9ACBE0", Offset = "0x9ACBE0", VA = "0x9ACBE0")]
		public Buff()
		{
		}

		[Token(Token = "0x6001912")]
		[Address(RVA = "0x9ACD90", Offset = "0x9ACD90", VA = "0x9ACD90")]
		public void Setup(Dictionary<string, IStatusEffect> allStatusEffects)
		{
		}

		[Token(Token = "0x6001913")]
		[Address(RVA = "0x9AD370", Offset = "0x9AD370", VA = "0x9AD370")]
		public float DurationInSeconds(long level)
		{
			return default(float);
		}

		[Token(Token = "0x6001914")]
		[Address(RVA = "0x9AD3D8", Offset = "0x9AD3D8", VA = "0x9AD3D8")]
		public int DurationInSceneCount(long level)
		{
			return default(int);
		}

		[Token(Token = "0x6001915")]
		[Address(RVA = "0x9AD404", Offset = "0x9AD404", VA = "0x9AD404")]
		public long MaxStacks(long level)
		{
			return default(long);
		}

		[Token(Token = "0x6001916")]
		[Address(RVA = "0x9AD4E4", Offset = "0x9AD4E4", VA = "0x9AD4E4")]
		public long StacksToApply(long level)
		{
			return default(long);
		}

		[Token(Token = "0x6001917")]
		[Address(RVA = "0x9AD520", Offset = "0x9AD520", VA = "0x9AD520")]
		public bool HasStunStatusEffect()
		{
			return default(bool);
		}

		[Token(Token = "0x6001918")]
		[Address(RVA = "0x9AD58C", Offset = "0x9AD58C", VA = "0x9AD58C")]
		public bool HasImmuneToAllBuffsEffect()
		{
			return default(bool);
		}

		[Token(Token = "0x6001919")]
		[Address(RVA = "0x9AD69C", Offset = "0x9AD69C", VA = "0x9AD69C", Slot = "14")]
		public override string GetSimpleDisplayText(long level)
		{
			return null;
		}

		[Token(Token = "0x600191A")]
		[Address(RVA = "0x9AD808", Offset = "0x9AD808", VA = "0x9AD808", Slot = "16")]
		public override List<AbilityTraitDisplay> GetDetailedDisplayText(long level, bool isSelf, bool isPassive)
		{
			return null;
		}

		[Token(Token = "0x600191B")]
		[Address(RVA = "0x9AE0F4", Offset = "0x9AE0F4", VA = "0x9AE0F4", Slot = "15")]
		protected override string CreateAbilityTraitTitle(string name, bool isSelf, bool isPassive)
		{
			return null;
		}

		[Token(Token = "0x600191C")]
		[Address(RVA = "0x9ADDD4", Offset = "0x9ADDD4", VA = "0x9ADDD4")]
		private AbilityTraitDisplay GetDurationDisplay(long level)
		{
			return null;
		}

		[Token(Token = "0x600191D")]
		[Address(RVA = "0x9ADFB4", Offset = "0x9ADFB4", VA = "0x9ADFB4")]
		private AbilityTraitDisplay GetMaxStacksDisplay(long level)
		{
			return null;
		}

		[Token(Token = "0x600191E")]
		[Address(RVA = "0x9AE054", Offset = "0x9AE054", VA = "0x9AE054")]
		private AbilityTraitDisplay GetStacksToApplyDisplay(long level)
		{
			return null;
		}

		[Token(Token = "0x600191F")]
		[Address(RVA = "0x9AE29C", Offset = "0x9AE29C", VA = "0x9AE29C")]
		private AbilityTraitDisplay GetStacksRelatedDisplay(string title, long currentAmount, long nextAmount, long level)
		{
			return null;
		}
	}
}
