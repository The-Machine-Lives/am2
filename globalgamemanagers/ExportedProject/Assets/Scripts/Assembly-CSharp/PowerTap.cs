using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.UkenTime;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x20000E6")]
public class PowerTap : Button
{
	[Token(Token = "0x4000512")]
	[FieldOffset(Offset = "0xE0")]
	private PowerController m_powerController;

	[Token(Token = "0x4000513")]
	[FieldOffset(Offset = "0xE8")]
	private ConstructionController m_constructionController;

	[Token(Token = "0x4000514")]
	[FieldOffset(Offset = "0xF0")]
	private UkenTimeController m_timeController;

	[Token(Token = "0x6000626")]
	[Address(RVA = "0x9DD184", Offset = "0x9DD184", VA = "0x9DD184")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000627")]
	[Address(RVA = "0x9DD358", Offset = "0x9DD358", VA = "0x9DD358", Slot = "32")]
	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0x9DD394", Offset = "0x9DD394", VA = "0x9DD394")]
	public PowerTap()
	{
	}
}
