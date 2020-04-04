namespace MAVN.Service.Dictionaries.Client.Models.Notifications
{
    /// <summary>
    /// Represents a model that contains additional information for all emails
    /// </summary>
    public class CommonInformationPropertiesModel
    {
        /// <summary>
        /// Represents information for support's phone number
        /// </summary>
        public string SupportPhoneNumber { get; set; }

        /// <summary>
        ///  Represents information for Facebook page link
        /// </summary>
        public string FacebookLink { get; set; }

        /// <summary>
        ///  Represents information for Twitter page link
        /// </summary>
        public string TwitterLink { get; set; }

        /// <summary>
        ///  Represents information for Instagram page link
        /// </summary>
        public string InstagramLink { get; set; }

        /// <summary>
        ///  Represents information for LinkedIn page link
        /// </summary>
        public string LinkedInLink { get; set; }

        /// <summary>
        ///  Represents information for YouTube page link
        /// </summary>
        public string YouTubeLink { get; set; }

        /// <summary>
        ///  Represents information for Download Page Link
        /// </summary>
        public string DownloadAppLink { get; set; }

        /// <summary>
        ///  Represents information for Terms And Conditions page link
        /// </summary>
        public string TermsAndConditionLink { get; set; }
        
        /// <summary>
        ///  Represents information for Privacy and Policy page link
        /// </summary>
        public string PrivacyPolicyLink { get; set; }

        /// <summary>
        ///  Represents information for unsubscribe Link
        /// </summary>
        public string UnsubscribeLink { get; set; }

        /// <summary>
        /// Represents android download link
        /// </summary>
        public string DownloadAndroidAppLink { get; set; }

        /// <summary>
        /// Represents iso download link
        /// </summary>
        public string DownloadIsoAppLink { get; set; }

        /// <summary>
        /// Represents default support email
        /// </summary>
        public string SupportEmailAddress { get; set; }
    }
}
