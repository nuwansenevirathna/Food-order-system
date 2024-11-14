-- Create a new table with the same structure but with paymentid as an identity column
CREATE TABLE paymenttab_new (
    paymentid INT IDENTITY(1,1) PRIMARY KEY,
    customername VARCHAR(255),
    order1 VARCHAR(255),
    qty1 INT,
    totalprice1 DECIMAL(18,2),
    order2 VARCHAR(255),
    qty2 INT,
    totalprice2 DECIMAL(18,2),
    order3 VARCHAR(255),
    qty3 INT,
    totalprice3 DECIMAL(18,2),
    amount DECIMAL(18,2),
    paid DECIMAL(18,2),
    balance DECIMAL(18,2),
    paymentmethod VARCHAR(50),
    paymentdate DATETIME
);

-- Copy data from the old table to the new table
INSERT INTO paymenttab_new (customername, order1, qty1, totalprice1, order2, qty2, totalprice2, order3, qty3, totalprice3, amount, paid, balance, paymentmethod, paymentdate)
SELECT customername, order1, qty1, totalprice1, order2, qty2, totalprice2, order3, qty3, totalprice3, amount, paid, balance, paymentmethod, paymentdate
FROM paymenttab;

-- Drop the old table
DROP TABLE paymenttab;

-- Rename the new table to the original name
EXEC sp_rename 'paymenttab_new', 'paymenttab';
