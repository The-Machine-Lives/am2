using AM2.ReferenceData;
using Il2CppDummyDll;

[Token(Token = "0x200007D")]
public interface IBuffState
{
	[Token(Token = "0x1700002F")]
	Buff buff
	{
		[Token(Token = "0x6000233")]
		get;
	}

	[Token(Token = "0x17000030")]
	double remainingTimeInSeconds
	{
		[Token(Token = "0x6000234")]
		get;
	}

	[Token(Token = "0x17000031")]
	int remainingTimeInSceneCount
	{
		[Token(Token = "0x6000235")]
		get;
	}

	[Token(Token = "0x17000032")]
	double remainingOvertimeAbilityTimeInSeconds
	{
		[Token(Token = "0x6000236")]
		get;
	}

	[Token(Token = "0x17000033")]
	bool isAlive
	{
		[Token(Token = "0x6000237")]
		get;
	}

	[Token(Token = "0x17000034")]
	float durationInSeconds
	{
		[Token(Token = "0x6000238")]
		get;
	}

	[Token(Token = "0x17000035")]
	int durationInSceneCount
	{
		[Token(Token = "0x6000239")]
		get;
	}

	[Token(Token = "0x17000036")]
	long stacks
	{
		[Token(Token = "0x600023A")]
		get;
	}

	[Token(Token = "0x17000037")]
	long level
	{
		[Token(Token = "0x600023B")]
		get;
	}
}
