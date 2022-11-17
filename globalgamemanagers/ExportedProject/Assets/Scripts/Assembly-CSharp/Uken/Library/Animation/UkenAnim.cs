using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Uken.Library.Animation
{
	[Token(Token = "0x2000490")]
	public class UkenAnim : UkenController
	{
		[Token(Token = "0x40014D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UkenAnim self;

		[Token(Token = "0x40014D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<UkenAnimBase> animationList;

		[Token(Token = "0x6002167")]
		[Address(RVA = "0xAE4BD0", Offset = "0xAE4BD0", VA = "0xAE4BD0")]
		public static UkenAnim Get()
		{
			return null;
		}

		[Token(Token = "0x6002168")]
		[Address(RVA = "0xAEEE38", Offset = "0xAEEE38", VA = "0xAEEE38")]
		public UkenAnim()
		{
		}

		[Token(Token = "0x6002169")]
		[Address(RVA = "0xAEEE98", Offset = "0xAEEE98", VA = "0xAEEE98", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600216A")]
		[Address(RVA = "0xAE566C", Offset = "0xAE566C", VA = "0xAE566C")]
		public void AddAnimation(UkenAnimBase animation)
		{
		}

		[Token(Token = "0x600216B")]
		[Address(RVA = "0xAEEF08", Offset = "0xAEEF08", VA = "0xAEEF08")]
		public void TranslateTo(GameObject ob, Vector2 toPosition, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
		}

		[Token(Token = "0x600216C")]
		[Address(RVA = "0xAEF190", Offset = "0xAEF190", VA = "0xAEF190")]
		public void TranslateFrom(GameObject ob, Vector2 fromPosition, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
		}

		[Token(Token = "0x600216D")]
		[Address(RVA = "0xAEF2BC", Offset = "0xAEF2BC", VA = "0xAEF2BC")]
		public void AnchoredTranslatePath(GameObject ob, List<Vector3> path, float durationOfEach, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
		}

		[Token(Token = "0x600216E")]
		[Address(RVA = "0xAEF500", Offset = "0xAEF500", VA = "0xAEF500")]
		public void TranslatePath(GameObject ob, List<Vector3> path, float durationOfEach, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
		}

		[Token(Token = "0x600216F")]
		[Address(RVA = "0xAEF784", Offset = "0xAEF784", VA = "0xAEF784")]
		public void TranslatePathBezier(GameObject ob, Vector3 startPoint, Vector3 controlPoint, Vector3 endPoint, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
		}

		[Token(Token = "0x6002170")]
		[Address(RVA = "0xAEF02C", Offset = "0xAEF02C", VA = "0xAEF02C")]
		public void Translate(GameObject ob, Vector2 fromPosition, Vector2 toPosition, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
		}

		[Token(Token = "0x6002171")]
		[Address(RVA = "0xAEF914", Offset = "0xAEF914", VA = "0xAEF914")]
		public void AnchoredTranslate(GameObject ob, Vector2 toPosition, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
		}

		[Token(Token = "0x6002172")]
		[Address(RVA = "0xAEFB80", Offset = "0xAEFB80", VA = "0xAEFB80")]
		public void Scale(GameObject ob, Vector3 fromScale, Vector3 toScale, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
		}

		[Token(Token = "0x6002173")]
		[Address(RVA = "0xAEFCB8", Offset = "0xAEFCB8", VA = "0xAEFCB8")]
		public void Rotate(GameObject ob, Vector3 rotation, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
		}

		[Token(Token = "0x6002174")]
		[Address(RVA = "0xAEFFA0", Offset = "0xAEFFA0", VA = "0xAEFFA0")]
		public void RotateTo(GameObject ob, Vector3 rotation, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
		}

		[Token(Token = "0x6002175")]
		[Address(RVA = "0xAF007C", Offset = "0xAF007C", VA = "0xAF007C")]
		public UkenAnimTransform GenerateTranslate(GameObject ob, Vector2 toPosition, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
			return null;
		}

		[Token(Token = "0x6002176")]
		[Address(RVA = "0xAE5464", Offset = "0xAE5464", VA = "0xAE5464")]
		public UkenAnimTransform GenerateTranslate(GameObject ob, Vector2 fromPosition, Vector2 toPosition, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
			return null;
		}

		[Token(Token = "0x6002177")]
		[Address(RVA = "0xAEF628", Offset = "0xAEF628", VA = "0xAEF628")]
		public UkenAnimTransform GenerateTranslate(GameObject ob, Vector3[] path, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart, UkenAnimTraversalType traversalType = UkenAnimTraversalType.Linear)
		{
			return null;
		}

		[Token(Token = "0x6002178")]
		[Address(RVA = "0xAEF9E0", Offset = "0xAEF9E0", VA = "0xAEF9E0")]
		public UkenAnimTransform GenerateAnchoredTranslate(GameObject ob, Vector2 toPosition, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
			return null;
		}

		[Token(Token = "0x6002179")]
		[Address(RVA = "0xAEF3A4", Offset = "0xAEF3A4", VA = "0xAEF3A4")]
		public UkenAnimTransform GenerateAnchoredTranslate(GameObject ob, Vector3[] path, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart, UkenAnimTraversalType traversalType = UkenAnimTraversalType.Linear)
		{
			return null;
		}

		[Token(Token = "0x600217A")]
		[Address(RVA = "0xAEEC24", Offset = "0xAEEC24", VA = "0xAEEC24")]
		public UkenAnimTransform GenerateScale(GameObject ob, Vector3 fromScale, Vector3 toScale, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
			return null;
		}

		[Token(Token = "0x600217B")]
		[Address(RVA = "0xAEFE30", Offset = "0xAEFE30", VA = "0xAEFE30")]
		public UkenAnimTransform GenerateRotate(GameObject ob, Vector3 rotation, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
			return null;
		}

		[Token(Token = "0x600217C")]
		[Address(RVA = "0xAE738C", Offset = "0xAE738C", VA = "0xAE738C")]
		public void AnimateFloat(float startValue, float endValue, float duration, [Optional] Action<float> onUpdate, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
		}

		[Token(Token = "0x600217D")]
		[Address(RVA = "0xAF0BC4", Offset = "0xAF0BC4", VA = "0xAF0BC4")]
		public UkenAnimFloat GenerateFloatAnimation(float startValue, float endValue, float duration, Action<float> onUpdate, [Optional] Action onStart, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType easing = UkenAnimEaseType.Linear)
		{
			return null;
		}

		[Token(Token = "0x600217E")]
		[Address(RVA = "0xAF0CD0", Offset = "0xAF0CD0", VA = "0xAF0CD0")]
		public void ChangeColor(Outline outline, Color startColor, Color endColor, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
		}

		[Token(Token = "0x600217F")]
		[Address(RVA = "0xAF0DDC", Offset = "0xAF0DDC", VA = "0xAF0DDC")]
		public UkenAnimOutline GenerateChangeColor(Outline outline, Color startColor, Color endColor, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
			return null;
		}

		[Token(Token = "0x6002180")]
		[Address(RVA = "0xAF1148", Offset = "0xAF1148", VA = "0xAF1148")]
		public void FadeOut(Graphic graphic, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
		}

		[Token(Token = "0x6002181")]
		[Address(RVA = "0xAF136C", Offset = "0xAF136C", VA = "0xAF136C")]
		public void ChangeColor(Graphic graphic, Color endColor, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
		}

		[Token(Token = "0x6002182")]
		[Address(RVA = "0xAF1220", Offset = "0xAF1220", VA = "0xAF1220")]
		public UkenAnimGraphic GenerateChangeColor(Graphic graphic, Color endColor, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
			return null;
		}

		[Token(Token = "0x6002183")]
		[Address(RVA = "0xAF1700", Offset = "0xAF1700", VA = "0xAF1700")]
		public void ChangeColor(Graphic graphic, Color startColor, Color endColor, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
		}

		[Token(Token = "0x6002184")]
		[Address(RVA = "0xAF180C", Offset = "0xAF180C", VA = "0xAF180C")]
		public UkenAnimGraphic GenerateChangeColor(Graphic graphic, Color startColor, Color endColor, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
			return null;
		}

		[Token(Token = "0x6002185")]
		[Address(RVA = "0xAF1A20", Offset = "0xAF1A20", VA = "0xAF1A20")]
		public UkenAnimImage GenerateFillImage(Image img, float endFill, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
			return null;
		}

		[Token(Token = "0x6002186")]
		[Address(RVA = "0xAF1D4C", Offset = "0xAF1D4C", VA = "0xAF1D4C")]
		public void FillImage(Image img, float endFill, float duration, [Optional] Action onComplete, float startDelay = 0f, UkenAnimEaseType curveType = UkenAnimEaseType.Linear, [Optional] Action onStart)
		{
		}

		[Token(Token = "0x6002187")]
		[Address(RVA = "0xAF1E10", Offset = "0xAF1E10", VA = "0xAF1E10", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}
	}
}
