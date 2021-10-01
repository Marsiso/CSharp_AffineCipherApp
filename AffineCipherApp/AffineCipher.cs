using System;
using System.Collections.Generic;
using System.Text;

namespace AffineCipherApp
{
    /// <summary>
    /// Static class providing methods and dictionaries for encrypting/decrypting using affine cipher.
    /// </summary>
    internal static class AffineCipher
    {
        /// <summary>
        /// Dictionary holding indexed characters ranging from letter A to Z.
        /// </summary>
        internal static readonly Dictionary<char, int> StdAlphabet;

        /// <summary>
        /// Dictionary holding indexed characters ranging from letter A to Z plus integers ranging from 0 to 9.
        /// </summary>
        internal static readonly Dictionary<char, int> ExtAlphabet;

        /// <summary>
        /// Inversion of keys and values of extended alphabet.
        /// </summary>
        internal static readonly Dictionary<int, char> InvAlphabet;

        /// <summary>
        /// Dictionary holding allowed characters and their projections used to filter user's input.
        /// </summary>
        internal static readonly Dictionary<char, char> ConversionDictionary;

        /// <summary>
        /// Dictionary holding chosen alphabets projections and theirs encrypted/decrypted characters used to encrypt/decrypt user's input.
        /// </summary>
        internal static Dictionary<char, char> AffineCipherDictionary;

        /// <summary>
        /// Holds and copy of an chosen alphabet's instance.
        /// </summary>
        private static Dictionary<char, int> _instance;

        /// <summary>
        /// Initializes core components before first usage needed for class to function properly.
        /// </summary>
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
                {'a', 'A'},
                {'A', 'A'},
                {'b', 'B'},
                {'B', 'B'},
                {'c', 'C'},
                {'C', 'C'},
                {'d', 'D'},
                {'D', 'D'},
                {'e', 'E'},
                {'E', 'E'},
                {'f', 'F'},
                {'F', 'F'},
                {'g', 'G'},
                {'G', 'G'},
                {'h', 'H'},
                {'H', 'H'},
                {'i', 'I'},
                {'I', 'I'},
                {'j', 'J'},
                {'J', 'J'},
                {'k', 'K'},
                {'K', 'K'},
                {'l', 'L'},
                {'L', 'L'},
                {'m', 'M'},
                {'M', 'M'},
                {'n', 'N'},
                {'N', 'N'},
                {'o', 'O'},
                {'O', 'O'},
                {'p', 'P'},
                {'P', 'P'},
                {'q', 'Q'},
                {'Q', 'Q'},
                {'r', 'R'},
                {'R', 'R'},
                {'s', 'S'},
                {'S', 'S'},
                {'t', 'T'},
                {'T', 'T'},
                {'u', 'U'},
                {'U', 'U'},
                {'v', 'V'},
                {'V', 'V'},
                {'w', 'W'},
                {'W', 'W'},
                {'x', 'X'},
                {'X', 'X'},
                {'y', 'Y'},
                {'Y', 'Y'},
                {'z', 'Z'},
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
                {'á', 'A'},
                {'Á', 'A'},
                {'č', 'C'},
                {'Č', 'C'},
                {'ď', 'D'},
                {'Ď', 'D'},
                {'é', 'E'},
                {'É', 'E'},
                {'ě', 'E'},
                {'Ě', 'E'},
                {'í', 'I'},
                {'Í', 'I'},
                {'ň', 'N'},
                {'Ň', 'N'},
                {'ó', 'O'},
                {'Ó', 'O'},
                {'ř', 'R'},
                {'Ř', 'R'},
                {'š', 'S'},
                {'Š', 'S'},
                {'ť', 'T'},
                {'Ť', 'T'},
                {'ú', 'U'},
                {'Ú', 'U'},
                {'ů', 'U'},
                {'Ů', 'U'},
                {'ý', 'Y'},
                {'Ý', 'Y'},
                {'ž', 'Z'},
                {'Ž', 'Z'}
            };
            AffineCipherDictionary = null;
            Instance = StdAlphabet;
        }

        /// <summary>
        /// Gets or sets chosen alphabet.
        /// </summary>
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

        /// <summary>
        /// Formats users input using conversion dictionary and decrypts its content using separate dictionary for decryption.
        /// </summary>
        /// <param name="input">Users input in form of string to be decrypted.</param>
        /// <returns>Decrypted and formatted input in form of string.</returns>
        internal static string FormatAndDecryptCipher(in string input)
        {
            var decrypted = new StringBuilder(capacity: 2000);
            foreach (var c in input)
            {
                if (Char.IsWhiteSpace(c)) continue;
                if (ConversionDictionary.TryGetValue(c, out char newValue))
                {
                    decrypted.Append(AffineCipherDictionary[newValue]);
                }
            }

            string temp = decrypted.ToString();
            string output = temp.Replace("XMEZERAX", " ");
            return output;
        }

        /// <summary>
        /// Formats users input using conversion dictionary and encrypts its content using separate dictionary for encryption.
        /// </summary>
        /// <param name="input">Users input in form of string to be encrypted.</param>
        /// <returns>Encrypted and formatted input in form of string.</returns>
        internal static string FormatAndEncryptOpenText(in string input)
        {
            var encrypted = new StringBuilder(capacity: 2000);
            for (int i = 0; i < input.Length; ++i)
            {
                if (i % 6 == 0) encrypted.Append(" ");
                if (ConversionDictionary.TryGetValue(input[i], out char newValue))
                {
                    encrypted.Append(AffineCipherDictionary[newValue]);
                    continue;
                }

                if (!Char.IsWhiteSpace(input[i])) continue;
                AppendEncryptedWhiteSpace(ref encrypted);
            }

            return encrypted.ToString();
        }

        /// <summary>
        /// Builds dictionary used for an encryption of users input.
        /// </summary>
        /// <param name="a">Ax + b mod m</param>
        /// <param name="b">ax + B mod m</param>
        /// <param name="m">ax + b mod M. GCD(a, m) must equal 1!!.</param>
        internal static void BuildEncryptionDictionary(int a, int b, int m)
        {
            AffineCipherDictionary = new Dictionary<char, char>();
            foreach (KeyValuePair<char, int> Letters in Instance)
            {
                AffineCipherDictionary.Add(Letters.Key, InvAlphabet[EncryptionMechanism(Letters.Value, ref a, ref b, ref m)]);
            }

            if (!ReferenceEquals(Instance, StdAlphabet)) return;
            AddNumbersAsChars();
        }

        /// <summary>
        /// Builds dictionary used for a decryption of users input based.
        /// </summary>
        /// <param name="a">Ax + b mod m</param>
        /// <param name="b">ax + B mod m</param>
        /// <param name="m">ax + b mod M. GCD(a, m) = 1</param>
        internal static void BuildDecryptionDictionary(int a, int b, int m)
        {
            AffineCipherDictionary = new Dictionary<char, char>();
            foreach (KeyValuePair<char, int> Letters in Instance)
            {
                AffineCipherDictionary.Add(Letters.Key, InvAlphabet[DecryptionMechanism(Letters.Value, ref a, ref b, ref m)]);
            }
            if (!ReferenceEquals(Instance, StdAlphabet)) return;
            AddNumbersAsChars();
        }

        /// <summary>
        /// Appends encrypted whitespace char to an already existent cipher.
        /// </summary>
        /// <param name="encrypted">Encrypted char whitespace</param>
        private static void AppendEncryptedWhiteSpace(ref StringBuilder encrypted)
        {
            encrypted.Append(AffineCipherDictionary['X']);
            encrypted.Append(AffineCipherDictionary['M']);
            encrypted.Append(AffineCipherDictionary['E']);
            encrypted.Append(AffineCipherDictionary['Z']);
            encrypted.Append(AffineCipherDictionary['E']);
            encrypted.Append(AffineCipherDictionary['R']);
            encrypted.Append(AffineCipherDictionary['A']);
            encrypted.Append(AffineCipherDictionary['X']);
        }

        /// <summary>
        /// Adds integers as chars ranging from 0 to 9 to an existing dictionary used for an encryption/decryption. Used together with standard alphabet.
        /// </summary>
        private static void AddNumbersAsChars()
        {
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

        /// <summary>
        /// Encrypts users input using affine cipher.
        /// </summary>
        /// <param name="input">Users input in form of an index of a char to be encrypted.</param>
        /// <param name="a">Ax + b mod m</param>
        /// <param name="b">ax + B mod m</param>
        /// <param name="m">ax + b mod M. GCD(a, m) = 1</param>
        /// <returns>Encrypted characters index to be used to instantiate encryption dictionary.</returns>
        private static int EncryptionMechanism(in int input, ref int a, ref int b, ref int m)
        {
            int temp = a * input + b;
            return Mod(ref temp, ref m);
        }

        /// <summary>
        /// Method providing math's modulo function implementation.
        /// </summary>
        /// <param name="left">Left operand of modulo.(dividend)</param>
        /// <param name="right">Right operand of modulo (divisor)</param>
        /// <returns>Reminder of number's division by divisor.</returns>
        private static int Mod(ref int left, ref int right)
        {
            int result = left % right;
            return result < 0
                ? result + right
                : result;
        }

        /// <summary>
        /// Decrypts users input using affine cipher.
        /// </summary>
        /// <param name="input">Users input in form of an index of a char to be decrypted.</param>
        /// <param name="a">Ax + b mod m</param>
        /// <param name="b">ax + B mod m</param>
        /// <param name="m">ax + b mod M. GCD(a, m) = 1</param>
        /// <returns>Decrypted characters index to be used to instantiate decryption dictionary.</returns>
        private static int DecryptionMechanism(in int input, ref int a, ref int b, ref int m)
        {
            int temp = (input - b) * a.ModInverse(m);
            return Mod(ref temp, ref m);
        }

        /// <summary>
        /// Implementation of math's inverse module.
        /// </summary>
        /// <returns>Module's inversion.</returns>
        private static int ModInverse(this int a, int m)
        {
            if (m == 1) return 0;
            int m0 = m;
            (int x, int y) = (1, 0);

            while (a > 1)
            {
                int q = a / m;
                (a, m) = (m, a % m);
                (x, y) = (y, x - q * y);
            }
            return x < 0
                ? x + m0
                : x;
        }
    }
}