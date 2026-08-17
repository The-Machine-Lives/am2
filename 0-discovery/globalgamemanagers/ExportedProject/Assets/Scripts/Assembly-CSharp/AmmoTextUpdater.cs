using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;

[Token(Token = "0x200013C")]
public class AmmoTextUpdater
{
	[Token(Token = "0x40007F4")]
	[FieldOffset(Offset = "0x10")]
	private string m_ammoText;

	[Token(Token = "0x40007F5")]
	[FieldOffset(Offset = "0x18")]
	private AM2Text m_text;

	[Token(Token = "0x40007F6")]
	[FieldOffset(Offset = "0x20")]
	private string m_ammoRef;

	[Token(Token = "0x40007F7")]
	[FieldOffset(Offset = "0x28")]
	private Recipe m_recipe;

	[Token(Token = "0x40007F8")]
	[FieldOffset(Offset = "0x30")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x40007F9")]
	[FieldOffset(Offset = "0x38")]
	private RecipeController m_recipeController;

	[Token(Token = "0x40007FA")]
	[FieldOffset(Offset = "0x40")]
	private long m_previousAmmo;

	[Token(Token = "0x40007FB")]
	[FieldOffset(Offset = "0x48")]
	private long m_previousMaxAmmo;

	[Token(Token = "0x60008F9")]
	[Address(RVA = "0xC1CC0C", Offset = "0xC1CC0C", VA = "0xC1CC0C")]
	public static string GetAmmoText(long quantity, long maxQuantity)
	{
		return null;
	}

	[Token(Token = "0x60008FA")]
	[Address(RVA = "0xC1CCB4", Offset = "0xC1CCB4", VA = "0xC1CCB4")]
	public AmmoTextUpdater(Recipe recipe, string ammoRef, AM2Text text)
	{
	}

	[Token(Token = "0x60008FB")]
	[Address(RVA = "0xC1CE44", Offset = "0xC1CE44", VA = "0xC1CE44")]
	public void Update()
	{
	}
}
