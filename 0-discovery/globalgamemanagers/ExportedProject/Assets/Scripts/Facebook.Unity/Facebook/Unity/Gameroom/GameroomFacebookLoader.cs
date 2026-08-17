using Il2CppDummyDll;

namespace Facebook.Unity.Gameroom
{
	[Token(Token = "0x200006D")]
	internal class GameroomFacebookLoader : FB.CompiledFacebookLoader
	{
		[Token(Token = "0x17000080")]
		protected override FacebookGameObject FBGameObject
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0xCE0768", Offset = "0xCE0768", VA = "0xCE0768", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xCE07EC", Offset = "0xCE07EC", VA = "0xCE07EC")]
		public GameroomFacebookLoader()
		{
		}
	}
}
