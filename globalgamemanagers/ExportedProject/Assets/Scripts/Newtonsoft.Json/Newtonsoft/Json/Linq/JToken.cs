using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000D5")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x80F174", Offset = "0x80F174")]
	[Preserve]
	public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable
	{
		[Token(Token = "0x20000D6")]
		private class LineInfoAnnotation
		{
			[Token(Token = "0x4000314")]
			[FieldOffset(Offset = "0x10")]
			internal readonly int LineNumber;

			[Token(Token = "0x4000315")]
			[FieldOffset(Offset = "0x14")]
			internal readonly int LinePosition;

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0xCFCE90", Offset = "0xCFCE90", VA = "0xCFCE90")]
			public LineInfoAnnotation(int lineNumber, int linePosition)
			{
			}
		}

		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F1C0", Offset = "0x80F1C0")]
		private sealed class _003CGetAncestors_003Ed__41 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			[Token(Token = "0x4000316")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000317")]
			[FieldOffset(Offset = "0x18")]
			private JToken _003C_003E2__current;

			[Token(Token = "0x4000318")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4000319")]
			[FieldOffset(Offset = "0x24")]
			private bool self;

			[Token(Token = "0x400031A")]
			[FieldOffset(Offset = "0x25")]
			public bool _003C_003E3__self;

			[Token(Token = "0x400031B")]
			[FieldOffset(Offset = "0x28")]
			public JToken _003C_003E4__this;

			[Token(Token = "0x400031C")]
			[FieldOffset(Offset = "0x30")]
			private JToken _003Ccurrent_003E5__1;

			[Token(Token = "0x1700013B")]
			private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECurrent
			{
				[Token(Token = "0x60006E0")]
				[Address(RVA = "0xCFCD4C", Offset = "0xCFCD4C", VA = "0xCFCD4C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60006E2")]
				[Address(RVA = "0xCFCDBC", Offset = "0xCFCDBC", VA = "0xCFCDBC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0xCFCC34", Offset = "0xCFCC34", VA = "0xCFCC34")]
			[DebuggerHidden]
			public _003CGetAncestors_003Ed__41(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0xCFCC84", Offset = "0xCFCC84", VA = "0xCFCC84", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0xCFCC88", Offset = "0xCFCC88", VA = "0xCFCC88", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0xCFCD54", Offset = "0xCFCD54", VA = "0xCFCD54", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0xCFCDC4", Offset = "0xCFCDC4", VA = "0xCFCDC4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0xCFCE8C", Offset = "0xCFCE8C", VA = "0xCFCE8C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F1D0", Offset = "0x80F1D0")]
		private sealed class _003CAfterSelf_003Ed__42 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			[Token(Token = "0x400031D")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400031E")]
			[FieldOffset(Offset = "0x18")]
			private JToken _003C_003E2__current;

			[Token(Token = "0x400031F")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4000320")]
			[FieldOffset(Offset = "0x28")]
			public JToken _003C_003E4__this;

			[Token(Token = "0x4000321")]
			[FieldOffset(Offset = "0x30")]
			private JToken _003Co_003E5__1;

			[Token(Token = "0x1700013D")]
			private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECurrent
			{
				[Token(Token = "0x60006E8")]
				[Address(RVA = "0xCFC49C", Offset = "0xCFC49C", VA = "0xCFC49C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013E")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60006EA")]
				[Address(RVA = "0xCFC50C", Offset = "0xCFC50C", VA = "0xCFC50C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0xCFC378", Offset = "0xCFC378", VA = "0xCFC378")]
			[DebuggerHidden]
			public _003CAfterSelf_003Ed__42(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0xCFC3C8", Offset = "0xCFC3C8", VA = "0xCFC3C8", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0xCFC3CC", Offset = "0xCFC3CC", VA = "0xCFC3CC", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0xCFC4A4", Offset = "0xCFC4A4", VA = "0xCFC4A4", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0xCFC514", Offset = "0xCFC514", VA = "0xCFC514", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0xCFC5D4", Offset = "0xCFC5D4", VA = "0xCFC5D4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F1E0", Offset = "0x80F1E0")]
		private sealed class _003CBeforeSelf_003Ed__43 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			[Token(Token = "0x4000322")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000323")]
			[FieldOffset(Offset = "0x18")]
			private JToken _003C_003E2__current;

			[Token(Token = "0x4000324")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4000325")]
			[FieldOffset(Offset = "0x28")]
			public JToken _003C_003E4__this;

			[Token(Token = "0x4000326")]
			[FieldOffset(Offset = "0x30")]
			private JToken _003Co_003E5__1;

			[Token(Token = "0x1700013F")]
			private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECurrent
			{
				[Token(Token = "0x60006F0")]
				[Address(RVA = "0xCFCAF8", Offset = "0xCFCAF8", VA = "0xCFCAF8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000140")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60006F2")]
				[Address(RVA = "0xCFCB68", Offset = "0xCFCB68", VA = "0xCFCB68", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0xCFC9C0", Offset = "0xCFC9C0", VA = "0xCFC9C0")]
			[DebuggerHidden]
			public _003CBeforeSelf_003Ed__43(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0xCFCA10", Offset = "0xCFCA10", VA = "0xCFCA10", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0xCFCA14", Offset = "0xCFCA14", VA = "0xCFCA14", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0xCFCB00", Offset = "0xCFCB00", VA = "0xCFCB00", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0xCFCB70", Offset = "0xCFCB70", VA = "0xCFCB70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0xCFCC30", Offset = "0xCFCC30", VA = "0xCFCC30", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F1F0", Offset = "0x80F1F0")]
		private sealed class _003CAnnotations_003Ed__171<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator where T : class
		{
			[Token(Token = "0x4000327")]
			[FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000328")]
			[FieldOffset(Offset = "0x0")]
			private T _003C_003E2__current;

			[Token(Token = "0x4000329")]
			[FieldOffset(Offset = "0x0")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x400032A")]
			[FieldOffset(Offset = "0x0")]
			public JToken _003C_003E4__this;

			[Token(Token = "0x400032B")]
			[FieldOffset(Offset = "0x0")]
			private object[] _003Cannotations_003E5__1;

			[Token(Token = "0x400032C")]
			[FieldOffset(Offset = "0x0")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x17000141")]
			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
			{
				[Token(Token = "0x60006F8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000142")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60006FA")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F5")]
			[DebuggerHidden]
			public _003CAnnotations_003Ed__171(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60006F6")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60006F7")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F9")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60006FB")]
			[DebuggerHidden]
			private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60006FC")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F200", Offset = "0x80F200")]
		private sealed class _003CAnnotations_003Ed__172 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IDisposable, IEnumerator
		{
			[Token(Token = "0x400032D")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400032E")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400032F")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4000330")]
			[FieldOffset(Offset = "0x28")]
			private Type type;

			[Token(Token = "0x4000331")]
			[FieldOffset(Offset = "0x30")]
			public Type _003C_003E3__type;

			[Token(Token = "0x4000332")]
			[FieldOffset(Offset = "0x38")]
			public JToken _003C_003E4__this;

			[Token(Token = "0x4000333")]
			[FieldOffset(Offset = "0x40")]
			private object[] _003Cannotations_003E5__1;

			[Token(Token = "0x4000334")]
			[FieldOffset(Offset = "0x48")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x17000143")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000700")]
				[Address(RVA = "0xCFC87C", Offset = "0xCFC87C", VA = "0xCFC87C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000144")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000702")]
				[Address(RVA = "0xCFC8EC", Offset = "0xCFC8EC", VA = "0xCFC8EC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0xCFC5D8", Offset = "0xCFC5D8", VA = "0xCFC5D8")]
			[DebuggerHidden]
			public _003CAnnotations_003Ed__172(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0xCFC628", Offset = "0xCFC628", VA = "0xCFC628", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0xCFC62C", Offset = "0xCFC62C", VA = "0xCFC62C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0xCFC884", Offset = "0xCFC884", VA = "0xCFC884", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0xCFC8F4", Offset = "0xCFC8F4", VA = "0xCFC8F4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EObject_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0xCFC9BC", Offset = "0xCFC9BC", VA = "0xCFC9BC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x10")]
		private JContainer _parent;

		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x18")]
		private JToken _previous;

		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x20")]
		private JToken _next;

		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x28")]
		private object _annotations;

		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly JTokenType[] BooleanTypes;

		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly JTokenType[] NumberTypes;

		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x10")]
		private static readonly JTokenType[] StringTypes;

		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x18")]
		private static readonly JTokenType[] GuidTypes;

		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x20")]
		private static readonly JTokenType[] TimeSpanTypes;

		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x28")]
		private static readonly JTokenType[] UriTypes;

		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x30")]
		private static readonly JTokenType[] CharTypes;

		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x38")]
		private static readonly JTokenType[] DateTimeTypes;

		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x40")]
		private static readonly JTokenType[] BytesTypes;

		[Token(Token = "0x1700012F")]
		public JContainer Parent
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0xFECE10", Offset = "0xFECE10", VA = "0xFECE10")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			[Token(Token = "0x600068D")]
			[Address(RVA = "0xFED238", Offset = "0xFED238", VA = "0xFED238")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000130")]
		public JToken Root
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0xFECE18", Offset = "0xFECE18", VA = "0xFECE18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000131")]
		public abstract JTokenType Type
		{
			[Token(Token = "0x6000691")]
			get;
		}

		[Token(Token = "0x17000132")]
		public abstract bool HasValues
		{
			[Token(Token = "0x6000692")]
			get;
		}

		[Token(Token = "0x17000133")]
		public JToken Next
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0xFF437C", Offset = "0xFF437C", VA = "0xFF437C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000695")]
			[Address(RVA = "0xFED248", Offset = "0xFED248", VA = "0xFED248")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public JToken Previous
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0xFF4384", Offset = "0xFF4384", VA = "0xFF4384")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000697")]
			[Address(RVA = "0xFED240", Offset = "0xFED240", VA = "0xFED240")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public string Path
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0xFF438C", Offset = "0xFF438C", VA = "0xFF438C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000136")]
		public virtual JToken this[object key]
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0xFF4714", Offset = "0xFF4714", VA = "0xFF4714", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000137")]
		public virtual JToken First
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0xFF47E4", Offset = "0xFF47E4", VA = "0xFF47E4", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000138")]
		public virtual JToken Last
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0xFF48B4", Offset = "0xFF48B4", VA = "0xFF48B4", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000139")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELineNumber
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0xFFB3F8", Offset = "0xFFB3F8", VA = "0xFFB3F8", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700013A")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELinePosition
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0xFFB454", Offset = "0xFFB454", VA = "0xFFB454", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600068F")]
		internal abstract JToken CloneToken();

		[Token(Token = "0x6000690")]
		internal abstract bool DeepEquals(JToken node);

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xFF4350", Offset = "0xFF4350", VA = "0xFF4350")]
		public static bool DeepEquals(JToken t1, JToken t2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xFEC2A8", Offset = "0xFEC2A8", VA = "0xFEC2A8")]
		internal JToken()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xFF4984", Offset = "0xFF4984", VA = "0xFF4984", Slot = "17")]
		public virtual JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xFF13CC", Offset = "0xFF13CC", VA = "0xFF13CC")]
		public void Remove()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xFEF1E4", Offset = "0xFEF1E4", VA = "0xFEF1E4")]
		public void Replace(JToken value)
		{
		}

		[Token(Token = "0x60006A0")]
		public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xFF49EC", Offset = "0xFF49EC", VA = "0xFF49EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xFF4A4C", Offset = "0xFF4A4C", VA = "0xFF4A4C")]
		public string ToString(Formatting formatting, params JsonConverter[] converters)
		{
			return null;
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xFF4C30", Offset = "0xFF4C30", VA = "0xFF4C30")]
		private static JValue EnsureValue(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xFF4D40", Offset = "0xFF4D40", VA = "0xFF4D40")]
		private static string GetType(JToken token)
		{
			return null;
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xFF4E64", Offset = "0xFF4E64", VA = "0xFF4E64")]
		private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xFF4F30", Offset = "0xFF4F30", VA = "0xFF4F30")]
		public static explicit operator bool(JToken value)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xFF5100", Offset = "0xFF5100", VA = "0xFF5100")]
		public static explicit operator DateTimeOffset(JToken value)
		{
			return default(DateTimeOffset);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xFF543C", Offset = "0xFF543C", VA = "0xFF543C")]
		public static explicit operator bool?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xFF5650", Offset = "0xFF5650", VA = "0xFF5650")]
		public static explicit operator long(JToken value)
		{
			return default(long);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xFF5820", Offset = "0xFF5820", VA = "0xFF5820")]
		public static explicit operator DateTime?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xFF5A94", Offset = "0xFF5A94", VA = "0xFF5A94")]
		public static explicit operator DateTimeOffset?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xFF5EA0", Offset = "0xFF5EA0", VA = "0xFF5EA0")]
		public static explicit operator decimal?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xFF60CC", Offset = "0xFF60CC", VA = "0xFF60CC")]
		public static explicit operator double?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xFF62E0", Offset = "0xFF62E0", VA = "0xFF62E0")]
		public static explicit operator char?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xFF64F4", Offset = "0xFF64F4", VA = "0xFF64F4")]
		public static explicit operator int(JToken value)
		{
			return default(int);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xFF66C4", Offset = "0xFF66C4", VA = "0xFF66C4")]
		public static explicit operator short(JToken value)
		{
			return default(short);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xFF6894", Offset = "0xFF6894", VA = "0xFF6894")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810F50", Offset = "0x810F50")]
		public static explicit operator ushort(JToken value)
		{
			return default(ushort);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xFF6A64", Offset = "0xFF6A64", VA = "0xFF6A64")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810F64", Offset = "0x810F64")]
		public static explicit operator char(JToken value)
		{
			return default(char);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xFF6C34", Offset = "0xFF6C34", VA = "0xFF6C34")]
		public static explicit operator byte(JToken value)
		{
			return default(byte);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xFF6E04", Offset = "0xFF6E04", VA = "0xFF6E04")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810F78", Offset = "0x810F78")]
		public static explicit operator sbyte(JToken value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xFF6FD4", Offset = "0xFF6FD4", VA = "0xFF6FD4")]
		public static explicit operator int?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xFF71E8", Offset = "0xFF71E8", VA = "0xFF71E8")]
		public static explicit operator short?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xFF73FC", Offset = "0xFF73FC", VA = "0xFF73FC")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810F8C", Offset = "0x810F8C")]
		public static explicit operator ushort?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xFF7610", Offset = "0xFF7610", VA = "0xFF7610")]
		public static explicit operator byte?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xFF7824", Offset = "0xFF7824", VA = "0xFF7824")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810FA0", Offset = "0x810FA0")]
		public static explicit operator sbyte?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xFF7A38", Offset = "0xFF7A38", VA = "0xFF7A38")]
		public static explicit operator DateTime(JToken value)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xFF7C70", Offset = "0xFF7C70", VA = "0xFF7C70")]
		public static explicit operator long?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xFF7E88", Offset = "0xFF7E88", VA = "0xFF7E88")]
		public static explicit operator float?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xFF8098", Offset = "0xFF8098", VA = "0xFF8098")]
		public static explicit operator decimal(JToken value)
		{
			return default(decimal);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xFF8268", Offset = "0xFF8268", VA = "0xFF8268")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810FB4", Offset = "0x810FB4")]
		public static explicit operator uint?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xFF847C", Offset = "0xFF847C", VA = "0xFF847C")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810FC8", Offset = "0x810FC8")]
		public static explicit operator ulong?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xFF8694", Offset = "0xFF8694", VA = "0xFF8694")]
		public static explicit operator double(JToken value)
		{
			return default(double);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xFF8864", Offset = "0xFF8864", VA = "0xFF8864")]
		public static explicit operator float(JToken value)
		{
			return default(float);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xFF8A34", Offset = "0xFF8A34", VA = "0xFF8A34")]
		public static explicit operator string(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xFF8CEC", Offset = "0xFF8CEC", VA = "0xFF8CEC")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810FDC", Offset = "0x810FDC")]
		public static explicit operator uint(JToken value)
		{
			return default(uint);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xFF8EBC", Offset = "0xFF8EBC", VA = "0xFF8EBC")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810FF0", Offset = "0x810FF0")]
		public static explicit operator ulong(JToken value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xFF908C", Offset = "0xFF908C", VA = "0xFF908C")]
		public static explicit operator Guid(JToken value)
		{
			return default(Guid);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xFF9374", Offset = "0xFF9374", VA = "0xFF9374")]
		public static explicit operator Guid?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xFF96A0", Offset = "0xFF96A0", VA = "0xFF96A0")]
		public static explicit operator TimeSpan(JToken value)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xFF98F8", Offset = "0xFF98F8", VA = "0xFF98F8")]
		public static explicit operator TimeSpan?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xFF9B8C", Offset = "0xFF9B8C", VA = "0xFF9B8C")]
		public static explicit operator Uri(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xFF9E70", Offset = "0xFF9E70", VA = "0xFF9E70", Slot = "5")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xFF9F14", Offset = "0xFF9F14", VA = "0xFF9F14", Slot = "4")]
		private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60006CC")]
		internal abstract int GetDeepHashCode();

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xFF9F8C", Offset = "0xFF9F8C", VA = "0xFF9F8C")]
		public JsonReader CreateReader()
		{
			return null;
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xFF9FF0", Offset = "0xFF9FF0", VA = "0xFF9FF0")]
		public object ToObject(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xFFABE0", Offset = "0xFFABE0", VA = "0xFFABE0")]
		public object ToObject(Type objectType, JsonSerializer jsonSerializer)
		{
			return null;
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xFFAD48", Offset = "0xFFAD48", VA = "0xFFAD48")]
		public static JToken ReadFrom(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xFFADB0", Offset = "0xFFADB0", VA = "0xFFADB0")]
		public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xFEAE40", Offset = "0xFEAE40", VA = "0xFEAE40")]
		internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings)
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xFFB06C", Offset = "0xFFB06C", VA = "0xFFB06C")]
		internal void SetLineInfo(int lineNumber, int linePosition)
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xFFB39C", Offset = "0xFFB39C", VA = "0xFFB39C", Slot = "6")]
		private bool Newtonsoft_002EJson_002EIJsonLineInfo_002EHasLineInfo()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xFFB4B0", Offset = "0xFFB4B0", VA = "0xFFB4B0", Slot = "9")]
		private object System_002EICloneable_002EClone()
		{
			return null;
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xFFB4BC", Offset = "0xFFB4BC", VA = "0xFFB4BC")]
		public JToken DeepClone()
		{
			return null;
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xFFB0E8", Offset = "0xFFB0E8", VA = "0xFFB0E8")]
		public void AddAnnotation(object annotation)
		{
		}

		[Token(Token = "0x60006DA")]
		public T Annotation<T>() where T : class
		{
			return null;
		}
	}
}
