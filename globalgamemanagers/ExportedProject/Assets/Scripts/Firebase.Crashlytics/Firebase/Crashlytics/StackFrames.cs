using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Firebase.Crashlytics
{
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x817ACC", Offset = "0x817ACC")]
	internal class StackFrames : IDisposable, IEnumerable, IEnumerable<FirebaseCrashlyticsFrame>
	{
		[Token(Token = "0x200000D")]
		public sealed class StackFramesEnumerator : IEnumerator, IEnumerator<FirebaseCrashlyticsFrame>, IDisposable
		{
			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StackFrames collectionRef;

			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int currentIndex;

			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object currentObject;

			[Token(Token = "0x400001D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int currentSize;

			[Token(Token = "0x1700000D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000098")]
				[Address(RVA = "0x17AB398", Offset = "0x17AB398", VA = "0x17AB398", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			public FirebaseCrashlyticsFrame Current
			{
				[Token(Token = "0x6000097")]
				[Address(RVA = "0x17AB234", Offset = "0x17AB234", VA = "0x17AB234", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000096")]
			[Address(RVA = "0x17AA65C", Offset = "0x17AA65C", VA = "0x17AA65C")]
			public StackFramesEnumerator(StackFrames collection)
			{
			}

			[Token(Token = "0x6000099")]
			[Address(RVA = "0x17AB39C", Offset = "0x17AB39C", VA = "0x17AB39C", Slot = "4")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x17AB42C", Offset = "0x17AB42C", VA = "0x17AB42C", Slot = "6")]
			public void Reset()
			{
			}

			[Token(Token = "0x600009B")]
			[Address(RVA = "0x17AB4E0", Offset = "0x17AB4E0", VA = "0x17AB4E0", Slot = "8")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000007")]
		public bool IsFixedSize
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x17A9CE8", Offset = "0x17A9CE8", VA = "0x17A9CE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x17A9CF0", Offset = "0x17A9CF0", VA = "0x17A9CF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public FirebaseCrashlyticsFrame this[int index]
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x17A9CF8", Offset = "0x17A9CF8", VA = "0x17A9CF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x17A9E0C", Offset = "0x17A9E0C", VA = "0x17A9E0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public int Capacity
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x17A9F18", Offset = "0x17A9F18", VA = "0x17A9F18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x17A9FFC", Offset = "0x17A9FFC", VA = "0x17A9FFC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public int Count
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x17AA26C", Offset = "0x17AA26C", VA = "0x17AA26C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000C")]
		public bool IsSynchronized
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x17AA270", Offset = "0x17AA270", VA = "0x17AA270")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x17A953C", Offset = "0x17A953C", VA = "0x17A953C")]
		internal StackFrames(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x17A95A0", Offset = "0x17A95A0", VA = "0x17A95A0")]
		public StackFrames(ICollection c)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x17A1D78", Offset = "0x17A1D78", VA = "0x17A1D78")]
		public StackFrames()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x17A9904", Offset = "0x17A9904", VA = "0x17A9904")]
		public StackFrames(StackFrames other)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x17A9A00", Offset = "0x17A9A00", VA = "0x17A9A00")]
		public StackFrames(int capacity)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x17A8C60", Offset = "0x17A8C60", VA = "0x17A8C60")]
		internal static HandleRef getCPtr(StackFrames obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x17A9AE8", Offset = "0x17A9AE8", VA = "0x17A9AE8", Slot = "1")]
		~StackFrames()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x17A9B64", Offset = "0x17A9B64", VA = "0x17A9B64", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x17AA278", Offset = "0x17AA278", VA = "0x17AA278")]
		public void CopyTo(FirebaseCrashlyticsFrame[] array)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x17AA4A8", Offset = "0x17AA4A8", VA = "0x17AA4A8")]
		public void CopyTo(FirebaseCrashlyticsFrame[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x17AA2B0", Offset = "0x17AA2B0", VA = "0x17AA2B0")]
		public void CopyTo(int index, FirebaseCrashlyticsFrame[] array, int arrayIndex, int count)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x17AA5FC", Offset = "0x17AA5FC", VA = "0x17AA5FC", Slot = "6")]
		private IEnumerator<FirebaseCrashlyticsFrame> System_002ECollections_002EGeneric_002EIEnumerable_003CFirebase_002ECrashlytics_002EFirebaseCrashlyticsFrame_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x17AA6AC", Offset = "0x17AA6AC", VA = "0x17AA6AC", Slot = "5")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x17AA70C", Offset = "0x17AA70C", VA = "0x17AA70C")]
		public StackFramesEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x17AA76C", Offset = "0x17AA76C", VA = "0x17AA76C")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x17A22C0", Offset = "0x17A22C0", VA = "0x17A22C0")]
		public void Add(FirebaseCrashlyticsFrame x)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x17AA0A8", Offset = "0x17AA0A8", VA = "0x17AA0A8")]
		private uint size()
		{
			return default(uint);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x17A9F1C", Offset = "0x17A9F1C", VA = "0x17A9F1C")]
		private uint capacity()
		{
			return default(uint);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x17AA188", Offset = "0x17AA188", VA = "0x17AA188")]
		private void reserve(uint n)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x17AA4EC", Offset = "0x17AA4EC", VA = "0x17AA4EC")]
		private FirebaseCrashlyticsFrame getitemcopy(int index)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x17A9CFC", Offset = "0x17A9CFC", VA = "0x17A9CFC")]
		private FirebaseCrashlyticsFrame getitem(int index)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x17A9E10", Offset = "0x17A9E10", VA = "0x17A9E10")]
		private void setitem(int index, FirebaseCrashlyticsFrame val)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x17AA840", Offset = "0x17AA840", VA = "0x17AA840")]
		public void AddRange(StackFrames values)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x17AA938", Offset = "0x17AA938", VA = "0x17AA938")]
		public StackFrames GetRange(int index, int count)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x17AAA60", Offset = "0x17AAA60", VA = "0x17AAA60")]
		public void Insert(int index, FirebaseCrashlyticsFrame x)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x17AAB68", Offset = "0x17AAB68", VA = "0x17AAB68")]
		public void InsertRange(int index, StackFrames values)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x17AAC70", Offset = "0x17AAC70", VA = "0x17AAC70")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x17AAD54", Offset = "0x17AAD54", VA = "0x17AAD54")]
		public void RemoveRange(int index, int count)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x17AAE40", Offset = "0x17AAE40", VA = "0x17AAE40")]
		public static StackFrames Repeat(FirebaseCrashlyticsFrame value, int count)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x17AAF6C", Offset = "0x17AAF6C", VA = "0x17AAF6C")]
		public void Reverse()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x17AB040", Offset = "0x17AB040", VA = "0x17AB040")]
		public void Reverse(int index, int count)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x17AB12C", Offset = "0x17AB12C", VA = "0x17AB12C")]
		public void SetRange(int index, StackFrames values)
		{
		}
	}
}
