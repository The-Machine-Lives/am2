using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

[Token(Token = "0x2000129")]
public class VolumeMultiplierView : MonoBehaviour
{
	[Token(Token = "0x4000790")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected AM2Button m_button;

	[Token(Token = "0x4000791")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected AM2Text m_volumeText;

	[Token(Token = "0x4000792")]
	[FieldOffset(Offset = "0x28")]
	private List<ProductionVolumeMode> m_volumeIncrements;

	[Token(Token = "0x4000793")]
	[FieldOffset(Offset = "0x30")]
	private int m_currentVolumeIncrementIndex;

	[Token(Token = "0x4000794")]
	[FieldOffset(Offset = "0x38")]
	private List<IVolumeModeItem> m_items;

	[Token(Token = "0x4000795")]
	private const string c_volumePlayerPrefsKey = "uken_local_item_convert_volume";

	[Token(Token = "0x4000796")]
	[FieldOffset(Offset = "0x40")]
	private Localizations m_localizationController;

	[Token(Token = "0x17000102")]
	public ProductionVolumeMode volumeMode
	{
		[Token(Token = "0x6000890")]
		[Address(RVA = "0xAB8DFC", Offset = "0xAB8DFC", VA = "0xAB8DFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000891")]
	[Address(RVA = "0xAB8E64", Offset = "0xAB8E64", VA = "0xAB8E64")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000892")]
	[Address(RVA = "0xAB8FB8", Offset = "0xAB8FB8", VA = "0xAB8FB8")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000893")]
	[Address(RVA = "0xAB9128", Offset = "0xAB9128", VA = "0xAB9128")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000894")]
	[Address(RVA = "0xAB91D8", Offset = "0xAB91D8", VA = "0xAB91D8")]
	public void ClearItems()
	{
	}

	[Token(Token = "0x6000895")]
	[Address(RVA = "0xAB9238", Offset = "0xAB9238", VA = "0xAB9238")]
	public bool HasActiveItems()
	{
		return default(bool);
	}

	[Token(Token = "0x6000896")]
	[Address(RVA = "0xAB93A4", Offset = "0xAB93A4", VA = "0xAB93A4")]
	public void AddItem(IVolumeModeItem item)
	{
	}

	[Token(Token = "0x6000897")]
	[Address(RVA = "0xAB9414", Offset = "0xAB9414", VA = "0xAB9414")]
	public void ChangeVolumeMode()
	{
	}

	[Token(Token = "0x6000898")]
	[Address(RVA = "0xAB903C", Offset = "0xAB903C", VA = "0xAB903C")]
	private void UpdateButtonText()
	{
	}

	[Token(Token = "0x6000899")]
	[Address(RVA = "0xAB8FDC", Offset = "0xAB8FDC", VA = "0xAB8FDC")]
	public void LoadVolumePlayerPrefs()
	{
	}

	[Token(Token = "0x600089A")]
	[Address(RVA = "0xAB94A0", Offset = "0xAB94A0", VA = "0xAB94A0")]
	public void RefreshViewAndItemViews()
	{
	}

	[Token(Token = "0x600089B")]
	[Address(RVA = "0xAB9648", Offset = "0xAB9648", VA = "0xAB9648")]
	public void SaveVolumePlayerPrefs()
	{
	}

	[Token(Token = "0x600089C")]
	[Address(RVA = "0xAB96A4", Offset = "0xAB96A4", VA = "0xAB96A4")]
	public VolumeMultiplierView()
	{
	}
}
