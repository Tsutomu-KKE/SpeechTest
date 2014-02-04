using CommandLine;
using CommandLine.Text;

namespace SpeechTest
{
    public class Options
    {
        [Option('l', "language", Required = true, HelpText = "Language of the speaker, for example 'ja-JP, Haruka'")]
        public string Language { get; set; }

        [Option('s', "speak", Required = true, HelpText = "Phrase to speak , example : こんにちは")]
        public string Speak { get; set; }

        [Option('v', "verbose", DefaultValue = true, HelpText = "Prints all messages to standard output.")]
        public bool Verbose { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
              (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
