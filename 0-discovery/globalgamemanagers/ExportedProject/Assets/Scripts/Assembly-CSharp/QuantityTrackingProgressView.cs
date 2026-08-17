using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x2000101")]
public class QuantityTrackingProgressView : MonoBehaviour
{
	[Token(Token = "0x40005EF")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ProgressBar m_progressBar;

	[Token(Token = "0x40005F0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2PaletteDatabase.AM2ColorPalettes m_fillingColorPalette;

	[Token(Token = "0x40005F1")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private AM2PaletteDatabase.AM2ColorPalettes m_filledColorPalette;

	[Token(Token = "0x40005F2")]
	[FieldOffset(Offset = "0x28")]
	private Color m_fillingColor;

	[Token(Token = "0x40005F3")]
	[FieldOffset(Offset = "0x38")]
	private Color m_filledColor;

	[Token(Token = "0x40005F4")]
	[FieldOffset(Offset = "0x48")]
	private List<Item> m_trackedItems;

	[Token(Token = "0x40005F5")]
	[FieldOffset(Offset = "0x50")]
	private List<long> m_maxQuantities;

	[Token(Token = "0x40005F6")]
	[FieldOffset(Offset = "0x58")]
	private float m_previousProgress;

	[Token(Token = "0x40005F7")]
	[FieldOffset(Offset = "0x60")]
	private List<float> progressList;

	[Token(Token = "0x40005F8")]
	[FieldOffset(Offset = "0x68")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x9E6D74", Offset = "0x9E6D74", VA = "0x9E6D74")]
	public void Initialize(Dictionary<string, long> costResources, Dictionary<string, long> levelGates)
	{
	}

	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x9E6EAC", Offset = "0x9E6EAC", VA = "0x9E6EAC")]
	private void SetupItemsAndQuantities(Dictionary<string, long> costResources, Dictionary<string, long> levelGates)
	{
	}

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x9E729C", Offset = "0x9E729C", VA = "0x9E729C")]
	public void RefreshWithMaxQuantity(Dictionary<string, long> costResources, Dictionary<string, long> levelGates)
	{
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x9E760C", Offset = "0x9E760C", VA = "0x9E760C")]
	public void UpdateMaxQuantity(long newMaxQuantity, int index = 0)
	{
	}

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x9E7684", Offset = "0x9E7684", VA = "0x9E7684")]
	protected void Update()
	{
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x9E72C8", Offset = "0x9E72C8", VA = "0x9E72C8")]
	public float CalculateClampedProgress()
	{
		return default(float);
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x9E753C", Offset = "0x9E753C", VA = "0x9E753C")]
	private void UpdateProgress(float progress)
	{
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x9E76C0", Offset = "0x9E76C0", VA = "0x9E76C0")]
	public QuantityTrackingProgressView()
	{
	}
}
