Note: Composition over inheritance

Why Strategy Wins 🧠
Aspect	             Inheritance	Strategy
Multiple discounts	 ❌ Hard     	✅ Easy
Runtime flexibility	 ❌ No	        ✅ Yes
Class explosion.   	 ❌ Yes.     	✅ No
OCP compliance. 	 Weak.      	 Strong
Composition	         ❌           	✅


Problem:
When using inheritance, code often has to be repeated to support different combinations of behavior, leading to class explosion.

Solution:
The Strategy pattern solves this by breaking behavior into small, independent algorithm components that can be interchanged and combined at runtime, avoiding the need for multiple inheritance-based classes.