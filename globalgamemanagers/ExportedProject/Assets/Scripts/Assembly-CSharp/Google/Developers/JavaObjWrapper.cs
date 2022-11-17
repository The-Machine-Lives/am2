using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Google.Developers
{
	[Token(Token = "0x2000247")]
	public class JavaObjWrapper
	{
		[Token(Token = "0x4000CAB")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr raw;

		[Token(Token = "0x4000CAC")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr cachedRawClass;

		[Token(Token = "0x17000266")]
		public IntPtr RawObject
		{
			[Token(Token = "0x600107B")]
			[Address(RVA = "0x9D6148", Offset = "0x9D6148", VA = "0x9D6148")]
			get
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x17000267")]
		public virtual IntPtr RawClass
		{
			[Token(Token = "0x600107C")]
			[Address(RVA = "0x9D6150", Offset = "0x9D6150", VA = "0x9D6150", Slot = "4")]
			get
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x6001078")]
		[Address(RVA = "0x9D6028", Offset = "0x9D6028", VA = "0x9D6028")]
		protected JavaObjWrapper()
		{
		}

		[Token(Token = "0x6001079")]
		[Address(RVA = "0x9D6074", Offset = "0x9D6074", VA = "0x9D6074")]
		public JavaObjWrapper(string clazzName)
		{
		}

		[Token(Token = "0x600107A")]
		[Address(RVA = "0x9D60E8", Offset = "0x9D60E8", VA = "0x9D60E8")]
		public JavaObjWrapper(IntPtr rawObject)
		{
		}

		[Token(Token = "0x600107D")]
		[Address(RVA = "0x9D61CC", Offset = "0x9D61CC", VA = "0x9D61CC")]
		public void CreateInstance(string clazzName, params object[] args)
		{
		}

		[Token(Token = "0x600107E")]
		[Address(RVA = "0x9D6328", Offset = "0x9D6328", VA = "0x9D6328")]
		protected static jvalue[] ConstructArgArray(object[] theArgs)
		{
			return null;
		}

		[Token(Token = "0x600107F")]
		public static T StaticInvokeObjectCall<T>(string type, string name, string sig, params object[] args)
		{
			return (T)null;
		}

		[Token(Token = "0x6001080")]
		[Address(RVA = "0x9D6A94", Offset = "0x9D6A94", VA = "0x9D6A94")]
		public static void StaticInvokeCallVoid(string type, string name, string sig, params object[] args)
		{
		}

		[Token(Token = "0x6001081")]
		public static T GetStaticObjectField<T>(string clsName, string name, string sig)
		{
			return (T)null;
		}

		[Token(Token = "0x6001082")]
		[Address(RVA = "0x9D6B64", Offset = "0x9D6B64", VA = "0x9D6B64")]
		public static int GetStaticIntField(string clsName, string name)
		{
			return default(int);
		}

		[Token(Token = "0x6001083")]
		[Address(RVA = "0x9D6BE4", Offset = "0x9D6BE4", VA = "0x9D6BE4")]
		public static string GetStaticStringField(string clsName, string name)
		{
			return null;
		}

		[Token(Token = "0x6001084")]
		[Address(RVA = "0x9D6C64", Offset = "0x9D6C64", VA = "0x9D6C64")]
		public static float GetStaticFloatField(string clsName, string name)
		{
			return default(float);
		}

		[Token(Token = "0x6001085")]
		[Address(RVA = "0x9D6CE4", Offset = "0x9D6CE4", VA = "0x9D6CE4")]
		public void InvokeCallVoid(string name, string sig, params object[] args)
		{
		}

		[Token(Token = "0x6001086")]
		public T InvokeCall<T>(string name, string sig, params object[] args)
		{
			return (T)null;
		}

		[Token(Token = "0x6001087")]
		public static T StaticInvokeCall<T>(string type, string name, string sig, params object[] args)
		{
			return (T)null;
		}

		[Token(Token = "0x6001088")]
		public T InvokeObjectCall<T>(string name, string sig, params object[] theArgs)
		{
			return (T)null;
		}
	}
}
