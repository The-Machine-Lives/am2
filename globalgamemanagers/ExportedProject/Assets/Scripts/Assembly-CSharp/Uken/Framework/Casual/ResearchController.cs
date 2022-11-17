using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Observe;
using Uken.Library.UINotification;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004B3")]
	public class ResearchController : UkenController, IUkenObserver<UntouchedUIMessage>
	{
		[Token(Token = "0x40015E8")]
		public const string c_researchUINotificationKey = "research";

		[Token(Token = "0x40015E9")]
		[FieldOffset(Offset = "0x18")]
		protected UkenObservable<List<ResearchSlotItem>> m_researchSlotSignal;

		[Token(Token = "0x40015EA")]
		[FieldOffset(Offset = "0x20")]
		protected UINotification<ResearchUIMessage> m_researchUINotification;

		[Token(Token = "0x40015EB")]
		[FieldOffset(Offset = "0x28")]
		private UkenUnsubscriber<UntouchedUIMessage> m_researchSignalHandle;

		[Token(Token = "0x40015EC")]
		[FieldOffset(Offset = "0x30")]
		private AM2InventoryController m_inventoryController;

		[Token(Token = "0x40015ED")]
		[FieldOffset(Offset = "0x38")]
		private ConstructionController m_constructionController;

		[Token(Token = "0x40015EE")]
		[FieldOffset(Offset = "0x40")]
		private AM2MessageController m_am2MessageController;

		[Token(Token = "0x40015EF")]
		[FieldOffset(Offset = "0x48")]
		private UkenTimeController m_time;

		[Token(Token = "0x40015F0")]
		[FieldOffset(Offset = "0x50")]
		private UIAlertController m_uiAlertController;

		[Token(Token = "0x40015F1")]
		[FieldOffset(Offset = "0x58")]
		private FTUEController m_ftueController;

		[Token(Token = "0x40015F2")]
		[FieldOffset(Offset = "0x60")]
		private SpeedBoosterController m_speedBoosterController;

		[Token(Token = "0x6002339")]
		[Address(RVA = "0xA862C0", Offset = "0xA862C0", VA = "0xA862C0")]
		public ResearchController(AM2InventoryController inventoryController, UkenTimeController time, ConstructionController constructionController, AM2MessageController am2MessageController, UIAlertController uiAlertController, FTUEController ftueController, SpeedBoosterController speedBoosterController)
		{
		}

		[Token(Token = "0x600233A")]
		[Address(RVA = "0xA863EC", Offset = "0xA863EC", VA = "0xA863EC", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x600233B")]
		[Address(RVA = "0xA86834", Offset = "0xA86834", VA = "0xA86834", Slot = "8")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x600233C")]
		[Address(RVA = "0xA866C0", Offset = "0xA866C0", VA = "0xA866C0")]
		private void AddResearchAsUntouchedForBuyType(EBuyType buyType)
		{
		}

		[Token(Token = "0x600233D")]
		[Address(RVA = "0xA868A0", Offset = "0xA868A0", VA = "0xA868A0")]
		private bool AnyResearchableOfBuyType(EBuyType buyType, HashSet<string> untouchedRefs)
		{
			return default(bool);
		}

		[Token(Token = "0x600233E")]
		[Address(RVA = "0xA86A24", Offset = "0xA86A24", VA = "0xA86A24")]
		public UkenUnsubscriber<List<ResearchSlotItem>> SubscribeToResearchSlotUpdates(IUkenObserver<List<ResearchSlotItem>> observer, bool signalOnSubscribe)
		{
			return null;
		}

		[Token(Token = "0x600233F")]
		[Address(RVA = "0xA86A9C", Offset = "0xA86A9C", VA = "0xA86A9C")]
		public UkenUnsubscriber<ResearchUIMessage> SubscribeToResearchUINotifications(IUkenObserver<ResearchUIMessage> observer)
		{
			return null;
		}

		[Token(Token = "0x6002340")]
		[Address(RVA = "0xA86B10", Offset = "0xA86B10", VA = "0xA86B10", Slot = "10")]
		private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CUntouchedUIMessage_003E_002EOnEmit(UntouchedUIMessage untouchedUIMessage)
		{
		}

		[Token(Token = "0x6002341")]
		[Address(RVA = "0xA86B44", Offset = "0xA86B44", VA = "0xA86B44")]
		private void UpdateUntouchedResearchAndNotify(HashSet<string> untouchedResearch)
		{
		}

		[Token(Token = "0x6002342")]
		[Address(RVA = "0xA86C58", Offset = "0xA86C58", VA = "0xA86C58")]
		private void UpdateResearchCompletionAndNotify(long completedCount)
		{
		}

		[Token(Token = "0x6002343")]
		[Address(RVA = "0xA86D44", Offset = "0xA86D44", VA = "0xA86D44", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6002344")]
		[Address(RVA = "0xA86DE4", Offset = "0xA86DE4", VA = "0xA86DE4")]
		private void UpdateResearch(float deltaTime)
		{
		}

		[Token(Token = "0x6002345")]
		[Address(RVA = "0xA76A90", Offset = "0xA76A90", VA = "0xA76A90")]
		public bool UpdateResearchSlotItem(ResearchSlotItem researchSlotItem, double deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6002346")]
		[Address(RVA = "0xA87518", Offset = "0xA87518", VA = "0xA87518")]
		public bool InstantBuyMultiple(Upgradable upgradable, int maxQuantity = 5000)
		{
			return default(bool);
		}

		[Token(Token = "0x6002347")]
		[Address(RVA = "0xA8777C", Offset = "0xA8777C", VA = "0xA8777C")]
		public bool TryInstantResearch(IResearchable researchable)
		{
			return default(bool);
		}

		[Token(Token = "0x6002348")]
		[Address(RVA = "0xA87BBC", Offset = "0xA87BBC", VA = "0xA87BBC")]
		private void ShowResearchAcquiredMesssage(IResearchable researchable)
		{
		}

		[Token(Token = "0x6002349")]
		[Address(RVA = "0xA87E0C", Offset = "0xA87E0C", VA = "0xA87E0C")]
		public ResearchSlotItem UpdateResearchSlotWithResearchable(long slotIndex, IResearchable researchable)
		{
			return null;
		}

		[Token(Token = "0x600234A")]
		[Address(RVA = "0xA86FD8", Offset = "0xA86FD8", VA = "0xA86FD8")]
		public List<ResearchSlotItem> GetAllResearchSlotItemsInOrder()
		{
			return null;
		}

		[Token(Token = "0x600234B")]
		[Address(RVA = "0xA75E38", Offset = "0xA75E38", VA = "0xA75E38")]
		public List<ResearchSlotItem> GetAllActiveResearchSlotItemsInOrder()
		{
			return null;
		}

		[Token(Token = "0x600234C")]
		[Address(RVA = "0xA88248", Offset = "0xA88248", VA = "0xA88248")]
		public bool IsCurrentlyResearching(string refDataRef)
		{
			return default(bool);
		}

		[Token(Token = "0x600234D")]
		[Address(RVA = "0xA88334", Offset = "0xA88334", VA = "0xA88334")]
		public void CompleteAndAwardResearch(IResearchable researchable, ResearchSlotItem researchSlotItem)
		{
		}

		[Token(Token = "0x600234E")]
		[Address(RVA = "0xA883B4", Offset = "0xA883B4", VA = "0xA883B4")]
		public void RemoveFromResearchSlot(IResearchable researchable, ResearchSlotItem researchSlotItem)
		{
		}

		[Token(Token = "0x600234F")]
		[Address(RVA = "0xA87D28", Offset = "0xA87D28", VA = "0xA87D28")]
		private void IncrementResearchable(IResearchable researchable)
		{
		}

		[Token(Token = "0x6002350")]
		[Address(RVA = "0xA87128", Offset = "0xA87128", VA = "0xA87128")]
		private void UpdateResearchItemProgress(IResearchable researchable, ResearchSlotItem researchSlotItem, long resourceSpent)
		{
		}
	}
}
