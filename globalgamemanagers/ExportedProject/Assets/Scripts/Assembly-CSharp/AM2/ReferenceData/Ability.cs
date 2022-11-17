using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200031F")]
	public class Ability : RuntimeData<RDAbility>, IItemModel, IInfoText, ISlottedItem
	{
		[Token(Token = "0x4000F8B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x827DE4", Offset = "0x827DE4")]
		private List<IAbilityEffect> _003CfriendlyEffects_003Ek__BackingField;

		[Token(Token = "0x4000F8C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x827DF4", Offset = "0x827DF4")]
		private List<IAbilityEffect> _003CenemyEffects_003Ek__BackingField;

		[Token(Token = "0x4000F8D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x827E04", Offset = "0x827E04")]
		private List<IAbilityEffect> _003CstartingZoneEffects_003Ek__BackingField;

		[Token(Token = "0x4000F8E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x827E14", Offset = "0x827E14")]
		private List<IAbilityEffect> _003CstartingSceneEffects_003Ek__BackingField;

		[Token(Token = "0x4000F8F")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x827E24", Offset = "0x827E24")]
		private List<CostResource> _003CcostResources_003Ek__BackingField;

		[Token(Token = "0x4000F90")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x827E34", Offset = "0x827E34")]
		private List<Tag> _003Ctags_003Ek__BackingField;

		[Token(Token = "0x4000F91")]
		[FieldOffset(Offset = "0x48")]
		private Formula m_levellableCooldownInSeconds;

		[Token(Token = "0x4000F92")]
		[FieldOffset(Offset = "0x50")]
		private Formula m_levellableCastTimeInSeconds;

		[Token(Token = "0x4000F93")]
		[FieldOffset(Offset = "0x58")]
		private Formula m_levellableAccuracy;

		[Token(Token = "0x170003C5")]
		public bool giveAbilityOnAcquireAmmo
		{
			[Token(Token = "0x6001944")]
			[Address(RVA = "0x9AB2CC", Offset = "0x9AB2CC", VA = "0x9AB2CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003C6")]
		public bool usesAmmo
		{
			[Token(Token = "0x6001945")]
			[Address(RVA = "0x9AB2F8", Offset = "0x9AB2F8", VA = "0x9AB2F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003C7")]
		public string ammo
		{
			[Token(Token = "0x6001946")]
			[Address(RVA = "0x9AB334", Offset = "0x9AB334", VA = "0x9AB334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C8")]
		public string readableName
		{
			[Token(Token = "0x6001947")]
			[Address(RVA = "0x9A6EEC", Offset = "0x9A6EEC", VA = "0x9A6EEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C9")]
		public string readableAmmoName
		{
			[Token(Token = "0x6001948")]
			[Address(RVA = "0x9AB360", Offset = "0x9AB360", VA = "0x9AB360")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003CA")]
		public string description
		{
			[Token(Token = "0x6001949")]
			[Address(RVA = "0x9AB38C", Offset = "0x9AB38C", VA = "0x9AB38C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003CB")]
		public string researchInfoText
		{
			[Token(Token = "0x600194A")]
			[Address(RVA = "0x9AB3B8", Offset = "0x9AB3B8", VA = "0x9AB3B8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003CC")]
		public string infoImageSource
		{
			[Token(Token = "0x600194B")]
			[Address(RVA = "0x9AB408", Offset = "0x9AB408", VA = "0x9AB408", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003CD")]
		public string readableItemName
		{
			[Token(Token = "0x600194C")]
			[Address(RVA = "0x9AB458", Offset = "0x9AB458", VA = "0x9AB458", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003CE")]
		public List<IAbilityEffect> friendlyEffects
		{
			[Token(Token = "0x600194D")]
			[Address(RVA = "0x9AB484", Offset = "0x9AB484", VA = "0x9AB484")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837B30", Offset = "0x837B30")]
			get
			{
				return null;
			}
			[Token(Token = "0x600194E")]
			[Address(RVA = "0x9AB48C", Offset = "0x9AB48C", VA = "0x9AB48C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837B40", Offset = "0x837B40")]
			private set
			{
			}
		}

		[Token(Token = "0x170003CF")]
		public List<IAbilityEffect> enemyEffects
		{
			[Token(Token = "0x600194F")]
			[Address(RVA = "0x9AB494", Offset = "0x9AB494", VA = "0x9AB494")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837B50", Offset = "0x837B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001950")]
			[Address(RVA = "0x9AB49C", Offset = "0x9AB49C", VA = "0x9AB49C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837B60", Offset = "0x837B60")]
			private set
			{
			}
		}

		[Token(Token = "0x170003D0")]
		public List<IAbilityEffect> startingZoneEffects
		{
			[Token(Token = "0x6001951")]
			[Address(RVA = "0x9AB4A4", Offset = "0x9AB4A4", VA = "0x9AB4A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837B70", Offset = "0x837B70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001952")]
			[Address(RVA = "0x9AB4AC", Offset = "0x9AB4AC", VA = "0x9AB4AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837B80", Offset = "0x837B80")]
			private set
			{
			}
		}

		[Token(Token = "0x170003D1")]
		public List<IAbilityEffect> startingSceneEffects
		{
			[Token(Token = "0x6001953")]
			[Address(RVA = "0x9AB4B4", Offset = "0x9AB4B4", VA = "0x9AB4B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837B90", Offset = "0x837B90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001954")]
			[Address(RVA = "0x9AB4BC", Offset = "0x9AB4BC", VA = "0x9AB4BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837BA0", Offset = "0x837BA0")]
			private set
			{
			}
		}

		[Token(Token = "0x170003D2")]
		public List<CostResource> costResources
		{
			[Token(Token = "0x6001955")]
			[Address(RVA = "0x9AB4C4", Offset = "0x9AB4C4", VA = "0x9AB4C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837BB0", Offset = "0x837BB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001956")]
			[Address(RVA = "0x9AB4CC", Offset = "0x9AB4CC", VA = "0x9AB4CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837BC0", Offset = "0x837BC0")]
			private set
			{
			}
		}

		[Token(Token = "0x170003D3")]
		public bool isUpgradable
		{
			[Token(Token = "0x6001957")]
			[Address(RVA = "0x9AB4D4", Offset = "0x9AB4D4", VA = "0x9AB4D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003D4")]
		public long maxLevel
		{
			[Token(Token = "0x6001958")]
			[Address(RVA = "0x9AB508", Offset = "0x9AB508", VA = "0x9AB508")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170003D5")]
		public string slottedItemRef
		{
			[Token(Token = "0x6001959")]
			[Address(RVA = "0x9AB534", Offset = "0x9AB534", VA = "0x9AB534", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003D6")]
		public bool ignoresDodge
		{
			[Token(Token = "0x600195A")]
			[Address(RVA = "0x9AB540", Offset = "0x9AB540", VA = "0x9AB540")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003D7")]
		public bool executeFriendlyEffectsOnDodge
		{
			[Token(Token = "0x600195B")]
			[Address(RVA = "0x9AB56C", Offset = "0x9AB56C", VA = "0x9AB56C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003D8")]
		public bool interruptable
		{
			[Token(Token = "0x600195C")]
			[Address(RVA = "0x9AB598", Offset = "0x9AB598", VA = "0x9AB598")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003D9")]
		public bool channelingInterruptable
		{
			[Token(Token = "0x600195D")]
			[Address(RVA = "0x9AB5C4", Offset = "0x9AB5C4", VA = "0x9AB5C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003DA")]
		public bool showCastingBar
		{
			[Token(Token = "0x600195E")]
			[Address(RVA = "0x9A6EC0", Offset = "0x9A6EC0", VA = "0x9A6EC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003DB")]
		public bool isChannelAbility
		{
			[Token(Token = "0x600195F")]
			[Address(RVA = "0x9AB5F0", Offset = "0x9AB5F0", VA = "0x9AB5F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003DC")]
		public float channelTimeInSeconds
		{
			[Token(Token = "0x6001960")]
			[Address(RVA = "0x9AB624", Offset = "0x9AB624", VA = "0x9AB624")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170003DD")]
		public string channelEndAbility
		{
			[Token(Token = "0x6001961")]
			[Address(RVA = "0x9AB650", Offset = "0x9AB650", VA = "0x9AB650")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003DE")]
		public string deathAbility
		{
			[Token(Token = "0x6001962")]
			[Address(RVA = "0x9AB67C", Offset = "0x9AB67C", VA = "0x9AB67C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003DF")]
		public string damageAbility
		{
			[Token(Token = "0x6001963")]
			[Address(RVA = "0x9AB6A8", Offset = "0x9AB6A8", VA = "0x9AB6A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003E0")]
		public List<Tag> tags
		{
			[Token(Token = "0x6001964")]
			[Address(RVA = "0x9AB6D4", Offset = "0x9AB6D4", VA = "0x9AB6D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837BD0", Offset = "0x837BD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001965")]
			[Address(RVA = "0x9AB6DC", Offset = "0x9AB6DC", VA = "0x9AB6DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837BE0", Offset = "0x837BE0")]
			private set
			{
			}
		}

		[Token(Token = "0x6001966")]
		[Address(RVA = "0x9AB6E4", Offset = "0x9AB6E4", VA = "0x9AB6E4")]
		public Ability()
		{
		}

		[Token(Token = "0x6001967")]
		[Address(RVA = "0x9AB784", Offset = "0x9AB784", VA = "0x9AB784", Slot = "4")]
		public override void Initialize(RDAbility referenceData)
		{
		}

		[Token(Token = "0x6001968")]
		[Address(RVA = "0x9AB7E4", Offset = "0x9AB7E4", VA = "0x9AB7E4")]
		public void Setup(Dictionary<string, IAbilityEffect> allAbilityEffects)
		{
		}

		[Token(Token = "0x6001969")]
		[Address(RVA = "0x9ABD94", Offset = "0x9ABD94", VA = "0x9ABD94")]
		public float CooldownInSeconds(long level)
		{
			return default(float);
		}

		[Token(Token = "0x600196A")]
		[Address(RVA = "0x9ABE44", Offset = "0x9ABE44", VA = "0x9ABE44")]
		public float CastTimeInSeconds(long level)
		{
			return default(float);
		}

		[Token(Token = "0x600196B")]
		[Address(RVA = "0x9ABEAC", Offset = "0x9ABEAC", VA = "0x9ABEAC")]
		public float AccuracyPercent(long level)
		{
			return default(float);
		}

		[Token(Token = "0x600196C")]
		[Address(RVA = "0x9ABC64", Offset = "0x9ABC64", VA = "0x9ABC64")]
		private List<IAbilityEffect> GetAbilityEffectsFromList(Dictionary<string, IAbilityEffect> allAbilityEffects, List<string> abilityEffectStrings)
		{
			return null;
		}
	}
}
