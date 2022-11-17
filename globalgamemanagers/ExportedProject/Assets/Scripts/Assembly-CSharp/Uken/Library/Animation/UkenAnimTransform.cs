using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Library.Animation
{
	[Token(Token = "0x200049B")]
	public class UkenAnimTransform : UkenAnimBase
	{
		[Token(Token = "0x4001519")]
		[FieldOffset(Offset = "0x48")]
		private RectTransform targetTransform;

		[Token(Token = "0x400151A")]
		[FieldOffset(Offset = "0x50")]
		private bool translateAnchored;

		[Token(Token = "0x400151B")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 startPositionAnchored;

		[Token(Token = "0x400151C")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 currentPositionAnchored;

		[Token(Token = "0x400151D")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 deltaPositionAnchored;

		[Token(Token = "0x400151E")]
		[FieldOffset(Offset = "0x78")]
		private Vector3[] pathPositionAnchored;

		[Token(Token = "0x400151F")]
		[FieldOffset(Offset = "0x80")]
		private bool translateLocal;

		[Token(Token = "0x4001520")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 startPositionLocal;

		[Token(Token = "0x4001521")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 currentPositionLocal;

		[Token(Token = "0x4001522")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 deltaPositionLocal;

		[Token(Token = "0x4001523")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3[] pathPositionLocal;

		[Token(Token = "0x4001524")]
		[FieldOffset(Offset = "0xB0")]
		private bool scale;

		[Token(Token = "0x4001525")]
		[FieldOffset(Offset = "0xB4")]
		private Vector3 startScale;

		[Token(Token = "0x4001526")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 currentScale;

		[Token(Token = "0x4001527")]
		[FieldOffset(Offset = "0xCC")]
		private Vector3 deltaScale;

		[Token(Token = "0x4001528")]
		[FieldOffset(Offset = "0xD8")]
		private bool rotate;

		[Token(Token = "0x4001529")]
		[FieldOffset(Offset = "0xDC")]
		private Vector3 startRotation;

		[Token(Token = "0x400152A")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 currentRotation;

		[Token(Token = "0x400152B")]
		[FieldOffset(Offset = "0xF4")]
		private Vector3 deltaRotation;

		[Token(Token = "0x60021DD")]
		[Address(RVA = "0xAF021C", Offset = "0xAF021C", VA = "0xAF021C")]
		public UkenAnimTransform(float duration, float startDelay)
		{
		}

		[Token(Token = "0x60021DE")]
		[Address(RVA = "0xAF5844", Offset = "0xAF5844", VA = "0xAF5844", Slot = "5")]
		public override bool IsComplete()
		{
			return default(bool);
		}

		[Token(Token = "0x60021DF")]
		[Address(RVA = "0xAF0220", Offset = "0xAF0220", VA = "0xAF0220")]
		public void SetTransform(RectTransform transform)
		{
		}

		[Token(Token = "0x60021E0")]
		[Address(RVA = "0xAF068C", Offset = "0xAF068C", VA = "0xAF068C")]
		public void TranslateLocal(Vector3 fromPosition, Vector3 goalPosition)
		{
		}

		[Token(Token = "0x60021E1")]
		[Address(RVA = "0xAF0504", Offset = "0xAF0504", VA = "0xAF0504")]
		public void TranslateLocal(Vector3 goalPosition)
		{
		}

		[Token(Token = "0x60021E2")]
		[Address(RVA = "0xAF07A8", Offset = "0xAF07A8", VA = "0xAF07A8")]
		public void TranslateLocal(Vector3[] path, UkenAnimTraversalType traversalType)
		{
		}

		[Token(Token = "0x60021E3")]
		[Address(RVA = "0xAF085C", Offset = "0xAF085C", VA = "0xAF085C")]
		public void TranslateAnchored(Vector3 goalPosition)
		{
		}

		[Token(Token = "0x60021E4")]
		[Address(RVA = "0xAF0A18", Offset = "0xAF0A18", VA = "0xAF0A18")]
		public void TranslateAnchored(Vector3[] path, UkenAnimTraversalType traversalType)
		{
		}

		[Token(Token = "0x60021E5")]
		[Address(RVA = "0xAE5648", Offset = "0xAE5648", VA = "0xAE5648")]
		public void ScaleLocal(Vector3 startingScale, Vector3 endingScale)
		{
		}

		[Token(Token = "0x60021E6")]
		[Address(RVA = "0xAF0ACC", Offset = "0xAF0ACC", VA = "0xAF0ACC")]
		public void RotateLocal(Vector3 toEularRotation)
		{
		}

		[Token(Token = "0x60021E7")]
		[Address(RVA = "0xAF5918", Offset = "0xAF5918", VA = "0xAF5918", Slot = "6")]
		public override bool Update(float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60021E8")]
		[Address(RVA = "0xAF5CB4", Offset = "0xAF5CB4", VA = "0xAF5CB4", Slot = "7")]
		protected override void OnFinalize()
		{
		}
	}
}
