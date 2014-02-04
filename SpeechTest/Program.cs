using System;
using System.Globalization;
using System.Speech.Synthesis;

namespace SpeechTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new Options();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                var syn = new SpeechSynthesizer();
                syn.SelectVoiceByHints(options.Gender, options.Age, 0, new CultureInfo(options.Culture));
                syn.Speak(options.Talk);
            }
        }
    }
}
