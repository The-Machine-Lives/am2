using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Observe;
using UnityEngine;

[Token(Token = "0x20000D4")]
public class MenuShortcuts : MonoBehaviour, IUkenObserver<List<Unlocker>>
{
	[Token(Token = "0x40003C8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TabButton m_tabButtonToSelect;

	[Token(Token = "0x40003C9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Button m_shortcutButton;

	[Token(Token = "0x40003CA")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private StorePageView m_storePageView;

	[Token(Token = "0x40003CB")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string m_subtabRefDataReference;

	[Token(Token = "0x40003CC")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject m_notificationIcon;

	[Token(Token = "0x40003CD")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private EUnlockType m_requiredUnlocker;

	[Token(Token = "0x40003CE")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string m_clickLogEventName;

	[Token(Token = "0x40003CF")]
	[FieldOffset(Offset = "0x50")]
	private TabButton m_subTabButton;

	[Token(Token = "0x40003D0")]
	[FieldOffset(Offset = "0x58")]
	private UkenUnsubscriber<List<Unlocker>> m_unlockerSignalHandle;

	[Token(Token = "0x40003D1")]
	[FieldOffset(Offset = "0x60")]
	private FTUEController m_ftueController;

	[Token(Token = "0x40003D2")]
	[FieldOffset(Offset = "0x68")]
	private CasualAnalog m_casualAnalogController;

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x99A7F4", Offset = "0x99A7F4", VA = "0x99A7F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600055E")]
	[Address(RVA = "0x99A97C", Offset = "0x99A97C", VA = "0x99A97C")]
	private void Start()
	{
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x99AC94", Offset = "0x99AC94", VA = "0x99AC94")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x99ADC4", Offset = "0x99ADC4", VA = "0x99ADC4")]
	private void UpdateNotificationIconVisibility(bool visible)
	{
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x99ADFC", Offset = "0x99ADFC", VA = "0x99ADFC", Slot = "4")]
	public void OnEmit(List<Unlocker> unlockers)
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x99AA64", Offset = "0x99AA64", VA = "0x99AA64")]
	private bool TryToAssignSubTabReference()
	{
		return default(bool);
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0x99AF94", Offset = "0x99AF94", VA = "0x99AF94")]
	private void OnPressEvent()
	{
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x99AFF0", Offset = "0x99AFF0", VA = "0x99AFF0")]
	public MenuShortcuts()
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0x99AFF8", Offset = "0x99AFF8", VA = "0x99AFF8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833EAC", Offset = "0x833EAC")]
	private void _003CStart_003Eb__12_0()
	{
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0x99B02C", Offset = "0x99B02C", VA = "0x99B02C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833EBC", Offset = "0x833EBC")]
	private bool _003CTryToAssignSubTabReference_003Eb__16_0(TabButton tabButton)
	{
		return default(bool);
	}
}
