using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000133")]
[Attribute(Name = "RequireComponent", RVA = "0x81E6BC", Offset = "0x81E6BC")]
public class AM2AnimationButton : AM2Button
{
	[Token(Token = "0x40007BE")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	private AM2Button m_targetButton;

	[Token(Token = "0x40007BF")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private AnimationView m_animationView;

	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x9793E0", Offset = "0x9793E0", VA = "0x9793E0", Slot = "44")]
	public override void ButtonClicked()
	{
	}

	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x979510", Offset = "0x979510", VA = "0x979510")]
	public AM2AnimationButton()
	{
	}
}
