using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004FE")]
	public class RDGameTrigger : BaseEntityDocument
	{
		[Token(Token = "0x4001793")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82FCB8", Offset = "0x82FCB8")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82FCB8", Offset = "0x82FCB8")]
		public GameTriggerType triggerType;

		[Token(Token = "0x4001794")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82FD08", Offset = "0x82FD08")]
		public string key;

		[Token(Token = "0x4001795")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82FD40", Offset = "0x82FD40")]
		public float threshold;

		[Token(Token = "0x6002659")]
		[Address(RVA = "0xA81224", Offset = "0xA81224", VA = "0xA81224")]
		public RDGameTrigger()
		{
		}
	}
}
