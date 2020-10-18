using PDF_Reader.Models;
using System.Threading.Tasks;

namespace PDF_Reader.Services
{
    public interface IMergePdf
    {
        Task<string> MergeFiles(FilesToMerge filesToMerge);
    }
}
