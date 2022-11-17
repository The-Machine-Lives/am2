using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.UkenTime;
using UnityEngine;

[Token(Token = "0x2000115")]
public class RecipeBoosterView : UnlockableRecipeComponentView
{
	[Token(Token = "0x40006D9")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected SpeedBoosterPopupView m_boosterPopupViewTemplate;

	[Token(Token = "0x40006DA")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected AM2Button m_button;

	[Token(Token = "0x40006DB")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected AM2Image m_buttonImage;

	[Token(Token = "0x40006DC")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected AM2Text m_buttonText;

	[Token(Token = "0x40006DD")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected Transform m_activeBoostersParent;

	[Token(Token = "0x40006DE")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Color m_shineColor;

	[Token(Token = "0x40006DF")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8242F0", Offset = "0x8242F0")]
	private double _003CpercentUp_003Ek__BackingField;

	[Token(Token = "0x40006E0")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x824300", Offset = "0x824300")]
	private double _003CpercentUpWithoutPrestigeBoost_003Ek__BackingField;

	[Token(Token = "0x40006E1")]
	[FieldOffset(Offset = "0x88")]
	private float m_buttonShineInterval;

	[Token(Token = "0x40006E2")]
	[FieldOffset(Offset = "0x8C")]
	private float m_timeRemainingUntilShine;

	[Token(Token = "0x40006E3")]
	[FieldOffset(Offset = "0x90")]
	private double m_previousPercentUp;

	[Token(Token = "0x40006E4")]
	[FieldOffset(Offset = "0x98")]
	private long m_previousTimeRemaining;

	[Token(Token = "0x40006E5")]
	[FieldOffset(Offset = "0xA0")]
	private double m_minTimeRemaining;

	[Token(Token = "0x40006E6")]
	[FieldOffset(Offset = "0xA8")]
	private Color m_originalButtonColor;

	[Token(Token = "0x40006E7")]
	[FieldOffset(Offset = "0xB8")]
	private CasualViewController m_viewController;

	[Token(Token = "0x40006E8")]
	[FieldOffset(Offset = "0xC0")]
	private Recipe m_recipe;

	[Token(Token = "0x40006E9")]
	[FieldOffset(Offset = "0xC8")]
	private UkenTimeController m_timeController;

	[Token(Token = "0x40006EA")]
	[FieldOffset(Offset = "0xD0")]
	private SpeedBoosterController m_speedBoosterController;

	[Token(Token = "0x170000ED")]
	public double percentUp
	{
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x9ED760", Offset = "0x9ED760", VA = "0x9ED760")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834180", Offset = "0x834180")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x9ED768", Offset = "0x9ED768", VA = "0x9ED768")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834190", Offset = "0x834190")]
		private set
		{
		}
	}

	[Token(Token = "0x170000EE")]
	public double percentUpWithoutPrestigeBoost
	{
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x9ED770", Offset = "0x9ED770", VA = "0x9ED770")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8341A0", Offset = "0x8341A0")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x9ED778", Offset = "0x9ED778", VA = "0x9ED778")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8341B0", Offset = "0x8341B0")]
		private set
		{
		}
	}

	[Token(Token = "0x60007AB")]
	[Address(RVA = "0x9ED780", Offset = "0x9ED780", VA = "0x9ED780")]
	protected void Awake()
	{
	}

	[Token(Token = "0x60007AC")]
	[Address(RVA = "0x9ED850", Offset = "0x9ED850", VA = "0x9ED850")]
	protected void Start()
	{
	}

	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x9ED898", Offset = "0x9ED898", VA = "0x9ED898")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x60007AE")]
	[Address(RVA = "0x9ED948", Offset = "0x9ED948", VA = "0x9ED948")]
	protected void Update()
	{
	}

	[Token(Token = "0x60007AF")]
	[Address(RVA = "0x9EDD44", Offset = "0x9EDD44", VA = "0x9EDD44")]
	public void Initialize(CasualViewController viewController, Recipe recipe)
	{
	}

	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x9EDFB0", Offset = "0x9EDFB0", VA = "0x9EDFB0")]
	public void RefreshBoost()
	{
	}

	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x9EE02C", Offset = "0x9EE02C", VA = "0x9EE02C")]
	private bool IsBoosted()
	{
		return default(bool);
	}

	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x9ED96C", Offset = "0x9ED96C", VA = "0x9ED96C")]
	private void UpdateButtonText()
	{
	}

	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x9EDAE0", Offset = "0x9EDAE0", VA = "0x9EDAE0")]
	private void UpdateButtonShine()
	{
	}

	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x9ED844", Offset = "0x9ED844", VA = "0x9ED844")]
	private void ResetShineTimer()
	{
	}

	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x9EE03C", Offset = "0x9EE03C", VA = "0x9EE03C")]
	private void RecalculateDisplayPercentUpAndTimeRemaining()
	{
	}

	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x9EE098", Offset = "0x9EE098", VA = "0x9EE098")]
	public void OnClickedOpen()
	{
	}

	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x9EE1E4", Offset = "0x9EE1E4", VA = "0x9EE1E4")]
	public RecipeBoosterView()
	{
	}
}
