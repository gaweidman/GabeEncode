using System;
using System.IO;
using System.Collections.Generic;

class GabeEncode
{
    static Dictionary<string, string> charDict = new Dictionary<string, string>();
    public static void Encode(string readPath, string savePath)
    {
        InitEncodeDict();
        StreamReader reader = new StreamReader(path);
        StreamWriter writer = new StreamWriter(savePath);
        string line = reader.ReadLine();
        int cursorpos = 0;
        while(line != null)
        {
            foreach(char c in line)
            {
                writer.Write(charDict[Convert.ToString(c)]);
                if(cursorpos < 15)
                {
                    writer.Write(" ");
                    cursorpos += 5;
                }
                else
                {
                    writer.Write("\n");
                    cursorpos = 0;
                }
            }
            line = reader.ReadLine();
            if(line != null)
            {
                if(cursorpos < 15)
                {
                    writer.Write("AAEE ");
                    cursorpos += 5;
                }
                else
                {
                    writer.Write("AAEE\n");
                    cursorpos = 0;
                }
            }
        }
        writer.Close();
        reader.Close();
    }
    public static void Decode(string readPath, string savePath)
    {
        InitDecodeDict();
        StreamReader reader = new StreamReader(readPath);
        StreamWriter writer = new StreamWriter(savePath);
        string line = reader.ReadLine();
        int cursorpos = 0;
        while(line != null)
        {
            for(int i = 0; i < line.Length; i += 5)
            {
                writer.Write(charDict[line.Substring(cursorpos, 4)]);
                cursorpos += 5;
            }
            cursorpos = 0;
            line = reader.ReadLine();
        }
        writer.Close();
        reader.Close();
    }
    private void InitEncodeDict()
    {
        charDict.Add(" ", "GGGG");
        charDict.Add("0", "GGGA");
        charDict.Add("1", "GGGB");
        charDict.Add("2", "GGGE");
        charDict.Add("3", "GGAG");
        charDict.Add("4", "GGAA");
        charDict.Add("5", "GGAB");
        charDict.Add("6", "GGAE");
        charDict.Add("7", "GGBG");
        charDict.Add("8", "GGBA");
        charDict.Add("9", "GGBB");
        charDict.Add(".", "GGBE");
        charDict.Add("a", "GGEG");
        charDict.Add("b", "GGEA");
        charDict.Add("c", "GGEB");
        charDict.Add("d", "GGEE");
        charDict.Add("e", "GAGG");
        charDict.Add("f", "GAGA");
        charDict.Add("g", "GAGB");
        charDict.Add("h", "GAGE");
        charDict.Add("i", "GAAG");
        charDict.Add("j", "GAAA");
        charDict.Add("k", "GAAB");
        charDict.Add("l", "GAAE");
        charDict.Add("m", "GABG");
        charDict.Add("n", "GABA");
        charDict.Add("o", "GABB");
        charDict.Add("p", "GABE");
        charDict.Add("q", "GAEG");
        charDict.Add("r", "GAEA");
        charDict.Add("s", "GAEB");
        charDict.Add("t", "GAEE");
        charDict.Add("u", "GBGG");
        charDict.Add("v", "GBGA");
        charDict.Add("w", "GBGB");
        charDict.Add("x", "GBGE");
        charDict.Add("y", "GBAG");
        charDict.Add("z", "GBAA");
        charDict.Add("A", "GBAB");
        charDict.Add("B", "GBAE");
        charDict.Add("C", "GBBG");
        charDict.Add("D", "GBBA");
        charDict.Add("E", "GBBB");
        charDict.Add("F", "GBBE");
        charDict.Add("G", "GBEG");
        charDict.Add("H", "GBEA");
        charDict.Add("I", "GBEB");
        charDict.Add("J", "GBEE");
        charDict.Add("K", "GEGG");
        charDict.Add("L", "GEGA");
        charDict.Add("M", "GEGB");
        charDict.Add("N", "GEGE");
        charDict.Add("O", "GEAG");
        charDict.Add("P", "GEAA");
        charDict.Add("Q", "GEAB");
        charDict.Add("R", "GEAE");
        charDict.Add("S", "GEBG");
        charDict.Add("T", "GEBA");
        charDict.Add("U", "GEBB");
        charDict.Add("V", "GEBE");
        charDict.Add("W", "GEEG");
        charDict.Add("X", "GEEA");
        charDict.Add("Y", "GEEB");
        charDict.Add("Z", "GEEE");
        charDict.Add("!", "AGGG");
        charDict.Add("@", "AGGA");
        charDict.Add("#", "AGGB");
        charDict.Add("$", "AGGE");
        charDict.Add("%", "AGAG");
        charDict.Add("^", "AGAA");
        charDict.Add("&", "AGAB");
        charDict.Add("*", "AGAE");
        charDict.Add("(", "AGBG");
        charDict.Add(")", "AGBA");
        charDict.Add("-", "AGBB");
        charDict.Add("=", "AGBE");
        charDict.Add("_", "AGEG");
        charDict.Add("+", "AGEA");
        charDict.Add("[", "AGEB");
        charDict.Add("]", "AGEE");
        charDict.Add("{", "AAGG");
        charDict.Add("}", "AAGA");
        charDict.Add("\\", "AAGB");
        charDict.Add("|", "AAGE");
        charDict.Add(";", "AAAG");
        charDict.Add(":", "AAAA");
        charDict.Add("\'", "AAAB");
        charDict.Add("\"", "AAAE");
        charDict.Add(",", "AABG");
        charDict.Add("/", "AABA");
        charDict.Add("<", "AABB");
        charDict.Add(">", "AABE");
        charDict.Add("?", "AAEG");
        charDict.Add("`", "AAEA");
        charDict.Add("~", "AAEB");
        charDict.Add("\n", "AAEE");
        // End Character: ABGG
    }
    public static void InitDecodeDict()
    {
        charDict.Add("GGGG", " ");
        charDict.Add("GGGA", "0");
        charDict.Add("GGGB", "1");
        charDict.Add("GGGE", "2");
        charDict.Add("GGAG", "3");
        charDict.Add("GGAA", "4");
        charDict.Add("GGAB", "5");
        charDict.Add("GGAE", "6");
        charDict.Add("GGBG", "7");
        charDict.Add("GGBA", "8");
        charDict.Add("GGBB", "9");
        charDict.Add("GGBE", ".");
        charDict.Add("GGEG", "a");
        charDict.Add("GGEA", "b");
        charDict.Add("GGEB", "c");
        charDict.Add("GGEE", "d");
        charDict.Add("GAGG", "e");
        charDict.Add("GAGA", "f");
        charDict.Add("GAGB", "g");
        charDict.Add("GAGE", "h");
        charDict.Add("GAAG", "i");
        charDict.Add("GAAA", "j");
        charDict.Add("GAAB", "k");
        charDict.Add("GAAE", "l");
        charDict.Add("GABG", "m");
        charDict.Add("GABA", "n");
        charDict.Add("GABB", "o");
        charDict.Add("GABE", "p");
        charDict.Add("GAEG", "q");
        charDict.Add("GAEA", "r");
        charDict.Add("GAEB", "s");
        charDict.Add("GAEE", "t");
        charDict.Add("GBGG", "u");
        charDict.Add("GBGA", "v");
        charDict.Add("GBGB", "w");
        charDict.Add("GBGE", "x");
        charDict.Add("GBAG", "y");
        charDict.Add("GBAA", "z");
        charDict.Add("GBAB", "A");
        charDict.Add("GBAE", "B");
        charDict.Add("GBBG", "C");
        charDict.Add("GBBA", "D");
        charDict.Add("GBBB", "E");
        charDict.Add("GBBE", "F");
        charDict.Add("GBEG", "G");
        charDict.Add("GBEA", "H");
        charDict.Add("GBEB", "I");
        charDict.Add("GBEE", "J");
        charDict.Add("GEGG", "K");
        charDict.Add("GEGA", "L");
        charDict.Add("GEGB", "M");
        charDict.Add("GEGE", "N");
        charDict.Add("GEAG", "O");
        charDict.Add("GEAA", "P");
        charDict.Add("GEAB", "Q");
        charDict.Add("GEAE", "R");
        charDict.Add("GEBG", "S");
        charDict.Add("GEBA", "T");
        charDict.Add("GEBB", "U");
        charDict.Add("GEBE", "V");
        charDict.Add("GEEG", "W");
        charDict.Add("GEEA", "X");
        charDict.Add("GEEB", "Y");
        charDict.Add("GEEE", "Z");
        charDict.Add("AGGG", "!");
        charDict.Add("AGGA", "@");
        charDict.Add("AGGB", "#");
        charDict.Add("AGGE", "$");
        charDict.Add("AGAG", "%");
        charDict.Add("AGAA", "^");
        charDict.Add("AGAB", "&");
        charDict.Add("AGAE", "*");
        charDict.Add("AGBG", "(");
        charDict.Add("AGBA", ")");
        charDict.Add("AGBB", "-");
        charDict.Add("AGBE", "=");
        charDict.Add("AGEG", "_");
        charDict.Add("AGEA", "+");
        charDict.Add("AGEB", "[");
        charDict.Add("AGEE", "]");
        charDict.Add("AAGG", "{");
        charDict.Add("AAGA", "}");
        charDict.Add("AAGB", "\\");
        charDict.Add("AAGE", "|");
        charDict.Add("AAAG", ";");
        charDict.Add("AAAA", ":");
        charDict.Add("AAAB", "\'");
        charDict.Add("AAAE", "\"");
        charDict.Add("AABG", ",");
        charDict.Add("AABA", "/");
        charDict.Add("AABB", "<");
        charDict.Add("AABE", ">");
        charDict.Add("AAEG", "?");
        charDict.Add("AAEA", "`");
        charDict.Add("AAEB", "~");
        charDict.Add("AAEE", "\n");
        // End Character: ABGG
    }
}