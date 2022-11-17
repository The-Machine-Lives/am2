using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Web;
using UnityEngine;

[Token(Token = "0x20001CB")]
public class ProductViewItem : BaseProductView
{
	[Token(Token = "0x4000A8F")]
	[FieldOffset(Offset = "0x30")]
	public AM2Text m_quantityText;

	[Token(Token = "0x4000A90")]
	[FieldOffset(Offset = "0x38")]
	public AM2Text m_itemNameText;

	[Token(Token = "0x4000A91")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_badgeObject;

	[Token(Token = "0x4000A92")]
	[FieldOffset(Offset = "0x48")]
	public AM2Text m_badgeTextTop;

	[Token(Token = "0x4000A93")]
	[FieldOffset(Offset = "0x50")]
	public AM2Text m_badgeTextBottom;

	[Token(Token = "0x6000C4A")]
	[Address(RVA = "0x9E0978", Offset = "0x9E0978", VA = "0x9E0978", Slot = "4")]
	public override void Initialize(Product product, UkenImageCacher imageCacher)
	{
	}

	[Token(Token = "0x6000C4B")]
	[Address(RVA = "0x9E0D74", Offset = "0x9E0D74", VA = "0x9E0D74")]
	public ProductViewItem()
	{
	}
}
