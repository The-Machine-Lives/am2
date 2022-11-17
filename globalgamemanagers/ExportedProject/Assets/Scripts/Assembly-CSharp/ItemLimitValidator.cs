using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

[Token(Token = "0x2000219")]
public class ItemLimitValidator
{
	[Token(Token = "0x4000BFB")]
	[FieldOffset(Offset = "0x10")]
	private ItemLimit[] m_itemLimitDefinitions;

	[Token(Token = "0x4000BFC")]
	[FieldOffset(Offset = "0x18")]
	private HashSet<string> m_depotNames;

	[Token(Token = "0x4000BFD")]
	[FieldOffset(Offset = "0x20")]
	private bool m_verbosePrint;

	[Token(Token = "0x6000E60")]
	[Address(RVA = "0x9913F0", Offset = "0x9913F0", VA = "0x9913F0")]
	public ItemLimitValidator(ItemLimit[] itemLimitDefinitions, bool verbosePrint)
	{
	}

	[Token(Token = "0x6000E61")]
	[Address(RVA = "0x991480", Offset = "0x991480", VA = "0x991480")]
	public void InitializeItemDefinitions()
	{
	}

	[Token(Token = "0x6000E62")]
	[Address(RVA = "0x991558", Offset = "0x991558", VA = "0x991558")]
	public void AddDepotToItemCount(string depotName, List<IBaseEntity> entities)
	{
	}

	[Token(Token = "0x6000E63")]
	[Address(RVA = "0x991734", Offset = "0x991734", VA = "0x991734")]
	public void AddToItemCount(string itemRef)
	{
	}

	[Token(Token = "0x6000E64")]
	[Address(RVA = "0x991940", Offset = "0x991940", VA = "0x991940")]
	public bool PrintViolations()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E65")]
	[Address(RVA = "0x992058", Offset = "0x992058", VA = "0x992058")]
	public void PrintDepotsThatAddToLimits()
	{
	}
}
