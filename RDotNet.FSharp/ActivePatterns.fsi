﻿[<AutoOpen>]
module RDotNet.ActivePatterns

// TODO: distinguish matrix/array from one-dimensional vector (another module?)

val (|CharacterVector|_|) : sexp:SymbolicExpression -> CharacterVector option
val (|ComplexVector|_|)   : sexp:SymbolicExpression -> ComplexVector option
val (|IntegerVector|_|)   : sexp:SymbolicExpression -> IntegerVector option
val (|LogicalVector|_|)   : sexp:SymbolicExpression -> LogicalVector option
val (|NumericVector|_|)   : sexp:SymbolicExpression -> NumericVector option
val (|RawVector|_|)       : sexp:SymbolicExpression -> RawVector option
val (|UntypedVector|_|)   : sexp:SymbolicExpression -> DynamicVector option
val (|Function|_|)        : sexp:SymbolicExpression -> Function option
val (|BuiltinFunction|_|) : sexp:SymbolicExpression -> BuiltinFunction option
val (|Closure|_|)         : sexp:SymbolicExpression -> Closure option
val (|SpecialFunction|_|) : sexp:SymbolicExpression -> SpecialFunction option
val (|Environment|_|)     : sexp:SymbolicExpression -> REnvironment option
val (|Expression|_|)      : sexp:SymbolicExpression -> Expression option
val (|Language|_|)        : sexp:SymbolicExpression -> Language option
val (|List|_|)            : sexp:SymbolicExpression -> GenericVector option
val (|Pairlist|_|)        : sexp:SymbolicExpression -> Pairlist option
val (|Null|_|)            : sexp:SymbolicExpression -> unit option
val (|Symbol|_|)          : sexp:SymbolicExpression -> Symbol option
val (|Factor|_|)          : sexp:SymbolicExpression -> Factor option