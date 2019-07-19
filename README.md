# Harry Potter Kata
Solution for Harry Potter Kata implemented in C#. This will help candidates to learn the basic OOP principles. The Kata requires certain amount of clever optimization algorithm. But, not too much!

## Problem Description

Bookshop offers 5 different Harry Potter books. In order to increase the sales, they decided to offer discounts.

One copy of any of the five books costs 8 EUR.

If you buy two different books, you get a 5%
discount on those two books.

If you buy 3 different books, you get a 10% discount.

If you buy 4 different books, you get a 20% discount.

If you go the whole hog, and buy all 5, you get a huge 25%
discount.

Note that if you buy, say, four books, of which 3 are
different titles, you get a 10% discount on the 3 that
form part of a set, but the fourth book still costs 8 EUR.

The mission is to write a piece of code to calculate the
price of any conceivable shopping basket (containing only
Harry Potter books), giving as big a discount as possible.

For example, how much does this basket of books cost?

- 2 copies of the first book
- 2 copies of the second book
- 2 copies of the third book
- 1 copy of the fourth book
- 1 copy of the fifth book

Answer: 51.20 EUR

|  I  |  II  | III |  IV  |  V  |          Formula							|  Price  |
|-----|------|-----|------|-----|-------------------------------------------|---------|
|  1  |      |     |      |     |     1 * 8									|  8.00   |
|  1  |  1   |     |      |     |     2 * 8 * 0.95							|  15.20  |
|  1  |  1   |  1  |      |     |     3 * 8 * 0.9							|  21.60  |
|  1  |  1   |  1  |  1   |     |     4 * 8 * 0.8							|  25.60  |
|  1  |  1   |  1  |  1   |  1  |     5 * 8 * 0.75							|  30.00  |
|  2  |      |     |      |     |     2 * 8									|  16.00  |
|  2  |  1   |     |      |     |     2 * 8 * 0.95 + 1 * 8					|  23.20  |
|  2  |  1   |  1  |      |     |     3 * 8 * 0.90 + 1 * 8					|  29.60  |
|  2  |  2   |  2  |  1   |  1  | 4 * 8 * 0.8 + 4 * 8 * 0.8					|  51.20  |
|  5  |  5   |  4  |  5   |  4  | 3 * (5 * 8 * 0.75) + 2 * (4 * 8 * 0.8)	|141.20  |
