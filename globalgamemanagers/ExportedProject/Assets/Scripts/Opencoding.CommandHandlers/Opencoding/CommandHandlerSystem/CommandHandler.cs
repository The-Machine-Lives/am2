using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Opencoding.CommandHandlerSystem
{
	[Token(Token = "0x2000002")]
	public abstract class CommandHandler
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		private string _description;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		private WeakReference _objectReference;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		private object _strongObjectReference;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x28")]
		protected Type _type;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x30")]
		protected string _methodOrPropertyName;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x38")]
		protected string _commandName;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x40")]
		private bool _isStatic;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81853C", Offset = "0x81853C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81853C", Offset = "0x81853C")]
		private MemberInfo _003CMemberInfo_003Ek__BackingField;

		[Token(Token = "0x17000001")]
		public string Description
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x17E1B58", Offset = "0x17E1B58", VA = "0x17E1B58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public string CommandName
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x17E1B60", Offset = "0x17E1B60", VA = "0x17E1B60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public string MethodOrPropertyName
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x17E1B68", Offset = "0x17E1B68", VA = "0x17E1B68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public abstract ParamInfo[] Parameters
		{
			[Token(Token = "0x6000007")]
			get;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x17E1B70", Offset = "0x17E1B70", VA = "0x17E1B70")]
		protected object GetObjectReference()
		{
			return null;
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x17E1DF0", Offset = "0x17E1DF0", VA = "0x17E1DF0", Slot = "0")]
		public override bool Equals(object otherObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x17E1F10", Offset = "0x17E1F10", VA = "0x17E1F10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000008")]
		public abstract void Invoke(params string[] arguments);

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x17E1FD8", Offset = "0x17E1FD8", VA = "0x17E1FD8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x17E2000", Offset = "0x17E2000", VA = "0x17E2000")]
		protected bool GetArgumentList(ParamInfo[] paramInfos, ParamInfo[] paramsParamInfos, string[] commandArguments, out object[] argumentValues)
		{
			return default(bool);
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x17E2694", Offset = "0x17E2694", VA = "0x17E2694")]
		private static bool FillArrayWithDefaults(ParamInfo[] paramsParamInfos, int startingIndex, Array array)
		{
			return default(bool);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x17E2FF0", Offset = "0x17E2FF0", VA = "0x17E2FF0")]
		protected string GetMethodParametersAsString(ParamInfo[] paramInfos, ParamInfo[] paramsParamInfos, bool styled = false)
		{
			return null;
		}
	}
}
