using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x20000CE")]
public class GemsCountView : MonoBehaviour
{
	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Text m_gemsCountText;

	[Token(Token = "0x400037A")]
	[FieldOffset(Offset = "0x20")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x400037B")]
	[FieldOffset(Offset = "0x28")]
	private RecipeItem m_gemsItem;

	[Token(Token = "0x400037C")]
	[FieldOffset(Offset = "0x30")]
	private long m_previousGemsCount;

	[Token(Token = "0x400037D")]
	[FieldOffset(Offset = "0x38")]
	private List<GameObject> m_modelViews;

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x9D43AC", Offset = "0x9D43AC", VA = "0x9D43AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x9D44EC", Offset = "0x9D44EC", VA = "0x9D44EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x9D44F0", Offset = "0x9D44F0", VA = "0x9D44F0")]
	private void UpdateVisualGemCount()
	{
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0x9D45EC", Offset = "0x9D45EC", VA = "0x9D45EC")]
	public bool HasActiveItems()
	{
		return default(bool);
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0x9D4728", Offset = "0x9D4728", VA = "0x9D4728")]
	public void AddItem(GameObject item)
	{
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x9D4798", Offset = "0x9D4798", VA = "0x9D4798")]
	public void ClearItems()
	{
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x9D47F8", Offset = "0x9D47F8", VA = "0x9D47F8")]
	public GemsCountView()
	{
	}
}
