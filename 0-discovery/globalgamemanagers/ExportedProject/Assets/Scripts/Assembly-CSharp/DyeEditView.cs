using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x20000F9")]
public class DyeEditView : MonoBehaviour
{
	[Token(Token = "0x40005AE")]
	private const float c_dyeWidth = 100f;

	[Token(Token = "0x40005AF")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform m_noDyeTextContainer;

	[Token(Token = "0x40005B0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GraphicEffectView m_noDyeTextEffectTemplate;

	[Token(Token = "0x40005B1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ProfilePageView m_profilePageView;

	[Token(Token = "0x40005B2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private BadgeScrollableSelector m_dyeSelector;

	[Token(Token = "0x40005B3")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AutoScrollableView m_autoScrollableView;

	[Token(Token = "0x40005B4")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private BadgeSwapper m_dyeItemViewTemplate;

	[Token(Token = "0x40005B5")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AM2Button m_confirmButton;

	[Token(Token = "0x40005B6")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AM2Button m_cancelButton;

	[Token(Token = "0x40005B7")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x823968", Offset = "0x823968")]
	private List<DyeEditView> m_dyeEditViews;

	[Token(Token = "0x40005B8")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8239B4", Offset = "0x8239B4")]
	private Dye _003CactiveDye_003Ek__BackingField;

	[Token(Token = "0x40005B9")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<string, BadgeSwapper> m_dyeItemViews;

	[Token(Token = "0x40005BA")]
	[FieldOffset(Offset = "0x70")]
	private CasualViewController m_viewController;

	[Token(Token = "0x40005BB")]
	[FieldOffset(Offset = "0x78")]
	private GraphicEffectView m_currentNoDyeTextEffect;

	[Token(Token = "0x40005BC")]
	[FieldOffset(Offset = "0x80")]
	private ProfilePageController m_profilePageController;

	[Token(Token = "0x40005BD")]
	[FieldOffset(Offset = "0x88")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x40005BE")]
	[FieldOffset(Offset = "0x90")]
	private bool m_ownedDyesPopulated;

	[Token(Token = "0x40005BF")]
	[FieldOffset(Offset = "0x91")]
	private bool m_isOpen;

	[Token(Token = "0x170000DD")]
	public Dye activeDye
	{
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x9C2190", Offset = "0x9C2190", VA = "0x9C2190")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833FF0", Offset = "0x833FF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x9C2198", Offset = "0x9C2198", VA = "0x9C2198")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834000", Offset = "0x834000")]
		set
		{
		}
	}

	[Token(Token = "0x6000697")]
	[Address(RVA = "0x9C21A0", Offset = "0x9C21A0", VA = "0x9C21A0")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6000698")]
	[Address(RVA = "0x9C2310", Offset = "0x9C2310", VA = "0x9C2310")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6000699")]
	[Address(RVA = "0x9C2530", Offset = "0x9C2530", VA = "0x9C2530")]
	public void Initialize(CasualViewController viewController, Dye inActiveDye)
	{
	}

	[Token(Token = "0x600069A")]
	[Address(RVA = "0x9C26A0", Offset = "0x9C26A0", VA = "0x9C26A0")]
	protected bool PopulateOwnedDyes()
	{
		return default(bool);
	}

	[Token(Token = "0x600069B")]
	[Address(RVA = "0x9C28F0", Offset = "0x9C28F0", VA = "0x9C28F0")]
	private void ResetSelectorPosition()
	{
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0x9C29D0", Offset = "0x9C29D0", VA = "0x9C29D0")]
	public void ToggleViewOpen()
	{
	}

	[Token(Token = "0x600069D")]
	[Address(RVA = "0x9C2A68", Offset = "0x9C2A68", VA = "0x9C2A68")]
	public void OpenView()
	{
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0x9C29E0", Offset = "0x9C29E0", VA = "0x9C29E0")]
	public void CloseView()
	{
	}

	[Token(Token = "0x600069F")]
	[Address(RVA = "0x9C2D20", Offset = "0x9C2D20", VA = "0x9C2D20")]
	public void OnClickConfirmDye()
	{
	}

	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x9C2EAC", Offset = "0x9C2EAC", VA = "0x9C2EAC")]
	private void OnConfirmApplyDye()
	{
	}

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x9C2F6C", Offset = "0x9C2F6C", VA = "0x9C2F6C")]
	public void RemoveDieFromList(Dye dyeToRemove, bool alertOtherDyeEditViews = false)
	{
	}

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x9C31EC", Offset = "0x9C31EC", VA = "0x9C31EC")]
	public void OnClickCancel()
	{
	}

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x9C2C2C", Offset = "0x9C2C2C", VA = "0x9C2C2C")]
	private void OnDyeTargetChanged(GameObject gameObject)
	{
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x9C31F0", Offset = "0x9C31F0", VA = "0x9C31F0")]
	public DyeEditView()
	{
	}
}
