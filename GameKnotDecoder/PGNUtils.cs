using System;
using System.Collections.Generic;
using System.Text;

namespace GameKnotDecoder
{
    public static class PGNUtils
    {
        private const string TagBracketLeft = "[";
        private const string TagBracketRight = "]";

        public static string ExtractPGNFromScript(string script)
        {
            string pgn;

            pgn = ExportSTR() + 
                "\n" + 
                ExportMovesAsPGN(script);
            return pgn;
        }

        public static string ExportSTR()
        {
            return ExportEvent("") + "\n" +
                   ExportSite("") + "\n" +
                   ExportDate("") + "\n" +
                   ExportRound("") + "\n" +
                   ExportWhite("") + "\n" +
                   ExportBlack("") + "\n" +
                   ExportResult("") + "\n";
        }

        public static string ExportEvent(string evnt)
        {
            return TagBracketLeft + "Event \"Unknown\"" + TagBracketRight;
        }

        public static string ExportSite(string evnt)
        {
            return TagBracketLeft + "Site \"Unknown\"" + TagBracketRight;
        }

        public static string ExportDate(string evnt)
        {
            return TagBracketLeft + "Date \"Unknown\"" + TagBracketRight;
        }

        public static string ExportRound(string evnt)
        {
            return TagBracketLeft + "Round \"Unknown\"" + TagBracketRight;
        }

        public static string ExportWhite(string evnt)
        {
            return TagBracketLeft + "White \"Unknown\"" + TagBracketRight;
        }

        public static string ExportBlack(string evnt)
        {
            return TagBracketLeft + "Black \"Unknown\"" + TagBracketRight;
        }

        public static string ExportResult(string evnt)
        {
            return TagBracketLeft + "Result \"Unknown\"" + TagBracketRight;
        }

        public static string ExportMovesAsPGN(string script)
        {
            var sb = new StringBuilder();
            var chessMoves = new List<ChessMove>();
            int charactersLeft = 0;
            string from;
            string to;
            string moves = ExtractMovesAsString(script);
            for (int i = 0; i < moves.Length; i += 4)
            {
                charactersLeft = moves.Length - i;

                from = null;
                to = null;
                if (charactersLeft < 2)
                {
                    throw new Exception("Input moves list is not complete.");
                }
                else if (charactersLeft >= 2)
                {
                    from = moves.Substring(i, 2);
                }
                if (charactersLeft >= 4)
                {
                    to = moves.Substring(i + 2, 2);
                }
                chessMoves.Add(new ChessMove(from, to));
            }
            int moveNumber = 1;
            int itemNumber = 0;
            while (chessMoves.Count > itemNumber)
            {
                sb.AppendFormat("{0}.{1} ", moveNumber++, chessMoves[itemNumber].To);
                if (++itemNumber < chessMoves.Count)
                    sb.AppendFormat("{0} ", chessMoves[itemNumber++].To);
            }
            sb.AppendFormat("\n");
            return sb.ToString();
        }

        private static string ExtractMovesAsString(string script)
        {
            int startPos = script.IndexOf("o.im('");
            int endPos = script.IndexOf("o.il");

            if (startPos == -1 || endPos == -1)
                return string.Empty;

            string moves = "";
            for (int i = startPos + 6; i < endPos - 5; i++)
            {
                if (char.IsUpper(script[i]) || char.IsLower(script[i]) || char.IsDigit(script[i]))
                {
                    moves += script[i];
                }
            }

            return moves;
        }
    }
}
