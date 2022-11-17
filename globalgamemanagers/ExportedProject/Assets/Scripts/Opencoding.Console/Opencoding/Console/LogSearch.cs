using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Opencoding.LogHistory;

namespace Opencoding.Console
{
	[Token(Token = "0x2000006")]
	internal class LogSearch
	{
		[Serializable]
		[Token(Token = "0x2000028")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C91C", Offset = "0x81C91C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400012C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400012D")]
			[FieldOffset(Offset = "0x8")]
			public static Action<LogHistoryItem> _003C_003E9__19_0;

			[Token(Token = "0x60001CD")]
			[Address(RVA = "0xE8F86C", Offset = "0xE8F86C", VA = "0xE8F86C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0xE8F874", Offset = "0xE8F874", VA = "0xE8F874")]
			internal void _003C_002Ector_003Eb__19_0(LogHistoryItem _003Cp0_003E)
			{
			}
		}

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x10")]
		private FilteredLogHistoryViewModel _filteredLogHistoryViewModel;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<LogHistoryItem> _searchResults;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x20")]
		private readonly HashSet<LogHistoryItem> _searchResultsHashSet;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x28")]
		private string _searchString;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x30")]
		public Action<LogHistoryItem> CurrentResultChanged;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81CB04", Offset = "0x81CB04")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81CB04", Offset = "0x81CB04")]
		private bool _003CEnabled_003Ek__BackingField;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x3C")]
		private int _currentResultIndex;

		[Token(Token = "0x17000014")]
		public bool Enabled
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0xE8F618", Offset = "0xE8F618", VA = "0xE8F618")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DC88", Offset = "0x81DC88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000047")]
			[Address(RVA = "0xE81410", Offset = "0xE81410", VA = "0xE81410")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DC98", Offset = "0x81DC98")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public bool IsSearchActive
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0xE820E0", Offset = "0xE820E0", VA = "0xE820E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		public List<LogHistoryItem> Results
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0xE82608", Offset = "0xE82608", VA = "0xE82608")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public int CurrentResultIndex
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0xE82610", Offset = "0xE82610", VA = "0xE82610")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0xE82898", Offset = "0xE82898", VA = "0xE82898")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public LogHistoryItem CurrentResult
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0xE8D32C", Offset = "0xE8D32C", VA = "0xE8D32C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public string SearchString
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0xE826E8", Offset = "0xE826E8", VA = "0xE826E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0xE826F0", Offset = "0xE826F0", VA = "0xE826F0")]
			set
			{
			}
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xE79FA4", Offset = "0xE79FA4", VA = "0xE79FA4")]
		public LogSearch(FilteredLogHistoryViewModel filteredLogHistoryViewModel)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xE8F620", Offset = "0xE8F620", VA = "0xE8F620")]
		private void RemoveLogHistoryItem(LogHistoryItem logHistoryItem)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xE8F6B8", Offset = "0xE8F6B8", VA = "0xE8F6B8")]
		private void CheckIfItemMatchesSearch(LogHistoryItem logHistoryItem)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xE8214C", Offset = "0xE8214C", VA = "0xE8214C")]
		public void RunSearchFromScratch()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xE8F6F4", Offset = "0xE8F6F4", VA = "0xE8F6F4")]
		private void AddItemIfMatchesSearch(LogHistoryItem item)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xE8F7AC", Offset = "0xE8F7AC", VA = "0xE8F7AC")]
		private bool DoesItemMatchSearchString(LogHistoryItem item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xE8E210", Offset = "0xE8E210", VA = "0xE8E210")]
		public bool IsLogHistoryItemASearchResult(LogHistoryItem item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xE827F4", Offset = "0xE827F4", VA = "0xE827F4")]
		public void NextSearchResult()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xE82778", Offset = "0xE82778", VA = "0xE82778")]
		public void PreviousSearchResult()
		{
		}
	}
}
