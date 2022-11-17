using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000334")]
	public class Zone : ResearchableRuntimeData<RDZone, ZoneItem>
	{
		[Token(Token = "0x4000FCE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8287F4", Offset = "0x8287F4")]
		private List<Encounter> _003Cencounters_003Ek__BackingField;

		[Token(Token = "0x4000FCF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x828804", Offset = "0x828804")]
		private RewardGroup _003ConEnterRewardGroup_003Ek__BackingField;

		[Token(Token = "0x17000404")]
		public List<Encounter> encounters
		{
			[Token(Token = "0x60019BF")]
			[Address(RVA = "0x973064", Offset = "0x973064", VA = "0x973064")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837C70", Offset = "0x837C70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60019C0")]
			[Address(RVA = "0x97306C", Offset = "0x97306C", VA = "0x97306C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837C80", Offset = "0x837C80")]
			private set
			{
			}
		}

		[Token(Token = "0x17000405")]
		public string readableName
		{
			[Token(Token = "0x60019C1")]
			[Address(RVA = "0x973074", Offset = "0x973074", VA = "0x973074")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000406")]
		public string playCostItemRef
		{
			[Token(Token = "0x60019C2")]
			[Address(RVA = "0x9730A0", Offset = "0x9730A0", VA = "0x9730A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000407")]
		public long playCostQuantity
		{
			[Token(Token = "0x60019C3")]
			[Address(RVA = "0x9730CC", Offset = "0x9730CC", VA = "0x9730CC")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000408")]
		public RewardGroup onEnterRewardGroup
		{
			[Token(Token = "0x60019C4")]
			[Address(RVA = "0x9730F8", Offset = "0x9730F8", VA = "0x9730F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837C90", Offset = "0x837C90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60019C5")]
			[Address(RVA = "0x973100", Offset = "0x973100", VA = "0x973100")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837CA0", Offset = "0x837CA0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000409")]
		public override string readableItemName
		{
			[Token(Token = "0x60019C6")]
			[Address(RVA = "0x973108", Offset = "0x973108", VA = "0x973108", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700040A")]
		public override string localizedAcquireText
		{
			[Token(Token = "0x60019C7")]
			[Address(RVA = "0x973134", Offset = "0x973134", VA = "0x973134", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700040B")]
		public BISoundEvents.EventKey ambientSoundEventOverride
		{
			[Token(Token = "0x60019C8")]
			[Address(RVA = "0x9731F8", Offset = "0x9731F8", VA = "0x9731F8")]
			get
			{
				return default(BISoundEvents.EventKey);
			}
		}

		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x96F9FC", Offset = "0x96F9FC", VA = "0x96F9FC")]
		public void Setup(RuntimeDataCache<Encounter, RDEncounter> encountersCache, RuntimeCostResourceCache costResourceCache)
		{
		}

		[Token(Token = "0x60019CA")]
		[Address(RVA = "0x973294", Offset = "0x973294", VA = "0x973294")]
		public IActionScene SelectScene(int stepIndex)
		{
			return null;
		}

		[Token(Token = "0x60019CB")]
		[Address(RVA = "0x97335C", Offset = "0x97335C", VA = "0x97335C")]
		public Zone()
		{
		}
	}
}
