using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Library.Animation
{
	[Token(Token = "0x2000491")]
	public class UkenAnimBase
	{
		[Token(Token = "0x200081B")]
		private delegate float InterpolationFunction(float time, float start, float change, float duration);

		[Token(Token = "0x200081C")]
		private delegate Vector3 TraversalFunction(Vector3[] points, float time);

		[Token(Token = "0x40014D2")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EA2C", Offset = "0x82EA2C")]
		private float _003CcurrentTime_003Ek__BackingField;

		[Token(Token = "0x40014D3")]
		[FieldOffset(Offset = "0x14")]
		private float _startDelay;

		[Token(Token = "0x40014D4")]
		[FieldOffset(Offset = "0x18")]
		private float _duration;

		[Token(Token = "0x40014D5")]
		[FieldOffset(Offset = "0x1C")]
		protected bool started;

		[Token(Token = "0x40014D6")]
		[FieldOffset(Offset = "0x1D")]
		protected bool complete;

		[Token(Token = "0x40014D7")]
		[FieldOffset(Offset = "0x20")]
		public Action OnStart;

		[Token(Token = "0x40014D8")]
		[FieldOffset(Offset = "0x28")]
		public Action OnComplete;

		[Token(Token = "0x40014D9")]
		[FieldOffset(Offset = "0x30")]
		private InterpolationFunction interpFunc;

		[Token(Token = "0x40014DA")]
		[FieldOffset(Offset = "0x38")]
		private TraversalFunction traverseFunc;

		[Token(Token = "0x40014DB")]
		[FieldOffset(Offset = "0x40")]
		protected bool paused;

		[Token(Token = "0x40014DC")]
		[FieldOffset(Offset = "0x41")]
		protected bool loop;

		[Token(Token = "0x40014DD")]
		[FieldOffset(Offset = "0x42")]
		protected bool skipped;

		[Token(Token = "0x170005DA")]
		public float Duration
		{
			[Token(Token = "0x6002188")]
			[Address(RVA = "0xAF1F60", Offset = "0xAF1F60", VA = "0xAF1F60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002189")]
			[Address(RVA = "0xAF1F68", Offset = "0xAF1F68", VA = "0xAF1F68")]
			protected set
			{
			}
		}

		[Token(Token = "0x170005DB")]
		public float StartDelay
		{
			[Token(Token = "0x600218A")]
			[Address(RVA = "0xAF2010", Offset = "0xAF2010", VA = "0xAF2010")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600218B")]
			[Address(RVA = "0xAF2018", Offset = "0xAF2018", VA = "0xAF2018")]
			protected set
			{
			}
		}

		[Token(Token = "0x170005DC")]
		public float currentTime
		{
			[Token(Token = "0x600218C")]
			[Address(RVA = "0xAF20C0", Offset = "0xAF20C0", VA = "0xAF20C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8394D4", Offset = "0x8394D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600218D")]
			[Address(RVA = "0xAF20C8", Offset = "0xAF20C8", VA = "0xAF20C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8394E4", Offset = "0x8394E4")]
			protected set
			{
			}
		}

		[Token(Token = "0x600218E")]
		[Address(RVA = "0xAF20D0", Offset = "0xAF20D0", VA = "0xAF20D0")]
		public UkenAnimBase(float duration, float startDelay = 0f)
		{
		}

		[Token(Token = "0x600218F")]
		[Address(RVA = "0xAF2130", Offset = "0xAF2130", VA = "0xAF2130")]
		public void ResetAnimation()
		{
		}

		[Token(Token = "0x6002190")]
		[Address(RVA = "0xAF2148", Offset = "0xAF2148", VA = "0xAF2148", Slot = "4")]
		public virtual void SkipAnimation()
		{
		}

		[Token(Token = "0x6002191")]
		[Address(RVA = "0xAF0228", Offset = "0xAF0228", VA = "0xAF0228")]
		public void SetInterpolationMode(UkenAnimEaseType type)
		{
		}

		[Token(Token = "0x6002192")]
		[Address(RVA = "0xAF231C", Offset = "0xAF231C", VA = "0xAF231C")]
		protected float EaseTime(float time, float start, float change, float duration)
		{
			return default(float);
		}

		[Token(Token = "0x6002193")]
		[Address(RVA = "0xAF28EC", Offset = "0xAF28EC", VA = "0xAF28EC")]
		public void SetTraversalMethod(UkenAnimTraversalType type)
		{
		}

		[Token(Token = "0x6002194")]
		[Address(RVA = "0xAF298C", Offset = "0xAF298C", VA = "0xAF298C")]
		protected Vector3 TraversePoints(Vector3[] points, float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6002195")]
		[Address(RVA = "0xAF067C", Offset = "0xAF067C", VA = "0xAF067C")]
		public void SetOnComplete(Action callback)
		{
		}

		[Token(Token = "0x6002196")]
		[Address(RVA = "0xAF0684", Offset = "0xAF0684", VA = "0xAF0684")]
		public void SetOnStart(Action callback)
		{
		}

		[Token(Token = "0x6002197")]
		[Address(RVA = "0xAF3220", Offset = "0xAF3220", VA = "0xAF3220", Slot = "5")]
		public virtual bool IsComplete()
		{
			return default(bool);
		}

		[Token(Token = "0x6002198")]
		[Address(RVA = "0xAF3228", Offset = "0xAF3228", VA = "0xAF3228")]
		public bool HasBeenSkipped()
		{
			return default(bool);
		}

		[Token(Token = "0x6002199")]
		[Address(RVA = "0xAF2188", Offset = "0xAF2188", VA = "0xAF2188")]
		protected void HandleOnStart()
		{
		}

		[Token(Token = "0x600219A")]
		[Address(RVA = "0xAF3230", Offset = "0xAF3230", VA = "0xAF3230", Slot = "6")]
		public virtual bool Update(float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x600219B")]
		[Address(RVA = "0xAF3320", Offset = "0xAF3320", VA = "0xAF3320", Slot = "7")]
		protected virtual void OnFinalize()
		{
		}

		[Token(Token = "0x600219C")]
		[Address(RVA = "0xAE5F68", Offset = "0xAE5F68", VA = "0xAE5F68")]
		public void Stop()
		{
		}

		[Token(Token = "0x600219D")]
		[Address(RVA = "0xAF3460", Offset = "0xAF3460", VA = "0xAF3460")]
		public void Pause()
		{
		}

		[Token(Token = "0x600219E")]
		[Address(RVA = "0xAF346C", Offset = "0xAF346C", VA = "0xAF346C")]
		public void Continue()
		{
		}

		[Token(Token = "0x600219F")]
		[Address(RVA = "0xAF3474", Offset = "0xAF3474", VA = "0xAF3474")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60021A0")]
		[Address(RVA = "0xAF347C", Offset = "0xAF347C", VA = "0xAF347C")]
		public void Loop(bool loop)
		{
		}
	}
}
