using Il2CppDummyDll;

[Token(Token = "0x2000183")]
public class QuestItem : VisiblyUnlockableItem
{
	[Token(Token = "0x400092A")]
	public new const string mc_sItemType = "QuestItem";

	[Token(Token = "0x400092B")]
	private const string c_task_progress = "task_progress_";

	[Token(Token = "0x400092C")]
	private const string c_repeatIndex = "repeatIndex";

	[Token(Token = "0x400092D")]
	private const long c_defaultTaskProgress = 0L;

	[Token(Token = "0x17000140")]
	public long repeatIndex
	{
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x9E81F0", Offset = "0x9E81F0", VA = "0x9E81F0")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x6000A84")]
	[Address(RVA = "0x9E7EE4", Offset = "0x9E7EE4", VA = "0x9E7EE4", Slot = "4")]
	public override void ResetTraits(bool resetLifeTimeQuantity = false)
	{
	}

	[Token(Token = "0x6000A85")]
	[Address(RVA = "0x9E8018", Offset = "0x9E8018", VA = "0x9E8018")]
	public long GetTaskProgress(long taskIndex)
	{
		return default(long);
	}

	[Token(Token = "0x6000A86")]
	[Address(RVA = "0x9E80AC", Offset = "0x9E80AC", VA = "0x9E80AC")]
	public void AddToTaskProgress(long taskIndex, long progress)
	{
	}

	[Token(Token = "0x6000A87")]
	[Address(RVA = "0x9E815C", Offset = "0x9E815C", VA = "0x9E815C")]
	public void ResetTaskProgress(long taskIndex)
	{
	}

	[Token(Token = "0x6000A88")]
	[Address(RVA = "0x9E7F70", Offset = "0x9E7F70", VA = "0x9E7F70")]
	public void ResetAllTaskProgress()
	{
	}

	[Token(Token = "0x6000A8A")]
	[Address(RVA = "0x9E8248", Offset = "0x9E8248", VA = "0x9E8248")]
	public void IncrementRepeatIndex()
	{
	}

	[Token(Token = "0x6000A8B")]
	[Address(RVA = "0x9E7F18", Offset = "0x9E7F18", VA = "0x9E7F18")]
	public void ResetRepeatIndex()
	{
	}

	[Token(Token = "0x6000A8C")]
	[Address(RVA = "0x9E82A8", Offset = "0x9E82A8", VA = "0x9E82A8")]
	public QuestItem()
	{
	}
}
