using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200007E")]
public interface IFightActorState
{
	[Token(Token = "0x17000038")]
	bool isAlive
	{
		[Token(Token = "0x600023C")]
		get;
	}

	[Token(Token = "0x17000039")]
	bool isStunned
	{
		[Token(Token = "0x600023D")]
		get;
	}

	[Token(Token = "0x1700003A")]
	double castTime
	{
		[Token(Token = "0x600023F")]
		get;
	}

	[Token(Token = "0x1700003B")]
	long currentHealth
	{
		[Token(Token = "0x6000240")]
		get;
	}

	[Token(Token = "0x1700003C")]
	long maxHealth
	{
		[Token(Token = "0x6000241")]
		get;
	}

	[Token(Token = "0x1700003D")]
	FightActorController friendlyTarget
	{
		[Token(Token = "0x6000242")]
		get;
	}

	[Token(Token = "0x1700003E")]
	FightActorController enemyTarget
	{
		[Token(Token = "0x6000243")]
		get;
	}

	[Token(Token = "0x1700003F")]
	long currentBuffsCount
	{
		[Token(Token = "0x6000244")]
		get;
	}

	[Token(Token = "0x600023E")]
	long GetStateForKey(StatModifierKey key);

	[Token(Token = "0x6000245")]
	List<IBuffState> GetAllBuffsAsList();
}
