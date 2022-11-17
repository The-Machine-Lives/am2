using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x200006F")]
public class QuestSceneController : ActionSceneController
{
	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x58")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x60")]
	private QuestScene m_questScene;

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x9E9528", Offset = "0x9E9528", VA = "0x9E9528")]
	public QuestSceneController(IActionScene inScene, PlayerActorController playerController)
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x9E97F4", Offset = "0x9E97F4", VA = "0x9E97F4", Slot = "10")]
	public override string GetLogSceneItem()
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x9E9738", Offset = "0x9E9738", VA = "0x9E9738")]
	private void AwardQuest()
	{
	}
}
