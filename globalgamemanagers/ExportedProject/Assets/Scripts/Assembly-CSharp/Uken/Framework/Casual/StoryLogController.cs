using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Library.Inventory;
using Uken.Library.Observe;
using Uken.Library.ReferenceData;
using Uken.Library.UINotification;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004BF")]
	public class StoryLogController : DepotController, IInventoryProgressTracker
	{
		[Token(Token = "0x400163C")]
		public const string c_storyLogUINotificationKey = "story_log";

		[Token(Token = "0x400163D")]
		public const string c_storyLogItemReference = "story_log";

		[Token(Token = "0x400163E")]
		[FieldOffset(Offset = "0x20")]
		private Localizations m_localizationController;

		[Token(Token = "0x400163F")]
		[FieldOffset(Offset = "0x28")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x4001640")]
		[FieldOffset(Offset = "0x30")]
		private StoryLogsCache m_storyLogCache;

		[Token(Token = "0x4001641")]
		[FieldOffset(Offset = "0x38")]
		private StoryLogItem m_storyLogItem;

		[Token(Token = "0x4001642")]
		[FieldOffset(Offset = "0x40")]
		protected UINotification<StoryLogUIMessage> m_storyLogUINotification;

		[Token(Token = "0x60023D6")]
		[Address(RVA = "0xA9879C", Offset = "0xA9879C", VA = "0xA9879C")]
		public StoryLogController(CasualDataStoreController dataController, InventoryController inventoryController, Localizations localizationController)
		{
		}

		[Token(Token = "0x60023D7")]
		[Address(RVA = "0xA98840", Offset = "0xA98840", VA = "0xA98840")]
		public UkenUnsubscriber<StoryLogUIMessage> SubscribeToStoryLogUINotifications(IUkenObserver<StoryLogUIMessage> observer)
		{
			return null;
		}

		[Token(Token = "0x60023D8")]
		[Address(RVA = "0xA988B4", Offset = "0xA988B4", VA = "0xA988B4")]
		public StoryLog GetStoryLog(string reference)
		{
			return null;
		}

		[Token(Token = "0x60023D9")]
		[Address(RVA = "0xA98924", Offset = "0xA98924", VA = "0xA98924")]
		public void OnEnterConstructionScene()
		{
		}

		[Token(Token = "0x60023DA")]
		[Address(RVA = "0xA98B30", Offset = "0xA98B30", VA = "0xA98B30")]
		public List<StoryLog> GetUnlockedStoryLogs()
		{
			return null;
		}

		[Token(Token = "0x60023DB")]
		[Address(RVA = "0xA98C9C", Offset = "0xA98C9C", VA = "0xA98C9C", Slot = "8")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x60023DC")]
		[Address(RVA = "0xA98CC4", Offset = "0xA98CC4", VA = "0xA98CC4", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x60023DD")]
		[Address(RVA = "0xA98D7C", Offset = "0xA98D7C", VA = "0xA98D7C", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x60023DE")]
		[Address(RVA = "0xA98F30", Offset = "0xA98F30", VA = "0xA98F30", Slot = "10")]
		public void TrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
		{
		}

		[Token(Token = "0x60023DF")]
		[Address(RVA = "0xA989A0", Offset = "0xA989A0", VA = "0xA989A0")]
		private void TryUnlockStoryLog(string reference, Item item)
		{
		}

		[Token(Token = "0x60023E0")]
		[Address(RVA = "0xA99000", Offset = "0xA99000", VA = "0xA99000")]
		public void ClearStoryLogUINotifications()
		{
		}
	}
}
