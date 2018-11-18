using Microsoft.AspNetCore.ResponseCompression;
using System.IO;
using System.IO.Compression;

namespace wowapi.Entities.Models.ThirdParty
{
    public class BrotliCompressionProvider : ICompressionProvider {

    public string EncodingName => "br";

    public bool SupportsFlush => true;

    public Stream CreateStream(Stream outputStream) => new System.IO.Compression.BrotliStream(outputStream, CompressionMode.Compress);

}
}