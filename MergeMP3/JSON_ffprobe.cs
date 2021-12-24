
using System.Text.Json.Serialization;

namespace MergeMP3
{
    public struct JSON_ffprobe
    {
        [JsonPropertyName("streams")]
        public JSON_ffprobe_stream[] Streams { get; set; }

        public string Duration => Streams[0].DurationText;

        public struct JSON_ffprobe_stream
        {
            [JsonPropertyName("duration")]
            public string Duration { get; set; }

            public string DurationText => TimeSpan.FromSeconds(double.Parse(Duration)).ToString("hh\\:mm\\:ss");
        }
    }
}
