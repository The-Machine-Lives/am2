using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Console.TouchDetectors
{
	[Token(Token = "0x2000021")]
	internal class ThreeFingersHeldTouchDetector : TouchDetector
	{
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<int, Vector2> _initialTouchPositions;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x18")]
		private bool _touchCancelled;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x1C")]
		private float _timeToActivateConsole;

		[Token(Token = "0x400011A")]
		private const float TIME_TO_HOLD_FINGERS_BEFORE_ACTIVATING = 0.6f;

		[Token(Token = "0x400011B")]
		private const float MAX_MOVEMENT_ALLOWED = 20f;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xE91398", Offset = "0xE91398", VA = "0xE91398", Slot = "4")]
		public bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xE915A4", Offset = "0xE915A4", VA = "0xE915A4")]
		private void HandleTouchBegan(Touch touch)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xE91664", Offset = "0xE91664", VA = "0xE91664")]
		private void HandleTouchMoved(Touch touch)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xE9176C", Offset = "0xE9176C", VA = "0xE9176C")]
		private void HandleTouchCanceled(Touch touch)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xE91760", Offset = "0xE91760", VA = "0xE91760")]
		private void HandleTouchEnded(Touch touch)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xE7956C", Offset = "0xE7956C", VA = "0xE7956C")]
		public ThreeFingersHeldTouchDetector()
		{
		}
	}
}
