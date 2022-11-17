using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000082")]
	[Preserve]
	public class JsonISerializableContract : JsonContainerContract
	{
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F7E8", Offset = "0x80F7E8")]
		private ObjectConstructor<object> _003CISerializableCreator_003Ek__BackingField;

		[Token(Token = "0x17000091")]
		public ObjectConstructor<object> ISerializableCreator
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xD14C18", Offset = "0xD14C18", VA = "0xD14C18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810558", Offset = "0x810558")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xD0E154", Offset = "0xD0E154", VA = "0xD0E154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810568", Offset = "0x810568")]
			set
			{
			}
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xD0E12C", Offset = "0xD0E12C", VA = "0xD0E12C")]
		public JsonISerializableContract(Type underlyingType)
		{
		}
	}
}
