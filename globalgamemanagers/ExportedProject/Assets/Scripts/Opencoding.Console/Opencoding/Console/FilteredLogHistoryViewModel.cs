using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Opencoding.LogHistory;

namespace Opencoding.Console
{
	[Token(Token = "0x200001C")]
	internal class FilteredLogHistoryViewModel : IDisposable
	{
		[Serializable]
		[Token(Token = "0x2000032")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C94C", Offset = "0x81C94C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400015A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400015B")]
			[FieldOffset(Offset = "0x8")]
			public static Action<LogHistoryItem> _003C_003E9__47_0;

			[Token(Token = "0x400015C")]
			[FieldOffset(Offset = "0x10")]
			public static Action<LogHistoryItem> _003C_003E9__47_1;

			[Token(Token = "0x400015D")]
			[FieldOffset(Offset = "0x18")]
			public static Action _003C_003E9__47_2;

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0xE836D4", Offset = "0xE836D4", VA = "0xE836D4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xE836DC", Offset = "0xE836DC", VA = "0xE836DC")]
			internal void _003C_002Ector_003Eb__47_0(LogHistoryItem _003Cp0_003E)
			{
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xE836E0", Offset = "0xE836E0", VA = "0xE836E0")]
			internal void _003C_002Ector_003Eb__47_1(LogHistoryItem _003Cp0_003E)
			{
			}

			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xE836E4", Offset = "0xE836E4", VA = "0xE836E4")]
			internal void _003C_002Ector_003Eb__47_2()
			{
			}
		}

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<LogHistoryItem> _filteredLogItems;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x18")]
		private string _filterString;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x20")]
		private bool _showInfos;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x21")]
		private bool _showWarnings;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x22")]
		private bool _showErrors;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x23")]
		private bool _showExceptions;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x24")]
		private bool _showAsserts;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x28")]
		private Action<LogHistoryItem> _logHistoryItemAdded;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x30")]
		private Action<LogHistoryItem> _logHistoryItemRemoved;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x38")]
		private Action _logHistoryListReset;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x40")]
		private IList<LogHistoryItem> _currentItemSource;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x48")]
		private Opencoding.LogHistory.LogHistory _logHistory;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x50")]
		private bool _onlyMatchStringsThatStartWithFilterString;

		[Token(Token = "0x17000073")]
		public string FilterString
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0xE81FF8", Offset = "0xE81FF8", VA = "0xE81FF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0xE8209C", Offset = "0xE8209C", VA = "0xE8209C")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public bool OnlyMatchStringsThatStartWithFilterString
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0xE81FF0", Offset = "0xE81FF0", VA = "0xE81FF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0xE82000", Offset = "0xE82000", VA = "0xE82000")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public bool ShowInfos
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xE83240", Offset = "0xE83240", VA = "0xE83240")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0xE83248", Offset = "0xE83248", VA = "0xE83248")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public bool ShowWarnings
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xE8326C", Offset = "0xE8326C", VA = "0xE8326C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0xE83274", Offset = "0xE83274", VA = "0xE83274")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public bool ShowErrors
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0xE83298", Offset = "0xE83298", VA = "0xE83298")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0xE832A0", Offset = "0xE832A0", VA = "0xE832A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public bool ShowExceptions
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0xE832C4", Offset = "0xE832C4", VA = "0xE832C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0xE832CC", Offset = "0xE832CC", VA = "0xE832CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public bool ShowAsserts
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0xE832F0", Offset = "0xE832F0", VA = "0xE832F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0xE832F8", Offset = "0xE832F8", VA = "0xE832F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public IList<LogHistoryItem> LogHistoryItems
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0xE8331C", Offset = "0xE8331C", VA = "0xE8331C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public bool IsFiltered
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0xE83324", Offset = "0xE83324", VA = "0xE83324")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action<LogHistoryItem> LogHistoryItemAdded
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0xE82A04", Offset = "0xE82A04", VA = "0xE82A04")]
			add
			{
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xE82AC8", Offset = "0xE82AC8", VA = "0xE82AC8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<LogHistoryItem> LogHistoryItemRemoved
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0xE82B8C", Offset = "0xE82B8C", VA = "0xE82B8C")]
			add
			{
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0xE82C50", Offset = "0xE82C50", VA = "0xE82C50")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action LogHistoryListReset
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0xE82D14", Offset = "0xE82D14", VA = "0xE82D14")]
			add
			{
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0xE82DD8", Offset = "0xE82DD8", VA = "0xE82DD8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xE79C30", Offset = "0xE79C30", VA = "0xE79C30")]
		public FilteredLogHistoryViewModel(Opencoding.LogHistory.LogHistory logHistory)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xE7AFE8", Offset = "0xE7AFE8", VA = "0xE7AFE8", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xE833B4", Offset = "0xE833B4", VA = "0xE833B4")]
		private void AddLogItemToFilteredListIfNecessary(LogHistoryItem historyItem)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xE835A8", Offset = "0xE835A8", VA = "0xE835A8")]
		private void RemoveLogItemFromFilteredList(LogHistoryItem historyItem)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xE82E9C", Offset = "0xE82E9C", VA = "0xE82E9C")]
		private void FilterLogItems()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xE83488", Offset = "0xE83488", VA = "0xE83488")]
		private bool PassesFilter(LogHistoryItem historyItem)
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xE8366C", Offset = "0xE8366C", VA = "0xE8366C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81E308", Offset = "0x81E308")]
		private bool _003CFilterLogItems_003Eb__51_0(LogHistoryItem item)
		{
			return default(bool);
		}
	}
}
