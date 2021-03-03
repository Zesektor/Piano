using System;
using System.Runtime.InteropServices;

namespace Piano
{
    class Program
    {
        static void Main(string[] args)
        {
            Key c = new Key(Note.C, Accidental.Sharp, Octave.First);
            Console.WriteLine(c); // C#

            Key d = new Key(Note.D, Accidental.Flat, Octave.First);
            Console.WriteLine(c.Equals(d));     // True
            Console.WriteLine(c.CompareTo(d));  // 0
        }
    }
}
