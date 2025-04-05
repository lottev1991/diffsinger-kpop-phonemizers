using System.Collections.Generic;
using OpenUtau.Api;
using OpenUtau.Core.G2p;
using OpenUtau.Core.Ustx;
using static OpenUtau.Core.KoreanPhonemizerUtil;

namespace OpenUtau.Core.DiffSinger {
    /// <summary>
    /// A DiffSinger phonemizer which can easily combine Korean and English on one track, while applying Korean sandhi rules on Hangeul lyrics.
    /// This is the "basic" version of the phonemizer, using the original ARPABET G2P.
    /// Special thanks to EX3.
    /// </summary>
    [Phonemizer("DiffSinger K-POP Phonemizer (ARPABET Basic)", "DIFFS KO+EN", "Lotte V")]
    public class DiffSingerKPopPhonemizerBasic : DiffSingerG2pPhonemizer {
        protected override string GetDictionaryName() => "dsdict-ko+en.yaml";
        protected override string GetLangCode() => "en"; // Had to pick one unfortunately. I picked English because it needs phonetic hints more often.
        protected override IG2p LoadBaseG2p() => new ArpabetG2p();
        protected override string[] GetBaseG2pVowels() => new string[] {
            "aa", "ae", "ah", "ao", "aw", "ay", "eh", "er",
            "ey", "ih", "iy", "ow", "oy", "uh", "uw"
        };

        protected override string[] GetBaseG2pConsonants() => new string[] {
            "b", "ch", "d", "dh", "f", "g", "hh", "jh", "k", "l", "m", "n",
            "ng", "p", "r", "s", "sh", "t", "th", "v", "w", "y", "z", "zh"
        };

        public override void SetUp(Note[][] groups, UProject project, UTrack track) {
            if (groups.Length == 0) {
                return;
            }
            // variate lyrics 
            RomanizeNotes(groups, false);

            //Split song into sentences (phrases)
            var phrase = new List<Note[]> { groups[0] };
            for (int i = 1; i < groups.Length; ++i) {
                //If the previous and current notes are connected, do not split the sentence
                if (groups[i - 1][^1].position + groups[i - 1][^1].duration == groups[i][0].position) {
                    phrase.Add(groups[i]);
                } else {
                    //If the previous and current notes are not connected, process the current sentence and start the next sentence
                    ProcessPart(phrase.ToArray());
                    phrase.Clear();
                    phrase.Add(groups[i]);
                }
            }
            if (phrase.Count > 0) {
                ProcessPart(phrase.ToArray());
            }
        }
    }
}
