namespace TrackerLibrary
{
	public class PrizeModel
	{
		/// <summary>
		/// The unique identifier for the prize.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// The number identifier for the place (2 for second place, etc)
		/// </summary>
        public int PlaceNumber { get; set; }

		/// <summary>
		/// THe friendly name for the place (second place, first running up, etc.)
		/// </summary>
		public string PlaceName { get; set; } = string.Empty;

		/// <summary>
		/// The fixed amount this place earns or zero if it is not used.
		/// </summary>
		public decimal PrizeAmount { get; set; }

		/// <summary>
		/// The number that receprsents the perctage of the overall take
		/// or zero if it is not user. The percentage is a fraction of (so 0.5 for 50%)
		/// </summary>
		public decimal PricePercentage { get; set; }
	}
}