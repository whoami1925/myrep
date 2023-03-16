#include <iostream>
#include "func.h"
using namespace std;

int main()
{
    int a, b;
    cin >> a >> b;
    int c = e_mul (a,b);
    int d = e_div (a,b);
    int t = e_ost (a,b);
    cout << c << " " << d << " " << t << endl;
    return 0;
}
