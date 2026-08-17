using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200006C")]
	[Preserve]
	internal static class CollectionUtils
	{
		[Token(Token = "0x60002DB")]
		public static bool IsNullOrEmpty<T>(ICollection<T> collection)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DC")]
		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection)
		{
		}

		[Token(Token = "0x60002DD")]
		public static void AddRange<T>(this IList<T> initial, IEnumerable collection)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xF09AA0", Offset = "0xF09AA0", VA = "0xF09AA0")]
		public static bool IsDictionaryType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xF09BD8", Offset = "0xF09BD8", VA = "0xF09BD8")]
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType)
		{
			return null;
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xF09D00", Offset = "0xF09D00", VA = "0xF09D00")]
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType)
		{
			return null;
		}

		[Token(Token = "0x60002E1")]
		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
		{
			return default(int);
		}

		[Token(Token = "0x60002E2")]
		public static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E3")]
		public static int IndexOfReference<T>(this List<T> list, T item)
		{
			return default(int);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xF0A024", Offset = "0xF0A024", VA = "0xF0A024")]
		private static IList<int> GetDimensions(IList values, int dimensionsCount)
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xF0A38C", Offset = "0xF0A38C", VA = "0xF0A38C")]
		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xF0A770", Offset = "0xF0A770", VA = "0xF0A770")]
		private static object JaggedArrayGetValue(IList values, int[] indices)
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xEF7B64", Offset = "0xEF7B64", VA = "0xEF7B64")]
		public static Array ToMultidimensionalArray(IList values, Type type, int rank)
		{
			return null;
		}
	}
}
