using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.ReferenceData.DataProviders
{
	[Token(Token = "0x2000485")]
	public class NetworkProvider : BaseProvider
	{
		[Token(Token = "0x2000816")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8212D8", Offset = "0x8212D8")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x4002349")]
			[FieldOffset(Offset = "0x10")]
			public NetworkProvider _003C_003E4__this;

			[Token(Token = "0x400234A")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool, BaseProvider, bool> onDataLoaded;

			[Token(Token = "0x60032E2")]
			[Address(RVA = "0xB35AA0", Offset = "0xB35AA0", VA = "0xB35AA0")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}
		}

		[Token(Token = "0x2000817")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8212E8", Offset = "0x8212E8")]
		private sealed class _003C_003Ec__DisplayClass10_1
		{
			[Token(Token = "0x400234B")]
			[FieldOffset(Offset = "0x10")]
			public PairedProviderRequest pairedRequest;

			[Token(Token = "0x400234C")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x60032E3")]
			[Address(RVA = "0xB35AA8", Offset = "0xB35AA8", VA = "0xB35AA8")]
			public _003C_003Ec__DisplayClass10_1()
			{
			}

			[Token(Token = "0x60032E4")]
			[Address(RVA = "0xB36DE0", Offset = "0xB36DE0", VA = "0xB36DE0")]
			internal void _003CLoadDataAsync_003Eb__0(WebResponse response, WebRequest sourceRequest)
			{
			}
		}

		[Token(Token = "0x2000818")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8212F8", Offset = "0x8212F8")]
		private sealed class _003C_003Ec__DisplayClass10_2
		{
			[Token(Token = "0x400234D")]
			[FieldOffset(Offset = "0x10")]
			public PairedProviderRequest pairedRequest;

			[Token(Token = "0x400234E")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals2;

			[Token(Token = "0x60032E5")]
			[Address(RVA = "0xB35BD8", Offset = "0xB35BD8", VA = "0xB35BD8")]
			public _003C_003Ec__DisplayClass10_2()
			{
			}

			[Token(Token = "0x60032E6")]
			[Address(RVA = "0xB36E78", Offset = "0xB36E78", VA = "0xB36E78")]
			internal void _003CLoadDataAsync_003Eb__1(WebResponse response, WebRequest sourceRequest)
			{
			}
		}

		[Token(Token = "0x2000819")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821308", Offset = "0x821308")]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x400234F")]
			[FieldOffset(Offset = "0x10")]
			public PairedProviderRequest request;

			[Token(Token = "0x4002350")]
			[FieldOffset(Offset = "0x18")]
			public NetworkProvider _003C_003E4__this;

			[Token(Token = "0x60032E7")]
			[Address(RVA = "0xB35FC4", Offset = "0xB35FC4", VA = "0xB35FC4")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60032E8")]
			[Address(RVA = "0xB36F08", Offset = "0xB36F08", VA = "0xB36F08")]
			internal void _003CSendNextRequest_003Eb__0(string serverChecksum)
			{
			}
		}

		[Token(Token = "0x40014AB")]
		[FieldOffset(Offset = "0x28")]
		private int m_requestThrottle;

		[Token(Token = "0x40014AC")]
		[FieldOffset(Offset = "0x0")]
		public static int g_depotsPerRequest;

		[Token(Token = "0x40014AD")]
		[FieldOffset(Offset = "0x30")]
		private string m_URL;

		[Token(Token = "0x40014AE")]
		[FieldOffset(Offset = "0x38")]
		private string m_checksumURL;

		[Token(Token = "0x40014AF")]
		[FieldOffset(Offset = "0x40")]
		private Action<WebRequest> m_webInterface;

		[Token(Token = "0x40014B0")]
		[FieldOffset(Offset = "0x48")]
		private Queue<PairedProviderRequest> m_networkRequestQueue;

		[Token(Token = "0x40014B1")]
		[FieldOffset(Offset = "0x50")]
		private int m_activeRequests;

		[Token(Token = "0x40014B2")]
		[FieldOffset(Offset = "0x54")]
		private bool m_bEnableChecksum;

		[Token(Token = "0x6002138")]
		[Address(RVA = "0xB352D8", Offset = "0xB352D8", VA = "0xB352D8")]
		public NetworkProvider(string url, string checksumURL, Action<WebRequest> webInterfaceCB, bool enableChecksum = false)
		{
		}

		[Token(Token = "0x6002139")]
		[Address(RVA = "0xB35394", Offset = "0xB35394", VA = "0xB35394", Slot = "6")]
		public override DataSource GetDataSourceValue()
		{
			return default(DataSource);
		}

		[Token(Token = "0x600213A")]
		[Address(RVA = "0xB3539C", Offset = "0xB3539C", VA = "0xB3539C", Slot = "4")]
		protected override bool LoadDataAsync(Action<bool, BaseProvider, bool> onDataLoaded)
		{
			return default(bool);
		}

		[Token(Token = "0x600213B")]
		[Address(RVA = "0xB35BE0", Offset = "0xB35BE0", VA = "0xB35BE0")]
		private bool SendNextRequest(Action<bool, BaseProvider, bool> onDataLoaded)
		{
			return default(bool);
		}

		[Token(Token = "0x600213C")]
		[Address(RVA = "0xB361D4", Offset = "0xB361D4", VA = "0xB361D4")]
		private void OnQueryComplete(WebResponse response, WebRequest sourceRequest, string checksum, Action<bool, BaseProvider, bool> onDataLoaded)
		{
		}

		[Token(Token = "0x600213D")]
		[Address(RVA = "0xB3679C", Offset = "0xB3679C", VA = "0xB3679C")]
		protected void CacheQueryResult(string text, string checksum, string fileName)
		{
		}

		[Token(Token = "0x600213E")]
		[Address(RVA = "0xB36A38", Offset = "0xB36A38", VA = "0xB36A38")]
		public void CleanCache()
		{
		}

		[Token(Token = "0x600213F")]
		[Address(RVA = "0xB36B94", Offset = "0xB36B94", VA = "0xB36B94")]
		public string LoadCachedChecksum(string fileName)
		{
			return null;
		}

		[Token(Token = "0x6002140")]
		[Address(RVA = "0xB36460", Offset = "0xB36460", VA = "0xB36460")]
		public bool LoadCachedQuery(string fileName, out string queryText)
		{
			return default(bool);
		}

		[Token(Token = "0x6002141")]
		[Address(RVA = "0xB36CF4", Offset = "0xB36CF4", VA = "0xB36CF4", Slot = "5")]
		protected override bool LoadData(Action<bool, BaseProvider, bool> onDataLoaded)
		{
			return default(bool);
		}
	}
}
