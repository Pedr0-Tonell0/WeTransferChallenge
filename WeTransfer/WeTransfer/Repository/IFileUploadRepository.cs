using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeTransfer.Repository
{
    public interface IFileUploadRepository
    {
        string CreateFile(ViewModel.VMFileUpload File);
        IEnumerable<Models.Socios> ReadFile(string PathFile);
    }
}
