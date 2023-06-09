namespace TrackerLibrary
{
	public class PrizeModel
	{
        public int PlaceNumber { get; set; }
		public string PlaceName { get; set; } = string.Empty;
		public decimal PrizeAmount { get; set; }
		public decimal PricePercentage { get; set; }
	}
}