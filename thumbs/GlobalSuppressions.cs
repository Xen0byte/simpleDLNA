using System.Diagnostics.CodeAnalysis;

[assembly:
  SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults",
    MessageId = "NMaier.SimpleDlna.Utilities.StreamPump", Scope = "member",
    Target =
      "NMaier.SimpleDlna.Thumbnails.VideoThumbnails.#GetThumbnailInternal(System.IO.Stream,System.Int32&,System.Int32&)")]
[assembly:
  SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member",
    Target =
      "NMaier.SimpleDlna.Thumbnails.VideoThumbnails.#GetThumbnailFromProcess(System.Diagnostics.Process,System.Int32&,System.Int32&)")]
[assembly:
  SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member",
    Target =
      "NMaier.SimpleDlna.Thumbnails.VideoThumbnails.#GetThumbnailInternal(System.IO.Stream,System.Int32&,System.Int32&)")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ffmpeg",
    Scope = "member", Target = "NMaier.SimpleDlna.Thumbnails.VideoThumbnails.#.ctor()")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
    Target = "NMaier.SimpleDlna.Thumbnails.ThumbnailMaker+Thumbnail.#Width")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
    Target = "NMaier.SimpleDlna.Thumbnails.ThumbnailMaker+Thumbnail.#Height")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
    Target = "NMaier.SimpleDlna.Thumbnails.ThumbnailMaker+Thumbnail.#Data")]
[assembly:
  SuppressMessage("Microsoft.Security", "CA2105:ArrayFieldsShouldNotBeReadOnly", Scope = "member",
    Target = "NMaier.SimpleDlna.Thumbnails.ThumbnailMaker+Thumbnail.#Data")]
[assembly:
  SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Scope = "type",
    Target = "NMaier.SimpleDlna.Thumbnails.ThumbnailMaker+Thumbnail")]
[assembly:
  SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults",
    MessageId = "NMaier.SimpleDlna.Utilities.StreamPump", Scope = "member",
    Target =
      "NMaier.SimpleDlna.Thumbnails.VideoThumbnailLoader.#GetThumbnailInternal(System.IO.Stream,System.Int32&,System.Int32&)")]
[assembly:
  SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member",
    Target =
      "NMaier.SimpleDlna.Thumbnails.VideoThumbnailLoader.#GetThumbnailInternal(System.IO.Stream,System.Int32&,System.Int32&)")]
[assembly:
  SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member",
    Target =
      "NMaier.SimpleDlna.Thumbnails.VideoThumbnailLoader.#GetThumbnailFromProcess(System.Diagnostics.Process,System.Int32&,System.Int32&)")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ffmpeg",
    Scope = "member", Target = "NMaier.SimpleDlna.Thumbnails.VideoThumbnailLoader.#.ctor()")]
[assembly:
  SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type",
    Target = "NMaier.SimpleDlna.Thumbnails.ImageThumbnailLoader")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2243:AttributeStringLiteralsShouldParseCorrectly")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dlna")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dlna",
    Scope = "namespace", Target = "NMaier.SimpleDlna.Thumbnails")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
    Target = "NMaier.SimpleDlna.Thumbnails")]
[assembly:
  SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member",
    Target =
      "NMaier.SimpleDlna.Thumbnails.ThumbnailMaker.#GetThumbnail(System.IO.FileSystemInfo,System.Int32,System.Int32)")]
