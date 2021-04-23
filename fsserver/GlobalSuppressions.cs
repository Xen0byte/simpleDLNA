using System.Diagnostics.CodeAnalysis;

[assembly:
  SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member",
    Target = "NMaier.SimpleDlna.FileMediaServer.TagLibFileAbstraction.#CloseStream(System.IO.Stream)")]
[assembly:
  SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member",
    Target =
      "NMaier.SimpleDlna.FileMediaServer.ImageFile.#.ctor(System.Runtime.Serialization.SerializationInfo,NMaier.SimpleDlna.FileMediaServer.DeserializeInfo)")]
[assembly:
  SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Scope = "member",
    Target = "NMaier.SimpleDlna.FileMediaServer.FileStore.#SetupDatabase()")]
[assembly:
  SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member",
    Target =
      "NMaier.SimpleDlna.FileMediaServer.FileStore.#OpenConnection(System.IO.FileInfo,System.Data.IDbConnection&)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dlna")]
[assembly:
  SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.GC.Collect",
    Scope = "member",
    Target =
      "NMaier.SimpleDlna.FileMediaServer.FileStore.#OpenConnection(System.IO.FileInfo,System.Data.IDbConnection&)")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
    Target = "NMaier.SimpleDlna.FileMediaServer")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dlna",
    Scope = "namespace", Target = "NMaier.SimpleDlna.FileMediaServer")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2243:AttributeStringLiteralsShouldParseCorrectly")]
[assembly:
  SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member",
    Target =
      "NMaier.SimpleDlna.FileMediaServer.FileStore.#OpenConnection(System.IO.FileInfo,System.Data.IDbConnection&)")]
