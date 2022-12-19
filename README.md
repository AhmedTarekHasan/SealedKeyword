<link rel="canonical" href="" />

# Compiler-Friendly Code: Sealed Keyword in .NET C#
### Why & When Sealed Keyword could lead to a performance boost in .NET C#.

<p align="center">
  <!--<img src="https://miro.medium.com/max/1400/1*v5qBr4h1qH6i_HavIwGAFQ.jpeg">-->
</p>

<br/>

<p>
What does it mean to write compiler friendly code?
</p>

<br/>

<p>
Any .NET code passes by more than one phase till finally reaches the machine code. Since many factors are involved into this process, there could be lots of details which we miss when we are first writing our code.
</p>

<br/>

<p>
However, the more clear and deterministic the code we write is, the more the compiler could assist us and generate optimized machine code.
</p>

<p>
In this article, we are going to discuss one example of the ways by which we can help the compiler optimize our code. This way is; using the Sealed Keyword.
</p>

<p>
Enough with the talking and let's see an example…
</p>

<br/>

If you are interested into reading more about this topic, you can read [the rest of the article][Article]. 

<br/>

## If you want to support me:
▶ Subscribe to Medium using [my referral link][Membership]<br/>
▶ Subscribe to [Medium Newsletter][Subscribe]<br/>
▶ Subscribe to [LinkedIn Newsletter][Newsletter]<br/>
▶ Follow me on [Medium][Blog]<br/>
▶ Follow me on [Twitter][Twitter]<br/>
▶ Follow me on [LinkedIn][LinkedIn]

<br/>

## Authors:
* [Ahmed Tarek Hasan]


[Ahmed Tarek Hasan]: https://medium.com/@eng_ahmed.tarek
[Blog]: https://medium.com/@eng_ahmed.tarek
[Membership]: https://medium.com/@eng_ahmed.tarek/membership
[Subscribe]: https://medium.com/subscribe/@eng_ahmed.tarek
[Twitter]: https://twitter.com/AhmedTarekHasa1
[LinkedIn]: https://www.linkedin.com/in/atarekhasan/
[Friend Links]: https://www.linkedin.com/feed/update/urn:li:activity:6866082670108143616/
[Newsletter]: https://www.linkedin.com/newsletters/development-simply-put-6866647119655247872/
[Article]: 