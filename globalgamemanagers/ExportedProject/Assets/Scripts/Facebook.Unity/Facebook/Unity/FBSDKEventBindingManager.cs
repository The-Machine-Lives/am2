using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000066")]
	public class FBSDKEventBindingManager
	{
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8165E0", Offset = "0x8165E0")]
		private List<FBSDKEventBinding> _003CeventBindings_003Ek__BackingField;

		[Token(Token = "0x17000078")]
		public List<FBSDKEventBinding> eventBindings
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xCD22F4", Offset = "0xCD22F4", VA = "0xCD22F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x817000", Offset = "0x817000")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xCDC490", Offset = "0xCDC490", VA = "0xCDC490")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x817010", Offset = "0x817010")]
			set
			{
			}
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xCD2414", Offset = "0xCD2414", VA = "0xCD2414")]
		public FBSDKEventBindingManager(List<object> listDict)
		{
		}
	}
}
