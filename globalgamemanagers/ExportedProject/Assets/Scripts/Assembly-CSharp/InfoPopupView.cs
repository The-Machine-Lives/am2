using System.Runtime.InteropServices;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.Inventory;
using Uken.Library.Web;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000163")]
public class InfoPopupView : CasualView
{
	[Token(Token = "0x400089E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static UkenImageCacher m_webImage;

	[Token(Token = "0x400089F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private AM2Text m_text;

	[Token(Token = "0x40008A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private AM2Image m_image;

	[Token(Token = "0x40008A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x825024", Offset = "0x825024")]
	[SerializeField]
	private GameObject m_dustingParent;

	[Token(Token = "0x40008A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private Button m_dustingButton;

	[Token(Token = "0x40008A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private Button m_decreaseDustingButton;

	[Token(Token = "0x40008A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private Button m_increaseDustingButton;

	[Token(Token = "0x40008A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private Text m_dustingAmountText;

	[Token(Token = "0x40008A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private Text m_dustingMaxAmountText;

	[Token(Token = "0x40008A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[SerializeField]
	private Text m_dustingOutputText;

	[Token(Token = "0x40008A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float m_padding;

	[Token(Token = "0x40008A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private float m_imageFadeTime;

	[Token(Token = "0x40008AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private RectTransform m_buttonTransform;

	[Token(Token = "0x40008AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private IDustable m_dustable;

	[Token(Token = "0x40008AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x40008AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private AM2MessageController m_am2MessageController;

	[Token(Token = "0x40008AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private ConstructionController m_constructionController;

	[Token(Token = "0x40008AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private string m_dustingOutputName;

	[Token(Token = "0x40008B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private long m_dustingAmount;

	[Token(Token = "0x40008B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private long m_quantity;

	[Token(Token = "0x60009BB")]
	[Address(RVA = "0x98B938", Offset = "0x98B938", VA = "0x98B938", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60009BC")]
	[Address(RVA = "0x98BABC", Offset = "0x98BABC", VA = "0x98BABC", Slot = "13")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60009BD")]
	[Address(RVA = "0x98B3B0", Offset = "0x98B3B0", VA = "0x98B3B0")]
	public void Initialize(CasualViewController parentController, string description, RectTransform buttonTransform, [Optional] IInfoText infoText, bool isResearch = false)
	{
	}

	[Token(Token = "0x60009BE")]
	[Address(RVA = "0x98B830", Offset = "0x98B830", VA = "0x98B830")]
	public void Initialize(CasualViewController parentController, IInfoText infoText, RectTransform buttonTransform, bool isResearch)
	{
	}

	[Token(Token = "0x60009BF")]
	[Address(RVA = "0x98C44C", Offset = "0x98C44C", VA = "0x98C44C")]
	private void Dust()
	{
	}

	[Token(Token = "0x60009C0")]
	[Address(RVA = "0x98BC40", Offset = "0x98BC40", VA = "0x98BC40")]
	private void RefreshPivot()
	{
	}

	[Token(Token = "0x60009C1")]
	[Address(RVA = "0x98C6D0", Offset = "0x98C6D0", VA = "0x98C6D0")]
	private InfoPopupPivot GetPivotFromLocation(RectTransform rectTransform)
	{
		return default(InfoPopupPivot);
	}

	[Token(Token = "0x60009C2")]
	[Address(RVA = "0x98BF2C", Offset = "0x98BF2C", VA = "0x98BF2C")]
	private void InitializeImage(IInfoText infoText)
	{
	}

	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x98C964", Offset = "0x98C964", VA = "0x98C964")]
	private void InitializeURLImage(IInfoText infoText)
	{
	}

	[Token(Token = "0x60009C4")]
	[Address(RVA = "0x98CAB4", Offset = "0x98CAB4", VA = "0x98CAB4")]
	private void InitializeResourceImage(IInfoText infoText)
	{
	}

	[Token(Token = "0x60009C5")]
	[Address(RVA = "0x98CBAC", Offset = "0x98CBAC", VA = "0x98CBAC")]
	private void SetSprite(Sprite sprite)
	{
	}

	[Token(Token = "0x60009C6")]
	[Address(RVA = "0x98CD28", Offset = "0x98CD28", VA = "0x98CD28")]
	protected void Update()
	{
	}

	[Token(Token = "0x60009C7")]
	[Address(RVA = "0x98CE28", Offset = "0x98CE28", VA = "0x98CE28")]
	private void ChangeDustingAmount(long delta)
	{
	}

	[Token(Token = "0x60009C8")]
	[Address(RVA = "0x98C168", Offset = "0x98C168", VA = "0x98C168")]
	private void UpdateDustingView()
	{
	}

	[Token(Token = "0x60009C9")]
	[Address(RVA = "0x98CE50", Offset = "0x98CE50", VA = "0x98CE50")]
	public InfoPopupView()
	{
	}

	[Token(Token = "0x60009CB")]
	[Address(RVA = "0x98CEC4", Offset = "0x98CEC4", VA = "0x98CEC4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8345D0", Offset = "0x8345D0")]
	private void _003CAwake_003Eb__20_0()
	{
	}

	[Token(Token = "0x60009CC")]
	[Address(RVA = "0x98CEEC", Offset = "0x98CEEC", VA = "0x98CEEC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8345E0", Offset = "0x8345E0")]
	private void _003CAwake_003Eb__20_1()
	{
	}

	[Token(Token = "0x60009CD")]
	[Address(RVA = "0x98CF14", Offset = "0x98CF14", VA = "0x98CF14")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8345F0", Offset = "0x8345F0")]
	private void _003COnDestroy_003Eb__21_0()
	{
	}

	[Token(Token = "0x60009CE")]
	[Address(RVA = "0x98CF3C", Offset = "0x98CF3C", VA = "0x98CF3C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834600", Offset = "0x834600")]
	private void _003COnDestroy_003Eb__21_1()
	{
	}

	[Token(Token = "0x60009CF")]
	[Address(RVA = "0x98CF64", Offset = "0x98CF64", VA = "0x98CF64")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834610", Offset = "0x834610")]
	private void _003CInitializeURLImage_003Eb__28_0(bool success, Sprite sprite)
	{
	}
}
