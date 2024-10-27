#include <iostream>
#include <string>
using namespace std;

int main() {
    string s;
    cout << "Enter a string: ";
    getline(cin, s);

    int c = 0;
    for (int i = 0; i < s.length(); i++) {
        if (s[i] == 'B' || s[i] == 'C' || s[i] == 'D' || s[i] == 'F' || s[i] == 'G' || s[i] == 'H' ||
            s[i] == 'J' || s[i] == 'K' || s[i] == 'L' || s[i] == 'M' || s[i] == 'N' || s[i] == 'P' ||
            s[i] == 'Q' || s[i] == 'R' || s[i] == 'S' || s[i] == 'T' || s[i] == 'V' || s[i] == 'W' ||
            s[i] == 'X' || s[i] == 'Y' || s[i] == 'Z' ||
            s[i] == 'b' || s[i] == 'c' || s[i] == 'd' || s[i] == 'f' || s[i] == 'g' || s[i] == 'h' ||
            s[i] == 'j' || s[i] == 'k' || s[i] == 'l' || s[i] == 'm' || s[i] == 'n' || s[i] == 'p' ||
            s[i] == 'q' || s[i] == 'r' || s[i] == 's' || s[i] == 't' || s[i] == 'v' || s[i] == 'w' ||
            s[i] == 'x' || s[i] == 'y' || s[i] == 'z') {
            c++;
        }
    }

    cout << "Consonants: " << c << endl;
    return 0;
}
