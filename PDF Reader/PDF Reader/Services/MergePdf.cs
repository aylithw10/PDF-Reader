using PDF_Reader.Models;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PDF_Reader.Services
{
    public class MergePdf : IMergePdf
    {
        public async Task<string> MergeFiles(FilesToMerge filesToMerge)
        {
            var mergedFile = UglyToad.PdfPig.Writer.PdfMerger.Merge(filesToMerge.StarterFile, filesToMerge.FileToAdd);

            await File.WriteAllBytesAsync($"{filesToMerge.SaveLocation}\\{filesToMerge.SaveName}", mergedFile);

            var newPdfName = $"{filesToMerge.SaveLocation}\\{filesToMerge.SaveName}";
            return newPdfName;
        }
    }
}
