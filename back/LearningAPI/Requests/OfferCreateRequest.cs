namespace LearningAPI.Requests
{
    public class OfferCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Photo { get; set; }
    }
}
