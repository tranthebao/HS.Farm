using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Farm.Authentication.TwoFactor.Google
{
    public class GoogleAuthenticatorSetupCode
    {
        public string Account { get; internal set; }
        public string SecrectKey { get; internal set; }
        public string ManualEntryKey { get; internal set; }
        public string QrCodeSetupImageUrl { get; internal set; }
    }
}
