using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x2000126")]
public class VIPStatusView : MonoBehaviour
{
	[Token(Token = "0x4000782")]
	private const string c_vipStatusDaysItemReference = "vip_status_days";

	[Token(Token = "0x4000783")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x8247BC", Offset = "0x8247BC")]
	private AM2Button m_vipStatusButton;

	[Token(Token = "0x4000784")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x824808", Offset = "0x824808")]
	private AM2Text m_vipStatusButtonText;

	[Token(Token = "0x4000785")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x824854", Offset = "0x824854")]
	private AM2Text m_vipStatusCountdownText;

	[Token(Token = "0x4000786")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x8248A0", Offset = "0x8248A0")]
	private VIPStatusPopUpView m_vipStatusPopUpViewTemplate;

	[Token(Token = "0x4000787")]
	[FieldOffset(Offset = "0x38")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000788")]
	[FieldOffset(Offset = "0x40")]
	private CasualViewController m_casualViewController;

	[Token(Token = "0x4000789")]
	[FieldOffset(Offset = "0x48")]
	private VIPStatusController m_vipStatusController;

	[Token(Token = "0x400078A")]
	[FieldOffset(Offset = "0x50")]
	private List<GameObject> m_modelViews;

	[Token(Token = "0x400078B")]
	[FieldOffset(Offset = "0x58")]
	private Color m_countdownTimerOriginalTextColor;

	[Token(Token = "0x400078C")]
	[FieldOffset(Offset = "0x68")]
	private string m_disabledText;

	[Token(Token = "0x600087C")]
	[Address(RVA = "0xAB81E0", Offset = "0xAB81E0", VA = "0xAB81E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600087D")]
	[Address(RVA = "0xAB8400", Offset = "0xAB8400", VA = "0xAB8400")]
	public void SetCasualViewController(CasualViewController casualViewController)
	{
	}

	[Token(Token = "0x600087E")]
	[Address(RVA = "0xAB8408", Offset = "0xAB8408", VA = "0xAB8408")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600087F")]
	[Address(RVA = "0xAB84B8", Offset = "0xAB84B8", VA = "0xAB84B8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000880")]
	[Address(RVA = "0xAB8568", Offset = "0xAB8568", VA = "0xAB8568")]
	private void Update()
	{
	}

	[Token(Token = "0x6000881")]
	[Address(RVA = "0xAB856C", Offset = "0xAB856C", VA = "0xAB856C")]
	private void UpdateCountdownText()
	{
	}

	[Token(Token = "0x6000882")]
	[Address(RVA = "0xAB87D0", Offset = "0xAB87D0", VA = "0xAB87D0")]
	public bool HasActiveItems()
	{
		return default(bool);
	}

	[Token(Token = "0x6000883")]
	[Address(RVA = "0xAB890C", Offset = "0xAB890C", VA = "0xAB890C")]
	public void AddItem(GameObject item)
	{
	}

	[Token(Token = "0x6000884")]
	[Address(RVA = "0xAB897C", Offset = "0xAB897C", VA = "0xAB897C")]
	public void ClearItems()
	{
	}

	[Token(Token = "0x6000885")]
	[Address(RVA = "0xAB89DC", Offset = "0xAB89DC", VA = "0xAB89DC")]
	private void OnVIPStatusButtonPressed()
	{
	}

	[Token(Token = "0x6000886")]
	[Address(RVA = "0xAB8AE4", Offset = "0xAB8AE4", VA = "0xAB8AE4")]
	public VIPStatusView()
	{
	}
}
