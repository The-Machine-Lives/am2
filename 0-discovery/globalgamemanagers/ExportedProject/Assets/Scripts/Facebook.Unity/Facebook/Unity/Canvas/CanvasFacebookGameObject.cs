using Il2CppDummyDll;

namespace Facebook.Unity.Canvas
{
	[Token(Token = "0x2000091")]
	internal class CanvasFacebookGameObject : FacebookGameObject, ICanvasFacebookCallbackHandler, IFacebookCallbackHandler
	{
		[Token(Token = "0x170000A0")]
		protected ICanvasFacebookImplementation CanvasFacebookImpl
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0xCCDFF8", Offset = "0xCCDFF8", VA = "0xCCDFF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xCCE0BC", Offset = "0xCCE0BC", VA = "0xCCE0BC", Slot = "11")]
		public void OnPayComplete(string result)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xCCE1AC", Offset = "0xCCE1AC", VA = "0xCCE1AC", Slot = "12")]
		public void OnFacebookAuthResponseChange(string message)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xCCE2A0", Offset = "0xCCE2A0", VA = "0xCCE2A0", Slot = "13")]
		public void OnUrlResponse(string message)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xCCE36C", Offset = "0xCCE36C", VA = "0xCCE36C", Slot = "14")]
		public void OnHideUnity(bool hide)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xCCE438", Offset = "0xCCE438", VA = "0xCCE438", Slot = "10")]
		protected override void OnAwake()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xCCE530", Offset = "0xCCE530", VA = "0xCCE530")]
		public CanvasFacebookGameObject()
		{
		}
	}
}
