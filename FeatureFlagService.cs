using LaunchDarkly.Client;

namespace Commander
{
    public class FeatureFlagService
    {
        private static readonly User TemporaryUser = User.WithKey("temporary-user");
        private readonly ILdClient _ldClient;

        public FeatureFlagService(ILdClient ldClient)
        {
            _ldClient = ldClient;
        }

        public bool Has(string featureName) => this._ldClient.BoolVariation(featureName, TemporaryUser);
    }
}
