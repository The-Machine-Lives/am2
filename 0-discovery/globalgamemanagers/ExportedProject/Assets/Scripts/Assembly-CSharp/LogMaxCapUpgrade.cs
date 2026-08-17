using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200019B")]
public class LogMaxCapUpgrade : MonoBehaviour
{
	[Token(Token = "0x40009B0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Button m_upgradeButton;

	[Token(Token = "0x40009B1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RecipeUpgradableItemView m_upgradableView;

	[Token(Token = "0x6000B15")]
	[Address(RVA = "0x999D78", Offset = "0x999D78", VA = "0x999D78")]
	private void Start()
	{
	}

	[Token(Token = "0x6000B16")]
	[Address(RVA = "0x999E28", Offset = "0x999E28", VA = "0x999E28")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000B17")]
	[Address(RVA = "0x999ED8", Offset = "0x999ED8", VA = "0x999ED8")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000B18")]
	[Address(RVA = "0x999F10", Offset = "0x999F10", VA = "0x999F10")]
	public LogMaxCapUpgrade()
	{
	}
}
