using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x200003E")]
	public abstract class ParameterOverride
	{
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x10")]
		public bool overrideState;

		[Token(Token = "0x60000B9")]
		internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

		[Token(Token = "0x60000BA")]
		public abstract int GetHash();

		[Token(Token = "0x60000BB")]
		public T GetValue<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xD88A50", Offset = "0xD88A50", VA = "0xD88A50", Slot = "6")]
		protected internal virtual void OnEnable()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xD88A54", Offset = "0xD88A54", VA = "0xD88A54", Slot = "7")]
		protected internal virtual void OnDisable()
		{
		}

		[Token(Token = "0x60000BE")]
		internal abstract void SetValue(ParameterOverride parameter);

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xD88A58", Offset = "0xD88A58", VA = "0xD88A58")]
		protected ParameterOverride()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class ParameterOverride<T> : ParameterOverride
	{
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x0")]
		public T value;

		[Token(Token = "0x60000C0")]
		public ParameterOverride()
		{
		}

		[Token(Token = "0x60000C1")]
		public ParameterOverride(T value)
		{
		}

		[Token(Token = "0x60000C2")]
		public ParameterOverride(T value, bool overrideState)
		{
		}

		[Token(Token = "0x60000C3")]
		internal override void Interp(ParameterOverride from, ParameterOverride to, float t)
		{
		}

		[Token(Token = "0x60000C4")]
		public virtual void Interp(T from, T to, float t)
		{
		}

		[Token(Token = "0x60000C5")]
		public void Override(T x)
		{
		}

		[Token(Token = "0x60000C6")]
		internal override void SetValue(ParameterOverride parameter)
		{
		}

		[Token(Token = "0x60000C7")]
		public override int GetHash()
		{
			return default(int);
		}

		[Token(Token = "0x60000C8")]
		public static implicit operator T(ParameterOverride<T> prop)
		{
			return (T)null;
		}
	}
}
