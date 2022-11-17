using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Observe;
using UnityEngine;

[Token(Token = "0x20000C7")]
public class ConstructionTabController : TabController, IUkenObserver<List<Unlocker>>
{
	[Token(Token = "0x400033B")]
	private const string c_powerTabKey = "powerTab";

	[Token(Token = "0x400033C")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected ConstructionViewController m_viewController;

	[Token(Token = "0x400033D")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<EUnlockType> m_tabUnlockTypes;

	[Token(Token = "0x400033E")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private CasualSceneController m_sceneController;

	[Token(Token = "0x400033F")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<EUnlockType, TabButton> m_tabButtonsDict;

	[Token(Token = "0x4000340")]
	[FieldOffset(Offset = "0x88")]
	private UkenUnsubscriber<List<Unlocker>> m_signalHandle;

	[Token(Token = "0x4000341")]
	[FieldOffset(Offset = "0x90")]
	private ConstructionController m_constructionController;

	[Token(Token = "0x4000342")]
	[FieldOffset(Offset = "0x98")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000343")]
	[FieldOffset(Offset = "0xA0")]
	private List<string> tabKeys;

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x9BE06C", Offset = "0x9BE06C", VA = "0x9BE06C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x9BE7F8", Offset = "0x9BE7F8", VA = "0x9BE7F8")]
	private void SetStartingTabIndex(EUnlockType tabType)
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x9BE8BC", Offset = "0x9BE8BC", VA = "0x9BE8BC")]
	public bool IsTabSelected(EUnlockType tabType)
	{
		return default(bool);
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x9BEA00", Offset = "0x9BEA00", VA = "0x9BEA00", Slot = "5")]
	public override void OnClickedButton(TabButton clickedButton)
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x9BEA3C", Offset = "0x9BEA3C", VA = "0x9BEA3C")]
	public void GoToTab(EUnlockType tabType)
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x9BEB08", Offset = "0x9BEB08", VA = "0x9BEB08")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x9BE978", Offset = "0x9BE978", VA = "0x9BE978")]
	private TabButton GetTabButtonForUnlockType(EUnlockType tabType)
	{
		return null;
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x9BEB64", Offset = "0x9BEB64", VA = "0x9BEB64", Slot = "6")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CSystem_002ECollections_002EGeneric_002EList_003CAM2_002EReferenceData_002EUnlocker_003E_003E_002EOnEmit(List<Unlocker> unlockers)
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x9BEFD0", Offset = "0x9BEFD0", VA = "0x9BEFD0")]
	public ConstructionTabController()
	{
	}
}
