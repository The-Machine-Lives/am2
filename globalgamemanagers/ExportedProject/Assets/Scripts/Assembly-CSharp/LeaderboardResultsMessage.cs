using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual.Leaderboards;
using Uken.Library.Scoreboards;

[Token(Token = "0x20001C6")]
public class LeaderboardResultsMessage
{
	[Token(Token = "0x4000A7B")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x825D8C", Offset = "0x825D8C")]
	private GlobalLeaderboard _003CglobalLeaderboard_003Ek__BackingField;

	[Token(Token = "0x4000A7C")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x825D9C", Offset = "0x825D9C")]
	private LeaderboardDefinition _003CleaderboardDefinition_003Ek__BackingField;

	[Token(Token = "0x4000A7D")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x825DAC", Offset = "0x825DAC")]
	private ScoreboardEntity _003Centity_003Ek__BackingField;

	[Token(Token = "0x4000A7E")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x825DBC", Offset = "0x825DBC")]
	private Dictionary<string, long> _003CrewardsTransaction_003Ek__BackingField;

	[Token(Token = "0x17000181")]
	public GlobalLeaderboard globalLeaderboard
	{
		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x992FA4", Offset = "0x992FA4", VA = "0x992FA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834A5C", Offset = "0x834A5C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x992FAC", Offset = "0x992FAC", VA = "0x992FAC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834A6C", Offset = "0x834A6C")]
		set
		{
		}
	}

	[Token(Token = "0x17000182")]
	public LeaderboardDefinition leaderboardDefinition
	{
		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x992FB4", Offset = "0x992FB4", VA = "0x992FB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834A7C", Offset = "0x834A7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x992FBC", Offset = "0x992FBC", VA = "0x992FBC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834A8C", Offset = "0x834A8C")]
		set
		{
		}
	}

	[Token(Token = "0x17000183")]
	public ScoreboardEntity entity
	{
		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x992FC4", Offset = "0x992FC4", VA = "0x992FC4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834A9C", Offset = "0x834A9C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x992FCC", Offset = "0x992FCC", VA = "0x992FCC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834AAC", Offset = "0x834AAC")]
		set
		{
		}
	}

	[Token(Token = "0x17000184")]
	public Dictionary<string, long> rewardsTransaction
	{
		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x992FD4", Offset = "0x992FD4", VA = "0x992FD4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834ABC", Offset = "0x834ABC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x992FDC", Offset = "0x992FDC", VA = "0x992FDC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834ACC", Offset = "0x834ACC")]
		set
		{
		}
	}

	[Token(Token = "0x6000C35")]
	[Address(RVA = "0x992FE4", Offset = "0x992FE4", VA = "0x992FE4")]
	public LeaderboardResultsMessage()
	{
	}
}
