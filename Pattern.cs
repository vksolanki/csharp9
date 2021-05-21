 static decimal CashBack(int total) =>
            total switch
            {
                >= 1000 => 100,
                (> 800) and (< 1000) => 50,
                (> 200) and (<= 800) => 30,
                200 => 10,
                _ => 0
            };

        //static decimal CashBack(int total)
        //{
        //    if (total >= 1000) return 100;
        //    else if (total > 800 && total < 1000) return 50;
        //    else if (total > 200 && total <= 800) return 30;
        //    else if (total == 200) return 10;
        //    else { return 0; }
        //}
