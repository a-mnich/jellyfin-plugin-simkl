using System;
using System.Text.Json.Serialization;
using MediaBrowser.Model.Dto;
#pragma warning disable SA1300

namespace Jellyfin.Plugin.Simkl.API.Objects
{
    /// <summary>
    /// Simkl episode container.
    /// </summary>
    public class SimklEpisode : SimklMediaObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimklEpisode"/> class.
        /// </summary>
        /// <param name="media">Episode Data.</param>
        public SimklEpisode(BaseItemDto media)
        {
            Title = media?.SeriesName;
            Ids = media is not null ? new SimklIds(media.ProviderIds) : null;
            Year = media?.ProductionYear;
            Season = media?.ParentIndexNumber;
            Episode = media?.IndexNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimklEpisode"/> class for JSON serialization.
        /// </summary>
        /// <param name="watchedAt">The date and time the episode was watched.</param>
        /// <param name="title">The title of the episode.</param>
        /// <param name="year">The year the episode was produced.</param>
        /// <param name="season">The season number of the episode.</param>
        /// <param name="episode">The episode number within the season.</param>
        /// <param name="multipart">Indicates if the episode is multipart.</param>
        /// <param name="ids">The provider IDs for the episode.</param>
        [JsonConstructor]
        public SimklEpisode(DateTime? watchedAt, string? title, int? year, int? season, int? episode, bool? multipart, SimklIds? ids)
        {
            WatchedAt = watchedAt;
            Title = title;
            Year = year;
            Season = season;
            Episode = episode;
            Multipart = multipart;
            Ids = ids;
        }

        /// <summary>
        /// Gets or sets watched at.
        /// </summary>
        [JsonPropertyName("watched_at")]
        public DateTime? WatchedAt { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonPropertyName("year")]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or sets the season.
        /// </summary>
        [JsonPropertyName("season")]
        public int? Season { get; set; }

        /// <summary>
        /// Gets or sets the episode.
        /// </summary>
        [JsonPropertyName("episode")]
        public int? Episode { get; set; }

        /// <summary>
        /// Gets or sets multipart.
        /// </summary>
        [JsonPropertyName("multipart")]
        public bool? Multipart { get; set; }
    }
}