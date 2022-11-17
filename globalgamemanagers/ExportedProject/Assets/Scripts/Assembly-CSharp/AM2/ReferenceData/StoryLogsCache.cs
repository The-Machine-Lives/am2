using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003A9")]
	public class StoryLogsCache : RuntimeDataCache<StoryLog, RDStoryLog>
	{
		[Token(Token = "0x20007A9")]
		private class GroupedStoryLogs
		{
			[Token(Token = "0x4002253")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832F90", Offset = "0x832F90")]
			private SortedDictionary<long, StoryLog> _003CstoryLogsByUnlockAmount_003Ek__BackingField;

			[Token(Token = "0x1700080B")]
			public SortedDictionary<long, StoryLog> storyLogsByUnlockAmount
			{
				[Token(Token = "0x60031AE")]
				[Address(RVA = "0x9708C4", Offset = "0x9708C4", VA = "0x9708C4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B80C", Offset = "0x83B80C")]
				get
				{
					return null;
				}
				[Token(Token = "0x60031AF")]
				[Address(RVA = "0x970DD0", Offset = "0x970DD0", VA = "0x970DD0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B81C", Offset = "0x83B81C")]
				set
				{
				}
			}

			[Token(Token = "0x60031B0")]
			[Address(RVA = "0x970D5C", Offset = "0x970D5C", VA = "0x970D5C")]
			public GroupedStoryLogs()
			{
			}
		}

		[Token(Token = "0x4001194")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, GroupedStoryLogs> m_lockedStoryLogs;

		[Token(Token = "0x4001195")]
		[FieldOffset(Offset = "0x40")]
		protected StoryLogItem m_storyLogItem;

		[Token(Token = "0x6001C6A")]
		[Address(RVA = "0x9705A0", Offset = "0x9705A0", VA = "0x9705A0")]
		public StoryLogsCache(DepotEntity<RDStoryLog> depot, StoryLogItem storyLogItem)
		{
		}

		[Token(Token = "0x6001C6B")]
		[Address(RVA = "0x970634", Offset = "0x970634", VA = "0x970634")]
		public bool ShouldTrackAllTimeQuantityOfItem(string itemRef)
		{
			return default(bool);
		}

		[Token(Token = "0x6001C6C")]
		[Address(RVA = "0x9706A4", Offset = "0x9706A4", VA = "0x9706A4")]
		public bool TryUnlockStoryLog(string itemRef, long alltimeQuantity, out StoryLog unlockedStoryLog)
		{
			return default(bool);
		}

		[Token(Token = "0x6001C6D")]
		[Address(RVA = "0x9708CC", Offset = "0x9708CC", VA = "0x9708CC", Slot = "5")]
		protected override StoryLog CreateRuntimeData(string reference, RDStoryLog refDataDocument)
		{
			return null;
		}
	}
}
