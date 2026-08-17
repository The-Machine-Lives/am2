using System;
using Il2CppDummyDll;

namespace Uken.Library.ReferenceData.DataProviders
{
	[Token(Token = "0x2000486")]
	public class ResourceProvider : BaseProvider
	{
		[Token(Token = "0x40014B3")]
		[FieldOffset(Offset = "0x28")]
		private string m_filePath;

		[Token(Token = "0x6002143")]
		[Address(RVA = "0xB372C0", Offset = "0xB372C0", VA = "0xB372C0")]
		public ResourceProvider(string filePath)
		{
		}

		[Token(Token = "0x6002144")]
		[Address(RVA = "0xB3732C", Offset = "0xB3732C", VA = "0xB3732C")]
		private string GetDataFilePath()
		{
			return null;
		}

		[Token(Token = "0x6002145")]
		[Address(RVA = "0xB37334", Offset = "0xB37334", VA = "0xB37334", Slot = "7")]
		public override bool SupportsAsync()
		{
			return default(bool);
		}

		[Token(Token = "0x6002146")]
		[Address(RVA = "0xB3733C", Offset = "0xB3733C", VA = "0xB3733C", Slot = "6")]
		public override DataSource GetDataSourceValue()
		{
			return default(DataSource);
		}

		[Token(Token = "0x6002147")]
		[Address(RVA = "0xB37344", Offset = "0xB37344", VA = "0xB37344", Slot = "4")]
		protected override bool LoadDataAsync(Action<bool, BaseProvider, bool> onDataLoaded)
		{
			return default(bool);
		}

		[Token(Token = "0x6002148")]
		[Address(RVA = "0xB373EC", Offset = "0xB373EC", VA = "0xB373EC", Slot = "5")]
		protected override bool LoadData(Action<bool, BaseProvider, bool> onDataLoaded)
		{
			return default(bool);
		}
	}
}
