using System;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x2000167")]
public class LoadoutSettingPopupView : CasualView
{
	[Token(Token = "0x2000647")]
	public enum SortMode
	{
		[Token(Token = "0x4001F3D")]
		Ammo = 0,
		[Token(Token = "0x4001F3E")]
		Alphabetical = 1,
		[Token(Token = "0x4001F3F")]
		ReverseAlphabetical = 2,
		[Token(Token = "0x4001F40")]
		Count = 3
	}

	[Token(Token = "0x40008BE")]
	public const string c_sortModeKey = "loadout_popup_view_sort_mode";

	[Token(Token = "0x40008BF")]
	public const string c_showAbilityNoAmmo = "loadout_popup_view_show_ability_no_ammo";

	[Token(Token = "0x40008C0")]
	private const string c_sort_mode_alphabetical_text = "A-Z";

	[Token(Token = "0x40008C1")]
	private const string c_sort_mode_reverse_alphabetical_text = "Z-A";

	[Token(Token = "0x40008C2")]
	private const string c_sort_mode_ammo_text = "Ammo";

	[Token(Token = "0x40008C3")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private AM2Button m_sortCycleButton;

	[Token(Token = "0x40008C4")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private AM2Text m_sortCycleButtonText;

	[Token(Token = "0x40008C5")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private AM2Button m_showAbilityNoAmmoButton;

	[Token(Token = "0x40008C6")]
	[FieldOffset(Offset = "0xD8")]
	private Action m_onClose;

	[Token(Token = "0x60009DD")]
	[Address(RVA = "0x998A30", Offset = "0x998A30", VA = "0x998A30", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60009DE")]
	[Address(RVA = "0x998B50", Offset = "0x998B50", VA = "0x998B50", Slot = "13")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60009DF")]
	[Address(RVA = "0x9984BC", Offset = "0x9984BC", VA = "0x9984BC")]
	public void Initialize(CasualViewController parentController, Action onClose)
	{
	}

	[Token(Token = "0x60009E0")]
	[Address(RVA = "0x998DE4", Offset = "0x998DE4", VA = "0x998DE4")]
	private void CycleSortMode()
	{
	}

	[Token(Token = "0x60009E1")]
	[Address(RVA = "0x998C70", Offset = "0x998C70", VA = "0x998C70")]
	private void SetSortModeString(SortMode mode)
	{
	}

	[Token(Token = "0x60009E2")]
	[Address(RVA = "0x998E78", Offset = "0x998E78", VA = "0x998E78", Slot = "14")]
	public override void OnCloseClicked()
	{
	}

	[Token(Token = "0x60009E3")]
	[Address(RVA = "0x998E84", Offset = "0x998E84", VA = "0x998E84")]
	private void ToggleShowAbilityNoAmmo()
	{
	}

	[Token(Token = "0x60009E4")]
	[Address(RVA = "0x998D40", Offset = "0x998D40", VA = "0x998D40")]
	private void SetShowAbilityNoAmmoText(bool showAbilityNoAmmo)
	{
	}

	[Token(Token = "0x60009E5")]
	[Address(RVA = "0x998F00", Offset = "0x998F00", VA = "0x998F00")]
	public LoadoutSettingPopupView()
	{
	}
}
