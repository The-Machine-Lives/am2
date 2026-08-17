using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000337")]
	public abstract class RDActionScene : BaseEntityDocument
	{
		[Token(Token = "0x4000FD9")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x828824", Offset = "0x828824")]
		public int weight;

		[Token(Token = "0x4000FDA")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "EntityReference", RVA = "0x82885C", Offset = "0x82885C")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82885C", Offset = "0x82885C")]
		public string sceneRewardGroup;

		[Token(Token = "0x4000FDB")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8288BC", Offset = "0x8288BC")]
		public long quantity;

		[Token(Token = "0x4000FDC")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x8288F4", Offset = "0x8288F4")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x8288F4", Offset = "0x8288F4")]
		public List<string> friendlyStartEffects;

		[Token(Token = "0x60019D2")]
		[Address(RVA = "0x9BA18C", Offset = "0x9BA18C", VA = "0x9BA18C")]
		public RDActionScene(string _ref)
		{
		}
	}
}
