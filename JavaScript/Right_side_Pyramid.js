function generateRightTiltedNumberPyramid() {
    const rows = parseInt(document.getElementById("rows").value);
    if (isNaN(rows) || rows < 1) {
        document.getElementById("pattern").innerText = "Please enter a valid number of rows.";
        return;
    }

    let pattern = "";
    for (let i = 1; i <= rows; i++) {
        pattern += " ";

        for (let j = 1; j <= i; j++) {
            pattern += j + " ";
        }
        pattern += "\n";
    }
    document.getElementById("pattern").innerText = pattern;
}