using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200039E")]
	public class Quest : RuntimeData<RDQuest>, IItemModel, IInfoText
	{
		[Token(Token = "0x4001181")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D794", Offset = "0x82D794")]
		private QuestItem _003CquestItem_003Ek__BackingField;

		[Token(Token = "0x4001182")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D7A4", Offset = "0x82D7A4")]
		private RewardGroup _003CstartRewardGroup_003Ek__BackingField;

		[Token(Token = "0x4001183")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D7B4", Offset = "0x82D7B4")]
		private RewardGroup _003CcompletionRewardGroup_003Ek__BackingField;

		[Token(Token = "0x4001184")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D7C4", Offset = "0x82D7C4")]
		private List<Task> _003Ctasks_003Ek__BackingField;

		[Token(Token = "0x4001185")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D7D4", Offset = "0x82D7D4")]
		private EventQuest _003CeventQuest_003Ek__BackingField;

		[Token(Token = "0x17000529")]
		public string readableName
		{
			[Token(Token = "0x6001C36")]
			[Address(RVA = "0x9B98D4", Offset = "0x9B98D4", VA = "0x9B98D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700052A")]
		public string shortDescription
		{
			[Token(Token = "0x6001C37")]
			[Address(RVA = "0x9B9900", Offset = "0x9B9900", VA = "0x9B9900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700052B")]
		public string readableItemName
		{
			[Token(Token = "0x6001C38")]
			[Address(RVA = "0x9B992C", Offset = "0x9B992C", VA = "0x9B992C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700052C")]
		public QuestItem questItem
		{
			[Token(Token = "0x6001C39")]
			[Address(RVA = "0x9B9958", Offset = "0x9B9958", VA = "0x9B9958")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838620", Offset = "0x838620")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C3A")]
			[Address(RVA = "0x9B9960", Offset = "0x9B9960", VA = "0x9B9960")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838630", Offset = "0x838630")]
			set
			{
			}
		}

		[Token(Token = "0x1700052D")]
		public bool consumeCostItem
		{
			[Token(Token = "0x6001C3B")]
			[Address(RVA = "0x9B9968", Offset = "0x9B9968", VA = "0x9B9968")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700052E")]
		public string costItemRef
		{
			[Token(Token = "0x6001C3C")]
			[Address(RVA = "0x9B9994", Offset = "0x9B9994", VA = "0x9B9994")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700052F")]
		public long costItemQuantity
		{
			[Token(Token = "0x6001C3D")]
			[Address(RVA = "0x9B99C0", Offset = "0x9B99C0", VA = "0x9B99C0")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000530")]
		public RewardGroup startRewardGroup
		{
			[Token(Token = "0x6001C3E")]
			[Address(RVA = "0x9B99EC", Offset = "0x9B99EC", VA = "0x9B99EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838640", Offset = "0x838640")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C3F")]
			[Address(RVA = "0x9B99F4", Offset = "0x9B99F4", VA = "0x9B99F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838650", Offset = "0x838650")]
			private set
			{
			}
		}

		[Token(Token = "0x17000531")]
		public RewardGroup completionRewardGroup
		{
			[Token(Token = "0x6001C40")]
			[Address(RVA = "0x9B99FC", Offset = "0x9B99FC", VA = "0x9B99FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838660", Offset = "0x838660")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C41")]
			[Address(RVA = "0x9B9A04", Offset = "0x9B9A04", VA = "0x9B9A04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838670", Offset = "0x838670")]
			private set
			{
			}
		}

		[Token(Token = "0x17000532")]
		public List<Task> tasks
		{
			[Token(Token = "0x6001C42")]
			[Address(RVA = "0x9B9A0C", Offset = "0x9B9A0C", VA = "0x9B9A0C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838680", Offset = "0x838680")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C43")]
			[Address(RVA = "0x9B9A14", Offset = "0x9B9A14", VA = "0x9B9A14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838690", Offset = "0x838690")]
			private set
			{
			}
		}

		[Token(Token = "0x17000533")]
		public long maxRepeats
		{
			[Token(Token = "0x6001C44")]
			[Address(RVA = "0x9B9A1C", Offset = "0x9B9A1C", VA = "0x9B9A1C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000534")]
		public List<int> tierRewardLevelsToDisplay
		{
			[Token(Token = "0x6001C45")]
			[Address(RVA = "0x9B9A48", Offset = "0x9B9A48", VA = "0x9B9A48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000535")]
		public string description
		{
			[Token(Token = "0x6001C46")]
			[Address(RVA = "0x9B9A74", Offset = "0x9B9A74", VA = "0x9B9A74", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000536")]
		public string researchInfoText
		{
			[Token(Token = "0x6001C47")]
			[Address(RVA = "0x9B9AA0", Offset = "0x9B9AA0", VA = "0x9B9AA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000537")]
		public string infoImageSource
		{
			[Token(Token = "0x6001C48")]
			[Address(RVA = "0x9B9ACC", Offset = "0x9B9ACC", VA = "0x9B9ACC", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000538")]
		public EventQuest eventQuest
		{
			[Token(Token = "0x6001C49")]
			[Address(RVA = "0x9B9AF8", Offset = "0x9B9AF8", VA = "0x9B9AF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8386A0", Offset = "0x8386A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C4A")]
			[Address(RVA = "0x9B2C64", Offset = "0x9B2C64", VA = "0x9B2C64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8386B0", Offset = "0x8386B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000539")]
		public bool isEvent
		{
			[Token(Token = "0x6001C4B")]
			[Address(RVA = "0x9B9B00", Offset = "0x9B9B00", VA = "0x9B9B00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700053A")]
		public List<string> resetOnFinish
		{
			[Token(Token = "0x6001C4C")]
			[Address(RVA = "0x9B9B10", Offset = "0x9B9B10", VA = "0x9B9B10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001C4D")]
		[Address(RVA = "0x9B9B3C", Offset = "0x9B9B3C", VA = "0x9B9B3C")]
		public Quest()
		{
		}

		[Token(Token = "0x6001C4E")]
		[Address(RVA = "0x9B9BC0", Offset = "0x9B9BC0", VA = "0x9B9BC0")]
		public void Setup(RuntimeDataCache<Task, RDTask> tasksCache, RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache)
		{
		}
	}
}
