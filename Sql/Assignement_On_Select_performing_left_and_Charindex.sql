--8.Select Email Username Portion: Retrieve the portion of the Email before the '@'
--symbol using the LEFT and CHARINDEX functions.select Left(Email,CHARINDEX('@',Email)-1) from Customer;