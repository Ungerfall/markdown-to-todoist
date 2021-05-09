//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from F:/development/markdown-to-todoist/src/grammar/TodoistGrammar.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class TodoistGrammarLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		SHARP=1, PERCENT=2, DATETIMESEPARATOR=3, HYPHEN=4, COLON=5, INT4=6, INT2=7, 
		NEWLINE=8;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"SHARP", "PERCENT", "DATETIMESEPARATOR", "HYPHEN", "COLON", "INT4", "INT2", 
		"NEWLINE", "DIGIT"
	};


	public TodoistGrammarLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public TodoistGrammarLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'#'", "'%'", "'T'", "'-'", "':'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "SHARP", "PERCENT", "DATETIMESEPARATOR", "HYPHEN", "COLON", "INT4", 
		"INT2", "NEWLINE"
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

	public override string GrammarFileName { get { return "TodoistGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static TodoistGrammarLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\n', '\x30', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\t', '\x5', '\t', ')', '\n', '\t', '\x3', '\t', '\x3', 
		'\t', '\x5', '\t', '-', '\n', '\t', '\x3', '\n', '\x3', '\n', '\x2', '\x2', 
		'\v', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\x2', '\x3', '\x2', '\x3', 
		'\x3', '\x2', '\x32', ';', '\x2', '\x30', '\x2', '\x3', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', 
		'\x2', '\x3', '\x15', '\x3', '\x2', '\x2', '\x2', '\x5', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\a', '\x19', '\x3', '\x2', '\x2', '\x2', '\t', '\x1B', 
		'\x3', '\x2', '\x2', '\x2', '\v', '\x1D', '\x3', '\x2', '\x2', '\x2', 
		'\r', '\x1F', '\x3', '\x2', '\x2', '\x2', '\xF', '$', '\x3', '\x2', '\x2', 
		'\x2', '\x11', ',', '\x3', '\x2', '\x2', '\x2', '\x13', '.', '\x3', '\x2', 
		'\x2', '\x2', '\x15', '\x16', '\a', '%', '\x2', '\x2', '\x16', '\x4', 
		'\x3', '\x2', '\x2', '\x2', '\x17', '\x18', '\a', '\'', '\x2', '\x2', 
		'\x18', '\x6', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1A', '\a', 'V', 
		'\x2', '\x2', '\x1A', '\b', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x1C', 
		'\a', '/', '\x2', '\x2', '\x1C', '\n', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'\x1E', '\a', '<', '\x2', '\x2', '\x1E', '\f', '\x3', '\x2', '\x2', '\x2', 
		'\x1F', ' ', '\x5', '\x13', '\n', '\x2', ' ', '!', '\x5', '\x13', '\n', 
		'\x2', '!', '\"', '\x5', '\x13', '\n', '\x2', '\"', '#', '\x5', '\x13', 
		'\n', '\x2', '#', '\xE', '\x3', '\x2', '\x2', '\x2', '$', '%', '\x5', 
		'\x13', '\n', '\x2', '%', '&', '\x5', '\x13', '\n', '\x2', '&', '\x10', 
		'\x3', '\x2', '\x2', '\x2', '\'', ')', '\a', '\xF', '\x2', '\x2', '(', 
		'\'', '\x3', '\x2', '\x2', '\x2', '(', ')', '\x3', '\x2', '\x2', '\x2', 
		')', '*', '\x3', '\x2', '\x2', '\x2', '*', '-', '\a', '\f', '\x2', '\x2', 
		'+', '-', '\a', '\xF', '\x2', '\x2', ',', '(', '\x3', '\x2', '\x2', '\x2', 
		',', '+', '\x3', '\x2', '\x2', '\x2', '-', '\x12', '\x3', '\x2', '\x2', 
		'\x2', '.', '/', '\t', '\x2', '\x2', '\x2', '/', '\x14', '\x3', '\x2', 
		'\x2', '\x2', '\x5', '\x2', '(', ',', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}