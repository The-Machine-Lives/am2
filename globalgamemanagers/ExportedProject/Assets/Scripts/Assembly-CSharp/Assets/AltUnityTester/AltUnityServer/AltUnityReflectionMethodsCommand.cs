using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer
{
	[Token(Token = "0x2000598")]
	internal class AltUnityReflectionMethodsCommand : AltUnityCommand
	{
		[Token(Token = "0x200086C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821648", Offset = "0x821648")]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			[Token(Token = "0x400241B")]
			[FieldOffset(Offset = "0x10")]
			public string altActionMethod;

			[Token(Token = "0x60033AD")]
			[Address(RVA = "0xC243D8", Offset = "0xC243D8", VA = "0xC243D8")]
			public _003C_003Ec__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60033AE")]
			[Address(RVA = "0xC25A38", Offset = "0xC25A38", VA = "0xC25A38")]
			internal bool _003CGetMethodInfoWithSpecificName_003Eb__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200086D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821658", Offset = "0x821658")]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x400241C")]
			[FieldOffset(Offset = "0x10")]
			public string[] parameter;

			[Token(Token = "0x60033AF")]
			[Address(RVA = "0xC24970", Offset = "0xC24970", VA = "0xC24970")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60033B0")]
			[Address(RVA = "0xC25A90", Offset = "0xC25A90", VA = "0xC25A90")]
			internal bool _003CGetMethodToBeInvoked_003Eb__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200086E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821668", Offset = "0x821668")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400241D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400241E")]
			[FieldOffset(Offset = "0x8")]
			public static Func<string, string, string> _003C_003E9__4_1;

			[Token(Token = "0x60033B2")]
			[Address(RVA = "0xC259CC", Offset = "0xC259CC", VA = "0xC259CC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60033B3")]
			[Address(RVA = "0xC259D4", Offset = "0xC259D4", VA = "0xC259D4")]
			internal string _003CGetMethodToBeInvoked_003Eb__4_1(string current, string typeOfParamete)
			{
				return null;
			}
		}

		[Token(Token = "0x6002AD0")]
		[Address(RVA = "0xC23B98", Offset = "0xC23B98", VA = "0xC23B98")]
		public static Type GetType(string typeName, string assemblyName)
		{
			return null;
		}

		[Token(Token = "0x6002AD1")]
		[Address(RVA = "0xC240DC", Offset = "0xC240DC", VA = "0xC240DC")]
		protected MemberInfo GetMemberForObjectComponent(AltUnityObject altUnityObject, AltUnityObjectProperty altUnityObjectProperty)
		{
			return null;
		}

		[Token(Token = "0x6002AD2")]
		[Address(RVA = "0xC242A4", Offset = "0xC242A4", VA = "0xC242A4")]
		private MethodInfo GetMethodForObjectComponent(AltUnityObject altUnityObject, AltUnityObjectAction altUnityObjectAction)
		{
			return null;
		}

		[Token(Token = "0x6002AD3")]
		[Address(RVA = "0xC242E8", Offset = "0xC242E8", VA = "0xC242E8")]
		protected MethodInfo[] GetMethodInfoWithSpecificName(Type componentType, string altActionMethod)
		{
			return null;
		}

		[Token(Token = "0x6002AD4")]
		[Address(RVA = "0xC243E0", Offset = "0xC243E0", VA = "0xC243E0")]
		protected MethodInfo GetMethodToBeInvoked(MethodInfo[] methodInfos, AltUnityObjectAction altUnityObjectAction)
		{
			return null;
		}

		[Token(Token = "0x6002AD5")]
		[Address(RVA = "0xC24978", Offset = "0xC24978", VA = "0xC24978")]
		protected static string InvokeMethod(MethodInfo methodInfo, AltUnityObjectAction altAction, object component, string response)
		{
			return null;
		}

		[Token(Token = "0x6002AD6")]
		[Address(RVA = "0xC24DDC", Offset = "0xC24DDC", VA = "0xC24DDC")]
		protected string GetValueForMember(MemberInfo memberInfo, GameObject testableObject, AltUnityObjectProperty altProperty)
		{
			return null;
		}

		[Token(Token = "0x6002AD7")]
		[Address(RVA = "0xC25280", Offset = "0xC25280", VA = "0xC25280")]
		protected string SetValueForMember(MemberInfo memberInfo, string valueString, GameObject testableObject, AltUnityObjectProperty altProperty)
		{
			return null;
		}

		[Token(Token = "0x6002AD8")]
		[Address(RVA = "0xC250D4", Offset = "0xC250D4", VA = "0xC250D4")]
		private string SerializeMemberValue(object value, Type type)
		{
			return null;
		}

		[Token(Token = "0x6002AD9")]
		[Address(RVA = "0xC2578C", Offset = "0xC2578C", VA = "0xC2578C")]
		private object DeserializeMemberValue(string valueString, Type type)
		{
			return null;
		}

		[Token(Token = "0x6002ADA")]
		[Address(RVA = "0xC258F8", Offset = "0xC258F8", VA = "0xC258F8", Slot = "4")]
		public override string Execute()
		{
			return null;
		}

		[Token(Token = "0x6002ADB")]
		[Address(RVA = "0xC25960", Offset = "0xC25960", VA = "0xC25960")]
		public AltUnityReflectionMethodsCommand()
		{
		}
	}
}
