function generateFibonacci() {
    const n = document.getElementById("terms").value;
    let result = "";
    let a = 0, b = 1, count = 1;

    if (n <= 0) {
        document.getElementById("result").innerText = "Please enter a positive integer.";
        return;
    }

    do {
        result += a + " ";
        let nextTerm = a + b;
        a = b;
        b = nextTerm;
        count++;
    } while (count <= n);

    document.getElementById("result").innerText = result.trim();
}