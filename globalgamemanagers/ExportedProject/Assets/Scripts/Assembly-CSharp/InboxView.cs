using System;
using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.Observe;
using UnityEngine;

[Token(Token = "0x2000214")]
public class InboxView : MonoBehaviour, IUkenObserver<List<MessageItem>>, IUkenObserver<List<Unlocker>>
{
	[Serializable]
	[Token(Token = "0x200066E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820688", Offset = "0x820688")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001FB3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001FB4")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<MessageItem> _003C_003E9__20_0;

		[Token(Token = "0x4001FB5")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<MessageItem> _003C_003E9__21_0;

		[Token(Token = "0x6002DC6")]
		[Address(RVA = "0x98AC94", Offset = "0x98AC94", VA = "0x98AC94")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002DC7")]
		[Address(RVA = "0x98AC9C", Offset = "0x98AC9C", VA = "0x98AC9C")]
		internal bool _003CUpdate_003Eb__20_0(MessageItem message)
		{
			return default(bool);
		}

		[Token(Token = "0x6002DC8")]
		[Address(RVA = "0x98ACD4", Offset = "0x98ACD4", VA = "0x98ACD4")]
		internal bool _003COpenInbox_003Eb__21_0(MessageItem message)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000BD0")]
	private const string c_inboxClickLogEventName = "inbox_header_click";

	[Token(Token = "0x4000BD1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ConstructionViewController m_constructionViewController;

	[Token(Token = "0x4000BD2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Button m_inboxButton;

	[Token(Token = "0x4000BD3")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private InboxPopup m_inboxPopupPrefab;

	[Token(Token = "0x4000BD4")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AM2Image m_notificationIcon;

	[Token(Token = "0x4000BD5")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AM2Text m_notificationText;

	[Token(Token = "0x4000BD6")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform m_noMessagesTextContainer;

	[Token(Token = "0x4000BD7")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GraphicEffectView m_noMessagesTextEffectTemplate;

	[Token(Token = "0x4000BD8")]
	[FieldOffset(Offset = "0x50")]
	private GraphicEffectView m_currentNoMessagesTextEffect;

	[Token(Token = "0x4000BD9")]
	[FieldOffset(Offset = "0x58")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x4000BDA")]
	[FieldOffset(Offset = "0x60")]
	private FTUEController m_ftueController;

	[Token(Token = "0x4000BDB")]
	[FieldOffset(Offset = "0x68")]
	private CasualAnalog m_casualAnalogController;

	[Token(Token = "0x4000BDC")]
	[FieldOffset(Offset = "0x70")]
	private List<MessageItem> m_messages;

	[Token(Token = "0x4000BDD")]
	[FieldOffset(Offset = "0x78")]
	private UkenUnsubscriber<List<MessageItem>> m_messageUnsubscriber;

	[Token(Token = "0x4000BDE")]
	[FieldOffset(Offset = "0x80")]
	private UkenUnsubscriber<List<Unlocker>> m_unlockerSignalHandle;

	[Token(Token = "0x4000BDF")]
	[FieldOffset(Offset = "0x88")]
	private InboxPopup m_popup;

	[Token(Token = "0x6000E29")]
	[Address(RVA = "0x98A134", Offset = "0x98A134", VA = "0x98A134", Slot = "4")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CSystem_002ECollections_002EGeneric_002EList_003CMessageItem_003E_003E_002EOnEmit(List<MessageItem> value)
	{
	}

	[Token(Token = "0x6000E2A")]
	[Address(RVA = "0x98A1E4", Offset = "0x98A1E4", VA = "0x98A1E4", Slot = "5")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CSystem_002ECollections_002EGeneric_002EList_003CAM2_002EReferenceData_002EUnlocker_003E_003E_002EOnEmit(List<Unlocker> unlockers)
	{
	}

	[Token(Token = "0x6000E2B")]
	[Address(RVA = "0x98A344", Offset = "0x98A344", VA = "0x98A344")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000E2C")]
	[Address(RVA = "0x98A640", Offset = "0x98A640", VA = "0x98A640")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000E2D")]
	[Address(RVA = "0x98A714", Offset = "0x98A714", VA = "0x98A714")]
	private void Update()
	{
	}

	[Token(Token = "0x6000E2E")]
	[Address(RVA = "0x98A8CC", Offset = "0x98A8CC", VA = "0x98A8CC")]
	private void OpenInbox()
	{
	}

	[Token(Token = "0x6000E2F")]
	[Address(RVA = "0x98ABC0", Offset = "0x98ABC0", VA = "0x98ABC0")]
	public InboxView()
	{
	}
}
