using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003B3")]
	public class Unlocker : ResearchableRuntimeData<RDUnlocker, UnlockItem>
	{
		[Token(Token = "0x40011C5")]
		[FieldOffset(Offset = "0x0")]
		public static HashSet<EUnlockType> c_upgradableUnlockTypes;

		[Token(Token = "0x40011C6")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82DF0C", Offset = "0x82DF0C")]
		private bool _003CisUpgradableUnlockType_003Ek__BackingField;

		[Token(Token = "0x40011C7")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82DF1C", Offset = "0x82DF1C")]
		private List<Condition> _003Cconditions_003Ek__BackingField;

		[Token(Token = "0x40011C8")]
		[FieldOffset(Offset = "0x78")]
		public RewardGroup rewardGroup;

		[Token(Token = "0x17000555")]
		public EUnlockType unlockType
		{
			[Token(Token = "0x6001C87")]
			[Address(RVA = "0x96E99C", Offset = "0x96E99C", VA = "0x96E99C")]
			get
			{
				return default(EUnlockType);
			}
		}

		[Token(Token = "0x17000556")]
		public bool isUpgradableUnlockType
		{
			[Token(Token = "0x6001C88")]
			[Address(RVA = "0x9718B0", Offset = "0x9718B0", VA = "0x9718B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8386E0", Offset = "0x8386E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C89")]
			[Address(RVA = "0x9718B8", Offset = "0x9718B8", VA = "0x9718B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8386F0", Offset = "0x8386F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000557")]
		public List<Condition> conditions
		{
			[Token(Token = "0x6001C8A")]
			[Address(RVA = "0x96EA4C", Offset = "0x96EA4C", VA = "0x96EA4C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838700", Offset = "0x838700")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C8B")]
			[Address(RVA = "0x9718C4", Offset = "0x9718C4", VA = "0x9718C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838710", Offset = "0x838710")]
			private set
			{
			}
		}

		[Token(Token = "0x17000558")]
		public string recipeRef
		{
			[Token(Token = "0x6001C8C")]
			[Address(RVA = "0x96E9C8", Offset = "0x96E9C8", VA = "0x96E9C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000559")]
		public string itemConverterRef
		{
			[Token(Token = "0x6001C8D")]
			[Address(RVA = "0x96E9F4", Offset = "0x96E9F4", VA = "0x96E9F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055A")]
		public string category
		{
			[Token(Token = "0x6001C8E")]
			[Address(RVA = "0x96EA20", Offset = "0x96EA20", VA = "0x96EA20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055B")]
		public override string readableItemName
		{
			[Token(Token = "0x6001C8F")]
			[Address(RVA = "0x9718CC", Offset = "0x9718CC", VA = "0x9718CC", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055C")]
		public override string localizedAcquireText
		{
			[Token(Token = "0x6001C90")]
			[Address(RVA = "0x9718F8", Offset = "0x9718F8", VA = "0x9718F8", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001C91")]
		[Address(RVA = "0x96E77C", Offset = "0x96E77C", VA = "0x96E77C")]
		public void Setup(RuntimeDataCache<Condition, RDCondition> conditionsCache, RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache, RuntimeCostResourceCache costResourceCache)
		{
		}

		[Token(Token = "0x6001C92")]
		[Address(RVA = "0x9719BC", Offset = "0x9719BC", VA = "0x9719BC")]
		public Unlocker()
		{
		}
	}
}
