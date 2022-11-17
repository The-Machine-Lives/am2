using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using UnityEngine;
using Utilities;

[Token(Token = "0x200011C")]
public abstract class ItemModelViewInstantiator
{
	[Token(Token = "0x2000630")]
	public delegate IEnumerable<ISubTabItemModel> GetItemModelsDelegate();

	[Token(Token = "0x4000738")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8244D0", Offset = "0x8244D0")]
	private SubTab _003CdefaultSubTab_003Ek__BackingField;

	[Token(Token = "0x4000739")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8244E0", Offset = "0x8244E0")]
	private ESubTabSelectionType _003CsubTabSelectionType_003Ek__BackingField;

	[Token(Token = "0x400073A")]
	[FieldOffset(Offset = "0x20")]
	private ObjectPoolController m_objectPoolController;

	[Token(Token = "0x400073B")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_template;

	[Token(Token = "0x400073C")]
	[FieldOffset(Offset = "0x30")]
	private GetItemModelsDelegate m_getItemModelsDelegate;

	[Token(Token = "0x170000F5")]
	public SubTab defaultSubTab
	{
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x9921E4", Offset = "0x9921E4", VA = "0x9921E4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834294", Offset = "0x834294")]
		get
		{
			return null;
		}
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x9921EC", Offset = "0x9921EC", VA = "0x9921EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8342A4", Offset = "0x8342A4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F6")]
	public ESubTabSelectionType subTabSelectionType
	{
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x9921F4", Offset = "0x9921F4", VA = "0x9921F4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8342B4", Offset = "0x8342B4")]
		get
		{
			return default(ESubTabSelectionType);
		}
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x9921FC", Offset = "0x9921FC", VA = "0x9921FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8342C4", Offset = "0x8342C4")]
		private set
		{
		}
	}

	[Token(Token = "0x600080E")]
	[Address(RVA = "0x992204", Offset = "0x992204", VA = "0x992204")]
	public ItemModelViewInstantiator(GameObject template, GetItemModelsDelegate getItemModelsDelegate, SubTab inDefaultSubTab, ESubTabSelectionType inSubTabSelectionType)
	{
	}

	[Token(Token = "0x600080F")]
	[Address(RVA = "0x992320", Offset = "0x992320", VA = "0x992320", Slot = "4")]
	public virtual bool ShouldInstantiate(ISubTabItemModel itemModel)
	{
		return default(bool);
	}

	[Token(Token = "0x6000810")]
	[Address(RVA = "0x99232C", Offset = "0x99232C", VA = "0x99232C")]
	public GameObject Instantiate(Transform parentTransform, ISubTabItemModel itemModel)
	{
		return null;
	}

	[Token(Token = "0x6000811")]
	[Address(RVA = "0x9923A8", Offset = "0x9923A8", VA = "0x9923A8")]
	public IEnumerable<ISubTabItemModel> GetAllItemModels()
	{
		return null;
	}

	[Token(Token = "0x6000812")]
	protected abstract void Setup(GameObject newGameObject, ISubTabItemModel itemModel);
}
