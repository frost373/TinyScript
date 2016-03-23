//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from TinyScript.g4 by ANTLR 4.5.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.2")]
[System.CLSCompliant(false)]
public partial class TinyScriptLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, StringLiteral=33, Decimal=34, Identifier=35, LineComment=36, 
		Comment=37, WhiteSpace=38;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "StringLiteral", 
		"Decimal", "NonZeroDigit", "DigitChar", "Identifier", "IdentifierChar", 
		"IdentifierStart", "Letter", "LineComment", "Comment", "WhiteSpace"
	};


	public TinyScriptLexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'if'", "'else'", "'('", "')'", "'{'", "'}'", "';'", "'print'", 
		"'while'", "'do'", "'for'", "'||'", "'&&'", "'=='", "'!='", "'<'", "'<='", 
		"'>'", "'>='", "'+'", "'-'", "'*'", "'/'", "'!'", "'true'", "'false'", 
		"'decimal'", "'string'", "'bool'", "'var'", "','", "'='"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, "StringLiteral", 
		"Decimal", "Identifier", "LineComment", "Comment", "WhiteSpace"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "TinyScript.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	private static string _serializedATN = _serializeATN();
	private static string _serializeATN()
	{
	    StringBuilder sb = new StringBuilder();
	    sb.Append("\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2(\x127");
		sb.Append("\b\x1\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6");
		sb.Append("\x4\a\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r");
		sb.Append("\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10\t\x10\x4\x11\t\x11\x4\x12");
		sb.Append("\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15\x4\x16\t\x16\x4");
		sb.Append("\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B\t\x1B");
		sb.Append("\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t ");
		sb.Append("\x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t");
		sb.Append("(\x4)\t)\x4*\t*\x4+\t+\x4,\t,\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3");
		sb.Append("\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\a");
		sb.Append("\x3\a\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n");
		sb.Append("\x3\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r");
		sb.Append("\x3\r\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10");
		sb.Append("\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x14\x3");
		sb.Append("\x14\x3\x14\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3\x18");
		sb.Append("\x3\x18\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3");
		sb.Append("\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C");
		sb.Append("\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1D\x3");
		sb.Append("\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E");
		sb.Append("\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3!\x3!\x3\"\x3\"\a\"\xC8");
		sb.Append("\n\"\f\"\xE\"\xCB\v\"\x3\"\x3\"\x3#\x3#\x3#\a#\xD2\n#\f#\xE");
		sb.Append("#\xD5\v#\x3#\x5#\xD8\n#\x3#\x3#\a#\xDC\n#\f#\xE#\xDF\v#\x3#");
		sb.Append("\x3#\a#\xE3\n#\f#\xE#\xE6\v#\x3#\x5#\xE9\n#\x5#\xEB\n#\x3$\x3");
		sb.Append("$\x3%\x3%\x3%\x5%\xF2\n%\x3&\x3&\a&\xF6\n&\f&\xE&\xF9\v&\x3");
		sb.Append("\'\x3\'\x3\'\x5\'\xFE\n\'\x3(\x3(\x5(\x102\n(\x3)\x3)\x3*\x3");
		sb.Append("*\x3*\x3*\a*\x10A\n*\f*\xE*\x10D\v*\x3*\x5*\x110\n*\x3*\x3*");
		sb.Append("\x3*\x3*\x3+\x3+\x3+\x3+\a+\x11A\n+\f+\xE+\x11D\v+\x3+\x3+\x3");
		sb.Append("+\x3+\x3+\x3,\x3,\x3,\x3,\x4\xC9\x11B\x2-\x3\x3\x5\x4\a\x5\t");
		sb.Append("\x6\v\a\r\b\xF\t\x11\n\x13\v\x15\f\x17\r\x19\xE\x1B\xF\x1D\x10");
		sb.Append("\x1F\x11!\x12#\x13%\x14\'\x15)\x16+\x17-\x18/\x19\x31\x1A\x33");
		sb.Append("\x1B\x35\x1C\x37\x1D\x39\x1E;\x1F= ?!\x41\"\x43#\x45$G\x2I\x2");
		sb.Append("K%M\x2O\x2Q\x2S&U\'W(\x3\x2\x6\x5\x2\f\f\xF\xF^^\x4\x2\x43\\");
		sb.Append("\x63|\x4\x2\f\f\xF\xF\x5\x2\v\f\xF\xF\"\"\x131\x2\x3\x3\x2\x2");
		sb.Append("\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v");
		sb.Append("\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2");
		sb.Append("\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2");
		sb.Append("\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2");
		sb.Append("\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2");
		sb.Append("\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-");
		sb.Append("\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2");
		sb.Append("\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2");
		sb.Append("\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3");
		sb.Append("\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2K\x3\x2\x2");
		sb.Append("\x2\x2S\x3\x2\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2\x2\x3Y\x3\x2");
		sb.Append("\x2\x2\x5\\\x3\x2\x2\x2\a\x61\x3\x2\x2\x2\t\x63\x3\x2\x2\x2");
		sb.Append("\v\x65\x3\x2\x2\x2\rg\x3\x2\x2\x2\xFi\x3\x2\x2\x2\x11k\x3\x2");
		sb.Append("\x2\x2\x13q\x3\x2\x2\x2\x15w\x3\x2\x2\x2\x17z\x3\x2\x2\x2\x19");
		sb.Append("~\x3\x2\x2\x2\x1B\x81\x3\x2\x2\x2\x1D\x84\x3\x2\x2\x2\x1F\x87");
		sb.Append("\x3\x2\x2\x2!\x8A\x3\x2\x2\x2#\x8C\x3\x2\x2\x2%\x8F\x3\x2\x2");
		sb.Append("\x2\'\x91\x3\x2\x2\x2)\x94\x3\x2\x2\x2+\x96\x3\x2\x2\x2-\x98");
		sb.Append("\x3\x2\x2\x2/\x9A\x3\x2\x2\x2\x31\x9C\x3\x2\x2\x2\x33\x9E\x3");
		sb.Append("\x2\x2\x2\x35\xA3\x3\x2\x2\x2\x37\xA9\x3\x2\x2\x2\x39\xB1\x3");
		sb.Append("\x2\x2\x2;\xB8\x3\x2\x2\x2=\xBD\x3\x2\x2\x2?\xC1\x3\x2\x2\x2");
		sb.Append("\x41\xC3\x3\x2\x2\x2\x43\xC5\x3\x2\x2\x2\x45\xEA\x3\x2\x2\x2");
		sb.Append("G\xEC\x3\x2\x2\x2I\xF1\x3\x2\x2\x2K\xF3\x3\x2\x2\x2M\xFD\x3");
		sb.Append("\x2\x2\x2O\x101\x3\x2\x2\x2Q\x103\x3\x2\x2\x2S\x105\x3\x2\x2");
		sb.Append("\x2U\x115\x3\x2\x2\x2W\x123\x3\x2\x2\x2YZ\ak\x2\x2Z[\ah\x2\x2");
		sb.Append("[\x4\x3\x2\x2\x2\\]\ag\x2\x2]^\an\x2\x2^_\au\x2\x2_`\ag\x2\x2");
		sb.Append("`\x6\x3\x2\x2\x2\x61\x62\a*\x2\x2\x62\b\x3\x2\x2\x2\x63\x64");
		sb.Append("\a+\x2\x2\x64\n\x3\x2\x2\x2\x65\x66\a}\x2\x2\x66\f\x3\x2\x2");
		sb.Append("\x2gh\a\x7F\x2\x2h\xE\x3\x2\x2\x2ij\a=\x2\x2j\x10\x3\x2\x2\x2");
		sb.Append("kl\ar\x2\x2lm\at\x2\x2mn\ak\x2\x2no\ap\x2\x2op\av\x2\x2p\x12");
		sb.Append("\x3\x2\x2\x2qr\ay\x2\x2rs\aj\x2\x2st\ak\x2\x2tu\an\x2\x2uv\a");
		sb.Append("g\x2\x2v\x14\x3\x2\x2\x2wx\a\x66\x2\x2xy\aq\x2\x2y\x16\x3\x2");
		sb.Append("\x2\x2z{\ah\x2\x2{|\aq\x2\x2|}\at\x2\x2}\x18\x3\x2\x2\x2~\x7F");
		sb.Append("\a~\x2\x2\x7F\x80\a~\x2\x2\x80\x1A\x3\x2\x2\x2\x81\x82\a(\x2");
		sb.Append("\x2\x82\x83\a(\x2\x2\x83\x1C\x3\x2\x2\x2\x84\x85\a?\x2\x2\x85");
		sb.Append("\x86\a?\x2\x2\x86\x1E\x3\x2\x2\x2\x87\x88\a#\x2\x2\x88\x89\a");
		sb.Append("?\x2\x2\x89 \x3\x2\x2\x2\x8A\x8B\a>\x2\x2\x8B\"\x3\x2\x2\x2");
		sb.Append("\x8C\x8D\a>\x2\x2\x8D\x8E\a?\x2\x2\x8E$\x3\x2\x2\x2\x8F\x90");
		sb.Append("\a@\x2\x2\x90&\x3\x2\x2\x2\x91\x92\a@\x2\x2\x92\x93\a?\x2\x2");
		sb.Append("\x93(\x3\x2\x2\x2\x94\x95\a-\x2\x2\x95*\x3\x2\x2\x2\x96\x97");
		sb.Append("\a/\x2\x2\x97,\x3\x2\x2\x2\x98\x99\a,\x2\x2\x99.\x3\x2\x2\x2");
		sb.Append("\x9A\x9B\a\x31\x2\x2\x9B\x30\x3\x2\x2\x2\x9C\x9D\a#\x2\x2\x9D");
		sb.Append("\x32\x3\x2\x2\x2\x9E\x9F\av\x2\x2\x9F\xA0\at\x2\x2\xA0\xA1\a");
		sb.Append("w\x2\x2\xA1\xA2\ag\x2\x2\xA2\x34\x3\x2\x2\x2\xA3\xA4\ah\x2\x2");
		sb.Append("\xA4\xA5\a\x63\x2\x2\xA5\xA6\an\x2\x2\xA6\xA7\au\x2\x2\xA7\xA8");
		sb.Append("\ag\x2\x2\xA8\x36\x3\x2\x2\x2\xA9\xAA\a\x66\x2\x2\xAA\xAB\a");
		sb.Append("g\x2\x2\xAB\xAC\a\x65\x2\x2\xAC\xAD\ak\x2\x2\xAD\xAE\ao\x2\x2");
		sb.Append("\xAE\xAF\a\x63\x2\x2\xAF\xB0\an\x2\x2\xB0\x38\x3\x2\x2\x2\xB1");
		sb.Append("\xB2\au\x2\x2\xB2\xB3\av\x2\x2\xB3\xB4\at\x2\x2\xB4\xB5\ak\x2");
		sb.Append("\x2\xB5\xB6\ap\x2\x2\xB6\xB7\ai\x2\x2\xB7:\x3\x2\x2\x2\xB8\xB9");
		sb.Append("\a\x64\x2\x2\xB9\xBA\aq\x2\x2\xBA\xBB\aq\x2\x2\xBB\xBC\an\x2");
		sb.Append("\x2\xBC<\x3\x2\x2\x2\xBD\xBE\ax\x2\x2\xBE\xBF\a\x63\x2\x2\xBF");
		sb.Append("\xC0\at\x2\x2\xC0>\x3\x2\x2\x2\xC1\xC2\a.\x2\x2\xC2@\x3\x2\x2");
		sb.Append("\x2\xC3\xC4\a?\x2\x2\xC4\x42\x3\x2\x2\x2\xC5\xC9\a$\x2\x2\xC6");
		sb.Append("\xC8\n\x2\x2\x2\xC7\xC6\x3\x2\x2\x2\xC8\xCB\x3\x2\x2\x2\xC9");
		sb.Append("\xCA\x3\x2\x2\x2\xC9\xC7\x3\x2\x2\x2\xCA\xCC\x3\x2\x2\x2\xCB");
		sb.Append("\xC9\x3\x2\x2\x2\xCC\xCD\a$\x2\x2\xCD\x44\x3\x2\x2\x2\xCE\xD7");
		sb.Append("\a\x32\x2\x2\xCF\xD3\a\x30\x2\x2\xD0\xD2\x5I%\x2\xD1\xD0\x3");
		sb.Append("\x2\x2\x2\xD2\xD5\x3\x2\x2\x2\xD3\xD1\x3\x2\x2\x2\xD3\xD4\x3");
		sb.Append("\x2\x2\x2\xD4\xD6\x3\x2\x2\x2\xD5\xD3\x3\x2\x2\x2\xD6\xD8\x5");
		sb.Append("G$\x2\xD7\xCF\x3\x2\x2\x2\xD7\xD8\x3\x2\x2\x2\xD8\xEB\x3\x2");
		sb.Append("\x2\x2\xD9\xDD\x5G$\x2\xDA\xDC\x5I%\x2\xDB\xDA\x3\x2\x2\x2\xDC");
		sb.Append("\xDF\x3\x2\x2\x2\xDD\xDB\x3\x2\x2\x2\xDD\xDE\x3\x2\x2\x2\xDE");
		sb.Append("\xE8\x3\x2\x2\x2\xDF\xDD\x3\x2\x2\x2\xE0\xE4\a\x30\x2\x2\xE1");
		sb.Append("\xE3\x5I%\x2\xE2\xE1\x3\x2\x2\x2\xE3\xE6\x3\x2\x2\x2\xE4\xE2");
		sb.Append("\x3\x2\x2\x2\xE4\xE5\x3\x2\x2\x2\xE5\xE7\x3\x2\x2\x2\xE6\xE4");
		sb.Append("\x3\x2\x2\x2\xE7\xE9\x5G$\x2\xE8\xE0\x3\x2\x2\x2\xE8\xE9\x3");
		sb.Append("\x2\x2\x2\xE9\xEB\x3\x2\x2\x2\xEA\xCE\x3\x2\x2\x2\xEA\xD9\x3");
		sb.Append("\x2\x2\x2\xEB\x46\x3\x2\x2\x2\xEC\xED\x4\x33;\x2\xEDH\x3\x2");
		sb.Append("\x2\x2\xEE\xF2\a\x32\x2\x2\xEF\xF2\x5G$\x2\xF0\xF2\a\x61\x2");
		sb.Append("\x2\xF1\xEE\x3\x2\x2\x2\xF1\xEF\x3\x2\x2\x2\xF1\xF0\x3\x2\x2");
		sb.Append("\x2\xF2J\x3\x2\x2\x2\xF3\xF7\x5O(\x2\xF4\xF6\x5M\'\x2\xF5\xF4");
		sb.Append("\x3\x2\x2\x2\xF6\xF9\x3\x2\x2\x2\xF7\xF5\x3\x2\x2\x2\xF7\xF8");
		sb.Append("\x3\x2\x2\x2\xF8L\x3\x2\x2\x2\xF9\xF7\x3\x2\x2\x2\xFA\xFE\x5");
		sb.Append("O(\x2\xFB\xFE\a\x32\x2\x2\xFC\xFE\x5G$\x2\xFD\xFA\x3\x2\x2\x2");
		sb.Append("\xFD\xFB\x3\x2\x2\x2\xFD\xFC\x3\x2\x2\x2\xFEN\x3\x2\x2\x2\xFF");
		sb.Append("\x102\a\x61\x2\x2\x100\x102\x5Q)\x2\x101\xFF\x3\x2\x2\x2\x101");
		sb.Append("\x100\x3\x2\x2\x2\x102P\x3\x2\x2\x2\x103\x104\t\x3\x2\x2\x104");
		sb.Append("R\x3\x2\x2\x2\x105\x106\a\x31\x2\x2\x106\x107\a\x31\x2\x2\x107");
		sb.Append("\x10B\x3\x2\x2\x2\x108\x10A\n\x4\x2\x2\x109\x108\x3\x2\x2\x2");
		sb.Append("\x10A\x10D\x3\x2\x2\x2\x10B\x109\x3\x2\x2\x2\x10B\x10C\x3\x2");
		sb.Append("\x2\x2\x10C\x10F\x3\x2\x2\x2\x10D\x10B\x3\x2\x2\x2\x10E\x110");
		sb.Append("\a\xF\x2\x2\x10F\x10E\x3\x2\x2\x2\x10F\x110\x3\x2\x2\x2\x110");
		sb.Append("\x111\x3\x2\x2\x2\x111\x112\a\f\x2\x2\x112\x113\x3\x2\x2\x2");
		sb.Append("\x113\x114\b*\x2\x2\x114T\x3\x2\x2\x2\x115\x116\a\x31\x2\x2");
		sb.Append("\x116\x117\a,\x2\x2\x117\x11B\x3\x2\x2\x2\x118\x11A\v\x2\x2");
		sb.Append("\x2\x119\x118\x3\x2\x2\x2\x11A\x11D\x3\x2\x2\x2\x11B\x11C\x3");
		sb.Append("\x2\x2\x2\x11B\x119\x3\x2\x2\x2\x11C\x11E\x3\x2\x2\x2\x11D\x11B");
		sb.Append("\x3\x2\x2\x2\x11E\x11F\a,\x2\x2\x11F\x120\a\x31\x2\x2\x120\x121");
		sb.Append("\x3\x2\x2\x2\x121\x122\b+\x2\x2\x122V\x3\x2\x2\x2\x123\x124");
		sb.Append("\t\x5\x2\x2\x124\x125\x3\x2\x2\x2\x125\x126\b,\x2\x2\x126X\x3");
		sb.Append("\x2\x2\x2\x11\x2\xC9\xD3\xD7\xDD\xE4\xE8\xEA\xF1\xF7\xFD\x101");
		sb.Append("\x10B\x10F\x11B\x3\b\x2\x2");
	    return sb.ToString();
	}

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}