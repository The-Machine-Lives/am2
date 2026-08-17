using Il2CppDummyDll;

namespace Firebase
{
	[Token(Token = "0x2000020")]
	public enum DependencyStatus
	{
		[Token(Token = "0x400005B")]
		Available = 0,
		[Token(Token = "0x400005C")]
		UnavailableDisabled = 1,
		[Token(Token = "0x400005D")]
		UnavailableInvalid = 2,
		[Token(Token = "0x400005E")]
		UnavilableMissing = 3,
		[Token(Token = "0x400005F")]
		UnavailablePermission = 4,
		[Token(Token = "0x4000060")]
		UnavailableUpdaterequired = 5,
		[Token(Token = "0x4000061")]
		UnavailableUpdating = 6,
		[Token(Token = "0x4000062")]
		UnavailableOther = 7
	}
}
