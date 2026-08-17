using AM2.ReferenceData;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000D9")]
public class MachineSounds
{
	[Token(Token = "0x40003EA")]
	[FieldOffset(Offset = "0x10")]
	private float m_thresholdToFadePowerActive;

	[Token(Token = "0x40003EB")]
	[FieldOffset(Offset = "0x14")]
	private float m_powerActiveForegroundVolume;

	[Token(Token = "0x40003EC")]
	[FieldOffset(Offset = "0x18")]
	private float m_powerActiveBackgroundVolume;

	[Token(Token = "0x40003ED")]
	[FieldOffset(Offset = "0x1C")]
	private float m_powerActiveMinPitch;

	[Token(Token = "0x40003EE")]
	[FieldOffset(Offset = "0x20")]
	private float m_powerActiveMaxPitch;

	[Token(Token = "0x40003EF")]
	[FieldOffset(Offset = "0x24")]
	private float m_powerActivePitchRange;

	[Token(Token = "0x40003F0")]
	[FieldOffset(Offset = "0x28")]
	private float m_powerButtonVolumeFadeInTime;

	[Token(Token = "0x40003F1")]
	[FieldOffset(Offset = "0x2C")]
	private float m_powerButtonVolumeFadeOutTime;

	[Token(Token = "0x40003F2")]
	[FieldOffset(Offset = "0x30")]
	private float m_powerButtonPitchFadeInTime;

	[Token(Token = "0x40003F3")]
	[FieldOffset(Offset = "0x34")]
	private float m_powerButtonPitchFadeOutTime;

	[Token(Token = "0x40003F4")]
	[FieldOffset(Offset = "0x38")]
	private float m_powerButtonMaxVolume;

	[Token(Token = "0x40003F5")]
	[FieldOffset(Offset = "0x3C")]
	private float m_powerButtonMinPitch;

	[Token(Token = "0x40003F6")]
	[FieldOffset(Offset = "0x40")]
	private float m_powerButtonMaxPitch;

	[Token(Token = "0x40003F7")]
	[FieldOffset(Offset = "0x44")]
	private float m_sustainedPowerForAWhileRate;

	[Token(Token = "0x40003F8")]
	[FieldOffset(Offset = "0x48")]
	private float m_powerButtonPitchRange;

	[Token(Token = "0x40003F9")]
	[FieldOffset(Offset = "0x4C")]
	private float m_powerButtonPressedTimeBeforeFadeOut;

	[Token(Token = "0x40003FA")]
	[FieldOffset(Offset = "0x50")]
	private float m_powerButtonFadeWhilePressedTime;

	[Token(Token = "0x40003FB")]
	[FieldOffset(Offset = "0x54")]
	private float m_currentPressedTime;

	[Token(Token = "0x40003FC")]
	[FieldOffset(Offset = "0x58")]
	private bool m_hasSustainedPowerForAWhile;

	[Token(Token = "0x40003FD")]
	[FieldOffset(Offset = "0x5C")]
	private float m_previousRate;

	[Token(Token = "0x40003FE")]
	[FieldOffset(Offset = "0x60")]
	private Recipe m_powerRecipe;

	[Token(Token = "0x40003FF")]
	[FieldOffset(Offset = "0x68")]
	private RecipeItem m_powerRecipeItem;

	[Token(Token = "0x4000400")]
	[FieldOffset(Offset = "0x70")]
	private AudioSource m_powerButtonPressedSound;

	[Token(Token = "0x4000401")]
	[FieldOffset(Offset = "0x78")]
	private AudioSource m_powerActiveSound;

	[Token(Token = "0x4000402")]
	[FieldOffset(Offset = "0x80")]
	private PowerPageView m_powerPageView;

	[Token(Token = "0x4000403")]
	[FieldOffset(Offset = "0x88")]
	private PowerButton m_powerButton;

	[Token(Token = "0x4000404")]
	[FieldOffset(Offset = "0x90")]
	private Transform m_constructionViewTransform;

	[Token(Token = "0x4000405")]
	[FieldOffset(Offset = "0x98")]
	private AM2SoundController m_soundController;

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x999F18", Offset = "0x999F18", VA = "0x999F18")]
	public MachineSounds(PowerPageView powerPageView, PowerButton powerButton, Transform constructionViewTransform)
	{
	}

	[Token(Token = "0x6000588")]
	[Address(RVA = "0x99A214", Offset = "0x99A214", VA = "0x99A214", Slot = "1")]
	~MachineSounds()
	{
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0x99A298", Offset = "0x99A298", VA = "0x99A298")]
	public void Update()
	{
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0x99A29C", Offset = "0x99A29C", VA = "0x99A29C")]
	private void UpatePowerButtonPressedSound()
	{
	}
}
