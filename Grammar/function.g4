grammar function;

options
{
	language = CSharp2;
}
//@parser::namespace { Generated }
//@lexer::namespace  { Generated }

/*
 * Parser Rules
 */

function	:	expr | EOF;

expr	:	'('expr')'
		|	<assoc=right> expr pow expr
		|	expr mul expr
		|	expr div expr
		|	expr add expr
		|	expr sub expr
		|	math_func
		|	value
		|	VAR;
		
skip: ;

mul: '*';
div: '/';
pow: '^';
add: '+';
sub: '-';
value: INT | FLOAT | PI;


math_func	:	cos
			|	sin 
			|	tan
			|	cot
			|	exponent
			|	sqrt
			|	abs
			|	acos
			|	asin
			|	atan
			|	cosh
			|	sinh
			|	tanh
			|	ln
			|	log;

cos: 'cos' '(' expr ')';
sin: 'sin' '('expr')';
tan: 'tan' '('expr')';
cot: 'cot' '(' expr')';
exponent: 'e' pow expr | 'exp' '('expr')';
sqrt: 'sqrt' '('expr')';
abs: 'abs' '('expr')';
acos: 'acos' '(' expr ')';
asin: 'asin' '(' expr ')';
atan: 'atan' '(' expr ')';
cosh: 'cosh' '(' expr ')';
sinh: 'sinh' '(' expr ')';
tanh: 'tanh' '(' expr ')';
ln: 'ln' '(' expr ')';
log: 'log' '_' '{' INT '}' '^' '{' INT '}';


/*
 * Lexer Rules
 */
VAR: [x,t];
fragment INT: [0-9]+;
fragment FLOAT: INT+ ([.,] INT+)?;
fragment PI: '\u03C0'|'pi';
WHITESPACE          : (' '|'\t'|'\r'|'\n')+ -> skip ;
