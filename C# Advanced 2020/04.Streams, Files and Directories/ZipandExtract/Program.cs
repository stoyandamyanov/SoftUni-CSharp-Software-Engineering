using System;
using System.IO.Compression;

namespace ZipandExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory("../../../copyMe","../../../myArchive.zip");

            ZipFile.ExtractToDirectory("../../../myArchive.zip", "../../../");
        }
    }
}
