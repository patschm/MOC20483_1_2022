namespace Extensibilty
{
    public static class AllExtensions
    {
        public static string SponsoredBy(this object s, string sponsorName)
        {
            return $"(Sponsored by {sponsorName}) {s}";
        }
    }
}