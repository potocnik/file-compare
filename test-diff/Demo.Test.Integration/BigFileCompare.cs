using FluentAssertions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using Xunit;

namespace Demo.Test.Integration
{
    public class BigFileCompare
    {
        private const string FileAPath = "stub/bigFileA.json";
        private const string FileBPath = "stub/bigFileB.json";
        private const string FileCPath = "stub/bigFileC.json";

        [Fact]
        public void WhenFilesAreEqual_ShowsNoChanges()
        {
            var objectA = JsonConvert.DeserializeObject(File.ReadAllText(FileAPath));
            var objectB = JsonConvert.DeserializeObject(File.ReadAllText(FileBPath));
            objectB.Should().BeEquivalentTo(objectA);
        }

        [Fact]
        public void WhenFilesAreDifferent_ShowsChanges()
        {
            var objectA = JsonConvert.DeserializeObject(File.ReadAllText(FileAPath));
            var objectC = JsonConvert.DeserializeObject(File.ReadAllText(FileCPath));
            objectC.Should().NotBe(objectA);
        }
    }
}
