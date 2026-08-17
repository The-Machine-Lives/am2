using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Uken.Library.Animation
{
	[Token(Token = "0x2000498")]
	public class UkenAnimOutline : UkenAnimBase
	{
		[Token(Token = "0x400150F")]
		[FieldOffset(Offset = "0x48")]
		private Outline targetOutline;

		[Token(Token = "0x4001510")]
		[FieldOffset(Offset = "0x50")]
		private Color startColor;

		[Token(Token = "0x4001511")]
		[FieldOffset(Offset = "0x60")]
		private Color currentColor;

		[Token(Token = "0x4001512")]
		[FieldOffset(Offset = "0x70")]
		private Color deltaColor;

		[Token(Token = "0x4001513")]
		[FieldOffset(Offset = "0x80")]
		private Color destinationColor;

		[Token(Token = "0x4001514")]
		[FieldOffset(Offset = "0x90")]
		private string assetName;

		[Token(Token = "0x4001515")]
		[FieldOffset(Offset = "0x98")]
		private bool seenUpdateError;

		[Token(Token = "0x60021D1")]
		[Address(RVA = "0xAF0F54", Offset = "0xAF0F54", VA = "0xAF0F54")]
		public UkenAnimOutline(float duration, float startDelay = 0f)
		{
		}

		[Token(Token = "0x60021D2")]
		[Address(RVA = "0xAF0F9C", Offset = "0xAF0F9C", VA = "0xAF0F9C")]
		public void SetOutlineTarget(Outline outline)
		{
		}

		[Token(Token = "0x60021D3")]
		[Address(RVA = "0xAF5444", Offset = "0xAF5444", VA = "0xAF5444")]
		public void SetColor(Color _destinationColor)
		{
		}

		[Token(Token = "0x60021D4")]
		[Address(RVA = "0xAF10AC", Offset = "0xAF10AC", VA = "0xAF10AC")]
		public void SetColor(Color _beginColor, Color _destinationColor)
		{
		}

		[Token(Token = "0x60021D5")]
		[Address(RVA = "0xAF5520", Offset = "0xAF5520", VA = "0xAF5520", Slot = "6")]
		public override bool Update(float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60021D6")]
		[Address(RVA = "0xAF571C", Offset = "0xAF571C", VA = "0xAF571C", Slot = "7")]
		protected override void OnFinalize()
		{
		}
	}
}
