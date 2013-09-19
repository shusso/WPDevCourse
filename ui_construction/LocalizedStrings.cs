
namespace WP71Demo
{
    public class LocalizedStrings
    {
        /// <summary>
        /// Note that we do not need to specify the namespace when creating the instance
        /// </summary>
        private static AppResources localizedResources = new AppResources();

        /// <summary>
        /// Gets of AppResources class instance
        /// </summary>
        public AppResources AppResources
        {
            get { return localizedResources; }
        }
    }
}
