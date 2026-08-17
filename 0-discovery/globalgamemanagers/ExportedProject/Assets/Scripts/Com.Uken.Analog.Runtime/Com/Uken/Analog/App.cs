using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200002A")]
	public class App
	{
		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "JsonConverterAttribute", RVA = "0x813C08", Offset = "0x813C08")]
		public enum GameName
		{
			[Token(Token = "0x400009D")]
			war = 0,
			[Token(Token = "0x400009E")]
			novawars = 1,
			[Token(Token = "0x400009F")]
			elementals = 2,
			[Token(Token = "0x40000A0")]
			villains = 3,
			[Token(Token = "0x40000A1")]
			legends = 4,
			[Token(Token = "0x40000A2")]
			crimeinc = 5,
			[Token(Token = "0x40000A3")]
			streets = 6,
			[Token(Token = "0x40000A4")]
			superheroes = 7,
			[Token(Token = "0x40000A5")]
			bazingo = 8,
			[Token(Token = "0x40000A6")]
			golem = 9,
			[Token(Token = "0x40000A7")]
			lootquest = 10,
			[Token(Token = "0x40000A8")]
			pool = 11,
			[Token(Token = "0x40000A9")]
			titans = 12,
			[Token(Token = "0x40000AA")]
			silver = 13,
			[Token(Token = "0x40000AB")]
			solitaire_wild = 14,
			[Token(Token = "0x40000AC")]
			jeopardy = 15,
			[Token(Token = "0x40000AD")]
			infinity_bingo = 16,
			[Token(Token = "0x40000AE")]
			emoticons = 17,
			[Token(Token = "0x40000AF")]
			millionaire = 18,
			[Token(Token = "0x40000B0")]
			wordup = 19,
			[Token(Token = "0x40000B1")]
			solitaire_jigsaw = 20,
			[Token(Token = "0x40000B2")]
			am2 = 21,
			[Token(Token = "0x40000B3")]
			jeopardy_cross = 22,
			[Token(Token = "0x40000B4")]
			platform = 23
		}

		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "JsonConverterAttribute", RVA = "0x813C6C", Offset = "0x813C6C")]
		public enum EnvironmentName
		{
			[Token(Token = "0x40000B6")]
			production = 0,
			[Token(Token = "0x40000B7")]
			staging = 1,
			[Token(Token = "0x40000B8")]
			sandbox = 2,
			[Token(Token = "0x40000B9")]
			preprod = 3,
			[Token(Token = "0x40000BA")]
			design = 4,
			[Token(Token = "0x40000BB")]
			development = 5
		}

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814780", Offset = "0x814780")]
		private string version;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8147B8", Offset = "0x8147B8")]
		private GameName name;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8147F0", Offset = "0x8147F0")]
		private EnvironmentName environment;

		[Token(Token = "0x1700003B")]
		[JsonIgnore]
		public string Name
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x16D4670", Offset = "0x16D4670", VA = "0x16D4670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		[JsonIgnore]
		public string Environment
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x16D4710", Offset = "0x16D4710", VA = "0x16D4710")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		[JsonIgnore]
		public string Version
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x16D47B0", Offset = "0x16D47B0", VA = "0x16D47B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x16D47B8", Offset = "0x16D47B8", VA = "0x16D47B8")]
			set
			{
			}
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x16D4630", Offset = "0x16D4630", VA = "0x16D4630")]
		public App(GameName gameName, EnvironmentName environmentName, string version)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x16D47C0", Offset = "0x16D47C0", VA = "0x16D47C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
