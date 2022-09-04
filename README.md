# Data Classifier
Problem	Statement:
You been	asked	to	write	a	classifier	for	historical	data	from	a	binary	data	stream.		The	input	data	consists	of	an	
ASCII	string	of	binary	states,	[x|y]	which	are	sensed every	millisecond	of	every	day	and	recorded	continuously	
for	a	5 year	period.	 Your	solution	will	be	deployed	on a	32-bit	single	processor	virtual	machine	with	2GB	of	
RAM,	so	make	your	code as	safe,	efficient, and	stable	as	possible.

Program,	in	Java,	C#,	or	C/C++,	a	fast	and	simple	solution	to	the	following	classification	problem	without	using	
any	regular	expression	or	pattern	matching	utilities/libraries.

Given	the	input stream	of	characters,	output	an	"A"	if	the	characters	"xxx"	are	found	in	exactly	that	sequence.		
If	the	characters	"xyx"	are	found	instead,	output	a "B".		Do	not	re-process	characters	so	as	to	output	both	an	
“A”	and	a	“B”	when	processing	the	same	input.	For	example:

Example	1:

Input:

 xxyxyxxxyxxx
 
Output:

 BAA
 
Example	2:

Input:

 xxxyxyxxxxyyxyxyx
 
Output:

 ABAB
 
To	be	scored, the	solutions:
1) must	compile,	must be	a	single .java,	.c, .c++, or	.cs	file.
2) must	read	from	standard	Input	and	write	to	standard	output.

Usage:
Prompt>	encode	<	input.txt
BAA

Scoring:

(NOTE	- Your	solution	will	be	scored	against	a reference implementation	in	the	language	you	chose)

Structure	&	Correctness:

10pts	– Single	File

10pts	– No	utilities	or	libraries	used

10pts	– Compiles	with	no	warnings	or	errors

10pts	– Generates	a	correct	answer	without	crashing

10pts	– Fails	gracefully	when	fed	erroneous	input

Performance (mean	+	standard	deviation over	60	runs):

50pts	– Execution	time	<=	reference solution

40pts	– Execution	time	>	1.0x,	<=	1.2x	reference solution

30pts	– Execution	time	>	1.2x,	<=	1.5x	reference solution

20pts	– Execution	time	>	1.5x,	<=	2.0x reference solution

10pts	– Execution	time	>	2.0x	reference solution

