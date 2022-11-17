using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x20000EB")]
public class PowerRecipeView : RecipeView
{
	[Token(Token = "0x400055B")]
	[FieldOffset(Offset = "0x298")]
	[SerializeField]
	private RecipeUpgradableItemView m_upgradePowerSustainTime;

	[Token(Token = "0x400055C")]
	[FieldOffset(Offset = "0x2A0")]
	[SerializeField]
	private RecipeUpgradableItemView m_upgradePowerGrowthRate;

	[Token(Token = "0x400055D")]
	[FieldOffset(Offset = "0x2A8")]
	[SerializeField]
	private RecipeUpgradableItemView m_upgradePowerDecayTime;

	[Token(Token = "0x400055E")]
	[FieldOffset(Offset = "0x2B0")]
	[SerializeField]
	private GameObject m_cyclesPerSecondParent;

	[Token(Token = "0x400055F")]
	[FieldOffset(Offset = "0x2B8")]
	[SerializeField]
	protected AM2Text m_decayText;

	[Token(Token = "0x4000560")]
	[FieldOffset(Offset = "0x2C0")]
	[SerializeField]
	private ProgressBar m_evosProgressBar;

	[Token(Token = "0x4000561")]
	[FieldOffset(Offset = "0x2C8")]
	[SerializeField]
	private AM2Text m_evosProgressBarText;

	[Token(Token = "0x4000562")]
	[FieldOffset(Offset = "0x2D0")]
	[SerializeField]
	private GameObject m_leftLineBackground;

	[Token(Token = "0x4000563")]
	[FieldOffset(Offset = "0x2D8")]
	[SerializeField]
	private AM2Text m_additionalCyclesPerSecondText;

	[Token(Token = "0x4000564")]
	[FieldOffset(Offset = "0x2E0")]
	[SerializeField]
	private AM2Text m_additionalSpeedBoosterText;

	[Token(Token = "0x4000565")]
	[FieldOffset(Offset = "0x2E8")]
	[SerializeField]
	protected float m_evoProgressBarHeight;

	[Token(Token = "0x4000566")]
	[FieldOffset(Offset = "0x2F0")]
	private Upgradable m_powerDecayTimeUpgradable;

	[Token(Token = "0x4000567")]
	[FieldOffset(Offset = "0x2F8")]
	private long m_previousDecayTime;

	[Token(Token = "0x4000568")]
	[FieldOffset(Offset = "0x300")]
	private float m_defaultClosedTraySize;

	[Token(Token = "0x600064A")]
	[Address(RVA = "0x9DAFC8", Offset = "0x9DAFC8", VA = "0x9DAFC8", Slot = "12")]
	public override void Initialize(Recipe inRecipe, ConstructionItem constructionItem, RecipeItem recipeItem, ProductionPageView parentPageView, CasualViewController viewController)
	{
	}

	[Token(Token = "0x600064B")]
	[Address(RVA = "0x9DC30C", Offset = "0x9DC30C", VA = "0x9DC30C", Slot = "14")]
	protected override void ShowUpgradesContainer(bool show)
	{
	}

	[Token(Token = "0x600064C")]
	[Address(RVA = "0x9DC468", Offset = "0x9DC468", VA = "0x9DC468", Slot = "18")]
	protected override void UpdateView()
	{
	}

	[Token(Token = "0x600064D")]
	[Address(RVA = "0x9DCA14", Offset = "0x9DCA14", VA = "0x9DCA14")]
	private void UpdateEvoProgressBar()
	{
	}

	[Token(Token = "0x600064E")]
	[Address(RVA = "0x9DCDF4", Offset = "0x9DCDF4", VA = "0x9DCDF4")]
	public PowerRecipeView()
	{
	}
}
