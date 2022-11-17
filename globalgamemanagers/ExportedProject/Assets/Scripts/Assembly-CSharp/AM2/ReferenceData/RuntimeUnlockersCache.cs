using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003B4")]
	public class RuntimeUnlockersCache : RuntimeResearchableDataCache<Unlocker, RDUnlocker, UnlockItem>
	{
		[Token(Token = "0x40011C9")]
		[FieldOffset(Offset = "0x78")]
		protected RuntimeDataCache<Condition, RDCondition> m_conditions;

		[Token(Token = "0x40011CA")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82DF2C", Offset = "0x82DF2C")]
		private Dictionary<string, Unlocker> _003CunfinishedUnlockersWithConditions_003Ek__BackingField;

		[Token(Token = "0x40011CB")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82DF3C", Offset = "0x82DF3C")]
		private Dictionary<string, string> _003CallUnlockersByUnlockTypeKey_003Ek__BackingField;

		[Token(Token = "0x1700055D")]
		public Dictionary<string, Unlocker> unfinishedUnlockersWithConditions
		{
			[Token(Token = "0x6001C94")]
			[Address(RVA = "0x96E210", Offset = "0x96E210", VA = "0x96E210")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838720", Offset = "0x838720")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C95")]
			[Address(RVA = "0x96E218", Offset = "0x96E218", VA = "0x96E218")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838730", Offset = "0x838730")]
			private set
			{
			}
		}

		[Token(Token = "0x1700055E")]
		protected Dictionary<string, string> allUnlockersByUnlockTypeKey
		{
			[Token(Token = "0x6001C96")]
			[Address(RVA = "0x96E220", Offset = "0x96E220", VA = "0x96E220")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838740", Offset = "0x838740")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C97")]
			[Address(RVA = "0x96E228", Offset = "0x96E228", VA = "0x96E228")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838750", Offset = "0x838750")]
			private set
			{
			}
		}

		[Token(Token = "0x6001C98")]
		[Address(RVA = "0x96E230", Offset = "0x96E230", VA = "0x96E230")]
		public RuntimeUnlockersCache(DepotEntity<RDUnlocker> depot, RuntimeDataCache<Condition, RDCondition> conditions, RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache, RuntimeDataCache<SubTab, RDSubTab> researchSubTabCache, RuntimeDataCache<Section, RDSection> sectionCache, RuntimeCostResourceCache costResourceCache)
		{
		}

		[Token(Token = "0x6001C99")]
		[Address(RVA = "0x96E33C", Offset = "0x96E33C", VA = "0x96E33C")]
		public string GetKeyForRecipeSpecificUnlocker(string recipeCategory, EUnlockType unlockType)
		{
			return null;
		}

		[Token(Token = "0x6001C9A")]
		[Address(RVA = "0x96E3E8", Offset = "0x96E3E8", VA = "0x96E3E8")]
		public bool IsUnlockerRecipeSpecific(EUnlockType unlockType)
		{
			return default(bool);
		}

		[Token(Token = "0x6001C9B")]
		[Address(RVA = "0x96E488", Offset = "0x96E488", VA = "0x96E488", Slot = "5")]
		protected override Unlocker CreateRuntimeData(string reference, RDUnlocker refDataDocument)
		{
			return null;
		}

		[Token(Token = "0x6001C9C")]
		[Address(RVA = "0x96EA54", Offset = "0x96EA54", VA = "0x96EA54")]
		public void OnConditionsMet(Unlocker unlocker)
		{
		}

		[Token(Token = "0x6001C9D")]
		[Address(RVA = "0x96EC70", Offset = "0x96EC70", VA = "0x96EC70")]
		public bool IsRecipeLocked(Recipe recipe)
		{
			return default(bool);
		}

		[Token(Token = "0x6001C9E")]
		[Address(RVA = "0x96ED64", Offset = "0x96ED64", VA = "0x96ED64")]
		public bool IsItemConverterLocked(ItemConverter itemConverter)
		{
			return default(bool);
		}

		[Token(Token = "0x6001C9F")]
		[Address(RVA = "0x96EDA8", Offset = "0x96EDA8", VA = "0x96EDA8")]
		public bool IsUpgradeLocked(string category, EUnlockType unlockType, out string unlockerRef)
		{
			return default(bool);
		}

		[Token(Token = "0x6001CA0")]
		[Address(RVA = "0x96EE48", Offset = "0x96EE48", VA = "0x96EE48")]
		public bool IsUnlockerLocked(EUnlockType unlockType)
		{
			return default(bool);
		}

		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0x96EEF4", Offset = "0x96EEF4", VA = "0x96EEF4")]
		public bool IsUnlockerLocked(string unlockerRef)
		{
			return default(bool);
		}

		[Token(Token = "0x6001CA2")]
		[Address(RVA = "0x96ECB0", Offset = "0x96ECB0", VA = "0x96ECB0")]
		private bool IsLocked(string key)
		{
			return default(bool);
		}
	}
}
