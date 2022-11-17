using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using UnityEngine;
using Utilities;

[Token(Token = "0x200012F")]
public class RewardVisualizer
{
	[Token(Token = "0x40007B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private GameObject m_textEffectTemplate;

	[Token(Token = "0x40007B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform m_textSpawnArea;

	[Token(Token = "0x40007B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool m_useObjectPool;

	[Token(Token = "0x40007B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x40007B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ObjectPoolController m_objectPoolController;

	[Token(Token = "0x40007B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Localizations m_localizationController;

	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x9FCD08", Offset = "0x9FCD08", VA = "0x9FCD08")]
	public RewardVisualizer(GameObject textEffectTemplate, Transform textTagSpawnArea, bool useObjectPool)
	{
	}

	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x9FCF08", Offset = "0x9FCF08", VA = "0x9FCF08")]
	public void DisplayRewardsFromTransaction(Dictionary<string, long> transaction, [Optional] Transform overrideParentTransform)
	{
	}
}
