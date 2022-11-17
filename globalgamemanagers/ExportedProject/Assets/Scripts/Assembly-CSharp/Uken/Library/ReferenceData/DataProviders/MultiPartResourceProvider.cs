using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.ReferenceData.DataProviders
{
	[Token(Token = "0x2000480")]
	public class MultiPartResourceProvider : BaseProvider
	{
		[Token(Token = "0x40014A4")]
		[FieldOffset(Offset = "0x28")]
		private List<string> m_sourceFiles;

		[Token(Token = "0x600212B")]
		[Address(RVA = "0xB34F58", Offset = "0xB34F58", VA = "0xB34F58")]
		public MultiPartResourceProvider(List<string> sourceFiles)
		{
		}

		[Token(Token = "0x600212C")]
		[Address(RVA = "0xB34FDC", Offset = "0xB34FDC", VA = "0xB34FDC", Slot = "6")]
		public override DataSource GetDataSourceValue()
		{
			return default(DataSource);
		}

		[Token(Token = "0x600212D")]
		[Address(RVA = "0xB34FE4", Offset = "0xB34FE4", VA = "0xB34FE4", Slot = "4")]
		protected override bool LoadDataAsync(Action<bool, BaseProvider, bool> onDataLoaded)
		{
			return default(bool);
		}

		[Token(Token = "0x600212E")]
		[Address(RVA = "0xB35058", Offset = "0xB35058", VA = "0xB35058", Slot = "5")]
		protected override bool LoadData(Action<bool, BaseProvider, bool> onDataLoaded)
		{
			return default(bool);
		}
	}
}
