using System;

namespace PhotoManiaPro
{
    struct FileSize
    {
        public double Size;
        public string Suffix;

        public FileSize(double size, string suffix)
        {
            this.Size = size;
            this.Suffix = suffix;
        }
    }

    class FileSizeSuffixRetriever
    {
        public static FileSize GetSuffix(long fileSize)
        {
            FileSize size;
            if (fileSize < 1000)
            {
                size = new FileSize(fileSize, "Bytes");
                return size;
            }
            else if (fileSize < 1022976)
            {
                size = new FileSize(Convert.ToDouble(fileSize / 1024.0), "KBytes");
                return size;
            }
            else
            {
                size = new FileSize(Convert.ToDouble(fileSize / (1024 * 1024.0)), "MBytes");
                return size;
            }
        }
    }
}
