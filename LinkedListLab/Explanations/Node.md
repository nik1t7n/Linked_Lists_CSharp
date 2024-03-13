# Node

Before we will discuss how to implement various types of Linked Lists, let's
consider how to implement the base of scuh lists - **Node**.

*(I will not write code here, because you can easily check it in the _Model_
folder).*

First of all I made the *Node* class with Generic type to make the program more
flexible. Then I created three properties:

- Data
- Next
- Prev (optional for some cases)

In the <u>Data</u> we will save a data itself, obviously. In the <u>Next</u> 
there is areference to next node. And <u>Prev</u> is used in **Double Linked 
List** to make a reference to previous node.

Class constructor is pretty trivial too. We just take passed data and store
it in our Data property.

Additionaly, I decided to make <u>DisplayNode</u> method. Here I check whether
the data is IEnumerable type or not. In this regard, I am already choosing
which way to output the data.