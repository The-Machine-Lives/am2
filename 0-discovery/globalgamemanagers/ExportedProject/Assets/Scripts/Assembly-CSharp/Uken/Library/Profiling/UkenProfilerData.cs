using System.Diagnostics;
using Il2CppDummyDll;

namespace Uken.Library.Profiling
{
	[Token(Token = "0x20003FD")]
	public class UkenProfilerData
	{
		[Token(Token = "0x40012AE")]
		[FieldOffset(Offset = "0x10")]
		public string sampleName;

		[Token(Token = "0x40012AF")]
		[FieldOffset(Offset = "0x18")]
		public float elapsedMilliseconds;

		[Token(Token = "0x40012B0")]
		[FieldOffset(Offset = "0x20")]
		private Stopwatch timer;

		[Token(Token = "0x6001E73")]
		[Address(RVA = "0xB32D68", Offset = "0xB32D68", VA = "0xB32D68")]
		public UkenProfilerData(string name)
		{
		}

		[Token(Token = "0x6001E74")]
		[Address(RVA = "0xB335D0", Offset = "0xB335D0", VA = "0xB335D0")]
		public void Start()
		{
		}

		[Token(Token = "0x6001E75")]
		[Address(RVA = "0xB336BC", Offset = "0xB336BC", VA = "0xB336BC")]
		public void Stop()
		{
		}
	}
}
