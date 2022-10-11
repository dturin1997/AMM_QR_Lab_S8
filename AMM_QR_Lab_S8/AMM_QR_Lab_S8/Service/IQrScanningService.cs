using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AMM_QR_Lab_S8.Service
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();

    }
}
