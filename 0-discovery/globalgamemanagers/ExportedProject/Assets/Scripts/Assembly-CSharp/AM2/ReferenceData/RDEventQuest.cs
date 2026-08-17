using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200039A")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F6B0", Offset = "0x81F6B0")]
	public class RDEventQuest : BaseEntityDocument
	{
		[Token(Token = "0x4001164")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82CF08", Offset = "0x82CF08")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CF08", Offset = "0x82CF08")]
		public string readableName;

		[Token(Token = "0x4001165")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82CF58", Offset = "0x82CF58")]
		[Attribute(Name = "EntityReference", RVA = "0x82CF58", Offset = "0x82CF58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CF58", Offset = "0x82CF58")]
		public string repeatingSchedule;

		[Token(Token = "0x4001166")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82CFCC", Offset = "0x82CFCC")]
		[Attribute(Name = "EntityReference", RVA = "0x82CFCC", Offset = "0x82CFCC")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82CFCC", Offset = "0x82CFCC")]
		public List<string> questsInEventChain;

		[Token(Token = "0x4001167")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "EntityReference", RVA = "0x82D040", Offset = "0x82D040")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D040", Offset = "0x82D040")]
		public string startRewardGroup;

		[Token(Token = "0x4001168")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "EntityReference", RVA = "0x82D0A0", Offset = "0x82D0A0")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D0A0", Offset = "0x82D0A0")]
		public string endRewardGroup;

		[Token(Token = "0x4001169")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "EntityReference", RVA = "0x82D100", Offset = "0x82D100")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D100", Offset = "0x82D100")]
		public string globalLeaderboard;

		[Token(Token = "0x400116A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82D160", Offset = "0x82D160")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x82D160", Offset = "0x82D160")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D160", Offset = "0x82D160")]
		public List<string> resetOnFinish;

		[Token(Token = "0x400116B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D270", Offset = "0x82D270")]
		public bool displayQuestProgressIndividually;

		[Token(Token = "0x400116C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "EntityReference", RVA = "0x82D2A8", Offset = "0x82D2A8")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82D2A8", Offset = "0x82D2A8")]
		public string unlocker;

		[Token(Token = "0x6001C1C")]
		[Address(RVA = "0x9BA490", Offset = "0x9BA490", VA = "0x9BA490")]
		public RDEventQuest(string _ref)
		{
		}
	}
}
