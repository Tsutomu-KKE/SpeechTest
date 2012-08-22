using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Speech.Synthesis;

namespace SpeechTest
{
	class Program
	{
		static void Main(string[] args)
		{
var syn = new System.Speech.Synthesis.SpeechSynthesizer();
syn.SelectVoice("Microsoft Server Speech Text to Speech Voice (ja-JP, Haruka)");
syn.Speak("こんにちは");
		}
	}
}
