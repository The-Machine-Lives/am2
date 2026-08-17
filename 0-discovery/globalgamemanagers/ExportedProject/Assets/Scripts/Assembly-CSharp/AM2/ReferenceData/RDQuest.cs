using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;
using UnityEngine;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200039D")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F6E8", Offset = "0x81F6E8")]
	public class RDQuest : BaseEntityDocument
	{
		[Token(Token = "0x4001174")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D358", Offset = "0x82D358")]
		public string readableName;

		[Token(Token = "0x4001175")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D390", Offset = "0x82D390")]
		public string description;

		[Token(Token = "0x4001176")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82D3C8", Offset = "0x82D3C8")]
		[Attribute(Name = "EntityReference", RVA = "0x82D3C8", Offset = "0x82D3C8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D3C8", Offset = "0x82D3C8")]
		public List<string> tasks;

		[Token(Token = "0x4001177")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D43C", Offset = "0x82D43C")]
		public bool consumeCostItem;

		[Token(Token = "0x4001178")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D474", Offset = "0x82D474")]
		public string costItemRef;

		[Token(Token = "0x4001179")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D4AC", Offset = "0x82D4AC")]
		public long costItemQuantity;

		[Token(Token = "0x400117A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "EntityReference", RVA = "0x82D4E4", Offset = "0x82D4E4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D4E4", Offset = "0x82D4E4")]
		public string startRewardGroup;

		[Token(Token = "0x400117B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "EntityReference", RVA = "0x82D544", Offset = "0x82D544")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D544", Offset = "0x82D544")]
		public string completionRewardGroup;

		[Token(Token = "0x400117C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D5A4", Offset = "0x82D5A4")]
		public long maxRepeats;

		[Token(Token = "0x400117D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D5DC", Offset = "0x82D5DC")]
		public List<int> tierRewardLevelsToDisplay;

		[Token(Token = "0x400117E")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D628", Offset = "0x82D628")]
		public string infoText;

		[Token(Token = "0x400117F")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D660", Offset = "0x82D660")]
		public string infoImageSource;

		[Token(Token = "0x4001180")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x82D698", Offset = "0x82D698")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D698", Offset = "0x82D698")]
		public List<string> resetOnFinish;

		[Token(Token = "0x6001C35")]
		[Address(RVA = "0x9BA8E8", Offset = "0x9BA8E8", VA = "0x9BA8E8")]
		public RDQuest(string _ref)
		{
		}
	}
}
