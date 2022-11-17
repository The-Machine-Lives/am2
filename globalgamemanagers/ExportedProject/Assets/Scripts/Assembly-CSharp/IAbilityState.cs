using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000077")]
public interface IAbilityState
{
	[Token(Token = "0x17000020")]
	EAbilityState cooldownState
	{
		[Token(Token = "0x60001ED")]
		get;
	}

	[Token(Token = "0x17000021")]
	float cooldownInSeconds
	{
		[Token(Token = "0x60001EE")]
		get;
	}

	[Token(Token = "0x17000022")]
	long maxAmmoCount
	{
		[Token(Token = "0x60001EF")]
		get;
	}

	[Token(Token = "0x17000023")]
	float remainingCastTimeInSeconds
	{
		[Token(Token = "0x60001F0")]
		get;
	}

	[Token(Token = "0x17000024")]
	float remainingCooldownTimeInSeconds
	{
		[Token(Token = "0x60001F1")]
		get;
	}

	[Token(Token = "0x17000025")]
	float remainingChannelTimeInSeconds
	{
		[Token(Token = "0x60001F2")]
		get;
	}

	[Token(Token = "0x17000026")]
	float channelTimeInSeconds
	{
		[Token(Token = "0x60001F3")]
		get;
	}

	[Token(Token = "0x60001F4")]
	Queue<EAbilityEvent> ConsumeEvents();
}
