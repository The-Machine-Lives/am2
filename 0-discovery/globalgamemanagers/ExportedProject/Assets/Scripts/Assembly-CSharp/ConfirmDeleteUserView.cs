using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200019F")]
public class ConfirmDeleteUserView : MonoBehaviour
{
	[Token(Token = "0x40009C5")]
	[FieldOffset(Offset = "0x0")]
	public static string c_confirmString;

	[Token(Token = "0x40009C6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private InputField m_confirmText;

	[Token(Token = "0x6000B33")]
	[Address(RVA = "0x9BD7A4", Offset = "0x9BD7A4", VA = "0x9BD7A4")]
	public bool ConfirmTextValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6000B34")]
	[Address(RVA = "0x9BD83C", Offset = "0x9BD83C", VA = "0x9BD83C")]
	public ConfirmDeleteUserView()
	{
	}
}
