using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000070")]
	[Preserve]
	internal static class ReflectionUtils
	{
		[Serializable]
		[Token(Token = "0x2000071")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E93C", Offset = "0x80E93C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40001DF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40001E0")]
			[FieldOffset(Offset = "0x8")]
			public static Func<ConstructorInfo, bool> _003C_003E9__10_0;

			[Token(Token = "0x40001E1")]
			[FieldOffset(Offset = "0x10")]
			public static Func<MemberInfo, string> _003C_003E9__29_0;

			[Token(Token = "0x40001E2")]
			[FieldOffset(Offset = "0x18")]
			public static Func<ParameterInfo, Type> _003C_003E9__37_0;

			[Token(Token = "0x40001E3")]
			[FieldOffset(Offset = "0x20")]
			public static Func<FieldInfo, bool> _003C_003E9__39_0;

			[Token(Token = "0x6000323")]
			[Address(RVA = "0x1772F38", Offset = "0x1772F38", VA = "0x1772F38")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000324")]
			[Address(RVA = "0x1772F40", Offset = "0x1772F40", VA = "0x1772F40")]
			internal bool _003CGetDefaultConstructor_003Eb__10_0(ConstructorInfo c)
			{
				return default(bool);
			}

			[Token(Token = "0x6000325")]
			[Address(RVA = "0x1772FB8", Offset = "0x1772FB8", VA = "0x1772FB8")]
			internal string _003CGetFieldsAndProperties_003Eb__29_0(MemberInfo m)
			{
				return null;
			}

			[Token(Token = "0x6000326")]
			[Address(RVA = "0x1772FEC", Offset = "0x1772FEC", VA = "0x1772FEC")]
			internal Type _003CGetMemberInfoFromType_003Eb__37_0(ParameterInfo p)
			{
				return null;
			}

			[Token(Token = "0x6000327")]
			[Address(RVA = "0x1773020", Offset = "0x1773020", VA = "0x1773020")]
			internal bool _003CGetChildPrivateFields_003Eb__39_0(FieldInfo f)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000072")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E94C", Offset = "0x80E94C")]
		private sealed class _003C_003Ec__DisplayClass42_0
		{
			[Token(Token = "0x40001E4")]
			[FieldOffset(Offset = "0x10")]
			public PropertyInfo subTypeProperty;

			[Token(Token = "0x6000328")]
			[Address(RVA = "0x1772D10", Offset = "0x1772D10", VA = "0x1772D10")]
			public _003C_003Ec__DisplayClass42_0()
			{
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0x1773050", Offset = "0x1773050", VA = "0x1773050")]
			internal bool _003CGetChildPrivateProperties_003Eb__0(PropertyInfo p)
			{
				return default(bool);
			}

			[Token(Token = "0x600032A")]
			[Address(RVA = "0x17730BC", Offset = "0x17730BC", VA = "0x17730BC")]
			internal bool _003CGetChildPrivateProperties_003Eb__1(PropertyInfo p)
			{
				return default(bool);
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x177317C", Offset = "0x177317C", VA = "0x177317C")]
			internal bool _003CGetChildPrivateProperties_003Eb__2(PropertyInfo p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000073")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E95C", Offset = "0x80E95C")]
		private sealed class _003C_003Ec__DisplayClass43_0
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x177330C", Offset = "0x177330C", VA = "0x177330C")]
			public _003C_003Ec__DisplayClass43_0()
			{
			}
		}

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Type[] EmptyTypes;

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x176EE80", Offset = "0x176EE80", VA = "0x176EE80")]
		static ReflectionUtils()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x176EEFC", Offset = "0x176EEFC", VA = "0x176EEFC")]
		public static bool IsVirtual(this PropertyInfo propertyInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x176EFAC", Offset = "0x176EFAC", VA = "0x176EFAC")]
		public static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x176F050", Offset = "0x176F050", VA = "0x176F050")]
		public static bool IsPublic(PropertyInfo property)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x176F114", Offset = "0x176F114", VA = "0x176F114")]
		public static Type GetObjectType(object v)
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x176F124", Offset = "0x176F124", VA = "0x176F124")]
		public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder)
		{
			return null;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x176F210", Offset = "0x176F210", VA = "0x176F210")]
		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x176E3D8", Offset = "0x176E3D8", VA = "0x176E3D8")]
		public static bool HasDefaultConstructor(Type t, bool nonPublic)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x176F500", Offset = "0x176F500", VA = "0x176F500")]
		public static ConstructorInfo GetDefaultConstructor(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x176F3D0", Offset = "0x176F3D0", VA = "0x176F3D0")]
		public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x176F568", Offset = "0x176F568", VA = "0x176F568")]
		public static bool IsNullable(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x176F60C", Offset = "0x176F60C", VA = "0x176F60C")]
		public static bool IsNullableType(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x176F71C", Offset = "0x176F71C", VA = "0x176F71C")]
		public static Type EnsureNotNullableType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x176F7A0", Offset = "0x176F7A0", VA = "0x176F7A0")]
		public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x176F804", Offset = "0x176F804", VA = "0x176F804")]
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x176F888", Offset = "0x176F888", VA = "0x176F888")]
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x176FB4C", Offset = "0x176FB4C", VA = "0x176FB4C")]
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x176FBD0", Offset = "0x176FBD0", VA = "0x176FBD0")]
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x176FD68", Offset = "0x176FD68", VA = "0x176FD68")]
		private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType)
		{
			return default(bool);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x176FEA8", Offset = "0x176FEA8", VA = "0x176FEA8")]
		public static Type GetCollectionItemType(Type type)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1770108", Offset = "0x1770108", VA = "0x1770108")]
		public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x176E914", Offset = "0x176E914", VA = "0x176E914")]
		public static Type GetMemberUnderlyingType(MemberInfo member)
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1770364", Offset = "0x1770364", VA = "0x1770364")]
		public static bool IsIndexedProperty(MemberInfo member)
		{
			return default(bool);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1770428", Offset = "0x1770428", VA = "0x1770428")]
		public static bool IsIndexedProperty(PropertyInfo property)
		{
			return default(bool);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x17704B4", Offset = "0x17704B4", VA = "0x17704B4")]
		public static object GetMemberValue(MemberInfo member, object target)
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x177094C", Offset = "0x177094C", VA = "0x177094C")]
		public static void SetMemberValue(MemberInfo member, object target, object value)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x176E4C8", Offset = "0x176E4C8", VA = "0x176E4C8")]
		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic)
		{
			return default(bool);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x176E6BC", Offset = "0x176E6BC", VA = "0x176E6BC")]
		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1770CB8", Offset = "0x1770CB8", VA = "0x1770CB8")]
		public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr)
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1771A54", Offset = "0x1771A54", VA = "0x1771A54")]
		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000315")]
		public static T GetAttribute<T>(object attributeProvider) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		public static T GetAttribute<T>(object attributeProvider, bool inherit) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		public static T[] GetAttributes<T>(object attributeProvider, bool inherit) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1771C74", Offset = "0x1771C74", VA = "0x1771C74")]
		public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1772124", Offset = "0x1772124", VA = "0x1772124")]
		public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x17722A0", Offset = "0x17722A0", VA = "0x17722A0")]
		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1772390", Offset = "0x1772390", VA = "0x1772390")]
		public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x177162C", Offset = "0x177162C", VA = "0x177162C")]
		public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1772644", Offset = "0x1772644", VA = "0x1772644")]
		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1771720", Offset = "0x1771720", VA = "0x1771720")]
		public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x17727F4", Offset = "0x17727F4", VA = "0x17727F4")]
		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag)
		{
			return default(BindingFlags);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1772804", Offset = "0x1772804", VA = "0x1772804")]
		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1772D18", Offset = "0x1772D18", VA = "0x1772D18")]
		public static object GetDefaultValue(Type type)
		{
			return null;
		}
	}
}
