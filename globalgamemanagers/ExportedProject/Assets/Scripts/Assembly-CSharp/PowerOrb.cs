using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x20000E2")]
public class PowerOrb : MonoBehaviour
{
	[Token(Token = "0x40004D9")]
	private const float c_maxBoosterPercentToConsider = 2000f;

	[Token(Token = "0x40004DA")]
	private const float c_minPowerBloom = 12f;

	[Token(Token = "0x40004DB")]
	private const float c_maxPowerBloom = 24f;

	[Token(Token = "0x40004DC")]
	private const float c_minBoosterSpinMultiplier = 0.5f;

	[Token(Token = "0x40004DD")]
	private const float c_maxBoosterSpinMultiplier = 1.5f;

	[Token(Token = "0x40004DE")]
	private const float c_minBoosterBloom = 2.5f;

	[Token(Token = "0x40004DF")]
	private const float c_maxBoosterBloom = 6f;

	[Token(Token = "0x40004E0")]
	private const float c_minSpinMultiplier = 0.2f;

	[Token(Token = "0x40004E1")]
	private const float c_initialSpinMultiplier = 0.7f;

	[Token(Token = "0x40004E2")]
	private const float c_spinMultiplierIncrement = 0.044f;

	[Token(Token = "0x40004E3")]
	private const float c_initialCamPos = -55f;

	[Token(Token = "0x40004E4")]
	private const float c_camPosIncrement = 2f;

	[Token(Token = "0x40004E5")]
	private const float c_minRotationTime = 1.5f;

	[Token(Token = "0x40004E6")]
	private const float c_maxRotationTime = 3f;

	[Token(Token = "0x40004E7")]
	private const float c_minRotationSpeed = 60f;

	[Token(Token = "0x40004E8")]
	private const float c_maxRotationSpeed = 120f;

	[Token(Token = "0x40004E9")]
	private const float c_minRotationDisableSwitch = 3f;

	[Token(Token = "0x40004EA")]
	private const float c_maxRotationDisableSwitch = 5f;

	[Token(Token = "0x40004EB")]
	private const int c_minBoosterParticles = 7;

	[Token(Token = "0x40004EC")]
	private const int c_maxBoosterParticles = 15;

	[Token(Token = "0x40004ED")]
	private const float c_rotationDiffSpeed = 60f;

	[Token(Token = "0x40004EE")]
	private const float c_orbitterIndexExponent = 0.35f;

	[Token(Token = "0x40004EF")]
	private const float c_orbitterRotationMultiplier = 0.25f;

	[Token(Token = "0x40004F0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform m_camera;

	[Token(Token = "0x40004F1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<GameObject> m_outerSquares;

	[Token(Token = "0x40004F2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<GameObject> m_innerSquares;

	[Token(Token = "0x40004F3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<RecipeOrbitter> m_recipeOrbitters;

	[Token(Token = "0x40004F4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ParticleSystem m_boostParticles;

	[Token(Token = "0x40004F5")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform m_cube;

	[Token(Token = "0x40004F6")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Renderer m_cubeMeshRenderer;

	[Token(Token = "0x40004F7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private PostProcessVolume m_postProcessVolume;

	[Token(Token = "0x40004F8")]
	[FieldOffset(Offset = "0x58")]
	private Material m_cubeMat;

	[Token(Token = "0x40004F9")]
	[FieldOffset(Offset = "0x60")]
	protected float m_remainingDisableRotationAxisTime;

	[Token(Token = "0x40004FA")]
	[FieldOffset(Offset = "0x64")]
	protected Vector3 m_timeRemainingOnRotationAxes;

	[Token(Token = "0x40004FB")]
	[FieldOffset(Offset = "0x70")]
	protected Vector3 m_desiredRotationSpeedForAxes;

	[Token(Token = "0x40004FC")]
	[FieldOffset(Offset = "0x7C")]
	protected Vector3 m_currentRotationSpeedForAxes;

	[Token(Token = "0x40004FD")]
	[FieldOffset(Offset = "0x88")]
	protected Vector3 m_currentDisabledRotationAxis;

	[Token(Token = "0x40004FE")]
	[FieldOffset(Offset = "0x94")]
	private float m_spinMultiplier;

	[Token(Token = "0x40004FF")]
	[FieldOffset(Offset = "0x98")]
	private long m_previousEvolutionLevel;

	[Token(Token = "0x4000500")]
	[FieldOffset(Offset = "0xA0")]
	private double m_previousSpeedUpPercent;

	[Token(Token = "0x4000501")]
	[FieldOffset(Offset = "0xA8")]
	private float m_currentSpinMultiplier;

	[Token(Token = "0x4000502")]
	[FieldOffset(Offset = "0xAC")]
	private float m_boosterBloomPower;

	[Token(Token = "0x4000503")]
	[FieldOffset(Offset = "0xB0")]
	private int m_previousRecipeCount;

	[Token(Token = "0x4000504")]
	[FieldOffset(Offset = "0xB8")]
	private Bloom m_bloom;

	[Token(Token = "0x4000505")]
	[FieldOffset(Offset = "0xC0")]
	private Recipe m_powerRecipe;

	[Token(Token = "0x4000506")]
	[FieldOffset(Offset = "0xC8")]
	private RecipeItem m_powerItem;

	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0xD0")]
	private SpeedBoosterController m_speedBoosterController;

	[Token(Token = "0x4000508")]
	[FieldOffset(Offset = "0xD8")]
	private ConstructionController m_constructionController;

	[Token(Token = "0x600060F")]
	[Address(RVA = "0x9A0A70", Offset = "0x9A0A70", VA = "0x9A0A70")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000610")]
	[Address(RVA = "0x9A0E20", Offset = "0x9A0E20", VA = "0x9A0E20")]
	private void SetupRecipeOrbittersRandomRotation()
	{
	}

	[Token(Token = "0x6000611")]
	[Address(RVA = "0x9A0F9C", Offset = "0x9A0F9C", VA = "0x9A0F9C")]
	private void InitializeRecipeOrbitters()
	{
	}

	[Token(Token = "0x6000612")]
	[Address(RVA = "0x9A1150", Offset = "0x9A1150", VA = "0x9A1150")]
	protected void Update()
	{
	}

	[Token(Token = "0x6000613")]
	[Address(RVA = "0x9A117C", Offset = "0x9A117C", VA = "0x9A117C")]
	private void UpdateSpeedBoost()
	{
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0x9A1304", Offset = "0x9A1304", VA = "0x9A1304")]
	private void UpdateCube()
	{
	}

	[Token(Token = "0x6000615")]
	[Address(RVA = "0x9A1688", Offset = "0x9A1688", VA = "0x9A1688")]
	private void UpdateBloom()
	{
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0x9A1784", Offset = "0x9A1784", VA = "0x9A1784")]
	private void UpdateCubeEvolution()
	{
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x9A1C78", Offset = "0x9A1C78", VA = "0x9A1C78")]
	private void RotateCube()
	{
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x9A140C", Offset = "0x9A140C", VA = "0x9A140C")]
	private void UpdateRecipeOrbitters()
	{
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0x9A0D88", Offset = "0x9A0D88", VA = "0x9A0D88")]
	private void GetRandomRotationTime(ref float rotationTime)
	{
	}

	[Token(Token = "0x600061A")]
	[Address(RVA = "0x9A1E34", Offset = "0x9A1E34", VA = "0x9A1E34")]
	private void UpdateRotationOnAxis(ref float currentRotationSpeed, ref float timeRemaining, ref float rotationSpeed, ref float rotationMultiplier)
	{
	}

	[Token(Token = "0x600061B")]
	[Address(RVA = "0x9A0DB8", Offset = "0x9A0DB8", VA = "0x9A0DB8")]
	private void GetRandomRotationSpeed(ref float rotationSpeed)
	{
	}

	[Token(Token = "0x600061C")]
	[Address(RVA = "0x9A1F68", Offset = "0x9A1F68", VA = "0x9A1F68")]
	private void UpdateRotationAxisDisable()
	{
	}

	[Token(Token = "0x600061D")]
	[Address(RVA = "0x9A2060", Offset = "0x9A2060", VA = "0x9A2060")]
	public PowerOrb()
	{
	}
}
