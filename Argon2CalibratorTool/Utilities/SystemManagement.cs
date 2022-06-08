using System;

namespace Argon2CalibratorTool.Utilities
{
    public static class SystemManagement
    {
        public static int GetTotalCpuCores()
        {
            return Environment.ProcessorCount;
        }
    }
}
