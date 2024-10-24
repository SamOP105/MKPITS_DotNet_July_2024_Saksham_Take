<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>Day of the Week</title>
</head>
<body>
    <input id="dayNumber" placeholder="Enter a number (1-7)" />
    <button onclick="getDayOfWeek()">Submit</button>
    <span id="result"></span>

    <script>
        function getDayOfWeek() {
            var dayNumber = parseInt(document.getElementById("dayNumber").value);
            let dayName;

            switch (dayNumber) {
                case 1:
                    dayName = "Sunday";
                    break;
                case 2:
                    dayName = "Monday";
                    break;
                case 3:
                    dayName = "Tuesday";
                    break;
                case 4:
                    dayName = "Wednesday";
                    break;
                case 5:
                    dayName = "Thursday";
                    break;
                case 6:
                    dayName = "Friday";
                    break;
                case 7:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number";
            }


            document.getElementById("result").innerHTML = "Day of the Week: " + dayName;
        }
    </script>
</body>
</html>
