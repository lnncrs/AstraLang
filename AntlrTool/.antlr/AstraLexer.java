// Generated from c:\\Users\\lenin\\OneDrive\\Projects\\u005Cufabc\\u005Cufabc-co-astralang\\astra\\AntlrTool\\Astra.g4 by ANTLR 4.9.2
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class AstraLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.9.2", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, INT=3, DOUBLE=4, STRING=5, ID=6, INTVAL=7, DOUBLEVAL=8, 
		STRINGVAL=9, ADD=10, SUB=11, MUL=12, DIV=13;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "T__1", "INT", "DOUBLE", "STRING", "ID", "INTVAL", "DOUBLEVAL", 
			"STRINGVAL", "ADD", "SUB", "MUL", "DIV"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'='", "';'", "'int'", "'double'", "'string'", null, null, null, 
			null, "'+'", "'-'", "'*'", "'/'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, "INT", "DOUBLE", "STRING", "ID", "INTVAL", "DOUBLEVAL", 
			"STRINGVAL", "ADD", "SUB", "MUL", "DIV"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}


	public AstraLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "Astra.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\17[\b\1\4\2\t\2\4"+
		"\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t"+
		"\13\4\f\t\f\4\r\t\r\4\16\t\16\3\2\3\2\3\3\3\3\3\4\3\4\3\4\3\4\3\5\3\5"+
		"\3\5\3\5\3\5\3\5\3\5\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\7\6\7\65\n\7\r\7\16"+
		"\7\66\3\b\6\b:\n\b\r\b\16\b;\3\t\6\t?\n\t\r\t\16\t@\3\t\3\t\6\tE\n\t\r"+
		"\t\16\tF\5\tI\n\t\3\n\3\n\7\nM\n\n\f\n\16\nP\13\n\3\n\3\n\3\13\3\13\3"+
		"\f\3\f\3\r\3\r\3\16\3\16\2\2\17\3\3\5\4\7\5\t\6\13\7\r\b\17\t\21\n\23"+
		"\13\25\f\27\r\31\16\33\17\3\2\5\4\2C\\c|\3\2\62;\3\2$$\2`\2\3\3\2\2\2"+
		"\2\5\3\2\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2\2\17\3\2"+
		"\2\2\2\21\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3\2\2\2"+
		"\2\33\3\2\2\2\3\35\3\2\2\2\5\37\3\2\2\2\7!\3\2\2\2\t%\3\2\2\2\13,\3\2"+
		"\2\2\r\64\3\2\2\2\179\3\2\2\2\21>\3\2\2\2\23J\3\2\2\2\25S\3\2\2\2\27U"+
		"\3\2\2\2\31W\3\2\2\2\33Y\3\2\2\2\35\36\7?\2\2\36\4\3\2\2\2\37 \7=\2\2"+
		" \6\3\2\2\2!\"\7k\2\2\"#\7p\2\2#$\7v\2\2$\b\3\2\2\2%&\7f\2\2&\'\7q\2\2"+
		"\'(\7w\2\2()\7d\2\2)*\7n\2\2*+\7g\2\2+\n\3\2\2\2,-\7u\2\2-.\7v\2\2./\7"+
		"t\2\2/\60\7k\2\2\60\61\7p\2\2\61\62\7i\2\2\62\f\3\2\2\2\63\65\t\2\2\2"+
		"\64\63\3\2\2\2\65\66\3\2\2\2\66\64\3\2\2\2\66\67\3\2\2\2\67\16\3\2\2\2"+
		"8:\t\3\2\298\3\2\2\2:;\3\2\2\2;9\3\2\2\2;<\3\2\2\2<\20\3\2\2\2=?\t\3\2"+
		"\2>=\3\2\2\2?@\3\2\2\2@>\3\2\2\2@A\3\2\2\2AH\3\2\2\2BD\7\60\2\2CE\t\3"+
		"\2\2DC\3\2\2\2EF\3\2\2\2FD\3\2\2\2FG\3\2\2\2GI\3\2\2\2HB\3\2\2\2HI\3\2"+
		"\2\2I\22\3\2\2\2JN\7$\2\2KM\n\4\2\2LK\3\2\2\2MP\3\2\2\2NL\3\2\2\2NO\3"+
		"\2\2\2OQ\3\2\2\2PN\3\2\2\2QR\7$\2\2R\24\3\2\2\2ST\7-\2\2T\26\3\2\2\2U"+
		"V\7/\2\2V\30\3\2\2\2WX\7,\2\2X\32\3\2\2\2YZ\7\61\2\2Z\34\3\2\2\2\t\2\66"+
		";@FHN\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}