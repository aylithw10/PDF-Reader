using PDF_Reader.Models;
using System.Threading.Tasks;

namespace PDF_Reader.Services
{
    public class MergePdf : IMergePdf
    {
        public async Task<string> MergeFiles(FilesToMerge filesToMerge)
        {            
            var newPdfName = $"{filesToMerge.SaveLocation}\\{filesToMerge.SaveName}.pdf";
            return newPdfName;
        }
    }
}
