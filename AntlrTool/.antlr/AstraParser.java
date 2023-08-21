// Generated from c:\\Users\\lenin\\OneDrive\\Projects\\u005Cufabc\\u005Cufabc-co-astralang\\astra\\AntlrTool\\Astra.g4 by ANTLR 4.9.2
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class AstraParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.9.2", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, INT=3, DOUBLE=4, STRING=5, ID=6, INTVAL=7, DOUBLEVAL=8, 
		STRINGVAL=9, ADD=10, SUB=11, MUL=12, DIV=13;
	public static final int
		RULE_program = 0, RULE_statement = 1, RULE_declaration = 2, RULE_expression = 3, 
		RULE_additive_expression = 4, RULE_multiplicative_expression = 5, RULE_primary_expression = 6;
	private static String[] makeRuleNames() {
		return new String[] {
			"program", "statement", "declaration", "expression", "additive_expression", 
			"multiplicative_expression", "primary_expression"
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

	@Override
	public String getGrammarFileName() { return "Astra.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public AstraParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class ProgramContext extends ParserRuleContext {
		public List<StatementContext> statement() {
			return getRuleContexts(StatementContext.class);
		}
		public StatementContext statement(int i) {
			return getRuleContext(StatementContext.class,i);
		}
		public ProgramContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_program; }
	}

	public final ProgramContext program() throws RecognitionException {
		ProgramContext _localctx = new ProgramContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_program);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(15); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(14);
				statement();
				}
				}
				setState(17); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << INT) | (1L << DOUBLE) | (1L << STRING) | (1L << ID))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class StatementContext extends ParserRuleContext {
		public DeclarationContext declaration() {
			return getRuleContext(DeclarationContext.class,0);
		}
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_statement; }
	}

	public final StatementContext statement() throws RecognitionException {
		StatementContext _localctx = new StatementContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_statement);
		try {
			setState(21);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case INT:
			case DOUBLE:
			case STRING:
				enterOuterAlt(_localctx, 1);
				{
				setState(19);
				declaration();
				}
				break;
			case ID:
				enterOuterAlt(_localctx, 2);
				{
				setState(20);
				expression();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class DeclarationContext extends ParserRuleContext {
		public TerminalNode INT() { return getToken(AstraParser.INT, 0); }
		public TerminalNode ID() { return getToken(AstraParser.ID, 0); }
		public TerminalNode INTVAL() { return getToken(AstraParser.INTVAL, 0); }
		public TerminalNode DOUBLE() { return getToken(AstraParser.DOUBLE, 0); }
		public TerminalNode DOUBLEVAL() { return getToken(AstraParser.DOUBLEVAL, 0); }
		public TerminalNode STRING() { return getToken(AstraParser.STRING, 0); }
		public TerminalNode STRINGVAL() { return getToken(AstraParser.STRINGVAL, 0); }
		public DeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_declaration; }
	}

	public final DeclarationContext declaration() throws RecognitionException {
		DeclarationContext _localctx = new DeclarationContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_declaration);
		try {
			setState(38);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case INT:
				enterOuterAlt(_localctx, 1);
				{
				setState(23);
				match(INT);
				setState(24);
				match(ID);
				setState(25);
				match(T__0);
				setState(26);
				match(INTVAL);
				setState(27);
				match(T__1);
				}
				break;
			case DOUBLE:
				enterOuterAlt(_localctx, 2);
				{
				setState(28);
				match(DOUBLE);
				setState(29);
				match(ID);
				setState(30);
				match(T__0);
				setState(31);
				match(DOUBLEVAL);
				setState(32);
				match(T__1);
				}
				break;
			case STRING:
				enterOuterAlt(_localctx, 3);
				{
				setState(33);
				match(STRING);
				setState(34);
				match(ID);
				setState(35);
				match(T__0);
				setState(36);
				match(STRINGVAL);
				setState(37);
				match(T__1);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ExpressionContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(AstraParser.ID, 0); }
		public Additive_expressionContext additive_expression() {
			return getRuleContext(Additive_expressionContext.class,0);
		}
		public ExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expression; }
	}

	public final ExpressionContext expression() throws RecognitionException {
		ExpressionContext _localctx = new ExpressionContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_expression);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(40);
			match(ID);
			setState(41);
			match(T__0);
			setState(42);
			additive_expression();
			setState(43);
			match(T__1);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Additive_expressionContext extends ParserRuleContext {
		public List<Multiplicative_expressionContext> multiplicative_expression() {
			return getRuleContexts(Multiplicative_expressionContext.class);
		}
		public Multiplicative_expressionContext multiplicative_expression(int i) {
			return getRuleContext(Multiplicative_expressionContext.class,i);
		}
		public List<TerminalNode> ADD() { return getTokens(AstraParser.ADD); }
		public TerminalNode ADD(int i) {
			return getToken(AstraParser.ADD, i);
		}
		public List<TerminalNode> SUB() { return getTokens(AstraParser.SUB); }
		public TerminalNode SUB(int i) {
			return getToken(AstraParser.SUB, i);
		}
		public Additive_expressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_additive_expression; }
	}

	public final Additive_expressionContext additive_expression() throws RecognitionException {
		Additive_expressionContext _localctx = new Additive_expressionContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_additive_expression);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(45);
			multiplicative_expression();
			setState(51);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==ADD || _la==SUB) {
				{
				setState(49);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case ADD:
					{
					setState(46);
					match(ADD);
					}
					break;
				case SUB:
					{
					setState(47);
					match(SUB);
					setState(48);
					multiplicative_expression();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				setState(53);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Multiplicative_expressionContext extends ParserRuleContext {
		public List<Primary_expressionContext> primary_expression() {
			return getRuleContexts(Primary_expressionContext.class);
		}
		public Primary_expressionContext primary_expression(int i) {
			return getRuleContext(Primary_expressionContext.class,i);
		}
		public List<TerminalNode> MUL() { return getTokens(AstraParser.MUL); }
		public TerminalNode MUL(int i) {
			return getToken(AstraParser.MUL, i);
		}
		public List<TerminalNode> DIV() { return getTokens(AstraParser.DIV); }
		public TerminalNode DIV(int i) {
			return getToken(AstraParser.DIV, i);
		}
		public Multiplicative_expressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_multiplicative_expression; }
	}

	public final Multiplicative_expressionContext multiplicative_expression() throws RecognitionException {
		Multiplicative_expressionContext _localctx = new Multiplicative_expressionContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_multiplicative_expression);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(54);
			primary_expression();
			setState(60);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==MUL || _la==DIV) {
				{
				setState(58);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case MUL:
					{
					setState(55);
					match(MUL);
					}
					break;
				case DIV:
					{
					setState(56);
					match(DIV);
					setState(57);
					primary_expression();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				setState(62);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Primary_expressionContext extends ParserRuleContext {
		public TerminalNode INTVAL() { return getToken(AstraParser.INTVAL, 0); }
		public TerminalNode DOUBLEVAL() { return getToken(AstraParser.DOUBLEVAL, 0); }
		public TerminalNode STRINGVAL() { return getToken(AstraParser.STRINGVAL, 0); }
		public TerminalNode ID() { return getToken(AstraParser.ID, 0); }
		public Primary_expressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_primary_expression; }
	}

	public final Primary_expressionContext primary_expression() throws RecognitionException {
		Primary_expressionContext _localctx = new Primary_expressionContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_primary_expression);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(63);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ID) | (1L << INTVAL) | (1L << DOUBLEVAL) | (1L << STRINGVAL))) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\17D\4\2\t\2\4\3\t"+
		"\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\3\2\6\2\22\n\2\r\2\16\2\23"+
		"\3\3\3\3\5\3\30\n\3\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3"+
		"\4\3\4\3\4\5\4)\n\4\3\5\3\5\3\5\3\5\3\5\3\6\3\6\3\6\3\6\7\6\64\n\6\f\6"+
		"\16\6\67\13\6\3\7\3\7\3\7\3\7\7\7=\n\7\f\7\16\7@\13\7\3\b\3\b\3\b\2\2"+
		"\t\2\4\6\b\n\f\16\2\3\3\2\b\13\2D\2\21\3\2\2\2\4\27\3\2\2\2\6(\3\2\2\2"+
		"\b*\3\2\2\2\n/\3\2\2\2\f8\3\2\2\2\16A\3\2\2\2\20\22\5\4\3\2\21\20\3\2"+
		"\2\2\22\23\3\2\2\2\23\21\3\2\2\2\23\24\3\2\2\2\24\3\3\2\2\2\25\30\5\6"+
		"\4\2\26\30\5\b\5\2\27\25\3\2\2\2\27\26\3\2\2\2\30\5\3\2\2\2\31\32\7\5"+
		"\2\2\32\33\7\b\2\2\33\34\7\3\2\2\34\35\7\t\2\2\35)\7\4\2\2\36\37\7\6\2"+
		"\2\37 \7\b\2\2 !\7\3\2\2!\"\7\n\2\2\")\7\4\2\2#$\7\7\2\2$%\7\b\2\2%&\7"+
		"\3\2\2&\'\7\13\2\2\')\7\4\2\2(\31\3\2\2\2(\36\3\2\2\2(#\3\2\2\2)\7\3\2"+
		"\2\2*+\7\b\2\2+,\7\3\2\2,-\5\n\6\2-.\7\4\2\2.\t\3\2\2\2/\65\5\f\7\2\60"+
		"\64\7\f\2\2\61\62\7\r\2\2\62\64\5\f\7\2\63\60\3\2\2\2\63\61\3\2\2\2\64"+
		"\67\3\2\2\2\65\63\3\2\2\2\65\66\3\2\2\2\66\13\3\2\2\2\67\65\3\2\2\28>"+
		"\5\16\b\29=\7\16\2\2:;\7\17\2\2;=\5\16\b\2<9\3\2\2\2<:\3\2\2\2=@\3\2\2"+
		"\2><\3\2\2\2>?\3\2\2\2?\r\3\2\2\2@>\3\2\2\2AB\t\2\2\2B\17\3\2\2\2\t\23"+
		"\27(\63\65<>";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}