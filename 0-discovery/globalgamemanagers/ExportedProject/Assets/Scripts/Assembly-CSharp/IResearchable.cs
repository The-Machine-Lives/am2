using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x20001C4")]
public interface IResearchable : ISubTabItemModel, IItemModel, IInfoText
{
	[Token(Token = "0x1700017B")]
	string costItemRef
	{
		[Token(Token = "0x6000C19")]
		get;
	}

	[Token(Token = "0x1700017C")]
	string localizedAcquireText
	{
		[Token(Token = "0x6000C1A")]
		get;
	}

	[Token(Token = "0x1700017D")]
	long costQuantity
	{
		[Token(Token = "0x6000C1B")]
		get;
	}

	[Token(Token = "0x1700017E")]
	EBuyType buyType
	{
		[Token(Token = "0x6000C1C")]
		get;
	}

	[Token(Token = "0x1700017F")]
	EBuyRefDataType buyRefDataType
	{
		[Token(Token = "0x6000C1D")]
		get;
	}

	[Token(Token = "0x17000180")]
	double remainingTimeToProgressInSeconds
	{
		[Token(Token = "0x6000C1E")]
		get;
		[Token(Token = "0x6000C1F")]
		set;
	}

	[Token(Token = "0x6000C20")]
	BuyDisplayInfo GetBuyDisplayInfo();

	[Token(Token = "0x6000C21")]
	string GetBuyName();

	[Token(Token = "0x6000C22")]
	void SetResearchProgress(long progress);

	[Token(Token = "0x6000C23")]
	long GetResearchProgress();

	[Token(Token = "0x6000C24")]
	void IncrementAmount();

	[Token(Token = "0x6000C25")]
	bool IsLevelMaxed();

	[Token(Token = "0x6000C26")]
	Dictionary<string, long> GetCostsDict();

	[Token(Token = "0x6000C27")]
	Dictionary<string, long> GetDictionaryLevelGates();
}
