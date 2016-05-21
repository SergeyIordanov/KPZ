
using KPZ_Lab4_WinForms;
using System;



public class Parser {
	public const int _EOF = 0;
	public const int _ident = 1;
	public const int _const = 2;
	public const int _bool = 3;
	public const int _operationHigh = 4;
	public const int _operationLow = 5;
	public const int _if = 6;
	public const int _else = 7;
	public const int maxT = 12;

	const bool _T = true;
	const bool _x = false;
	const int minErrDist = 2;
	
	public Scanner scanner;
	public Errors  errors;

	public Token t;    // last recognized token
	public Token la;   // lookahead token
	int errDist = minErrDist;

    private Form1 form;

	public Parser(Scanner scanner) {
		this.scanner = scanner;
		errors = new Errors();
	}

	void SynErr (int n) {
		if (errDist >= minErrDist) errors.SynErr(la.line, la.col, n);
		errDist = 0;
	}

	public void SemErr (string msg) {
		if (errDist >= minErrDist) errors.SemErr(t.line, t.col, msg);
		errDist = 0;
	}
	
	void Get () {
		for (;;) {
			t = la;
			la = scanner.Scan();
			if (la.kind <= maxT) { ++errDist; break; }

			la = t;
		}
	}
	
	void Expect (int n) {
		if (la.kind==n) Get(); else { SynErr(n); }
	}
	
	bool StartOf (int s) {
		return set[s, la.kind];
	}
	
	void ExpectWeak (int n, int follow) {
		if (la.kind == n) Get();
		else {
			SynErr(n);
			while (!StartOf(follow)) Get();
		}
	}


	bool WeakSeparator(int n, int syFol, int repFol) {
		int kind = la.kind;
		if (kind == n) {Get(); return true;}
		else if (StartOf(repFol)) {return false;}
		else {
			SynErr(n);
			while (!(set[syFol, kind] || set[repFol, kind] || set[0, kind])) {
				Get();
				kind = la.kind;
			}
			return StartOf(syFol);
		}
	}

	
	void Sample() {
		Expect(6);
		Expect(8);
		X();
		Expect(9);
		Expect(1);
		Expect(10);
		A();
		Expect(11);
		E();
	}

	void X() {
		A();
		Expect(3);
		A();
	}

	void A() {
		M();
		A2();
	}

	void E() {
		if (la.kind == 0) {
			if (false) {
			}
		} else if (la.kind == 7) {
			Get();
			Expect(1);
			Expect(10);
			A();
			Expect(11);
		} else SynErr(13);
	}

	void M() {
		P();
		M1();
	}

	void A2() {
		if (la.kind == 5) {
			B();
		} else if (la.kind == 3 || la.kind == 9 || la.kind == 11) {
			if (false) {
			}
		} else SynErr(14);
	}

	void B() {
		Expect(5);
		B2();
	}

	void B2() {
		M();
		B3();
	}

	void B3() {
		if (la.kind == 5) {
			B();
		} else if (la.kind == 3 || la.kind == 9 || la.kind == 11) {
			if (false) {
			}
		} else SynErr(15);
	}

	void P() {
		if (la.kind == 8) {
			Get();
			A();
			Expect(9);
		} else if (la.kind == 1 || la.kind == 2) {
			U();
		} else SynErr(16);
	}

	void M1() {
		if (la.kind == 4) {
			C();
		} else if (StartOf(1)) {
			if (false) {
			}
		} else SynErr(17);
	}

	void C() {
		Expect(4);
		C2();
	}

	void C2() {
		if (la.kind == 1 || la.kind == 2 || la.kind == 8) {
			M();
		} else if (la.kind == 1 || la.kind == 2 || la.kind == 8) {
			P();
			C();
		} else SynErr(18);
	}

	void U() {
		if (la.kind == 1) {
			Get();
		} else if (la.kind == 2) {
			Get();
		} else SynErr(19);
	}



	public void Parse() {
		la = new Token();
		la.val = "";		
		Get();
		Sample();
		Expect(0);

	}
	
	static readonly bool[,] set = {
		{_T,_x,_x,_x, _x,_x,_x,_x, _x,_x,_x,_x, _x,_x},
		{_x,_x,_x,_T, _x,_T,_x,_x, _x,_T,_x,_T, _x,_x}

	};
} // end Parser


public class Errors {
	public int count = 0;                                    // number of errors detected
	public System.IO.TextWriter errorStream = Console.Out;   // error messages go to this stream
	public string errMsgFormat = "-- line {0} col {1}: {2}"; // 0=line, 1=column, 2=text

	public virtual void SynErr (int line, int col, int n) {
		string s;
		switch (n) {
			case 0: s = "EOF expected"; break;
			case 1: s = "ident expected"; break;
			case 2: s = "const expected"; break;
			case 3: s = "bool expected"; break;
			case 4: s = "operationHigh expected"; break;
			case 5: s = "operationLow expected"; break;
			case 6: s = "if expected"; break;
			case 7: s = "else expected"; break;
			case 8: s = "\"(\" expected"; break;
			case 9: s = "\")\" expected"; break;
			case 10: s = "\"=\" expected"; break;
			case 11: s = "\";\" expected"; break;
			case 12: s = "??? expected"; break;
			case 13: s = "invalid E"; break;
			case 14: s = "invalid A2"; break;
			case 15: s = "invalid B3"; break;
			case 16: s = "invalid P"; break;
			case 17: s = "invalid M1"; break;
			case 18: s = "invalid C2"; break;
			case 19: s = "invalid U"; break;

			default: s = "error " + n; break;
		}
		errorStream.WriteLine(errMsgFormat, line, col, s);
		count++;
	}

	public virtual void SemErr (int line, int col, string s) {
		errorStream.WriteLine(errMsgFormat, line, col, s);
		count++;
	}
	
	public virtual void SemErr (string s) {
		errorStream.WriteLine(s);
		count++;
	}
	
	public virtual void Warning (int line, int col, string s) {
		errorStream.WriteLine(errMsgFormat, line, col, s);
	}
	
	public virtual void Warning(string s) {
		errorStream.WriteLine(s);
	}
} // Errors


public class FatalError: Exception {
	public FatalError(string m): base(m) {}
}
