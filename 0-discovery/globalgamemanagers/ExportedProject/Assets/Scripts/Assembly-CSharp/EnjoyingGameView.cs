using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x20001B3")]
public class EnjoyingGameView : CasualViewBase
{
	[Token(Token = "0x4000A4C")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	protected GameObject ratingPopupViewTemplate;

	[Token(Token = "0x4000A4D")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	protected GameObject tellUsWhyPopupViewTemplate;

	[Token(Token = "0x6000BD6")]
	[Address(RVA = "0x9C4C38", Offset = "0x9C4C38", VA = "0x9C4C38")]
	public void Init()
	{
	}

	[Token(Token = "0x6000BD7")]
	[Address(RVA = "0x9C4C40", Offset = "0x9C4C40", VA = "0x9C4C40")]
	public void OnClickYes()
	{
	}

	[Token(Token = "0x6000BD8")]
	[Address(RVA = "0x9C4D54", Offset = "0x9C4D54", VA = "0x9C4D54")]
	public void OnClickNo()
	{
	}

	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0x9C4E68", Offset = "0x9C4E68", VA = "0x9C4E68")]
	public EnjoyingGameView()
	{
	}
}
