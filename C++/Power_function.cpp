#include <iostream>
using namespace std;

int main() {
    double base;
    int exponent;
    double result = 1.0;

    cout << "Enter the base: ";
    cin >> base;

    cout << "Enter the exponent: ";
    cin >> exponent;

    bool isNegative = (exponent < 0);
    if (isNegative) {
        exponent = -exponent;
    }

    for (int i = 0; i < exponent; i++) {
        result *= base;
    }

    // If the exponent was negative, take the reciprocal
    if (isNegative) {
        result = 1.0 / result;
    }

    cout << base << "^" << exponent << " = " << result << endl;

    return 0;
}
