CREATE PROCEDURE CalculateTradeCategories
    @Portfolio TradeInput READONLY
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TradeCategories TradeCategoryOutput;

    INSERT INTO @TradeCategories (ID_TRADE_CATEGORY, ID_TRADE, CATEGORY_NAME)
    SELECT
        NEWID(),
		ID_TRADE,
        CASE
            WHEN CLIENT_SECTOR = 'Private' AND Value > 1000000 THEN 'HIGHRISK'
            WHEN CLIENT_SECTOR = 'Public' AND Value > 1000000 THEN 'MEDIUMRISK'
            ELSE 'LOWRISK'
        END
    FROM @Portfolio;

	INSERT INTO TRADE (ID_TRADE, VALUE, CLIENT_SECTOR, RISK_CATEGORY)
    SELECT p.*, t.CATEGORY_NAME
	FROM @Portfolio p
	INNER JOIN @TradeCategories t ON t.ID_TRADE = p.ID_TRADE;
END;