//2
// 
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// 

using System.Reflection;

[assembly: AssemblyFileVersion("1.9.99.2")]
[assembly: AssemblyVersion("1.9.99.2")]
[assembly: AssemblyInformationalVersion("1.9.99")]
[assembly: KSPAssembly("SpaceYLifters", 1,9)]

namespace SpaceYLifters
{
	/// <summary>Version - retrieved at compile from SpaceYLifters.version</summary>
	public static class Version
	{
		/// <summary>Major revision</summary>
		public const int major = 1;
		/// <summary>Minor revision</summary>
		public const int minor = 9;
		/// <summary>Patch revision</summary>
		public const int patch = 99;
		/// <summary>Build revision</summary>
		public const int build = 2;
		/// <summary>Version String const</summary>
		public const string Number = "1.9.99.2";
#if DEBUG
		/// <summary>Debug Version String const</summary>
        public const string Text = Number + "-zed'K BETA DEBUG";
		/// <summary>Debug SVersion String const</summary>
        public const string SText = Number + "-zed'K BETA DEBUG";
#else
		/// <summary>Text Version String const</summary>
        public const string Text = Number + "-zed'K";
		/// <summary>Plain Text Version String const</summary>
		public const string SText = Number;
#endif
	}
}