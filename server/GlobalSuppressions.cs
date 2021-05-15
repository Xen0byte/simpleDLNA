using System.Diagnostics.CodeAnalysis;

[assembly:
  SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.Views.NewView")]
[assembly:
  SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.Views.FilterView")]
[assembly:
  SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "client", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.Ssdp.SsdpHandler.#Dispose()")]
[assembly:
  SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.Comparers.DateComparer")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.VirtualFolder.#resources")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.VirtualFolder.#folders")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1036:OverrideMethodsOnComparableTypes", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.VirtualFolder")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.VirtualClonedFolder.#.ctor(NMaier.SimpleDlna.Server.IMediaFolder)")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.Subtitle.#MediaType")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.Subtitle.#Equals(NMaier.SimpleDlna.Server.IMediaItem)")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1036:OverrideMethodsOnComparableTypes", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.Subtitle")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.RawHeaders")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "UUID",
    Scope = "member", Target = "NMaier.SimpleDlna.Server.IMediaServer.#UUID")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "ByPath",
    Scope = "member", Target = "NMaier.SimpleDlna.Server.Identifiers.#GetItemByPath(System.String)")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Bookmarkable",
    Scope = "type", Target = "NMaier.SimpleDlna.Server.IBookmarkable")]
[assembly:
  SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.HttpServer.#AcceptCallback(System.IAsyncResult)")]
[assembly:
  SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults",
    MessageId = "NMaier.SimpleDlna.Utilities.StreamPump", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.HttpClient.#SendResponse()")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "sdlna",
    Scope = "member", Target = "NMaier.SimpleDlna.Server.HtmlTools.#CreateHtmlArticle(System.String)")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "GitHub",
    Scope = "member", Target = "NMaier.SimpleDlna.Server.HtmlTools.#CreateHtmlArticle(System.String)")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "VORBIS",
    Scope = "member", Target = "NMaier.SimpleDlna.Server.DlnaMime.#VORBIS")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SRT", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#SRT")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "MATROSKA",
    Scope = "member", Target = "NMaier.SimpleDlna.Server.DlnaMime.#MATROSKA")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "AVI", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#AVI")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "AAC", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#AAC")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dlna", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.DlnaMediaTypes")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMaps.#Media2Ext")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
    Target = "NMaier.SimpleDlna.Server.Comparers")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dlna",
    Scope = "namespace", Target = "NMaier.SimpleDlna.Server.Metadata")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dlna",
    Scope = "namespace", Target = "NMaier.SimpleDlna.Server.Views")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dlna", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.DlnaMaps")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dlna",
    Scope = "member", Target = "NMaier.SimpleDlna.Server.DlnaMaps.#Dlna2Ext")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dlna",
    Scope = "member", Target = "NMaier.SimpleDlna.Server.DlnaMaps.#Ext2Dlna")]
[assembly:
  SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMaps.#.cctor()")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMaps.#Dlna2Ext")]
[assembly:
  SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.FileResponse")]
[assembly:
  SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.Redirect.#.ctor(System.String)")]
[assembly:
  SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.Redirect.#.ctor(System.Uri)")]
[assembly:
  SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.Views.PlainView")]
[assembly:
  SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.Views.LargeView")]
[assembly:
  SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.Ssdp.SsdpHandler.#ReceiveCallback(System.IAsyncResult)")]
[assembly:
  SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.Comparers.FileSizeComparer")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.VirtualFolder.#resources")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.VirtualFolder.#folders")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.VirtualFolder.#Equals(NMaier.SimpleDlna.Server.IMediaItem)")]
[assembly:
  SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Scope = "member",
    Target =
      "NMaier.SimpleDlna.Server.VirtualClonedFolder.#.ctor(NMaier.SimpleDlna.Server.IMediaFolder,System.String,System.String,NMaier.SimpleDlna.Server.DlnaMediaTypes)")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.Subtitle.#Title")]
[assembly:
  SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.Subtitle.#InfoDate")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.Subtitle.#Cover")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.ResponseHeaders")]
[assembly:
  SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "request", Scope = "member",
    Target =
      "NMaier.SimpleDlna.Server.MediaMount.#AddVideoProperties(NMaier.SimpleDlna.Server.IRequest,NMaier.SimpleDlna.Server.IMediaResource,System.Xml.XmlElement)")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.IHeaders")]
[assembly:
  SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.GC.Collect",
    Scope = "member", Target = "NMaier.SimpleDlna.Server.Identifiers.#Cleanup()")]
[assembly:
  SuppressMessage("Microsoft.Usage", "CA2240:ImplementISerializableCorrectly", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.HttpStatusException")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Satisfiable",
    Scope = "member", Target = "NMaier.SimpleDlna.Server.HttpCode.#RangeNotSatisfiable")]
[assembly:
  SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.HttpClient.#SendResponse()")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "SimpleDLNA",
    Scope = "member", Target = "NMaier.SimpleDlna.Server.HtmlTools.#CreateHtmlArticle(System.String)")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.Headers")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "WMV", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#WMV")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "MPEG", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#MPEG")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "JPEG", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#JPEG")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "AVC", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#AVC")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dlna", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.DlnaMime")]
[assembly:
  SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMaps.#PN")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dlna",
    Scope = "namespace", Target = "NMaier.SimpleDlna.Server")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dlna",
    Scope = "namespace", Target = "NMaier.SimpleDlna.Server.Comparers")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
    Target = "NMaier.SimpleDlna.Server.Views")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2243:AttributeStringLiteralsShouldParseCorrectly")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dlna")]
[assembly:
  SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMaps.#Ext2Dlna")]
[assembly:
  SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMaps.#Ext2Media")]
[assembly:
  SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMaps.#Dlna2Ext")]
[assembly:
  SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMaps.#Media2Ext")]
[assembly:
  SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMaps.#Mime")]
[assembly:
  SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.Redirect.#.ctor(NMaier.SimpleDlna.Server.HttpCode,System.Uri)")]
[assembly:
  SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type",
    Target = "NMaier.SimpleDlna.Server.Views.DimensionView")]
[assembly:
  SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMaps.#AllPN")]
[assembly:
  SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMaps.#AllPN")]
[assembly:
  SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMaps.#MainPN")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "AAC", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#AudioAAC")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FLAC", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#AudioFLAC")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "RAW", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#AudioRAW")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "VORBIS",
    Scope = "member", Target = "NMaier.SimpleDlna.Server.DlnaMime.#AudioVORBIS")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "GIF", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#ImageGIF")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "JPEG", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#ImageJPEG")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "PNG", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#ImagePNG")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SRT", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#SubtitleSRT")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "GPP", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#Video3GPP")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "AVC", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#VideoAVC")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "AVI", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#VideoAVI")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FLV", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#VideoFLV")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "MATROSKA",
    Scope = "member", Target = "NMaier.SimpleDlna.Server.DlnaMime.#VideoMKV")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "MPEG", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#VideoMPEG")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "OGV", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#VideoOGV")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "WMV", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#VideoWMV")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "UUID", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.IMediaServer.#UUID")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "MKV", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.DlnaMime.#VideoMKV")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "GENERAL",
    Scope = "member", Target = "NMaier.SimpleDlna.Server.Identifiers.#GENERAL_ROOT")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ROOT", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.Identifiers.#GENERAL_ROOT")]
[assembly:
  SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
    Target = "NMaier.SimpleDlna.Server.Identifiers.#GENERAL_ROOT")]
