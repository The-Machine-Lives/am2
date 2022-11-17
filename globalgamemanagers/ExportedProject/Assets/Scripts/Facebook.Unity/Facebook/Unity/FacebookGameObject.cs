using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity
{
	[Token(Token = "0x2000016")]
	internal abstract class FacebookGameObject : MonoBehaviour, IFacebookCallbackHandler
	{
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816230", Offset = "0x816230")]
		private IFacebookImplementation _003CFacebook_003Ek__BackingField;

		[Token(Token = "0x17000029")]
		public IFacebookImplementation Facebook
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0xCCE0B4", Offset = "0xCCE0B4", VA = "0xCCE0B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816840", Offset = "0x816840")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0xCCE5C4", Offset = "0xCCE5C4", VA = "0xCCE5C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816850", Offset = "0x816850")]
			set
			{
			}
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xCDDC84", Offset = "0xCDDC84", VA = "0xCDDC84")]
		public void Awake()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xCDDD34", Offset = "0xCDDD34", VA = "0xCDDD34", Slot = "4")]
		public void OnInitComplete(string message)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xCDDE18", Offset = "0xCDDE18", VA = "0xCDDE18", Slot = "5")]
		public void OnLoginComplete(string message)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xCDDF00", Offset = "0xCDDF00", VA = "0xCDDF00", Slot = "8")]
		public void OnLogoutComplete(string message)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xCDDFE8", Offset = "0xCDDFE8", VA = "0xCDDFE8", Slot = "9")]
		public void OnGetAppLinkComplete(string message)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xCDE0D0", Offset = "0xCDE0D0", VA = "0xCDE0D0", Slot = "6")]
		public void OnAppRequestsComplete(string message)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xCDE1B8", Offset = "0xCDE1B8", VA = "0xCDE1B8", Slot = "7")]
		public void OnShareLinkComplete(string message)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xCDE2A0", Offset = "0xCDE2A0", VA = "0xCDE2A0", Slot = "10")]
		protected virtual void OnAwake()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xCCE538", Offset = "0xCCE538", VA = "0xCCE538")]
		protected FacebookGameObject()
		{
		}
	}
}
