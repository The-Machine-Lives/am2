using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Inventory;
using Uken.Library.Observe;
using Uken.Library.UINotification;

namespace AM2
{
	[Token(Token = "0x200030C")]
	public class UIAlertController : UkenController, IInventoryProgressTracker
	{
		[Token(Token = "0x20007A5")]
		private class UIAlertNotification : UINotification<UntouchedUIMessage>
		{
			[Token(Token = "0x4002246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832F50", Offset = "0x832F50")]
			private bool _003CnotifyOnlyOnce_003Ek__BackingField;

			[Token(Token = "0x4002247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<string> m_alreadyEmittedElements;

			[Token(Token = "0x17000807")]
			public bool notifyOnlyOnce
			{
				[Token(Token = "0x600319F")]
				[Address(RVA = "0x9789C0", Offset = "0x9789C0", VA = "0x9789C0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B78C", Offset = "0x83B78C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60031A0")]
				[Address(RVA = "0x9779C4", Offset = "0x9779C4", VA = "0x9779C4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B79C", Offset = "0x83B79C")]
				set
				{
				}
			}

			[Token(Token = "0x60031A1")]
			[Address(RVA = "0x977624", Offset = "0x977624", VA = "0x977624")]
			public UIAlertNotification(string name)
			{
			}

			[Token(Token = "0x60031A2")]
			[Address(RVA = "0x978190", Offset = "0x978190", VA = "0x978190")]
			public bool AddUntouchedElementByReference(string reference)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000E64")]
		private const string c_untouchedUIMessageKey = "alert_";

		[Token(Token = "0x4000E65")]
		private const string c_untouchedResearchMessageKey = "res";

		[Token(Token = "0x4000E66")]
		private const string c_untouchedCustomKeys = "keys";

		[Token(Token = "0x4000E67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, UIAlertNotification> m_untouchedElementsByItemType;

		[Token(Token = "0x4000E68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, HashSet<string>> m_ignoredItemReferences;

		[Token(Token = "0x4000E69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UIAlertNotification m_untouchedResearchNotification;

		[Token(Token = "0x4000E6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<string> m_persistentResearchItemTypes;

		[Token(Token = "0x4000E6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<UIAlertNotification> m_dirtyNotifications;

		[Token(Token = "0x4000E6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AM2InventoryController m_inventoryController;

		[Token(Token = "0x6001871")]
		[Address(RVA = "0x977474", Offset = "0x977474", VA = "0x977474")]
		public static string GetNotificationKeyForItemType(string itemType)
		{
			return null;
		}

		[Token(Token = "0x6001872")]
		[Address(RVA = "0x9774C8", Offset = "0x9774C8", VA = "0x9774C8")]
		public UIAlertController(AM2InventoryController inventoryController)
		{
		}

		[Token(Token = "0x6001873")]
		[Address(RVA = "0x9776AC", Offset = "0x9776AC", VA = "0x9776AC")]
		public void RegisterItemType(string itemType, bool isPersistentResearchItemType = false, [Optional] List<string> ignoredItemReferences, bool emitOnItemRemoval = true, bool notifyOnlyOnce = false)
		{
		}

		[Token(Token = "0x6001874")]
		[Address(RVA = "0x9779D0", Offset = "0x9779D0", VA = "0x9779D0")]
		public UkenUnsubscriber<UntouchedUIMessage> SubscribeToCustomKeys(IUkenObserver<UntouchedUIMessage> observer, bool signalOnSubscribe)
		{
			return null;
		}

		[Token(Token = "0x6001875")]
		[Address(RVA = "0x977A38", Offset = "0x977A38", VA = "0x977A38")]
		public UkenUnsubscriber<UntouchedUIMessage> SubscribeToItemType(string itemType, IUkenObserver<UntouchedUIMessage> observer, bool signalOnSubscribe)
		{
			return null;
		}

		[Token(Token = "0x6001876")]
		[Address(RVA = "0x977AC4", Offset = "0x977AC4", VA = "0x977AC4")]
		public UkenUnsubscriber<UntouchedUIMessage> SubscribeToResearch(IUkenObserver<UntouchedUIMessage> observer, bool signalOnSubscribe)
		{
			return null;
		}

		[Token(Token = "0x6001877")]
		[Address(RVA = "0x977B3C", Offset = "0x977B3C", VA = "0x977B3C")]
		public UntouchedUIMessage GetResearchMessage()
		{
			return null;
		}

		[Token(Token = "0x6001878")]
		[Address(RVA = "0x977B9C", Offset = "0x977B9C", VA = "0x977B9C")]
		public UntouchedUIMessage GetMessageForItemType(string itemType)
		{
			return null;
		}

		[Token(Token = "0x6001879")]
		[Address(RVA = "0x977C48", Offset = "0x977C48", VA = "0x977C48")]
		public void SetMessageForItemType(string itemType, UntouchedUIMessage updatedUIMessage, EEmitType emitType = EEmitType.None)
		{
		}

		[Token(Token = "0x600187A")]
		[Address(RVA = "0x977D00", Offset = "0x977D00", VA = "0x977D00")]
		public void SetCustomKeyViewed(string customKey)
		{
		}

		[Token(Token = "0x600187B")]
		[Address(RVA = "0x977E4C", Offset = "0x977E4C", VA = "0x977E4C")]
		public void AddCustomKeyAsUntouched(string customKey)
		{
		}

		[Token(Token = "0x600187C")]
		[Address(RVA = "0x977F64", Offset = "0x977F64", VA = "0x977F64")]
		public void SetAllItemsViewed(string uiNotificationKey, EEmitType emitType = EEmitType.None)
		{
		}

		[Token(Token = "0x600187D")]
		[Address(RVA = "0x9780EC", Offset = "0x9780EC", VA = "0x9780EC")]
		public void SetItemViewed(string reference, bool forceNotification = false)
		{
		}

		[Token(Token = "0x600187E")]
		[Address(RVA = "0x977D64", Offset = "0x977D64", VA = "0x977D64")]
		private void SetItemViewed(string uiNotificationKey, string reference, bool forceNotification = false)
		{
		}

		[Token(Token = "0x600187F")]
		[Address(RVA = "0x978160", Offset = "0x978160", VA = "0x978160")]
		public void AddItemAsUntouched(string itemType, string reference)
		{
		}

		[Token(Token = "0x6001880")]
		[Address(RVA = "0x977EB8", Offset = "0x977EB8", VA = "0x977EB8")]
		private void AddItemAsUntouched(UIAlertNotification uiNotification, string reference)
		{
		}

		[Token(Token = "0x6001881")]
		[Address(RVA = "0x978258", Offset = "0x978258", VA = "0x978258")]
		private void OnItemRemoved(UIAlertNotification uiNotification, string reference)
		{
		}

		[Token(Token = "0x6001882")]
		[Address(RVA = "0x9783A0", Offset = "0x9783A0", VA = "0x9783A0")]
		public void SetResearchNotificationDirty()
		{
		}

		[Token(Token = "0x6001883")]
		[Address(RVA = "0x978414", Offset = "0x978414", VA = "0x978414")]
		public void AddResearchAsUntouched(string reference, bool forceNotification = false)
		{
		}

		[Token(Token = "0x6001884")]
		[Address(RVA = "0x9784F0", Offset = "0x9784F0", VA = "0x9784F0")]
		public void SetResearchViewed(string reference, bool forceNotification = false)
		{
		}

		[Token(Token = "0x6001885")]
		[Address(RVA = "0x978028", Offset = "0x978028", VA = "0x978028")]
		private void SetNotificationMessage(UIAlertNotification uiNotification, UntouchedUIMessage message, EEmitType emitType = EEmitType.SetDirty)
		{
		}

		[Token(Token = "0x6001886")]
		[Address(RVA = "0x9778A8", Offset = "0x9778A8", VA = "0x9778A8")]
		private UIAlertNotification FindOrCreateNotificationForItemType(string itemType)
		{
			return null;
		}

		[Token(Token = "0x6001887")]
		[Address(RVA = "0x9785CC", Offset = "0x9785CC", VA = "0x9785CC", Slot = "10")]
		public void TrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
		{
		}

		[Token(Token = "0x6001888")]
		[Address(RVA = "0x978820", Offset = "0x978820", VA = "0x978820", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}
	}
}
