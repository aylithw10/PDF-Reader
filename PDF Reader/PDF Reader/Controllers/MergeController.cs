using Microsoft.AspNetCore.Mvc;
using PDF_Reader.Models;
using PDF_Reader.Services;
using System.Threading.Tasks;

namespace PDF_Reader.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MergeController : ControllerBase
    {
        private IMergePdf _mergePdf;
        public MergeController(IMergePdf mergePdf)
        {
            _mergePdf = mergePdf;
        }
        public async Task<IActionResult> MergePdfFiles(FilesToMerge filesToMerge)
        {
            var mergedFile = await _mergePdf.MergeFiles(filesToMerge);
            return Ok(mergedFile);
        }
    }
}
