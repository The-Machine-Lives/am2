using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000323")]
	public class AbilityGroup : RuntimeData<RDAbilityGroup>, IWeighted
	{
		[Token(Token = "0x4000F9D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x827F38", Offset = "0x827F38")]
		private List<Ability> _003Cabilities_003Ek__BackingField;

		[Token(Token = "0x170003E2")]
		public List<Ability> abilities
		{
			[Token(Token = "0x6001978")]
			[Address(RVA = "0x9ABF14", Offset = "0x9ABF14", VA = "0x9ABF14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837C10", Offset = "0x837C10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001979")]
			[Address(RVA = "0x9ABF1C", Offset = "0x9ABF1C", VA = "0x9ABF1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837C20", Offset = "0x837C20")]
			private set
			{
			}
		}

		[Token(Token = "0x170003E3")]
		public EAbilityBehavior abilityBehavior
		{
			[Token(Token = "0x600197A")]
			[Address(RVA = "0x9ABF24", Offset = "0x9ABF24", VA = "0x9ABF24")]
			get
			{
				return default(EAbilityBehavior);
			}
		}

		[Token(Token = "0x170003E4")]
		public int weight
		{
			[Token(Token = "0x600197B")]
			[Address(RVA = "0x9ABF50", Offset = "0x9ABF50", VA = "0x9ABF50", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600197C")]
		[Address(RVA = "0x9ABF7C", Offset = "0x9ABF7C", VA = "0x9ABF7C")]
		public void Setup(RuntimeDataCache<Ability, RDAbility> abilitiesCache)
		{
		}

		[Token(Token = "0x600197D")]
		[Address(RVA = "0x9A64C8", Offset = "0x9A64C8", VA = "0x9A64C8")]
		public Ability SelectAbility(int index)
		{
			return null;
		}

		[Token(Token = "0x600197E")]
		[Address(RVA = "0x9AC004", Offset = "0x9AC004", VA = "0x9AC004")]
		public AbilityGroup()
		{
		}
	}
}
