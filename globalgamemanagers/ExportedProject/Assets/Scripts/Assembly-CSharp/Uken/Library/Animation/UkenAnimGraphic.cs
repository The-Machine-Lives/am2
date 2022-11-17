using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Uken.Library.Animation
{
	[Token(Token = "0x2000496")]
	public class UkenAnimGraphic : UkenAnimBase
	{
		[Token(Token = "0x40014FC")]
		[FieldOffset(Offset = "0x48")]
		private Graphic targetGraphic;

		[Token(Token = "0x40014FD")]
		[FieldOffset(Offset = "0x50")]
		private Color startColor;

		[Token(Token = "0x40014FE")]
		[FieldOffset(Offset = "0x60")]
		private Color currentColor;

		[Token(Token = "0x40014FF")]
		[FieldOffset(Offset = "0x70")]
		private Color deltaColor;

		[Token(Token = "0x4001500")]
		[FieldOffset(Offset = "0x80")]
		private Color destinationColor;

		[Token(Token = "0x4001501")]
		[FieldOffset(Offset = "0x90")]
		private string assetName;

		[Token(Token = "0x4001502")]
		[FieldOffset(Offset = "0x98")]
		private bool seenUpdateError;

		[Token(Token = "0x60021C3")]
		[Address(RVA = "0xAF1450", Offset = "0xAF1450", VA = "0xAF1450")]
		public UkenAnimGraphic(float duration, float startDelay)
		{
		}

		[Token(Token = "0x60021C4")]
		[Address(RVA = "0xAF4B34", Offset = "0xAF4B34", VA = "0xAF4B34", Slot = "5")]
		public override bool IsComplete()
		{
			return default(bool);
		}

		[Token(Token = "0x60021C5")]
		[Address(RVA = "0xAF1498", Offset = "0xAF1498", VA = "0xAF1498")]
		public void SetTextTarget(Graphic graphic)
		{
		}

		[Token(Token = "0x60021C6")]
		[Address(RVA = "0xAF1984", Offset = "0xAF1984", VA = "0xAF1984")]
		public void SetColor(Color _beginColor, Color _destinationColor)
		{
		}

		[Token(Token = "0x60021C7")]
		[Address(RVA = "0xAF15A8", Offset = "0xAF15A8", VA = "0xAF15A8")]
		public void SetColor(Color _destinationColor)
		{
		}

		[Token(Token = "0x60021C8")]
		[Address(RVA = "0xAF4C08", Offset = "0xAF4C08", VA = "0xAF4C08", Slot = "6")]
		public override bool Update(float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60021C9")]
		[Address(RVA = "0xAF4E0C", Offset = "0xAF4E0C", VA = "0xAF4E0C", Slot = "7")]
		protected override void OnFinalize()
		{
		}
	}
}
