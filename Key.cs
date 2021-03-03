using System;

namespace Piano
{
    public enum Note { C = 1, D = 2, E = 3, F = 4, G = 5, A = 6, B = 7 }
    public enum Accidental { NoAlt = 0, Sharp = 1, Flat = -1 }
    public enum Octave { SubCountr = 2, Countr = 9, Big = 16, Small = 23, First = 30, Second = 37, Third = 44, Fourth = 51, Fifth = 58 }
    public struct Key : IComparable<Key>
    {
        public Note Note { get; set; }
        public Accidental Accidental { get; set; }
        public Octave Octave { get; set; }
        private double numberOfKey;
        public Key(Note note, Accidental accidental, Octave octave)
        {
            Note = note;
            Octave = octave;
            Accidental = accidental;
            numberOfKey = (int)Octave - (int)Note - (0.5 * (int)Accidental);
        }
        public override string ToString()
        {
            var alt = string.Empty;
            if (Accidental == Accidental.Sharp) alt = "#";
            else if (Accidental == Accidental.Flat) alt = "b";
            return (1 < numberOfKey && numberOfKey <= 52) ? $"{Note.ToString()}{alt}" : "Key don't exist!";
        }

        public override bool Equals(object obj)
        {
            if (obj is Key key)
                return Equals(key);
            return false;
        }

        public bool Equals(Key key)
        {
            return CompareTo(key) == 0;
        }

        public override int GetHashCode() => (int)numberOfKey * 10;

        public int CompareTo(Key key)
        {
            if (numberOfKey > key.numberOfKey) return -1;
            return numberOfKey < key.numberOfKey ? 1 : 0;
        }
    }
}

