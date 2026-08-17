using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Animation;
using UnityEngine;

[Token(Token = "0x20000E7")]
public class PowerView : MonoBehaviour
{
	[Token(Token = "0x4000515")]
	private const float GlowScaleAnimDuration = 0.5f;

	[Token(Token = "0x4000516")]
	[FieldOffset(Offset = "0x18")]
	private double c_coreParticleExp;

	[Token(Token = "0x4000517")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ParticleSystem m_powerParticleSystemLines;

	[Token(Token = "0x4000518")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ParticleSystem m_powerParticleSystemCore;

	[Token(Token = "0x4000519")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ParticleSystem m_powerParticleSystemBalls;

	[Token(Token = "0x400051A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ParticleSystem m_powerParticleSystemGlow;

	[Token(Token = "0x400051B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ParticleSystem m_powerBonusSpeedParticle;

	[Token(Token = "0x400051C")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private SpriteRenderer m_powerBonusGlow;

	[Token(Token = "0x400051D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ParticleSystem m_powerBonusStar;

	[Token(Token = "0x400051E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private SpriteRenderer m_powerBonusShockWave;

	[Token(Token = "0x400051F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ParticleSystem m_powerBonusSparkles;

	[Token(Token = "0x4000520")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ParticleSystem m_powerBonusSparkles2;

	[Token(Token = "0x4000521")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private int m_colorIndex;

	[Token(Token = "0x4000522")]
	[FieldOffset(Offset = "0x74")]
	private Color m_pinkColor;

	[Token(Token = "0x4000523")]
	[FieldOffset(Offset = "0x84")]
	private Color m_blueColor;

	[Token(Token = "0x4000524")]
	[FieldOffset(Offset = "0x94")]
	private Color m_greenColor;

	[Token(Token = "0x4000525")]
	[FieldOffset(Offset = "0xA4")]
	private Color m_greyColor;

	[Token(Token = "0x4000526")]
	[FieldOffset(Offset = "0xB4")]
	private Color m_pinkColorWithAlpha;

	[Token(Token = "0x4000527")]
	[FieldOffset(Offset = "0xC4")]
	private Color m_blueColorWithAlpha;

	[Token(Token = "0x4000528")]
	[FieldOffset(Offset = "0xD4")]
	private Color m_greenColorWithAlpha;

	[Token(Token = "0x4000529")]
	[FieldOffset(Offset = "0xE4")]
	private Color m_greyColorWithAlpha;

	[Token(Token = "0x400052A")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private Camera m_particleSystemCamera;

	[Token(Token = "0x400052B")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private int m_cameraZoomSize;

	[Token(Token = "0x400052C")]
	[FieldOffset(Offset = "0x104")]
	[SerializeField]
	private bool m_isZoomCamera;

	[Token(Token = "0x400052D")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private RenderTexture m_powerRenderTexture;

	[Token(Token = "0x400052E")]
	[FieldOffset(Offset = "0x110")]
	private ConstructionItem m_constructionItem;

	[Token(Token = "0x400052F")]
	[FieldOffset(Offset = "0x118")]
	private Upgradable m_powerCyclesPerSecond;

	[Token(Token = "0x4000530")]
	[FieldOffset(Offset = "0x120")]
	private ConstructionController m_constructionController;

	[Token(Token = "0x4000531")]
	[FieldOffset(Offset = "0x128")]
	private UkenAnimTransform m_glowScaleAnim;

	[Token(Token = "0x4000532")]
	[FieldOffset(Offset = "0x130")]
	private Color originalColor;

	[Token(Token = "0x4000533")]
	[FieldOffset(Offset = "0x140")]
	private UkenAnimChain m_bonusChainAnim;

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x9DD39C", Offset = "0x9DD39C", VA = "0x9DD39C")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600062A")]
	[Address(RVA = "0x9DD4D8", Offset = "0x9DD4D8", VA = "0x9DD4D8")]
	private void UpdateAllParticleSystemColors()
	{
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x9DD5BC", Offset = "0x9DD5BC", VA = "0x9DD5BC")]
	private void UpdateParticleSystemColor(bool isPaletteColor, ParticleSystem targetParticleSystem, bool isUpdateColorOverLifetime, bool isAlpha)
	{
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x9DD7D4", Offset = "0x9DD7D4", VA = "0x9DD7D4")]
	public void UpdatePowerView(float deltaTime, bool isPressed, double currentPowerPerSecond)
	{
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x9DDC00", Offset = "0x9DDC00", VA = "0x9DDC00")]
	private void UpdatePowerCamera()
	{
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x9DD83C", Offset = "0x9DD83C", VA = "0x9DD83C")]
	private void CalculatePowerParticleSystemLines(float deltaTime, bool isPressed, double currentPowerPerSecond)
	{
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x9DD99C", Offset = "0x9DD99C", VA = "0x9DD99C")]
	private void CalculatePowerParticleSystemCore(float deltaTime, bool isPressed, double currentPowerPerSecond)
	{
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x9DDA8C", Offset = "0x9DDA8C", VA = "0x9DDA8C")]
	private void CalculatePowerParticleSystemBalls(float deltaTime, bool isPressed, double currentPowerPerSecond)
	{
	}

	[Token(Token = "0x6000631")]
	[Address(RVA = "0x9DDF04", Offset = "0x9DDF04", VA = "0x9DDF04")]
	private void CalculatePowerParticleSystemGlow(float deltaTime, bool isPressed, double currentPowerPerSecond)
	{
	}

	[Token(Token = "0x6000632")]
	[Address(RVA = "0x9DDDFC", Offset = "0x9DDDFC", VA = "0x9DDDFC")]
	public static void UpdatePowerParticleSystem(ParticleSystem targetParticleSystem, int maxParticles, float particleRate, double particleSpeed)
	{
	}

	[Token(Token = "0x6000633")]
	[Address(RVA = "0x9DDFF0", Offset = "0x9DDFF0", VA = "0x9DDFF0")]
	private static void SaveRenderTextureToFile(RenderTexture targetRenderTexture)
	{
	}

	[Token(Token = "0x6000634")]
	[Address(RVA = "0x9DDFF4", Offset = "0x9DDFF4", VA = "0x9DDFF4")]
	public void PlayUpgradeEffect(float toNextThreshold, bool isBonus)
	{
	}

	[Token(Token = "0x6000635")]
	[Address(RVA = "0x9DE2E4", Offset = "0x9DE2E4", VA = "0x9DE2E4")]
	private void AnimateBonusEffects()
	{
	}

	[Token(Token = "0x6000636")]
	[Address(RVA = "0x9DE0F8", Offset = "0x9DE0F8", VA = "0x9DE0F8")]
	private void AnimateGlowScale(float toNextThreshold)
	{
	}

	[Token(Token = "0x6000637")]
	[Address(RVA = "0x9DE61C", Offset = "0x9DE61C", VA = "0x9DE61C")]
	public PowerView()
	{
	}

	[Token(Token = "0x6000638")]
	[Address(RVA = "0x9DE808", Offset = "0x9DE808", VA = "0x9DE808")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833F60", Offset = "0x833F60")]
	private void _003CAnimateBonusEffects_003Eb__43_0(float value)
	{
	}

	[Token(Token = "0x6000639")]
	[Address(RVA = "0x9DE8C0", Offset = "0x9DE8C0", VA = "0x9DE8C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833F70", Offset = "0x833F70")]
	private void _003CAnimateBonusEffects_003Eb__43_1()
	{
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0x9DE908", Offset = "0x9DE908", VA = "0x9DE908")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833F80", Offset = "0x833F80")]
	private void _003CAnimateBonusEffects_003Eb__43_2(float value)
	{
	}

	[Token(Token = "0x600063B")]
	[Address(RVA = "0x9DEA2C", Offset = "0x9DEA2C", VA = "0x9DEA2C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833F90", Offset = "0x833F90")]
	private void _003CAnimateBonusEffects_003Eb__43_3()
	{
	}

	[Token(Token = "0x600063C")]
	[Address(RVA = "0x9DEAC8", Offset = "0x9DEAC8", VA = "0x9DEAC8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833FA0", Offset = "0x833FA0")]
	private void _003CAnimateBonusEffects_003Eb__43_4()
	{
	}
}
