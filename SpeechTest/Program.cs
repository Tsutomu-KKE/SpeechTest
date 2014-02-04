using System;

namespace SpeechTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new Options();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                if (options.Language != null && options.Speak != null)
                {
                    var syn = new System.Speech.Synthesis.SpeechSynthesizer();
                    syn.SelectVoice(String.Format("Microsoft Server Speech Text to Speech Voice ({0})", options.Language));
                    syn.Speak(options.Speak);
                }
            }
        }
    }
}
