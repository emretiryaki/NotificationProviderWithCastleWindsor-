using System.ComponentModel;

namespace NotificationProviderWithCastleWindsor.Enums
{
    public enum ActivationType
    {
        [Description("Activation code sms in enrollment")]
        EnrollActivation = 1,
        [Description("Activation code sms in password change")]
        CustomerPasswordChangeActivation = 2,
        

    }
}