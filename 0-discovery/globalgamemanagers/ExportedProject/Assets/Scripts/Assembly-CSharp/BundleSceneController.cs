using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x200006C")]
public class BundleSceneController : ActionSceneController
{
	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8219D8", Offset = "0x8219D8")]
	private IActionScene _003Cm_currentSceneInBundleScene_003Ek__BackingField;

	[Token(Token = "0x400017B")]
	[FieldOffset(Offset = "0x60")]
	private BundleScene m_bundleScene;

	[Token(Token = "0x400017C")]
	[FieldOffset(Offset = "0x68")]
	private ZoneController m_zoneController;

	[Token(Token = "0x400017D")]
	[FieldOffset(Offset = "0x70")]
	private RunController m_runController;

	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x78")]
	private List<Encounter> m_encounters;

	[Token(Token = "0x17000016")]
	public IActionScene m_currentSceneInBundleScene
	{
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xA470AC", Offset = "0xA470AC", VA = "0xA470AC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8338AC", Offset = "0x8338AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xA470B4", Offset = "0xA470B4", VA = "0xA470B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8338BC", Offset = "0x8338BC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public bool isBundleSceneDone
	{
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xA470BC", Offset = "0xA470BC", VA = "0xA470BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000018")]
	public override bool canUseAbilities
	{
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xA470EC", Offset = "0xA470EC", VA = "0xA470EC", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xA47100", Offset = "0xA47100", VA = "0xA47100")]
	public BundleSceneController(IActionScene inScene, PlayerActorController playerController)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xA47430", Offset = "0xA47430", VA = "0xA47430")]
	public void InitCurrentSubScene()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xA47610", Offset = "0xA47610", VA = "0xA47610", Slot = "7")]
	public override ActionSceneController GetActiveActionController()
	{
		return null;
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xA47624", Offset = "0xA47624", VA = "0xA47624", Slot = "10")]
	public override string GetLogSceneItem()
	{
		return null;
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xA476A4", Offset = "0xA476A4", VA = "0xA476A4", Slot = "8")]
	public override bool TryGoToNextSubScene()
	{
		return default(bool);
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xA476E8", Offset = "0xA476E8", VA = "0xA476E8")]
	public void TryHandleChoiceBranching()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xA47A0C", Offset = "0xA47A0C", VA = "0xA47A0C", Slot = "9")]
	public override void Update(float deltaTime)
	{
	}
}
