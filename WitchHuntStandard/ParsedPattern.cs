using System;

namespace WitchHuntStandard
{
    public ref struct ParsedPattern
    {
        public Span<byte> BytesToSearch;

        public Span<byte> Mask;

        public Span<string> PostPattern;
    }
}