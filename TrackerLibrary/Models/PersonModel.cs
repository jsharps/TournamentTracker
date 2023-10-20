namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The first name of the person.
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// The last name of the person.
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// The email address of the person.
        /// </summary>
        public string EmailAddress { get; set; } = string.Empty;

        /// <summary>
        /// The primary cell phone number of the person.
        /// </summary>
        public string CellphoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// The ID of the person.
        /// </summary>
        public int Id { get; set; }
    }
}