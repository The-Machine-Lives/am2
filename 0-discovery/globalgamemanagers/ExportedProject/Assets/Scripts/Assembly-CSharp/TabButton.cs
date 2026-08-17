using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000121")]
public class TabButton : MonoBehaviour
{
	[Token(Token = "0x2000634")]
	public delegate void RedDotNotificationVisiblie(bool visible);

	[Token(Token = "0x400075C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TabController m_controller;

	[Token(Token = "0x400075D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Toggle m_toggle;

	[Token(Token = "0x400075E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image m_image;

	[Token(Token = "0x400075F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AM2Text m_text;

	[Token(Token = "0x4000760")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ConstructionPageView m_page;

	[Token(Token = "0x4000761")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject m_redDotNotification;

	[Token(Token = "0x4000762")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject m_greenDotNotification;

	[Token(Token = "0x4000763")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private BISoundEvents.EventKey m_onClickSound;

	[Token(Token = "0x4000764")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private bool m_playSound;

	[Token(Token = "0x4000765")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private string m_tabPressEventName;

	[Token(Token = "0x4000766")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x824690", Offset = "0x824690")]
	private int _003Cpriority_003Ek__BackingField;

	[Token(Token = "0x4000767")]
	[FieldOffset(Offset = "0x70")]
	private string m_readableName;

	[Token(Token = "0x4000768")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8246A0", Offset = "0x8246A0")]
	private string _003CtabReference_003Ek__BackingField;

	[Token(Token = "0x4000769")]
	[FieldOffset(Offset = "0x80")]
	private string m_uiPreferencesKey;

	[Token(Token = "0x400076A")]
	[FieldOffset(Offset = "0x88")]
	private BISoundEvents.EventKey m_onClickSoundOverride;

	[Token(Token = "0x400076B")]
	[FieldOffset(Offset = "0x90")]
	private CasualAnalog m_casualAnalogController;

	[Token(Token = "0x170000FB")]
	public int priority
	{
		[Token(Token = "0x6000846")]
		[Address(RVA = "0xA10AB4", Offset = "0xA10AB4", VA = "0xA10AB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834324", Offset = "0x834324")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000847")]
		[Address(RVA = "0xA1109C", Offset = "0xA1109C", VA = "0xA1109C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834334", Offset = "0x834334")]
		private set
		{
		}
	}

	[Token(Token = "0x170000FC")]
	public string tabReference
	{
		[Token(Token = "0x6000848")]
		[Address(RVA = "0xA110A4", Offset = "0xA110A4", VA = "0xA110A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834344", Offset = "0x834344")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000849")]
		[Address(RVA = "0xA110AC", Offset = "0xA110AC", VA = "0xA110AC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834354", Offset = "0x834354")]
		private set
		{
		}
	}

	[Token(Token = "0x170000FD")]
	public bool isStartingTab
	{
		[Token(Token = "0x600084A")]
		[Address(RVA = "0xA110B4", Offset = "0xA110B4", VA = "0xA110B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000002")]
	public event RedDotNotificationVisiblie OnRedDotNotificationVisibilityChanged
	{
		[Token(Token = "0x6000844")]
		[Address(RVA = "0xA10EC4", Offset = "0xA10EC4", VA = "0xA10EC4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834304", Offset = "0x834304")]
		add
		{
		}
		[Token(Token = "0x6000845")]
		[Address(RVA = "0xA10FB0", Offset = "0xA10FB0", VA = "0xA10FB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834314", Offset = "0x834314")]
		remove
		{
		}
	}

	[Token(Token = "0x600084B")]
	[Address(RVA = "0xA106C8", Offset = "0xA106C8", VA = "0xA106C8")]
	public void Initialize(ConstructionPageView inPage, TabController inController, ToggleGroup inToggleGroup, string subTabShortName, string subTabName, int inPriority, string reference, string tabPressEventName)
	{
	}

	[Token(Token = "0x600084C")]
	[Address(RVA = "0xA111A4", Offset = "0xA111A4", VA = "0xA111A4")]
	private void Start()
	{
	}

	[Token(Token = "0x600084D")]
	[Address(RVA = "0xA112FC", Offset = "0xA112FC", VA = "0xA112FC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600084E")]
	[Address(RVA = "0xA11364", Offset = "0xA11364", VA = "0xA11364")]
	public void Select()
	{
	}

	[Token(Token = "0x600084F")]
	[Address(RVA = "0xA0E550", Offset = "0xA0E550", VA = "0xA0E550")]
	public bool Selected()
	{
		return default(bool);
	}

	[Token(Token = "0x6000850")]
	[Address(RVA = "0xA11398", Offset = "0xA11398", VA = "0xA11398")]
	public void RefreshSelection()
	{
	}

	[Token(Token = "0x6000851")]
	[Address(RVA = "0xA113F0", Offset = "0xA113F0", VA = "0xA113F0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000852")]
	[Address(RVA = "0xA113F8", Offset = "0xA113F8", VA = "0xA113F8")]
	public void OnLock()
	{
	}

	[Token(Token = "0x6000853")]
	[Address(RVA = "0xA11524", Offset = "0xA11524", VA = "0xA11524")]
	public void OnUnlock()
	{
	}

	[Token(Token = "0x6000854")]
	[Address(RVA = "0xA11698", Offset = "0xA11698", VA = "0xA11698")]
	public void OnPressed(bool value)
	{
	}

	[Token(Token = "0x6000855")]
	[Address(RVA = "0xA11794", Offset = "0xA11794", VA = "0xA11794")]
	public void OnPressedShortcut(bool value)
	{
	}

	[Token(Token = "0x6000856")]
	[Address(RVA = "0xA1170C", Offset = "0xA1170C", VA = "0xA1170C")]
	private void UpdateAfterPress(bool value)
	{
	}

	[Token(Token = "0x6000857")]
	[Address(RVA = "0xA117AC", Offset = "0xA117AC", VA = "0xA117AC")]
	public void TogglePage(bool isOn)
	{
	}

	[Token(Token = "0x6000858")]
	[Address(RVA = "0xA110DC", Offset = "0xA110DC", VA = "0xA110DC")]
	public void SetText(string text)
	{
	}

	[Token(Token = "0x6000859")]
	[Address(RVA = "0xA1119C", Offset = "0xA1119C", VA = "0xA1119C")]
	public void SetReadableName(string text)
	{
	}

	[Token(Token = "0x600085A")]
	[Address(RVA = "0xA118A8", Offset = "0xA118A8", VA = "0xA118A8")]
	public void SetAmbientSoundKey(BISoundEvents.EventKey ambientSoundKey)
	{
	}

	[Token(Token = "0x600085B")]
	[Address(RVA = "0xA118E0", Offset = "0xA118E0", VA = "0xA118E0")]
	public void SetOnClickSoundOverride(BISoundEvents.EventKey onClickSoundOverride)
	{
	}

	[Token(Token = "0x600085C")]
	[Address(RVA = "0xA118E8", Offset = "0xA118E8", VA = "0xA118E8")]
	public bool IsRedDotVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x600085D")]
	[Address(RVA = "0xA11918", Offset = "0xA11918", VA = "0xA11918")]
	public void ShowRedDotNotification(bool show)
	{
	}

	[Token(Token = "0x600085E")]
	[Address(RVA = "0xA11DC0", Offset = "0xA11DC0", VA = "0xA11DC0")]
	public void ShowGreenDotNotification(bool show)
	{
	}

	[Token(Token = "0x600085F")]
	[Address(RVA = "0xA11330", Offset = "0xA11330", VA = "0xA11330")]
	public void SetTitleToReadableName()
	{
	}

	[Token(Token = "0x6000860")]
	[Address(RVA = "0xA11F94", Offset = "0xA11F94", VA = "0xA11F94")]
	public TabButton()
	{
	}
}
