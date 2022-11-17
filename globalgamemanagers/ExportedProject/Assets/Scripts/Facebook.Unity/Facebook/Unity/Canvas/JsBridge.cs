using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity.Canvas
{
	[Token(Token = "0x2000098")]
	internal class JsBridge : MonoBehaviour
	{
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x18")]
		private ICanvasFacebookCallbackHandler facebook;

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xCCE5DC", Offset = "0xCCE5DC", VA = "0xCCE5DC")]
		public void Start()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xCCE634", Offset = "0xCCE634", VA = "0xCCE634")]
		public void OnLoginComplete(string responseJsonData = "")
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xCCE6FC", Offset = "0xCCE6FC", VA = "0xCCE6FC")]
		public void OnFacebookAuthResponseChange(string responseJsonData = "")
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xCCE7C4", Offset = "0xCCE7C4", VA = "0xCCE7C4")]
		public void OnPayComplete(string responseJsonData = "")
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xCCE888", Offset = "0xCCE888", VA = "0xCCE888")]
		public void OnAppRequestsComplete(string responseJsonData = "")
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xCCE950", Offset = "0xCCE950", VA = "0xCCE950")]
		public void OnShareLinkComplete(string responseJsonData = "")
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xCCEA18", Offset = "0xCCEA18", VA = "0xCCEA18")]
		public void OnFacebookFocus(string state)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xCCEAFC", Offset = "0xCCEAFC", VA = "0xCCEAFC")]
		public void OnInitComplete(string responseJsonData = "")
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xCCEBC0", Offset = "0xCCEBC0", VA = "0xCCEBC0")]
		public void OnUrlResponse(string url = "")
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xCCEC88", Offset = "0xCCEC88", VA = "0xCCEC88")]
		public JsBridge()
		{
		}
	}
}
