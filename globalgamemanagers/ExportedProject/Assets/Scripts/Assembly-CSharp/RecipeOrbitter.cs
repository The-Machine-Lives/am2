using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x20000E8")]
public class RecipeOrbitter : MonoBehaviour
{
	[Token(Token = "0x4000534")]
	private const float c_minColorMult = 0.7f;

	[Token(Token = "0x4000535")]
	private const float c_minLineAlpha = 0.3f;

	[Token(Token = "0x4000536")]
	private const long c_defaultMaxMaxCapLevel = 40L;

	[Token(Token = "0x4000537")]
	private const float c_minScale = 0.3f;

	[Token(Token = "0x4000538")]
	private const float c_maxScale = 2f;

	[Token(Token = "0x4000539")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Renderer m_meshRenderer;

	[Token(Token = "0x400053A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform m_meshTransform;

	[Token(Token = "0x400053B")]
	[FieldOffset(Offset = "0x28")]
	private Material m_meshMaterial;

	[Token(Token = "0x400053C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private LineRenderer m_orbitLine;

	[Token(Token = "0x400053D")]
	[FieldOffset(Offset = "0x38")]
	private long m_maxMaxCapLevel;

	[Token(Token = "0x400053E")]
	[FieldOffset(Offset = "0x40")]
	private Color m_originalColor;

	[Token(Token = "0x400053F")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 m_rotationDirection;

	[Token(Token = "0x4000540")]
	[FieldOffset(Offset = "0x5C")]
	private float m_orbitSpeed;

	[Token(Token = "0x4000541")]
	[FieldOffset(Offset = "0x60")]
	private Recipe m_recipe;

	[Token(Token = "0x4000542")]
	[FieldOffset(Offset = "0x68")]
	private RecipeItem m_recipeItem;

	[Token(Token = "0x4000543")]
	[FieldOffset(Offset = "0x70")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x4000544")]
	[FieldOffset(Offset = "0x78")]
	private long m_previousMaxCapLevel;

	[Token(Token = "0x170000D9")]
	public bool isRecipeValid
	{
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x9EF240", Offset = "0x9EF240", VA = "0x9EF240")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600063E")]
	[Address(RVA = "0x9EF250", Offset = "0x9EF250", VA = "0x9EF250")]
	public void Initialize(Recipe recipe)
	{
	}

	[Token(Token = "0x600063F")]
	[Address(RVA = "0x9EF4D0", Offset = "0x9EF4D0", VA = "0x9EF4D0")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000640")]
	[Address(RVA = "0x9EF7F4", Offset = "0x9EF7F4", VA = "0x9EF7F4")]
	public void UpdateView()
	{
	}

	[Token(Token = "0x6000641")]
	[Address(RVA = "0x9EFDB8", Offset = "0x9EFDB8", VA = "0x9EFDB8")]
	public RecipeOrbitter()
	{
	}
}
