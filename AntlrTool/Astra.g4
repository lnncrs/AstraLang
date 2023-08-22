grammar Astra;

program: statement*;

statement: assignment
         | ifStatement
         | whileStatement
         | doWhileStatement
         | expressionStatement
         | inputStatement
         | outputStatement
         ;

assignment: ID '=' expression ';';
ifStatement: 'if' '(' expression ')' block ('else' block)?;
whileStatement: 'while' '(' expression ')' block;
doWhileStatement: 'do' block 'while' '(' expression ')' ';';
inputStatement: 'input' ID ';';
outputStatement: 'print' expression ';' | 'println' expression ';';
expressionStatement: expression ';';

block: '{' statement* '}';

expression: '(' expression ')'                                                 # parensExpression
          | expression op=('+' | '-') expression                               # additiveExpression
          | expression op=('*' | '/' | '%' ) expression                        # multiplicativeExpression
          | expression op=('>' | '>=' | '<' | '<=' | '==' | '!=') expression   # relationalExpression
          | INT                                                                # intLiteral
          | DOUBLE                                                             # doubleLiteral
          | STRING                                                             # stringLiteral
          | ID                                                                 # variable
          ;

ID: [a-zA-Z_] [a-zA-Z0-9_]*;
INT: [0-9]+;
DOUBLE: [0-9]+'.'[0-9]+;
STRING: '"' .*? '"';
WS: [ \t\r\n]+ -> skip;
