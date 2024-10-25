#include <iostream>
using namespace std;

int main() {
    int n;

    cout << "Enter a positive integer: ";
    cin >> n;

    cout << "Prime numbers up to " << n << " are: ";
    for (int num = 2; num <= n; num++) {

        int i = 2;
        while (i <= num / 2) {
            if (num % i == 0) {

                break;
            }
            i++;
        }

        if (i > num / 2) {
            cout << num << " ";
        }
    }

    cout << endl;
    return 0;
}