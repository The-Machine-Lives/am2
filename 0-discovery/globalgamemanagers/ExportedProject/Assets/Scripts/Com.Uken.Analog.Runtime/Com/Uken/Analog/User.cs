using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000035")]
	public class User
	{
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814D08", Offset = "0x814D08")]
		private string id;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814D40", Offset = "0x814D40")]
		private UserState state;

		[Token(Token = "0x17000058")]
		[JsonIgnore]
		public string Id
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x16DA4BC", Offset = "0x16DA4BC", VA = "0x16DA4BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x16DA4C4", Offset = "0x16DA4C4", VA = "0x16DA4C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		[JsonIgnore]
		public UserState State
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x16D76D4", Offset = "0x16D76D4", VA = "0x16D76D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x16DA4CC", Offset = "0x16DA4CC", VA = "0x16DA4CC")]
			set
			{
			}
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x16D6190", Offset = "0x16D6190", VA = "0x16D6190")]
		public User(UserState state)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x16D61BC", Offset = "0x16D61BC", VA = "0x16D61BC")]
		public User SetId(string userId)
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x16DA4D4", Offset = "0x16DA4D4", VA = "0x16DA4D4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
