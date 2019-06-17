grammar Applications;

application:
	START_UML title (aggregateRoots) (interfaces?) END_UML;

START_UML: '@startuml';

END_UML: '@enduml';

title: TITLE (title_ = qualifiedId);

TITLE: 'title';

aggregateRoots: aggregateRoot+;

OPEN_BRACE: '{';

CLOSE_BRACE: '}';

OPEN_PARENS: '(';

CLOSE_PARENS: ')';

OPEN_BRACKET: '<';

CLOSE_BRACKET: '>';

COMMA: ',';

DOT: '.';

NAMESPACE: 'namespace';

aggregateRoot:
	NAMESPACE (name_ = id) OPEN_BRACE (domain?) (commands?) (
		queries?
	) CLOSE_BRACE;

domain: NAMESPACE DOMAIN OPEN_BRACE (classDefs) CLOSE_BRACE;

DOMAIN: 'Domain';

classDefs: classDef+;

classDef: CLASS (name_ = id) classBody;

classBody: OPEN_BRACE (properties?) CLOSE_BRACE;

CLASS: 'class';

properties: property+;

property: (type) (name_ = id);

commands: NAMESPACE COMMANDS OPEN_BRACE (command+) CLOSE_BRACE;

COMMANDS: 'Commands';

command:
	NAMESPACE (name_ = id) OPEN_BRACE (commandClassDef?) (
		modelClassDef?
	) (resultClassDef?) (dependencies?) (configClassDef?) CLOSE_BRACE;

commandClassDef: CLASS COMMAND classBody;

COMMAND: 'Command';

modelClassDef: CLASS MODEL classBody;

MODEL: 'Model';

resultClassDef: CLASS RESULT classBody;

RESULT: 'Result';

dependencies: dependency+;

dependency: (type_ = qualifiedId) REQUIRED_BY (COMMAND | QUERY);

REQUIRED_BY: '-->';

configClassDef: CLASS CONFIG classBody;

CONFIG: 'Config';

queries: NAMESPACE QUERIES OPEN_BRACE (query+) CLOSE_BRACE;

QUERIES: 'Queries';

query:
	NAMESPACE (name_ = id) OPEN_BRACE (queryClassDef?) (
		modelClassDef?
	) (resultClassDef) (dependencies?) (configClassDef?) CLOSE_BRACE;

queryClassDef: CLASS QUERY classBody;

QUERY: 'Query';

interfaces:
	NAMESPACE INTERFACES OPEN_BRACE (interfaceDefs) CLOSE_BRACE;

INTERFACES: 'Interfaces';

interfaceDefs: interfaceDef+;

interfaceDef:
	INTERFACE (name_ = id) OPEN_BRACE (methods) CLOSE_BRACE;

INTERFACE: 'interface';

methods: method+;

method:
	(returnType_ = typeOrVoid) (name_ = id) OPEN_PARENS (
		parameters?
	) CLOSE_PARENS;

typeOrVoid: (type | VOID);

VOID: 'void';

parameters: parameter (COMMA parameter)*;

parameter: (type) (name_ = parameterName);

type:
	dataType											# SimpleType
	| nullableDataType									# NullableSimpleType
	| qualifiedId										# ReferenceType
	| type OPEN_BRACKET typeArguments CLOSE_BRACKET	# GenericType;

dataType:
	BOOL
	| DATETIME
	| INT
	| STRING
	| IENUMERABLE
	| IQUERYABLE;

BOOL: 'bool';
DATETIME: 'datetime';
INT: 'int';
STRING: 'string';
IENUMERABLE: 'IEnumerable';
IQUERYABLE: 'IQueryable';

nullableDataType: dataType NULLABLE;

NULLABLE: '?';

typeArguments: type (COMMA type)*;

qualifiedId: id ( DOT id)*;

id: ID | DOMAIN | INTERFACES;

ID: [A-Z][A-Za-z0-9]*;

parameterName: PARAMETER_NAME;

PARAMETER_NAME: [a-z][A-Za-z0-9]*;

WS: (' ' | '\t' | '\r' | '\n')+ -> skip;
