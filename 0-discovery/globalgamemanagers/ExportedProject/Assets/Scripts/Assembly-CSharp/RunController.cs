using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;

[Token(Token = "0x2000091")]
public class RunController
{
	[Token(Token = "0x4000242")]
	[FieldOffset(Offset = "0x10")]
	private int m_stepIndex;

	[Token(Token = "0x4000243")]
	[FieldOffset(Offset = "0x18")]
	private BundleSceneController m_lastBundleSceneController;

	[Token(Token = "0x4000244")]
	[FieldOffset(Offset = "0x20")]
	private List<Encounter> m_encounters;

	[Token(Token = "0x4000245")]
	[FieldOffset(Offset = "0x28")]
	private PlayerActorController m_playerController;

	[Token(Token = "0x4000246")]
	[FieldOffset(Offset = "0x30")]
	private ActionSceneController m_currentActionSceneController;

	[Token(Token = "0x4000247")]
	[FieldOffset(Offset = "0x38")]
	private ZoneController m_zoneController;

	[Token(Token = "0x4000248")]
	[FieldOffset(Offset = "0x40")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x4000249")]
	[FieldOffset(Offset = "0x48")]
	private CasualAnalog m_analogController;

	[Token(Token = "0x1700004C")]
	public bool canUseAbilities
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x9FD3FC", Offset = "0x9FD3FC", VA = "0x9FD3FC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700004D")]
	public bool isRunDone
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x9FD414", Offset = "0x9FD414", VA = "0x9FD414")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x9FD4A0", Offset = "0x9FD4A0", VA = "0x9FD4A0")]
	public RunController(List<Encounter> encounters, PlayerActorController playerController)
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x9FD694", Offset = "0x9FD694", VA = "0x9FD694")]
	public void InitCurrentSceneController()
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x9FDBFC", Offset = "0x9FDBFC", VA = "0x9FDBFC")]
	public ActionSceneController GoToNextScene()
	{
		return null;
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x9FDC38", Offset = "0x9FDC38", VA = "0x9FDC38")]
	public ActionSceneController GoToNextSceneRecursive()
	{
		return null;
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x9FDD00", Offset = "0x9FDD00", VA = "0x9FDD00")]
	public ActionSceneController GetActiveActionController()
	{
		return null;
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x9FDCBC", Offset = "0x9FDCBC", VA = "0x9FDCBC")]
	public void IncrementStep()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x9FD6C8", Offset = "0x9FD6C8", VA = "0x9FD6C8")]
	public IActionScene SelectSceneAtCurrentStepIndex()
	{
		return null;
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x9FD794", Offset = "0x9FD794", VA = "0x9FD794")]
	public ActionSceneController SetupSceneController(IActionScene targetScene, bool isSubScene)
	{
		return null;
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x9FDE88", Offset = "0x9FDE88", VA = "0x9FDE88")]
	public void Update(float deltaTime)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x9FDD20", Offset = "0x9FDD20", VA = "0x9FDD20")]
	private void LogSceneEncounter(IActionScene targetScene, ActionSceneController targetActionSceneController)
	{
	}
}
