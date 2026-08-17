using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000B4")]
	[Preserve]
	public class ReflectionValueProvider : IValueProvider
	{
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x10")]
		private readonly MemberInfo _memberInfo;

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xF05DA4", Offset = "0xF05DA4", VA = "0xF05DA4")]
		public ReflectionValueProvider(MemberInfo memberInfo)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xF05E18", Offset = "0xF05E18", VA = "0xF05E18", Slot = "4")]
		public void SetValue(object target, object value)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xF05FE0", Offset = "0xF05FE0", VA = "0xF05FE0", Slot = "5")]
		public object GetValue(object target)
		{
			return null;
		}
	}
}
