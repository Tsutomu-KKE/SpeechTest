using System.Globalization;
using System.Speech.Synthesis;
using CommandLine;
using CommandLine.Text;

namespace SpeechTest
{
    public class Options
    {
        [Option('g', "gender", Required = true, HelpText = "Male or Female speaker, for example Male, Female")]
        public VoiceGender Gender { get; set; }

        [Option('a', "age", Required = true, HelpText = "Age group of the speaker, for example Adult, Child, Senior, Teen")]
        public VoiceAge Age { get; set; }

        [Option('c', "culture", Required = true, HelpText = "Culture language of the speaker, for example en-US, el-GR, ja-JP")]
        public string Culture { get; set; }

        [Option('t', "talk", Required = true, HelpText = "Phrase to speak , example : \"Hello my name is Mr Speech\"")]
        public string Talk { get; set; }

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
