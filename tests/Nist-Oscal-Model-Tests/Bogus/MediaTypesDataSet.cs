using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bogus;
using Bogus.Premium;

namespace Nist.Oscal.Tests.Bogus
{
    public static class MediaTypeExtensions
    {
        public static MediaTypes MediaTypes(this Faker faker)
        {
            return ContextHelper.GetOrSet(faker, () => new MediaTypes());
        }
    }

    public class MediaTypes : DataSet
    {
        public string MediaType() => Random.ListItem(mediaTypes.Select(m => m.Key).ToList()).Trim();
        public string FileExtension() => Random.ListItem(mediaTypes.SelectMany(m => m.Value).ToList());
        public string FileExtension(string mediaType)
        {
            if (string.IsNullOrEmpty(mediaType) == false 
             && mediaTypes.TryGetValue(mediaType, out var values))
            {
                return Random.ListItem(values.ToList());
            } else
            {
                return FileExtension();
            }
        }

        private static readonly Dictionary<string, IEnumerable<string>> mediaTypes = new Dictionary<string, IEnumerable<string>>
        { 
            { "application/x-executable", new [] { ".exe", ".bat", ".cmd", ".msi", "" }},
            { "application/graphql", new[] { ".graphql" }},
            { "application/javascript", new[] { ".js" }},
            { "application/json", new[] { ".json" }},
            { "application/ld+json", new[] { ".json" }},
            { "application/feed+json", new[] { ".json" }},
            { "application/msword", new[] { ".doc", ".docx", ".docm" }},
            { "application/pdf", new[] { ".pdf" }},
            { "application/sql", new[] { ".sql" }},
            { "application/vnd.api+json", new[] { ".json" }},
            { "application/vnd.ms-excel", new[] { ".xls", ".xslm", ".xslx" }},
            { "application/vnd.ms-powerpoint", new[] { ".ppt", ".pptx" }},
            { "application/vnd.oasis.opendocument.text", new[] { ".odt", ".fodt" }},
            { "application/vnd.openxmlformats-officedocument.presentationml.presentation", new[] { ".pptx" }},
            { "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", new[] { ".xlsx" }},
            { "application/vnd.openxmlformats-officedocument.wordprocessingml.document", new[] { ".docx" }},
            { "application/x-www-form-urlencoded", new[] { "" }},
            { "application/xml", new[] { ".xml" }},
            { "application/zip", new[] { ".zip" }},
            { "application/zstd ", new[] { ".zstd" }},
            { "application/macbinary", new[] { ".bin" }},
            { "audio/mpeg", new[] { ".mpeg" }},
            { "audio/ogg", new[] { ".ogg" }},
            { "image/apng", new[] { ".apng" }},
            { "image/avif", new[] { ".avif" }},
            { "image/flif", new[] { ".flif" }},
            { "image/gif", new[] { ".gif" }},
            { "image/jpeg", new[] { ".jpeg" }},
            { "image/jxl", new[] { ".jxl" }},
            { "image/png", new[] { ".png" }},
            { "image/svg+xml", new[] { ".svg", ".svgz" }},
            { "image/webp", new[] { ".webp" }},
            { "image/x-mng", new[] { ".mng" }},
            { "multipart/form-data", new[] { "" }},
            { "text/css", new[] { ".css" }},
            { "text/csv", new[] { ".csv" }},
            { "text/html", new[] { ".html", ".htm" }},
            { "text/php", new[] { ".php" }},
            { "text/plain", new[] { ".txt", ".text" }},
            { "text/xml", new[] { ".xml" }},
        };
    }
}
