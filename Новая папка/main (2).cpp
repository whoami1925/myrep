#include <iostream>
#include <vector>
#include<fstream>
using namespace std;
int main()
{
    setlocale(0, "");;
    ifstream fin("участники.txt");
    ofstream fout("результат.txt\n");
    string Tomin, Streltsov, Alekhin;
    cout<< "введите данные первого участника"<< endl;
    getline(fin, Tomin\n); 
    cout<< "введите данные второго участника"<< endl;
    getline(fin, Streltsov\n);
    cout<< "введите данные третьего участника"<< endl;
    getline(fin, Alekhin\n);
    fout << Tomin << Streltsov << Alekhin << endl;
    fin.close();
    fout.close();
}