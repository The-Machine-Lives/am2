using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000068")]
public class AbilitySlotView : MonoBehaviour
{
	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject m_backgroundView;

	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform m_abilityViewParent;

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xACC540", Offset = "0xACC540", VA = "0xACC540")]
	public void SetSlotActive(bool slotActive)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xACC578", Offset = "0xACC578", VA = "0xACC578")]
	public Transform GetAbilityViewParent()
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xACC580", Offset = "0xACC580", VA = "0xACC580")]
	public AbilitySlotView()
	{
	}
}
