using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200013E")]
public class BIBadge : MonoBehaviour
{
	[Token(Token = "0x4000800")]
	[FieldOffset(Offset = "0x18")]
	public CanvasGroup m_Vis;

	[Token(Token = "0x4000801")]
	[FieldOffset(Offset = "0x20")]
	public Text m_Text;

	[Token(Token = "0x6000902")]
	[Address(RVA = "0xA3C494", Offset = "0xA3C494", VA = "0xA3C494")]
	public void SetBadge(bool state, string text = "!")
	{
	}

	[Token(Token = "0x6000903")]
	[Address(RVA = "0xA3C5C8", Offset = "0xA3C5C8", VA = "0xA3C5C8")]
	public BIBadge()
	{
	}
}
