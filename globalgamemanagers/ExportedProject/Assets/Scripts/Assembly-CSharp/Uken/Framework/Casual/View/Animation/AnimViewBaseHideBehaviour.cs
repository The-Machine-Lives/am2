using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Framework.Casual.View.Animation
{
	[Token(Token = "0x2000581")]
	public class AnimViewBaseHideBehaviour : StateMachineBehaviour
	{
		[Token(Token = "0x4001A3A")]
		[FieldOffset(Offset = "0x18")]
		public Action OnHideFinished;

		[Token(Token = "0x6002A3F")]
		[Address(RVA = "0xAA150C", Offset = "0xAA150C", VA = "0xAA150C", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6002A40")]
		[Address(RVA = "0xAA1520", Offset = "0xAA1520", VA = "0xAA1520")]
		public AnimViewBaseHideBehaviour()
		{
		}
	}
}
