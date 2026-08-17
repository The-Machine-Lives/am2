using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Framework.Casual.View.Animation
{
	[Token(Token = "0x2000582")]
	public class AnimViewBaseShowBehaviour : StateMachineBehaviour
	{
		[Token(Token = "0x4001A3B")]
		[FieldOffset(Offset = "0x18")]
		public Action OnShowFinished;

		[Token(Token = "0x6002A41")]
		[Address(RVA = "0xAA1528", Offset = "0xAA1528", VA = "0xAA1528", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6002A42")]
		[Address(RVA = "0xAA153C", Offset = "0xAA153C", VA = "0xAA153C")]
		public AnimViewBaseShowBehaviour()
		{
		}
	}
}
