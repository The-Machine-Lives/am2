using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000029")]
	public class Assignment
	{
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8146A0", Offset = "0x8146A0")]
		[SerializeField]
		private string experiment_name;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x8146D8", Offset = "0x8146D8")]
		[SerializeField]
		private string assigned_group;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814710", Offset = "0x814710")]
		[SerializeField]
		private string session_treatment;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814748", Offset = "0x814748")]
		[SerializeField]
		private string test_state;

		[Token(Token = "0x17000037")]
		public string ExperimentName
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x16D5EE8", Offset = "0x16D5EE8", VA = "0x16D5EE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x16D5EF0", Offset = "0x16D5EF0", VA = "0x16D5EF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public string AssignedGroup
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x16D5EF8", Offset = "0x16D5EF8", VA = "0x16D5EF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x16D5F00", Offset = "0x16D5F00", VA = "0x16D5F00")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public string SessionTreatment
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x16D5F08", Offset = "0x16D5F08", VA = "0x16D5F08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x16D5F10", Offset = "0x16D5F10", VA = "0x16D5F10")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public string TestState
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x16D5F18", Offset = "0x16D5F18", VA = "0x16D5F18")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x16D5F20", Offset = "0x16D5F20", VA = "0x16D5F20")]
			set
			{
			}
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x16D5E9C", Offset = "0x16D5E9C", VA = "0x16D5E9C")]
		public Assignment(string experimentName, string assignedGroup, string sessionTreatment, string testState)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x16CDB54", Offset = "0x16CDB54", VA = "0x16CDB54")]
		public void WriteJson(JsonWriter writer)
		{
		}
	}
}
