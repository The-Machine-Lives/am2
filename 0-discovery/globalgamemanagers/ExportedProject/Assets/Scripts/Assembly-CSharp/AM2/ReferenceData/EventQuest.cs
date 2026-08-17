using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200039B")]
	public class EventQuest : RuntimeData<RDEventQuest>, IItemModel, IInfoText
	{
		[Token(Token = "0x400116D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D308", Offset = "0x82D308")]
		private EventSchedule _003CrepeatingSchedule_003Ek__BackingField;

		[Token(Token = "0x400116E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D318", Offset = "0x82D318")]
		private Quest _003Cquest_003Ek__BackingField;

		[Token(Token = "0x400116F")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D328", Offset = "0x82D328")]
		private RewardGroup _003CstartRewardGroup_003Ek__BackingField;

		[Token(Token = "0x4001170")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D338", Offset = "0x82D338")]
		private RewardGroup _003CendRewardGroup_003Ek__BackingField;

		[Token(Token = "0x4001171")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D348", Offset = "0x82D348")]
		private GlobalLeaderboard _003CglobalLeaderboard_003Ek__BackingField;

		[Token(Token = "0x4001172")]
		[FieldOffset(Offset = "0x40")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x1700051B")]
		public string readableName
		{
			[Token(Token = "0x6001C1D")]
			[Address(RVA = "0x9B251C", Offset = "0x9B251C", VA = "0x9B251C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700051C")]
		public EventSchedule repeatingSchedule
		{
			[Token(Token = "0x6001C1E")]
			[Address(RVA = "0x9B2548", Offset = "0x9B2548", VA = "0x9B2548")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838580", Offset = "0x838580")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C1F")]
			[Address(RVA = "0x9B2550", Offset = "0x9B2550", VA = "0x9B2550")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838590", Offset = "0x838590")]
			private set
			{
			}
		}

		[Token(Token = "0x1700051D")]
		public Quest quest
		{
			[Token(Token = "0x6001C20")]
			[Address(RVA = "0x9B2558", Offset = "0x9B2558", VA = "0x9B2558")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8385A0", Offset = "0x8385A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C21")]
			[Address(RVA = "0x9B2560", Offset = "0x9B2560", VA = "0x9B2560")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8385B0", Offset = "0x8385B0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700051E")]
		public RewardGroup startRewardGroup
		{
			[Token(Token = "0x6001C22")]
			[Address(RVA = "0x9B2568", Offset = "0x9B2568", VA = "0x9B2568")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8385C0", Offset = "0x8385C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C23")]
			[Address(RVA = "0x9B2570", Offset = "0x9B2570", VA = "0x9B2570")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8385D0", Offset = "0x8385D0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700051F")]
		public RewardGroup endRewardGroup
		{
			[Token(Token = "0x6001C24")]
			[Address(RVA = "0x9B2578", Offset = "0x9B2578", VA = "0x9B2578")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8385E0", Offset = "0x8385E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C25")]
			[Address(RVA = "0x9B2580", Offset = "0x9B2580", VA = "0x9B2580")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8385F0", Offset = "0x8385F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000520")]
		public GlobalLeaderboard globalLeaderboard
		{
			[Token(Token = "0x6001C26")]
			[Address(RVA = "0x9B2588", Offset = "0x9B2588", VA = "0x9B2588")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838600", Offset = "0x838600")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C27")]
			[Address(RVA = "0x9B2590", Offset = "0x9B2590", VA = "0x9B2590")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838610", Offset = "0x838610")]
			private set
			{
			}
		}

		[Token(Token = "0x17000521")]
		public string readableItemName
		{
			[Token(Token = "0x6001C28")]
			[Address(RVA = "0x9B2598", Offset = "0x9B2598", VA = "0x9B2598", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000522")]
		public string readableNameWithEventPrefix
		{
			[Token(Token = "0x6001C29")]
			[Address(RVA = "0x9B259C", Offset = "0x9B259C", VA = "0x9B259C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000523")]
		public List<string> resetOnFinish
		{
			[Token(Token = "0x6001C2A")]
			[Address(RVA = "0x9B2600", Offset = "0x9B2600", VA = "0x9B2600")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000524")]
		public string description
		{
			[Token(Token = "0x6001C2B")]
			[Address(RVA = "0x9B262C", Offset = "0x9B262C", VA = "0x9B262C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000525")]
		public string researchInfoText
		{
			[Token(Token = "0x6001C2C")]
			[Address(RVA = "0x9B267C", Offset = "0x9B267C", VA = "0x9B267C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000526")]
		public string infoImageSource
		{
			[Token(Token = "0x6001C2D")]
			[Address(RVA = "0x9B26CC", Offset = "0x9B26CC", VA = "0x9B26CC", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000527")]
		public bool displayQuestProgressIndividually
		{
			[Token(Token = "0x6001C2E")]
			[Address(RVA = "0x9B271C", Offset = "0x9B271C", VA = "0x9B271C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000528")]
		public string unlockerReference
		{
			[Token(Token = "0x6001C2F")]
			[Address(RVA = "0x9B2748", Offset = "0x9B2748", VA = "0x9B2748")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001C30")]
		[Address(RVA = "0x9B2774", Offset = "0x9B2774", VA = "0x9B2774")]
		public EventQuest()
		{
		}

		[Token(Token = "0x6001C31")]
		[Address(RVA = "0x9B27C4", Offset = "0x9B27C4", VA = "0x9B27C4")]
		public void Setup(RuntimeDataCache<Quest, RDQuest> questsCache)
		{
		}

		[Token(Token = "0x6001C32")]
		[Address(RVA = "0x9B2C74", Offset = "0x9B2C74", VA = "0x9B2C74")]
		public bool HasRequiredUnlocker()
		{
			return default(bool);
		}
	}
}
