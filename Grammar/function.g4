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
		|	expr (MUL | DIV) expr
		|	<assoc=right> expr (POW) expr
		|	expr (ADD | SUB) expr
		|	math_func
		|	VALUE
		|	VAR;
		
skip: ;


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
exponent: 'e' POW expr | 'exp' '('expr')';
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

VAR : [xt];
fragment INT: [0-9]+;
fragment FLOAT: INT+ ([.,] INT+)?;
MUL: '*';
DIV: '/';
ADD: '+';
SUB: '-';
VALUE: INT | FLOAT | PI;
fragment PI: '\u03C0'|'pi';
POW: '^';
WHITESPACE          : (' '|'\t'|'\r'|'\n')+ -> skip ;
