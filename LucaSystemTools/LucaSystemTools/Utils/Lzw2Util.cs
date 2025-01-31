﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucaSystem {
    //from http://rosettacode.org/wiki/LZW_compression#C.23
    public class Lzw2Util {

        public static string Decompress(List<UInt16> compressed) {
            // build the dictionary
            int dictSize = 256;
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for (int i = 0; i < dictSize; i++) {
                dictionary.Add(i, ((char)i).ToString());
            }

            string characters = dictionary[compressed[0] / 2];
            //compressed.RemoveAt(0);
            StringBuilder decompressed = new StringBuilder();

            foreach (UInt16 k in compressed) {
                var code = k / 2;
                string entry = dictionary.ContainsKey(code) ? dictionary[code] :
                    characters + characters[0];

                decompressed.Append(entry);

                // new sequence; add it to the dictionary
                dictionary.Add(dictSize++, characters + entry[0]);
                characters = entry;
            }

            return decompressed.ToString();
        }

        public static List<int> Compress(string uncompressed) {
            // build the dictionary
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < 256; i++)
                dictionary.Add(((char)i).ToString(), i);
            dictionary.Add(((char)256).ToString(), 0);
            string w = string.Empty;
            List<int> compressed = new List<int>();
            foreach (char c in uncompressed) {
                string wc = w + c;
                if (dictionary.ContainsKey(wc)) {
                    w = wc;
                } else {
                    // write w to output
                    compressed.Add(dictionary[w]);
                    // wc is a new sequence; add it to the dictionary
                    dictionary.Add(wc, dictionary.Count);
                    w = c.ToString();
                }
            }
            // write remaining output if necessary
            if (!string.IsNullOrEmpty(w))
                compressed.Add(dictionary[w]);

            return compressed;
        }

        public static List<int> Compress(byte[] uncompressed) {
            // build the dictionary
            // build the dictionary
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < 256; i++)
                dictionary.Add((i + 256).ToString(), i);
            string w = string.Empty;
            List<int> compressed = new List<int>();

            foreach (byte c in uncompressed) {

                string wc = w + (c + 256).ToString();
                if (dictionary.ContainsKey(wc)) {
                    w = wc;
                } else {
                    // write w to output
                    compressed.Add(dictionary[w]);
                    // wc is a new sequence; add it to the dictionary
                    dictionary.Add(wc, dictionary.Count);
                    w = (c + 256).ToString();
                }
            }

            // write remaining output if necessary
            if (!string.IsNullOrEmpty(w))
                compressed.Add(dictionary[w]);

            return compressed;
        }
    }
}
