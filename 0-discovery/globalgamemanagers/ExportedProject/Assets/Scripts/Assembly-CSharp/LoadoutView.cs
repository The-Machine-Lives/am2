using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

[Token(Token = "0x20000D3")]
public class LoadoutView : SlottableView<Ability>
{
	[Token(Token = "0x40003C5")]
	[FieldOffset(Offset = "0x48")]
	private LoadoutController m_loadoutController;

	[Token(Token = "0x40003C6")]
	[FieldOffset(Offset = "0x50")]
	private AbilitiesController m_abilitiesController;

	[Token(Token = "0x40003C7")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected List<LoadoutAbilityView> m_slottedItemViews;

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x998F08", Offset = "0x998F08", VA = "0x998F08")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x999078", Offset = "0x999078", VA = "0x999078", Slot = "7")]
	public override void OnClickedItemView(int sourceIndex, Ability ability, int clickCount, SlottedItemView<Ability> itemView)
	{
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x999150", Offset = "0x999150", VA = "0x999150", Slot = "10")]
	protected override List<SlottedItemView<Ability>> GetItemViews()
	{
		return null;
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x9991C0", Offset = "0x9991C0", VA = "0x9991C0")]
	public LoadoutView()
	{
	}
}
