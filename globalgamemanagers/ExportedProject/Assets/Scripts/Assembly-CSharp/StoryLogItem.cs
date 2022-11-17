using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.Inventory;

[Token(Token = "0x200018A")]
public class StoryLogItem : Item
{
	[Token(Token = "0x4000959")]
	public new const string mc_sItemType = "StoryLogItem";

	[Token(Token = "0x400095A")]
	private const int c_maxStoryLogs = 500;

	[Token(Token = "0x400095B")]
	private const int c_maxGroups = 20;

	[Token(Token = "0x400095C")]
	private const int c_maxStoryLogsPerGroup = 25;

	[Token(Token = "0x400095D")]
	private const string c_storyLogGroupPrefix = "log_ids_";

	[Token(Token = "0x400095E")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8251FC", Offset = "0x8251FC")]
	private List<string> _003CstoryLogIDs_003Ek__BackingField;

	[Token(Token = "0x17000158")]
	public List<string> storyLogIDs
	{
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0xA0B35C", Offset = "0xA0B35C", VA = "0xA0B35C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8346E4", Offset = "0x8346E4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0xA0B364", Offset = "0xA0B364", VA = "0xA0B364")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8346F4", Offset = "0x8346F4")]
		private set
		{
		}
	}

	[Token(Token = "0x6000AC8")]
	[Address(RVA = "0xA0B36C", Offset = "0xA0B36C", VA = "0xA0B36C", Slot = "4")]
	public override void ResetTraits(bool resetLifeTimeQuantity = false)
	{
	}

	[Token(Token = "0x6000AC9")]
	[Address(RVA = "0xA0B42C", Offset = "0xA0B42C", VA = "0xA0B42C")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000ACA")]
	[Address(RVA = "0xA0B58C", Offset = "0xA0B58C", VA = "0xA0B58C")]
	private string GetGroupString(int index)
	{
		return null;
	}

	[Token(Token = "0x6000ACB")]
	[Address(RVA = "0xA0B5F8", Offset = "0xA0B5F8", VA = "0xA0B5F8")]
	private string GetGroupKey(int index)
	{
		return null;
	}

	[Token(Token = "0x6000ACC")]
	[Address(RVA = "0xA0B660", Offset = "0xA0B660", VA = "0xA0B660")]
	public void AddStoryLog(string logID)
	{
	}

	[Token(Token = "0x6000ACD")]
	[Address(RVA = "0xA0B81C", Offset = "0xA0B81C", VA = "0xA0B81C")]
	public bool HasStoryLog(string logID)
	{
		return default(bool);
	}

	[Token(Token = "0x6000ACE")]
	[Address(RVA = "0xA0B778", Offset = "0xA0B778", VA = "0xA0B778")]
	private void AddStoryLog(int groupIndex, string logID)
	{
	}

	[Token(Token = "0x6000ACF")]
	[Address(RVA = "0xA0B398", Offset = "0xA0B398", VA = "0xA0B398")]
	private void ResetStoryLogs()
	{
	}

	[Token(Token = "0x6000AD0")]
	[Address(RVA = "0xA0B88C", Offset = "0xA0B88C", VA = "0xA0B88C")]
	public StoryLogItem()
	{
	}
}
