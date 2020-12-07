using System;
using System.Collections;
using System.IO;

namespace HuffmansEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string:");
            string filePath = Console.ReadLine();
            HuffmanTree huffmanTree = new HuffmanTree();
            BinaryReader binaryReader = new BinaryReader(File.Open(filePath, FileMode.Open));
            string input = binaryReader.ReadString();
            // Build the Huffman tree
            huffmanTree.Build(input);

            // Encode
            BitArray encoded = huffmanTree.Encode(input);
            
            Console.Write("Encoded: ");
            foreach (bool bit in encoded)
            {
                Console.Write((bit ? 1 : 0) + "");
            }
            Console.WriteLine();

            // Decode
            string decoded = huffmanTree.Decode(encoded);

            Console.WriteLine("Decoded: " + decoded);

            Console.ReadLine();
        }
    }
}
