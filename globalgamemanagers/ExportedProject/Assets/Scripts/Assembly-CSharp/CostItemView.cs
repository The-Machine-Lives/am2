using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x20000C9")]
public class CostItemView : MonoBehaviour
{
	[Token(Token = "0x4000354")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected AM2Text m_amountText;

	[Token(Token = "0x4000355")]
	[FieldOffset(Offset = "0x20")]
	private Item m_costItem;

	[Token(Token = "0x4000356")]
	[FieldOffset(Offset = "0x28")]
	private long m_cost;

	[Token(Token = "0x4000357")]
	[FieldOffset(Offset = "0x30")]
	private long m_previousCost;

	[Token(Token = "0x4000358")]
	[FieldOffset(Offset = "0x38")]
	private long m_previousItemQuantity;

	[Token(Token = "0x4000359")]
	[FieldOffset(Offset = "0x40")]
	private long m_previousLevel;

	[Token(Token = "0x400035A")]
	[FieldOffset(Offset = "0x48")]
	private Localizations m_localizationController;

	[Token(Token = "0x400035B")]
	[FieldOffset(Offset = "0x50")]
	private ItemMinimalDetails m_itemDetails;

	[Token(Token = "0x400035C")]
	[FieldOffset(Offset = "0x58")]
	private bool m_showTitle;

	[Token(Token = "0x400035D")]
	[FieldOffset(Offset = "0x59")]
	private bool m_showLevel;

	[Token(Token = "0x400035E")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8225CC", Offset = "0x8225CC")]
	private string _003Cformat_003Ek__BackingField;

	[Token(Token = "0x400035F")]
	[FieldOffset(Offset = "0x68")]
	private string m_textValueHexColor;

	[Token(Token = "0x170000CE")]
	public string format
	{
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x9C04EC", Offset = "0x9C04EC", VA = "0x9C04EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833E4C", Offset = "0x833E4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x9C04F4", Offset = "0x9C04F4", VA = "0x9C04F4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833E5C", Offset = "0x833E5C")]
		set
		{
		}
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x9C04FC", Offset = "0x9C04FC", VA = "0x9C04FC")]
	public void Initialize(long cost, Item costItem, bool showTitle, bool showLevel = false, bool refreshFormat = true)
	{
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x9C0720", Offset = "0x9C0720", VA = "0x9C0720")]
	public void UpdateCost(long cost)
	{
	}

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x9C072C", Offset = "0x9C072C", VA = "0x9C072C")]
	public void DisableText()
	{
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x9C0778", Offset = "0x9C0778", VA = "0x9C0778")]
	private void Update()
	{
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x9C0C8C", Offset = "0x9C0C8C", VA = "0x9C0C8C")]
	public CostItemView()
	{
	}
}
