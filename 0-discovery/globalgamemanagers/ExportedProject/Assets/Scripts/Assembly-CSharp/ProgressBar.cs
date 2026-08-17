using Il2CppDummyDll;
using Uken.Library.Animation;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001D7")]
public class ProgressBar : MonoBehaviour
{
	[Token(Token = "0x4000AC3")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x825E7C", Offset = "0x825E7C")]
	private float _003CfillAmount_003Ek__BackingField;

	[Token(Token = "0x4000AC4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected Image m_image;

	[Token(Token = "0x4000AC5")]
	[FieldOffset(Offset = "0x28")]
	protected UkenAnimGraphic m_anim;

	[Token(Token = "0x4000AC6")]
	[FieldOffset(Offset = "0x30")]
	protected Color m_originalColor;

	[Token(Token = "0x17000189")]
	public float fillAmount
	{
		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x9E63D0", Offset = "0x9E63D0", VA = "0x9E63D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834B1C", Offset = "0x834B1C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x9E63D8", Offset = "0x9E63D8", VA = "0x9E63D8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834B2C", Offset = "0x834B2C")]
		private set
		{
		}
	}

	[Token(Token = "0x6000C8A")]
	[Address(RVA = "0x9E63E0", Offset = "0x9E63E0", VA = "0x9E63E0", Slot = "4")]
	public virtual void Initialize(float fillAmount)
	{
	}

	[Token(Token = "0x6000C8B")]
	[Address(RVA = "0x9DCD50", Offset = "0x9DCD50", VA = "0x9DCD50")]
	public void SetFillAmount(float fillAmount)
	{
	}

	[Token(Token = "0x6000C8C")]
	[Address(RVA = "0x9E642C", Offset = "0x9E642C", VA = "0x9E642C")]
	public void SetColor(Color color)
	{
	}

	[Token(Token = "0x6000C8D")]
	[Address(RVA = "0x9E6494", Offset = "0x9E6494", VA = "0x9E6494")]
	public void FlashColor(Color color, float duration)
	{
	}

	[Token(Token = "0x6000C8E")]
	[Address(RVA = "0x9E65D4", Offset = "0x9E65D4", VA = "0x9E65D4")]
	public ProgressBar()
	{
	}
}
