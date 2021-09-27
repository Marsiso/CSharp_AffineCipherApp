using System;
using System.Collections.Generic;
using System.Text;

namespace AffineCipherApp
{
    internal static class AffineCipher
    {
        internal static readonly Dictionary<char, int> StdAlphabet;
        internal static readonly Dictionary<char, int> ExtAlphabet;
        internal static readonly Dictionary<int, char> InvAlphabet;
        internal static readonly Dictionary<char, char> ConversionDictionary;
        internal static Dictionary<char, char> AffineCipherDictionary;
        private static Dictionary<char, int> _instance;

        static AffineCipher()
        {
            StdAlphabet = new Dictionary<char, int>
            {
                {'A', 0},
                {'B', 1},
                {'C', 2},
                {'D', 3},
                {'E', 4},
                {'F', 5},
                {'G', 6},
                {'H', 7},
                {'I', 8},
                {'J', 9},
                {'K', 10},
                {'L', 11},
                {'M', 12},
                {'N', 13},
                {'O', 14},
                {'P', 15},
                {'Q', 16},
                {'R', 17},
                {'S', 18},
                {'T', 19},
                {'U', 20},
                {'V', 21},
                {'W', 22},
                {'X', 23},
                {'Y', 24},
                {'Z', 25}
            };
            ExtAlphabet = new Dictionary<char, int>
            {
                {'A', 0},
                {'B', 1},
                {'C', 2},
                {'D', 3},
                {'E', 4},
                {'F', 5},
                {'G', 6},
                {'H', 7},
                {'I', 8},
                {'J', 9},
                {'K', 10},
                {'L', 11},
                {'M', 12},
                {'N', 13},
                {'O', 14},
                {'P', 15},
                {'Q', 16},
                {'R', 17},
                {'S', 18},
                {'T', 19},
                {'U', 20},
                {'V', 21},
                {'W', 22},
                {'X', 23},
                {'Y', 24},
                {'Z', 25},
                {'0', 26},
                {'1', 27},
                {'2', 28},
                {'3', 29},
                {'4', 30},
                {'5', 31},
                {'6', 32},
                {'7', 33},
                {'8', 34},
                {'9', 35}
            };
            InvAlphabet = new Dictionary<int, char>
            {
                {0, 'A'},
                {1, 'B'},
                {2, 'C'},
                {3, 'D'},
                {4, 'E'},
                {5, 'F'},
                {6, 'G'},
                {7, 'H'},
                {8, 'I'},
                {9, 'J'},
                {10, 'K'},
                {11, 'L'},
                {12, 'M'},
                {13, 'N'},
                {14, 'O'},
                {15, 'P'},
                {16, 'Q'},
                {17, 'R'},
                {18, 'S'},
                {19, 'T'},
                {20, 'U'},
                {21, 'V'},
                {22, 'W'},
                {23, 'X'},
                {24, 'Y'},
                {25, 'Z'},
                {26, '0'},
                {27, '1'},
                {28, '2'},
                {29, '3'},
                {30, '4'},
                {31, '5'},
                {32, '6'},
                {33, '7'},
                {34, '8'},
                {35, '9'}
            };
            ConversionDictionary = new Dictionary<char, char>()
            {
                {'A', 'A'},
                {'B', 'B'},
                {'C', 'C'},
                {'D', 'D'},
                {'E', 'E'},
                {'F', 'F'},
                {'G', 'G'},
                {'H', 'H'},
                {'I', 'I'},
                {'J', 'J'},
                {'K', 'K'},
                {'L', 'L'},
                {'M', 'M'},
                {'N', 'N'},
                {'O', 'O'},
                {'P', 'P'},
                {'Q', 'Q'},
                {'R', 'R'},
                {'S', 'S'},
                {'T', 'T'},
                {'U', 'U'},
                {'V', 'V'},
                {'W', 'W'},
                {'X', 'X'},
                {'Y', 'Y'},
                {'Z', 'Z'},
                {'0', '0'},
                {'1', '1'},
                {'2', '2'},
                {'3', '3'},
                {'4', '4'},
                {'5', '5'},
                {'6', '6'},
                {'7', '7'},
                {'8', '8'},
                {'9', '9'},
                {'Á', 'A'},
                {'Č', 'C'},
                {'Ď', 'D'},
                {'É', 'E'},
                {'Ě', 'E'},
                {'Í', 'I'},
                {'Ň', 'N'},
                {'Ó', 'O'},
                {'Ř', 'R'},
                {'Š', 'S'},
                {'Ť', 'T'},
                {'Ú', 'U'},
                {'Ů', 'U'},
                {'Ý', 'Y'},
                {'Ž', 'Z'}
            };
            AffineCipherDictionary = null;
            Instance = StdAlphabet;
        }

        internal static Dictionary<char, int> Instance
        {
            get => _instance;
            set
            {
                if (!ReferenceEquals(_instance, value))
                {
                    _instance = value;
                }
            }
        }

        internal static string FormatTextAndDecrypt(in string input)
        {
            var decrypted = new StringBuilder(capacity: 2000);
            foreach (var c in input)
            {
                //TODO remove char.toupper
                if (Char.IsWhiteSpace(c)) continue;
                if (ConversionDictionary.TryGetValue(Char.ToUpper(c), out char newValue))
                {
                    decrypted.Append(AffineCipherDictionary[newValue]);
                }
            }

            string temp = decrypted.ToString();
            string output = temp.Replace("XMEZERAX", " ");
            return output;
        }

        internal static string FormatTextAndEncrypt(in string input)
        {
            var encrypted = new StringBuilder(capacity: 2000);
            foreach (var c in input)
            {
                //TODO remove char.toupper
                if (ConversionDictionary.TryGetValue(Char.ToUpper(c), out char newValue))
                {
                    encrypted.Append(AffineCipherDictionary[newValue]);
                    continue;
                }

                if (!Char.IsWhiteSpace(c)) continue;
                encrypted.Append(AffineCipherDictionary['X']);
                encrypted.Append(AffineCipherDictionary['M']);
                encrypted.Append(AffineCipherDictionary['E']);
                encrypted.Append(AffineCipherDictionary['Z']);
                encrypted.Append(AffineCipherDictionary['E']);
                encrypted.Append(AffineCipherDictionary['R']);
                encrypted.Append(AffineCipherDictionary['A']);
                encrypted.Append(AffineCipherDictionary['X']);
            }
            //TODO optimeze with readonlyspan
            string output = encrypted.ToString();
            for (int i = 5; i < output.Length; i += 6)
            {
                output = output.Insert(i, " ");
            }
            return output;
        }

        internal static void BuildEncryptionDictionary(int a, int b, int m)
        {
            AffineCipherDictionary = new Dictionary<char, char>();
            foreach (KeyValuePair<char, int> Letters in Instance)
            {
                AffineCipherDictionary.Add(Letters.Key, InvAlphabet[EncryptionMechanism(Letters.Value, ref a, ref b, ref m)]);
            }

            if (!ReferenceEquals(Instance, StdAlphabet)) return;
            AffineCipherDictionary.Add('0', '0');
            AffineCipherDictionary.Add('1', '1');
            AffineCipherDictionary.Add('2', '2');
            AffineCipherDictionary.Add('3', '3');
            AffineCipherDictionary.Add('4', '4');
            AffineCipherDictionary.Add('5', '5');
            AffineCipherDictionary.Add('6', '6');
            AffineCipherDictionary.Add('7', '7');
            AffineCipherDictionary.Add('8', '8');
            AffineCipherDictionary.Add('9', '9');
        }

        internal static void BuildDecryptionDictionary(int a, int b, int m)
        {
            AffineCipherDictionary = new Dictionary<char, char>();
            foreach (KeyValuePair<char, int> Letters in Instance)
            {
                AffineCipherDictionary.Add(Letters.Key, InvAlphabet[DecryptionMechanism(Letters.Value, ref a, ref b, ref m)]);
            }
            if (!ReferenceEquals(Instance, StdAlphabet)) return;
            AffineCipherDictionary.Add('0', '0');
            AffineCipherDictionary.Add('1', '1');
            AffineCipherDictionary.Add('2', '2');
            AffineCipherDictionary.Add('3', '3');
            AffineCipherDictionary.Add('4', '4');
            AffineCipherDictionary.Add('5', '5');
            AffineCipherDictionary.Add('6', '6');
            AffineCipherDictionary.Add('7', '7');
            AffineCipherDictionary.Add('8', '8');
            AffineCipherDictionary.Add('9', '9');
        }

        private static int EncryptionMechanism(in int input, ref int a, ref int b, ref int m)
        {
            int encryptedVal = a * input + Mod(ref b, ref m);
            if (encryptedVal < m) return encryptedVal;
            encryptedVal %= m;
            return encryptedVal;
        }

        private static int Mod(ref int left, ref int right)
        {
            int result = left % right;
            return result < 0
                ? result + right
                : result;
        }

        private static int DecryptionMechanism(in int input, ref int a, ref int b, ref int m)
        {
            int temp = (input - b) * ModInverse(a, m);
            return Mod(ref temp, ref m);
        }

        private static int ModInverse(int left, int right)
        {
            int m0 = right;
            int y = 0, x = 1;

            if (right == 1)
                return 0;

            while (left > 1)
            {
                int q = left / right;
                int t = right;

                right = left % right;
                left = t;
                t = y;

                y = x - q * y;
                x = t;
            }

            if (x < 0)
                x += m0;

            return x;
        }
    }
}