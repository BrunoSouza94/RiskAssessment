DECLARE @Trades TradeInput;
INSERT INTO @Trades (ID_TRADE, VALUE, CLIENT_SECTOR)
VALUES
    (NEWID(), 2000000, 'Private'),
    (NEWID(), 400000, 'Public'),
    (NEWID(), 500000, 'Public'),
    (NEWID(), 3000000, 'Public');

EXEC CalculateTradeCategories @Portfolio = @Trades;