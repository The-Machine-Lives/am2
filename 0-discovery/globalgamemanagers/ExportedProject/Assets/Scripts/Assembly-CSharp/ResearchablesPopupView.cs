using System;
using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x2000109")]
public class ResearchablesPopupView : ResearchablesView
{
	[Token(Token = "0x400067F")]
	[FieldOffset(Offset = "0x110")]
	protected ResearchView m_researchView;

	[Token(Token = "0x4000680")]
	[FieldOffset(Offset = "0x118")]
	private ResearchController m_researchController;

	[Token(Token = "0x4000681")]
	[FieldOffset(Offset = "0x120")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x824004", Offset = "0x824004")]
	private bool _003CallowBackButtonDismiss_003Ek__BackingField;

	[Token(Token = "0x170000E8")]
	public bool allowBackButtonDismiss
	{
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x9F8754", Offset = "0x9F8754", VA = "0x9F8754")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834110", Offset = "0x834110")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x9F875C", Offset = "0x9F875C", VA = "0x9F875C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834120", Offset = "0x834120")]
		set
		{
		}
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0x9F6A24", Offset = "0x9F6A24", VA = "0x9F6A24")]
	public void Initialize(ConstructionViewController parentController, int slotIndex, EBuyType buyType, ResearchView researchView)
	{
	}

	[Token(Token = "0x6000743")]
	[Address(RVA = "0x9F8768", Offset = "0x9F8768", VA = "0x9F8768", Slot = "22")]
	public override void OnSelectResearch(IResearchableItemView researchableItem)
	{
	}

	[Token(Token = "0x6000744")]
	[Address(RVA = "0x9F87C4", Offset = "0x9F87C4", VA = "0x9F87C4", Slot = "11")]
	protected override void OnHideFinished(Action onHideComplete)
	{
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0x9F8950", Offset = "0x9F8950", VA = "0x9F8950")]
	public ResearchablesPopupView()
	{
	}
}
