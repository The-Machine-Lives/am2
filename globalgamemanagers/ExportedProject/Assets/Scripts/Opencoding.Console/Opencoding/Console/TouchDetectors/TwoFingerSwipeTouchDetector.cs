using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Console.TouchDetectors
{
	[Token(Token = "0x2000022")]
	internal class TwoFingerSwipeTouchDetector : TouchDetector
	{
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<int, Vector2> _initialTouchPositions;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<int, Vector2> _maximumOffsetPosition;

		[Token(Token = "0x400011E")]
		private const float DRAG_DISTANCE_REQUIRED = 180f;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xE91778", Offset = "0xE91778", VA = "0xE91778", Slot = "4")]
		public bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xE91944", Offset = "0xE91944", VA = "0xE91944")]
		private void HandleTouchBegan(Touch touch)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xE91A20", Offset = "0xE91A20", VA = "0xE91A20")]
		private void HandleTouchMoved(Touch touch)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xE91DEC", Offset = "0xE91DEC", VA = "0xE91DEC")]
		private void HandleTouchCanceled(Touch touch)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xE91BD8", Offset = "0xE91BD8", VA = "0xE91BD8")]
		private void HandleTouchEnded(Touch touch, ref bool shouldShowConsole)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xE91F90", Offset = "0xE91F90", VA = "0xE91F90")]
		private void DetectSwipeUp(float maxDistanceMoved, Vector2 offset)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xE91EA4", Offset = "0xE91EA4", VA = "0xE91EA4")]
		private void DetectSwipeDown(float maxDistanceMoved, Vector2 offset, ref bool shouldShowConsole)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xE794DC", Offset = "0xE794DC", VA = "0xE794DC")]
		public TwoFingerSwipeTouchDetector()
		{
		}
	}
}
