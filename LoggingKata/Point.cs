namespace LoggingKata
{
    public struct Point
    {
        public static object Location { get; internal set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}