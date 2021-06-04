using FluentAssertions;
using System.IO;
using Xunit;

namespace Demo.Test.Integration
{
    public class SimpleCompare
    {
        private const string JsonAPath = "stub/fileA.json";
        private const string JsonBPath = "stub/fileB.json";
        private const string JsonCPath = "stub/fileC.json";

        private const string XmlAPath = "stub/fileA.xml";
        private const string XmlBPath = "stub/fileB.xml";
        private const string XmlCPath = "stub/fileC.xml";

        [Fact]
        public void WhenJsonFilesAreEqual_ShowsNoChanges()
        {
            var contentA = File.ReadAllText(JsonAPath);
            var contentB = File.ReadAllText(JsonBPath);
            contentB.Should().Be(contentA);
        }

        [Fact]
        public void WhenJsonFilesAreDifferent_ShowsChanges()
        {
            var contentA = File.ReadAllText(JsonAPath);
            var contentC = File.ReadAllText(JsonCPath);
            contentC.Should().NotBe(contentA);
        }

        [Fact]
        public void WhenXmlFilesAreEqual_ShowsNoChanges()
        {
            var contentA = File.ReadAllText(XmlAPath);
            var contentB = File.ReadAllText(XmlBPath);
            contentB.Should().Be(contentA);
        }

        [Fact]
        public void WhenXmlFilesAreDifferent_ShowsChanges()
        {
            var contentA = File.ReadAllText(JsonAPath);
            var contentC = File.ReadAllText(XmlCPath);
            contentC.Should().NotBe(contentA);
        }
    }
}
