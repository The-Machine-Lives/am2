using System;
using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.Observe;
using UnityEngine;

[Token(Token = "0x20000E0")]
public class ZonePageView : ConstructionPageView, IUkenObserver<UntouchedUIMessage>, IUkenObserver<List<Unlocker>>
{
	[Token(Token = "0x40004AF")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject m_zoneItemViewTemplate;

	[Token(Token = "0x40004B0")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject m_zoneListView;

	[Token(Token = "0x40004B1")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private LoadoutView m_loadoutView;

	[Token(Token = "0x40004B2")]
	[FieldOffset(Offset = "0x50")]
	private List<ZoneItemView> m_zoneViews;

	[Token(Token = "0x40004B3")]
	[FieldOffset(Offset = "0x58")]
	private Queue<Func<bool>> m_confirmationChecks;

	[Token(Token = "0x40004B4")]
	[FieldOffset(Offset = "0x60")]
	private ZoneItemView m_pendingZoneItemView;

	[Token(Token = "0x40004B5")]
	[FieldOffset(Offset = "0x68")]
	private UkenUnsubscriber<UntouchedUIMessage> m_zoneSignalHandle;

	[Token(Token = "0x40004B6")]
	[FieldOffset(Offset = "0x70")]
	private UkenUnsubscriber<UntouchedUIMessage> m_loadoutSignalHandle;

	[Token(Token = "0x40004B7")]
	[FieldOffset(Offset = "0x78")]
	private UkenUnsubscriber<UntouchedUIMessage> m_abilitySignalHandle;

	[Token(Token = "0x40004B8")]
	[FieldOffset(Offset = "0x80")]
	private UkenUnsubscriber<List<Unlocker>> m_unlockerSignalHandle;

	[Token(Token = "0x40004B9")]
	[FieldOffset(Offset = "0x88")]
	private UntouchedUIMessage m_latestZoneUIMessage;

	[Token(Token = "0x40004BA")]
	[FieldOffset(Offset = "0x90")]
	private bool m_hasUntouchedLoadoutSlot;

	[Token(Token = "0x40004BB")]
	[FieldOffset(Offset = "0x91")]
	private bool m_hasUntouchedAbilityItems;

	[Token(Token = "0x40004BC")]
	[FieldOffset(Offset = "0x98")]
	private ZoneController m_zoneController;

	[Token(Token = "0x40004BD")]
	[FieldOffset(Offset = "0xA0")]
	private LoadoutController m_loadoutController;

	[Token(Token = "0x40004BE")]
	[FieldOffset(Offset = "0xA8")]
	private AbilitiesController m_abilitiesController;

	[Token(Token = "0x40004BF")]
	[FieldOffset(Offset = "0xB0")]
	private Localizations m_localizationController;

	[Token(Token = "0x40004C0")]
	[FieldOffset(Offset = "0xB8")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x40004C1")]
	[FieldOffset(Offset = "0xC0")]
	private FTUEController m_ftueController;

	[Token(Token = "0x40004C2")]
	[FieldOffset(Offset = "0xC8")]
	private QuestController m_questController;

	[Token(Token = "0x40004C3")]
	[FieldOffset(Offset = "0xD0")]
	private UIAlertController m_uiAlertController;

	[Token(Token = "0x60005F5")]
	[Address(RVA = "0xABA8FC", Offset = "0xABA8FC", VA = "0xABA8FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005F6")]
	[Address(RVA = "0xABB154", Offset = "0xABB154", VA = "0xABB154", Slot = "4")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60005F7")]
	[Address(RVA = "0xABB268", Offset = "0xABB268", VA = "0xABB268", Slot = "6")]
	public override void OnTogglePageOff()
	{
	}

	[Token(Token = "0x60005F8")]
	[Address(RVA = "0xABB3C4", Offset = "0xABB3C4", VA = "0xABB3C4")]
	public void RefreshLoadoutView()
	{
	}

	[Token(Token = "0x60005F9")]
	[Address(RVA = "0xABB29C", Offset = "0xABB29C", VA = "0xABB29C")]
	private void ClearAllNotifications()
	{
	}

	[Token(Token = "0x60005FA")]
	[Address(RVA = "0xABAE6C", Offset = "0xABAE6C", VA = "0xABAE6C")]
	private void RebuildZoneList()
	{
	}

	[Token(Token = "0x60005FB")]
	[Address(RVA = "0xABA7F0", Offset = "0xABA7F0", VA = "0xABA7F0")]
	public void OnSelectZone(ZoneItemView zoneItemView)
	{
	}

	[Token(Token = "0x60005FC")]
	[Address(RVA = "0xABB690", Offset = "0xABB690", VA = "0xABB690")]
	private bool EnsureLoadoutCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60005FD")]
	[Address(RVA = "0xABB97C", Offset = "0xABB97C", VA = "0xABB97C")]
	private void ShowUntrackedQuestsPopup()
	{
	}

	[Token(Token = "0x60005FE")]
	[Address(RVA = "0xABB828", Offset = "0xABB828", VA = "0xABB828")]
	private void ShowBadLoadoutMessage(string message)
	{
	}

	[Token(Token = "0x60005FF")]
	[Address(RVA = "0xABB3DC", Offset = "0xABB3DC", VA = "0xABB3DC")]
	private void ConfirmSelectZone()
	{
	}

	[Token(Token = "0x6000600")]
	[Address(RVA = "0xABBB20", Offset = "0xABBB20", VA = "0xABBB20")]
	private void GoToQuestsTab()
	{
	}

	[Token(Token = "0x6000601")]
	[Address(RVA = "0xABBB54", Offset = "0xABBB54", VA = "0xABBB54", Slot = "8")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CSystem_002ECollections_002EGeneric_002EList_003CAM2_002EReferenceData_002EUnlocker_003E_003E_002EOnEmit(List<Unlocker> unlockers)
	{
	}

	[Token(Token = "0x6000602")]
	[Address(RVA = "0xABBD68", Offset = "0xABBD68", VA = "0xABBD68", Slot = "7")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CUntouchedUIMessage_003E_002EOnEmit(UntouchedUIMessage message)
	{
	}

	[Token(Token = "0x6000603")]
	[Address(RVA = "0xABBB58", Offset = "0xABBB58", VA = "0xABBB58")]
	private void RefreshRedDotNotifications()
	{
	}

	[Token(Token = "0x6000604")]
	[Address(RVA = "0xABBE70", Offset = "0xABBE70", VA = "0xABBE70")]
	public ZonePageView()
	{
	}
}
