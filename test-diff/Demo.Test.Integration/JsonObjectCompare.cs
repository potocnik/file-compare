using FluentAssertions;
using Newtonsoft.Json.Linq;
using System.IO;
using Xunit;

namespace Demo.Test.Integration
{
    public class JsonObjectCompare
    {
        private const string FileAPath = "stub/fileA.json";
        private const string FileBPath = "stub/fileB.json";
        private const string FileCPath = "stub/fileC.json";

        [Fact]
        public void WhenFilesAreEqual_ShowsNoChanges()
        {
            var objectA = JObject.Parse(File.ReadAllText(FileAPath));
            var objectB = JObject.Parse(File.ReadAllText(FileBPath));
            objectB.Should().Equal(objectA);
        }

        [Fact]
        public void WhenFilesAreDifferent_ShowsChanges()
        {
            var objectA = JObject.Parse(File.ReadAllText(FileAPath));
            var objectC = JObject.Parse(File.ReadAllText(FileCPath));
            objectC.Should().NotBeSameAs(objectA);
        }
    }
}
