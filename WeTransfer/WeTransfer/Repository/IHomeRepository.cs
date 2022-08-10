using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeTransfer.Repository
{
    public interface IHomeRepository
    {
        void AddSocio(IEnumerable<Models.Socios> socios);
        int GetCantidadSocios();
        double GetPromedioSociosRacing();
        List<Models.Socios> GetTop100();
        List<Models.Socios> GetTop5();
        List<ViewModel.VMSocios> GetUltimoPunto();

    }

}
