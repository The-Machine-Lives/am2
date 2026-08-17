using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

[Token(Token = "0x20001AA")]
public class TitleItemView : MonoBehaviour
{
	[Token(Token = "0x40009FA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Button m_selectButton;

	[Token(Token = "0x40009FB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public AM2Text m_text;

	[Token(Token = "0x40009FC")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82566C", Offset = "0x82566C")]
	private IReadable _003Ctitle_003Ek__BackingField;

	[Token(Token = "0x40009FD")]
	[FieldOffset(Offset = "0x30")]
	private AutoScrollableView m_parentView;

	[Token(Token = "0x1700016A")]
	public IReadable title
	{
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0xA144D4", Offset = "0xA144D4", VA = "0xA144D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8348D8", Offset = "0x8348D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0xA144F8", Offset = "0xA144F8", VA = "0xA144F8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8348E8", Offset = "0x8348E8")]
		private set
		{
		}
	}

	[Token(Token = "0x6000B9C")]
	[Address(RVA = "0xA14500", Offset = "0xA14500", VA = "0xA14500")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6000B9D")]
	[Address(RVA = "0xA145B4", Offset = "0xA145B4", VA = "0xA145B4")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6000B9E")]
	[Address(RVA = "0xA13F50", Offset = "0xA13F50", VA = "0xA13F50")]
	public void Initialize(IReadable inTitle, AutoScrollableView parentView)
	{
	}

	[Token(Token = "0x6000B9F")]
	[Address(RVA = "0xA14668", Offset = "0xA14668", VA = "0xA14668")]
	protected void SelectButtonPressed()
	{
	}

	[Token(Token = "0x6000BA0")]
	[Address(RVA = "0xA146B0", Offset = "0xA146B0", VA = "0xA146B0")]
	public TitleItemView()
	{
	}
}
