using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000CF")]
public class IngredientView : MonoBehaviour
{
	[Token(Token = "0x400037E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected AM2Text m_text;

	[Token(Token = "0x400037F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected CostItemView m_costView;

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x98DDDC", Offset = "0x98DDDC", VA = "0x98DDDC")]
	public void Initialize(long cost, string itemRef)
	{
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x98DFD8", Offset = "0x98DFD8", VA = "0x98DFD8")]
	public void InitializeText(string text)
	{
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x98E098", Offset = "0x98E098", VA = "0x98E098")]
	public void UpdateCost(long cost)
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x98E0D0", Offset = "0x98E0D0", VA = "0x98E0D0")]
	public IngredientView()
	{
	}
}
