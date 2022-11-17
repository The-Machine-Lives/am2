using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004DC")]
	public class CasualSceneBackgroundController : MonoBehaviour
	{
		[Token(Token = "0x40016F9")]
		[FieldOffset(Offset = "0x18")]
		public Image m_ActiveBackground;

		[Token(Token = "0x40016FA")]
		[FieldOffset(Offset = "0x20")]
		public Image m_TopBackground;

		[Token(Token = "0x6002552")]
		[Address(RVA = "0xA54A0C", Offset = "0xA54A0C", VA = "0xA54A0C")]
		public void Init()
		{
		}

		[Token(Token = "0x6002553")]
		[Address(RVA = "0xA54B78", Offset = "0xA54B78", VA = "0xA54B78")]
		public void AnimateToNewBackground(Sprite newBG, float duration = 0.3f)
		{
		}

		[Token(Token = "0x6002554")]
		[Address(RVA = "0xA54F88", Offset = "0xA54F88", VA = "0xA54F88")]
		public void DimActiveBG(Color target)
		{
		}

		[Token(Token = "0x6002555")]
		[Address(RVA = "0xA54FF0", Offset = "0xA54FF0", VA = "0xA54FF0")]
		public Sprite GetActiveBackground()
		{
			return null;
		}

		[Token(Token = "0x6002556")]
		[Address(RVA = "0xA55090", Offset = "0xA55090", VA = "0xA55090")]
		public void SetActiveBackground(Sprite BG)
		{
		}

		[Token(Token = "0x6002557")]
		[Address(RVA = "0xA54E8C", Offset = "0xA54E8C", VA = "0xA54E8C")]
		private void clearOldBG()
		{
		}

		[Token(Token = "0x6002558")]
		[Address(RVA = "0xA552C0", Offset = "0xA552C0", VA = "0xA552C0")]
		public CasualSceneBackgroundController()
		{
		}
	}
}
