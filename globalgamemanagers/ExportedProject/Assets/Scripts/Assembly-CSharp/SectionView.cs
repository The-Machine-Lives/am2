using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Library.Animation;
using UnityEngine;

[Token(Token = "0x200011A")]
public class SectionView : MonoBehaviour
{
	[Token(Token = "0x4000724")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Text titleText;

	[Token(Token = "0x4000725")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private DropdownButton m_trayButton;

	[Token(Token = "0x4000726")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform m_trayArrow;

	[Token(Token = "0x4000727")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform m_trayParent;

	[Token(Token = "0x4000728")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform m_childrenContainer;

	[Token(Token = "0x4000729")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8244B0", Offset = "0x8244B0")]
	private SubTab _003CsubTab_003Ek__BackingField;

	[Token(Token = "0x400072A")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8244C0", Offset = "0x8244C0")]
	private Section _003Csection_003Ek__BackingField;

	[Token(Token = "0x400072B")]
	[FieldOffset(Offset = "0x50")]
	private bool m_trayOpen;

	[Token(Token = "0x400072C")]
	[FieldOffset(Offset = "0x58")]
	private UkenAnimFloat m_trayAnim;

	[Token(Token = "0x400072D")]
	[FieldOffset(Offset = "0x60")]
	private float m_openTraySize;

	[Token(Token = "0x400072E")]
	[FieldOffset(Offset = "0x64")]
	private float m_closedTraySize;

	[Token(Token = "0x400072F")]
	[FieldOffset(Offset = "0x68")]
	private float m_trayAnimDuration;

	[Token(Token = "0x4000730")]
	[FieldOffset(Offset = "0x6C")]
	private float m_currentHeight;

	[Token(Token = "0x4000731")]
	[FieldOffset(Offset = "0x70")]
	protected float m_previousContentTransformHeight;

	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x74")]
	private bool m_isResizeDeferred;

	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x78")]
	private string m_uiPreferencesKey;

	[Token(Token = "0x170000F2")]
	public Transform childContainer
	{
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x9FEABC", Offset = "0x9FEABC", VA = "0x9FEABC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000F3")]
	public SubTab subTab
	{
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x9FEAC4", Offset = "0x9FEAC4", VA = "0x9FEAC4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834254", Offset = "0x834254")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x9FEACC", Offset = "0x9FEACC", VA = "0x9FEACC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834264", Offset = "0x834264")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F4")]
	public Section section
	{
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x9FEAD4", Offset = "0x9FEAD4", VA = "0x9FEAD4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834274", Offset = "0x834274")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x9FEADC", Offset = "0x9FEADC", VA = "0x9FEADC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834284", Offset = "0x834284")]
		private set
		{
		}
	}

	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x9FEAE4", Offset = "0x9FEAE4", VA = "0x9FEAE4")]
	public void Initialize(Section inSection, SubTab inSubTab)
	{
	}

	[Token(Token = "0x60007FC")]
	[Address(RVA = "0x9FEC44", Offset = "0x9FEC44", VA = "0x9FEC44")]
	public void SetSiblingIndex(int index)
	{
	}

	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x9FEBFC", Offset = "0x9FEBFC", VA = "0x9FEBFC")]
	private void StartClosed()
	{
	}

	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x9FED88", Offset = "0x9FED88", VA = "0x9FED88")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x9FEEB8", Offset = "0x9FEEB8", VA = "0x9FEEB8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000800")]
	[Address(RVA = "0x9FEF68", Offset = "0x9FEF68", VA = "0x9FEF68")]
	protected void Update()
	{
	}

	[Token(Token = "0x6000801")]
	[Address(RVA = "0x9FEF6C", Offset = "0x9FEF6C", VA = "0x9FEF6C")]
	private void UpdateContentSize()
	{
	}

	[Token(Token = "0x6000802")]
	[Address(RVA = "0x9FF060", Offset = "0x9FF060", VA = "0x9FF060")]
	private void OnResizedContent()
	{
	}

	[Token(Token = "0x6000803")]
	[Address(RVA = "0x9FF108", Offset = "0x9FF108", VA = "0x9FF108")]
	public void OnItemAdded()
	{
	}

	[Token(Token = "0x6000804")]
	[Address(RVA = "0x9FF10C", Offset = "0x9FF10C", VA = "0x9FF10C")]
	public void ToggleTrayOpen()
	{
	}

	[Token(Token = "0x6000805")]
	[Address(RVA = "0x9FF144", Offset = "0x9FF144", VA = "0x9FF144")]
	public void OpenTray(bool open)
	{
	}

	[Token(Token = "0x6000806")]
	[Address(RVA = "0x9FEC80", Offset = "0x9FEC80", VA = "0x9FEC80")]
	private void OnUpdateViewHeight(float height)
	{
	}

	[Token(Token = "0x6000807")]
	[Address(RVA = "0x9FF330", Offset = "0x9FF330", VA = "0x9FF330")]
	private void OnDoneOpen()
	{
	}

	[Token(Token = "0x6000808")]
	[Address(RVA = "0x9FF3E8", Offset = "0x9FF3E8", VA = "0x9FF3E8")]
	private void OnDoneClose()
	{
	}

	[Token(Token = "0x6000809")]
	[Address(RVA = "0x9FF3F0", Offset = "0x9FF3F0", VA = "0x9FF3F0")]
	public SectionView()
	{
	}
}
