int n1 = 1, n2 = 3, n3 = 3;

switch (n1 + n2 + n3)

{

case 0:

case 2:

case 4:

++n1;

n3 += n2;

     break;

case 1:

case 3:

case 5:

--n1;

n3 -= n2;

break;

default:

      n1 += n2;

break;

}

Console.WriteLine(n1 + "\n" + n2 + "\n" + n3);