using System.IO;

namespace NMaier.SimpleDlna.FileMediaServer.Files
{
  internal class FilePicture : IPicture
  {
    private readonly FileInfo PictureFile;
    private byte[] fileContent;

    internal FilePicture(FileInfo source)
    {
      PictureFile = source;
    }

    public string MimeType
    {
      get => "image/jpeg";
      set { }
    }

    public PictureType Type
    {
      get => PictureType.FrontCover;
      set { }
    }

    public string Description
    {
      get => "thumbnail";
      set { }
    }

    public ByteVector Data
    {
      get
      {
        if (fileContent == null) fileContent = File.ReadAllBytes(PictureFile.FullName);
        return new ByteVector(fileContent);
      }
      set { }
    }
  }
}
