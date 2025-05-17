namespace AkademiqNetRapidApi.Models
{
    public class RootTastyApi
    {
        public List<TastyViewModel> Results { get; set; }
    }

    public class TastyViewModel
    {
        public string name { get; set; }
        public string thumbnail_url { get; set; }
        public string original_video_url { get; set; }
    }
}
