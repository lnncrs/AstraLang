grammar Astra;

// Defining tokens
INT:    'int';
DOUBLE: 'double';
STRING: 'string';
ID:     [a-zA-Z]+;
INTVAL: [0-9]+;
DOUBLEVAL: [0-9]+ ('.' [0-9]+)?;
STRINGVAL: '"' ~["]* '"';
ADD:    '+';
SUB:    '-';
MUL:    '*';
DIV:    '/';

// Defining the grammar rules
program: statement+;

statement: declaration | expression;

declaration: INT ID '=' INTVAL ';'
           | DOUBLE ID '=' DOUBLEVAL ';'
           | STRING ID '=' STRINGVAL ';';

expression: ID '=' additive_expression ';';

additive_expression: multiplicative_expression (ADD|SUB multiplicative_expression)*;

multiplicative_expression: primary_expression (MUL|DIV primary_expression)*;

primary_expression: INTVAL | DOUBLEVAL | STRINGVAL | ID;