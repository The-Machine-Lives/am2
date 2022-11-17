using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Uken.Library.Animation
{
	[Token(Token = "0x2000497")]
	public class UkenAnimImage : UkenAnimBase
	{
		[Token(Token = "0x4001503")]
		[FieldOffset(Offset = "0x48")]
		private Image targetImage;

		[Token(Token = "0x4001504")]
		[FieldOffset(Offset = "0x50")]
		private Color startColor;

		[Token(Token = "0x4001505")]
		[FieldOffset(Offset = "0x60")]
		private Color currentColor;

		[Token(Token = "0x4001506")]
		[FieldOffset(Offset = "0x70")]
		private Color deltaColor;

		[Token(Token = "0x4001507")]
		[FieldOffset(Offset = "0x80")]
		private Color destinationColor;

		[Token(Token = "0x4001508")]
		[FieldOffset(Offset = "0x90")]
		private float startFill;

		[Token(Token = "0x4001509")]
		[FieldOffset(Offset = "0x94")]
		private float deltaFill;

		[Token(Token = "0x400150A")]
		[FieldOffset(Offset = "0x98")]
		private float endFill;

		[Token(Token = "0x400150B")]
		[FieldOffset(Offset = "0x9C")]
		private bool changeColor;

		[Token(Token = "0x400150C")]
		[FieldOffset(Offset = "0x9D")]
		private bool changeFill;

		[Token(Token = "0x400150D")]
		[FieldOffset(Offset = "0xA0")]
		private string assetName;

		[Token(Token = "0x400150E")]
		[FieldOffset(Offset = "0xA8")]
		private bool seenUpdateError;

		[Token(Token = "0x60021CA")]
		[Address(RVA = "0xAF1B40", Offset = "0xAF1B40", VA = "0xAF1B40")]
		public UkenAnimImage(float duration, float startDelay = 0f)
		{
		}

		[Token(Token = "0x60021CB")]
		[Address(RVA = "0xAF1B88", Offset = "0xAF1B88", VA = "0xAF1B88")]
		public void SetImageTarget(Image img)
		{
		}

		[Token(Token = "0x60021CC")]
		[Address(RVA = "0xAF4F3C", Offset = "0xAF4F3C", VA = "0xAF4F3C")]
		public void SetColor(Color _destinationColor)
		{
		}

		[Token(Token = "0x60021CD")]
		[Address(RVA = "0xAF5020", Offset = "0xAF5020", VA = "0xAF5020")]
		public void SetColor(Color _beginColor, Color _destinationColor)
		{
		}

		[Token(Token = "0x60021CE")]
		[Address(RVA = "0xAF1C98", Offset = "0xAF1C98", VA = "0xAF1C98")]
		public void SetFill(float fill)
		{
		}

		[Token(Token = "0x60021CF")]
		[Address(RVA = "0xAF50C4", Offset = "0xAF50C4", VA = "0xAF50C4", Slot = "6")]
		public override bool Update(float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60021D0")]
		[Address(RVA = "0xAF530C", Offset = "0xAF530C", VA = "0xAF530C", Slot = "7")]
		protected override void OnFinalize()
		{
		}
	}
}
