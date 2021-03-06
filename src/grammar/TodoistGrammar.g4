grammar TodoistGrammar;

options
{
    language=CSharp;
}

/**
    lexer rules
*/
SHARP : '#';
PERCENT : '%';
DATETIMESEPARATOR : 'T';
OPEN_SB : '[';
CLOSE_SB : ']';
X_LETTER : 'x';
HYPHEN : '-';
COLON : ':';
DIGIT : [0-9];
INT2 : DIGIT DIGIT;
INT4 : DIGIT DIGIT DIGIT DIGIT;
NEWLINE : '\r'? '\n' | '\r';
PERIOD : '.';
SPACE : ' ';
TEXT : [a-zA-Z0-9];


/**
    parser rules 
*/

project : SHARP SPACE date? description (NEWLINE | EOF) task* EOF?;

task : DIGIT+ PERIOD SPACE checkbox SPACE date? description NEWLINE? subtask*;

subtask : SPACE SPACE DIGIT+ PERIOD SPACE checkbox SPACE date? description NEWLINE?;

checkbox : OPEN_SB (SPACE | X_LETTER) CLOSE_SB;

description : inline+;

date
    : PERCENT INT4 HYPHEN INT2 HYPHEN INT2 DATETIMESEPARATOR INT2 COLON INT2 COLON INT2 PERCENT
    ;

inline : TEXT
    | SHARP
    | PERCENT
    | DATETIMESEPARATOR
    | HYPHEN
    | COLON
    | DIGIT
    | INT2
    | INT4
    | PERIOD
    | SPACE
    | X_LETTER
    ;