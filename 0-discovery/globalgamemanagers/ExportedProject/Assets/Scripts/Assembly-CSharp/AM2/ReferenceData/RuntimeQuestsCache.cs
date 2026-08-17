using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200039F")]
	public class RuntimeQuestsCache : RuntimeVisiblyUnlockableDataCache<Quest, RDQuest, QuestItem>
	{
		[Token(Token = "0x4001186")]
		[FieldOffset(Offset = "0x58")]
		private RuntimeDataCache<Task, RDTask> m_tasksCache;

		[Token(Token = "0x4001187")]
		[FieldOffset(Offset = "0x60")]
		private RuntimeDataCache<RewardGroup, RDRewardGroup> m_rewardGroupsCache;

		[Token(Token = "0x6001C4F")]
		[Address(RVA = "0x96CF98", Offset = "0x96CF98", VA = "0x96CF98")]
		public RuntimeQuestsCache(DepotEntity<RDQuest> depot, RuntimeDataCache<Task, RDTask> taskCache, RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache)
		{
		}

		[Token(Token = "0x6001C50")]
		[Address(RVA = "0x96D020", Offset = "0x96D020", VA = "0x96D020", Slot = "5")]
		protected override Quest CreateRuntimeData(string reference, RDQuest refDataDocument)
		{
			return null;
		}

		[Token(Token = "0x6001C51")]
		[Address(RVA = "0x96D0B4", Offset = "0x96D0B4", VA = "0x96D0B4")]
		private bool IsUnlockedAndIncompleteQuest(QuestItem questItem)
		{
			return default(bool);
		}
	}
}
