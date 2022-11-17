using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.Scoreboards;

namespace Uken.Framework.Casual.Leaderboards
{
	[Token(Token = "0x200058E")]
	public class Leaderboard
	{
		[Token(Token = "0x4001A53")]
		[FieldOffset(Offset = "0x10")]
		public LeaderboardEntity Self;

		[Token(Token = "0x4001A54")]
		[FieldOffset(Offset = "0x18")]
		public List<LeaderboardEntity> Top;

		[Token(Token = "0x4001A55")]
		[FieldOffset(Offset = "0x20")]
		public List<LeaderboardEntity> Above;

		[Token(Token = "0x4001A56")]
		[FieldOffset(Offset = "0x28")]
		public List<LeaderboardEntity> Below;

		[Token(Token = "0x4001A57")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832C10", Offset = "0x832C10")]
		private bool _003CIsSelfTopRanked_003Ek__BackingField;

		[Token(Token = "0x4001A58")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832C20", Offset = "0x832C20")]
		private DateTime _003CStartTime_003Ek__BackingField;

		[Token(Token = "0x4001A59")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832C30", Offset = "0x832C30")]
		private DateTime _003CEndTime_003Ek__BackingField;

		[Token(Token = "0x4001A5A")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832C40", Offset = "0x832C40")]
		private string _003CLeaderboardName_003Ek__BackingField;

		[Token(Token = "0x4001A5B")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832C50", Offset = "0x832C50")]
		private LeaderboardType _003CType_003Ek__BackingField;

		[Token(Token = "0x1700076D")]
		public bool IsSelfTopRanked
		{
			[Token(Token = "0x6002A73")]
			[Address(RVA = "0xA6ED98", Offset = "0xA6ED98", VA = "0xA6ED98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A84C", Offset = "0x83A84C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002A74")]
			[Address(RVA = "0xA6EDA0", Offset = "0xA6EDA0", VA = "0xA6EDA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A85C", Offset = "0x83A85C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700076E")]
		public DateTime StartTime
		{
			[Token(Token = "0x6002A75")]
			[Address(RVA = "0xA6EDAC", Offset = "0xA6EDAC", VA = "0xA6EDAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A86C", Offset = "0x83A86C")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6002A76")]
			[Address(RVA = "0xA6EDB4", Offset = "0xA6EDB4", VA = "0xA6EDB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A87C", Offset = "0x83A87C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700076F")]
		public DateTime EndTime
		{
			[Token(Token = "0x6002A77")]
			[Address(RVA = "0xA6EDBC", Offset = "0xA6EDBC", VA = "0xA6EDBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A88C", Offset = "0x83A88C")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6002A78")]
			[Address(RVA = "0xA6EDC4", Offset = "0xA6EDC4", VA = "0xA6EDC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A89C", Offset = "0x83A89C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000770")]
		public string LeaderboardName
		{
			[Token(Token = "0x6002A79")]
			[Address(RVA = "0xA6EDCC", Offset = "0xA6EDCC", VA = "0xA6EDCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A8AC", Offset = "0x83A8AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A7A")]
			[Address(RVA = "0xA6EDD4", Offset = "0xA6EDD4", VA = "0xA6EDD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A8BC", Offset = "0x83A8BC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000771")]
		public LeaderboardType Type
		{
			[Token(Token = "0x6002A7B")]
			[Address(RVA = "0xA6EDDC", Offset = "0xA6EDDC", VA = "0xA6EDDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A8CC", Offset = "0x83A8CC")]
			get
			{
				return default(LeaderboardType);
			}
			[Token(Token = "0x6002A7C")]
			[Address(RVA = "0xA6EDE4", Offset = "0xA6EDE4", VA = "0xA6EDE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A8DC", Offset = "0x83A8DC")]
			protected set
			{
			}
		}

		[Token(Token = "0x6002A7D")]
		[Address(RVA = "0xA6EDEC", Offset = "0xA6EDEC", VA = "0xA6EDEC")]
		public Leaderboard(ScoreboardScoreData score, ScoreboardDefinition backup)
		{
		}

		[Token(Token = "0x6002A7E")]
		[Address(RVA = "0xA6F604", Offset = "0xA6F604", VA = "0xA6F604")]
		public double GetTimeIntervalInSeconds()
		{
			return default(double);
		}
	}
}
