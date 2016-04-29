using System;

namespace GameKnotDecoder
{
    public class ChessMove
    {
        private string _from;
        public string From {
            get
            {
                return _from;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid value passed to From");
                }
                else
                {
                    _from = value;
                }
            }
        }

        public string To { get; set; }

        public ChessMove(string from, string to)
        {
            From = from;
            To = to;
        }
    }
}
