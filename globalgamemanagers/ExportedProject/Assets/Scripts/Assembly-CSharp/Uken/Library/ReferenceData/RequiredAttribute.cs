using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x200047E")]
	public class RequiredAttribute : ValidateAttribute
	{
		[Token(Token = "0x400149E")]
		private const string errMsgTemplate = "The field {0} is required";

		[Token(Token = "0x400149F")]
		private const string noEmptyMsgTemplate = "The field {0} cannot be empty";

		[Token(Token = "0x40014A0")]
		[FieldOffset(Offset = "0x10")]
		private bool allowEmpty;

		[Token(Token = "0x600211E")]
		[Address(RVA = "0xB37D98", Offset = "0xB37D98", VA = "0xB37D98")]
		public RequiredAttribute(bool allowEmpty = true)
		{
		}
	}
}
